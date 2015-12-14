using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using FileDialogLib;
using FileDialogLib.Objects;
using GameArchiveLib;
using GameDataLib;
using GameObjectLib;
using GameObserverLib;



namespace GameObjectEditor
{
    public partial class GameObjecteEditor : Form
    {
        GameFileDialog fileDialog = new GameFileDialog();
        private GameObserver Observer = new GameObserver();
        private GameArchive Archive = GameArchive.Instance;

        private Dictionary<string, GameObject> DisplayObjectList = new Dictionary<string, GameObject>();
        private Dictionary<string, Property> displayObjectPropertiesList = new Dictionary<string, Property>();

        private const string extension = "gcod";
        private const string name = "Observer";

        private string SaveDirectory = @"C:\";
        private GameObject selectedGameObject;
        private Property selectedProperty;
        private ObserverData currentObserverData;
        public GameObjecteEditor()
        {
            InitializeComponent();
            DisableAll();
            DisableGameObjectEntry();
            DisableGamePropertyEntry();
        }
        

        #region helper GameObject methods
        private void getGameObjects(ObserverData observerData)
        {
            ClearGameObjectListBox();
            foreach (KeyValuePair<string, GameObject> obj in observerData.ObjectList)
            {
                Observer.ObserveGameObject(obj.Value);
                DisplayObjectList.Add(obj.Key, obj.Value);
            }
            fillGameObjectListBox();
        }

        private void fillGameObjectListBox()
        {
            foreach (KeyValuePair<string, GameObject> obj in DisplayObjectList)
            {
                listBox_GameObjects.Items.Add(obj.Key);
            }
        }

        private void ClearGameObjectListBox()
        {
            listBox_GameObjects.Items.Clear();
            Observer.ClearObserverGameObjects();
            DisplayObjectList.Clear();
        }

        private void AddGameObjectToDisplay(GameObject gameObject)
        {
            DisplayObjectList.Add(gameObject.Name, gameObject);
            listBox_GameObjects.Items.Add(gameObject.Name);
        }

        private void RemoveGameObjectFromDisplay(GameObject gameObject)
        {
            DisplayObjectList.Remove(gameObject.Name);
            listBox_GameObjects.Items.Remove(gameObject.Name);
        }

        private void RemoveGameObjectFromDisplay(string objectName)
        {
            DisplayObjectList.Remove(objectName);
            listBox_GameObjects.Items.Remove(objectName);
        }

        #endregion

        #region GCD buttons
        private void btn_NewGCD_Click(object sender, EventArgs e)
        {
            ClearGameObjectListBox();
            ObserverData observerData = Observer.GetObserverData();
            Response response = fileDialog.SaveFile(observerData, extension, name);
            SaveDirectory = response.DirectoryPath;
            EnableAll();
        }
        private void btn_LoadGCD_Click(object sender, EventArgs e)
        {
            Response response = fileDialog.LoadFile<ObserverData>(extension, name);
            if (!response.ValidData) return;

            currentObserverData = (ObserverData)response.Data;
            SaveDirectory = response.DirectoryPath;
            getGameObjects(currentObserverData);
            EnableAll();
        }

        private void btn_SaveGCD_Click(object sender, EventArgs e)
        {
            if (currentObserverData == null) return;
            currentObserverData = Observer.GetObserverData();
            Archive.SaveData(currentObserverData, SaveDirectory);
        }
        #endregion

        #region GameObject Buttons
        private void btn_NewGameObject_Click(object sender, EventArgs e)
        {
            NewGameObject newObjectForm = new NewGameObject(Observer);
            newObjectForm.Closed += delegate(object o, EventArgs args)
            {
                if (newObjectForm.ValidObject)
                {
                    AddGameObjectToDisplay(newObjectForm.ReturnGameObject);
                }
            };
            newObjectForm.ShowDialog();
        }
        private void btn_SaveObject_Click(object sender, EventArgs e)
        {
           SaveSelectedGameObject();
        }

        private void SaveSelectedGameObject()
        {
            string objectName = selectedGameObject.Name;
            bool doesGameObjectExist = Observer.DoesGameObjectNameExist(txtBox_GameObjectName.Text);

            if (string.IsNullOrWhiteSpace(objectName))
            {
                MessageBox.Show("Game Object's name cannot be empty", "Empty Game Object Name", MessageBoxButtons.OK);
                return;
            }
            if (objectName != txtBox_GameObjectName.Text && doesGameObjectExist)
            {
                MessageBox.Show("GameObject name " + txtBox_GameObjectName.Text + " already exists");
                return;
            }

            selectedGameObject.Name = txtBox_GameObjectName.Text;
            RemoveGameObjectFromDisplay(objectName);
            Observer.UnobserveGameObject(objectName);
            Observer.ObserveGameObject(selectedGameObject);
            AddGameObjectToDisplay(selectedGameObject);
        }

        private void btn_DeleteGameObject_Click(object sender, EventArgs e)
        {
            string objectName = txtBox_GameObjectName.Text;

            if (string.IsNullOrWhiteSpace(objectName))
            {
                MessageBox.Show("Game Object's name cannot be empty", "Empty Game Object Name", MessageBoxButtons.OK);
                return;
            }

            if (!Observer.DoesGameObjectNameExist(txtBox_GameObjectName.Text))
            {
                MessageBox.Show("GameObject name " + txtBox_GameObjectName.Text + " does not exist");
                return;
            }
            DialogResult result = MessageBox.Show("Are you sure you want to delete " + objectName + "?", "Delete Game Object",
                MessageBoxButtons.OKCancel);
            switch (result)
            {
                case DialogResult.OK:
                    bool observe = Observer.UnobserveGameObject(txtBox_GameObjectName.Text);
                    if (!observe)
                    {
                        MessageBox.Show("Nope", "Nope", MessageBoxButtons.OK);
                    }
                    RemoveGameObjectFromDisplay(txtBox_GameObjectName.Text);
                    txtBox_GameObjectName.Text = string.Empty;
                    if (selectedGameObject.Name == txtBox_GameObjectName.Text)
                    {
                        displayObjectPropertiesList.Clear();
                        listBox_Properties.Items.Clear();
                    }
                    break;
                case DialogResult.Cancel:
                    return;
            }
        }
        #endregion

        #region Disable All and Enable All buttons
        private void DisableAll()
        {
            btn_NewGameObject.Enabled = false;
            btn_NewProperty.Enabled = false;
            btn_SaveGCD.Enabled = false;
        }

        private void EnableAll()
        {
            btn_NewGameObject.Enabled = true;
            btn_NewProperty.Enabled = true;
            btn_SaveGCD.Enabled = true;

        }
        #endregion

        #region Listbox EventHandlers
        private void listObjectBox_OnSelect(object sender, EventArgs args)
        {
            if (listBox_GameObjects.SelectedItem == null)
            {
                DisableGameObjectEntry();
                DisableGamePropertyEntry();
                listBox_Properties.Items.Clear();
                return;
            }
            EnableGameObjectEntry();
            string gameObjectName = (string)listBox_GameObjects.SelectedItem;
            txtBox_GameObjectName.Text = gameObjectName;
            
            GameObject gameObject;
            DisplayObjectList.TryGetValue(gameObjectName, out gameObject);
            if (gameObject == null)
            {
                MessageBox.Show("Null GameObject", "Null GameObject", MessageBoxButtons.OK);
                return;
            }
            selectedGameObject = gameObject;
            ClearPropertyFields();
            FillPropertyBox(gameObject.GetAllProperties());
        }

        private void listPropertiesBox_OnSelect(object sender, EventArgs args)
        {
            if (listBox_Properties.SelectedItem == null)
            {
                DisableGamePropertyEntry();
                return;
            }
            EnableGamePropertyEntry();
            string propertyName = (string)listBox_Properties.SelectedItem;
            EnableGamePropertyEntry();
            txtBox_PropertyName.Text = propertyName;
            Property prop;
            displayObjectPropertiesList.TryGetValue(propertyName, out prop);
            if (prop == null)
            {
                MessageBox.Show("Null Property", "Null Property", MessageBoxButtons.OK);
                return;
            }

            selectedProperty = prop;
            txtBox_PropertyValue.Text = prop.Value;
            switch (prop.Type)
            {
                case PropertyType.String:
                    radio_String.Checked = true;
                    radio_Number.Checked = false;
                    radion_Boolean.Checked = false;
                    break;
                case PropertyType.Number:
                    radio_String.Checked = false;
                    radio_Number.Checked = true;
                    radion_Boolean.Checked = false;
                    break;
                case PropertyType.Bool:
                    radio_String.Checked = false;
                    radio_Number.Checked = false;
                    radion_Boolean.Checked = true;
                    break;
            }
        }
        #endregion

        #region GameObject Property helper methods

        private void FillPropertyBox(Dictionary<string, Property> propertyList)
        {
            displayObjectPropertiesList = selectedGameObject.GetAllProperties();
            listBox_Properties.Items.Clear();
            foreach (KeyValuePair<string, Property> prop in displayObjectPropertiesList)
            {
                listBox_Properties.Items.Add(prop.Key);
            }
        }
        #endregion

        private void btn_NewProperty_Click(object sender, EventArgs e)
        {
            string objectName = (string) listBox_GameObjects.SelectedItem;
            if (string.IsNullOrEmpty(objectName))
            {
                return;
            }
            
            NewGameObjectProperty newPropWindow = new NewGameObjectProperty(selectedGameObject);
            newPropWindow.Closed += delegate(object o, EventArgs args)
            {
                if (!newPropWindow.ValidProperty) return;
                selectedGameObject.AddProperty(newPropWindow.ReturnProperty);
                SaveSelectedGameObject();
                AddPropertyToDisplayWindow(newPropWindow.ReturnProperty);
            };
            newPropWindow.ShowDialog();
        }

        private void AddPropertyToDisplayWindow(Property property)
        {
            listBox_Properties.Items.Add(property.Name);
            if (displayObjectPropertiesList.ContainsKey(property.Name)) return;
            displayObjectPropertiesList.Add(property.Name, property);
        }

        private void RemovePropertyFromDisplayWindow(string name)
        {
            listBox_Properties.Items.Remove(name);
            displayObjectPropertiesList.Remove(name);
        }

        private void btn_SaveProperty_Click(object sender, EventArgs e)
        {
            string propName = txtBox_PropertyName.Text;
            bool propExist = selectedGameObject.DoesPropertyExist(propName);
            if (propExist && selectedProperty.Name != txtBox_PropertyName.Text)
            {
                MessageBox.Show("Property name " + propName + " already exists in GameObject " + selectedGameObject.Name);
                return;
            }
            Dictionary<string, bool> typeSelected = IsTypeSelected();
            if (typeSelected.Count > 1)
            {
                MessageBox.Show("Too many Types selected", "Too many types", MessageBoxButtons.OK);
                return;
            }
            if (typeSelected.Count < 1)
            {
                MessageBox.Show("No type selected", "No type", MessageBoxButtons.OK);
                return;
            }
            string type = typeSelected.First().Key;
            if (!IsPropertyValueValid(type))
            {
                return;
            }
            switch (propExist)
            {
                case true:
                    switch (type)
                    {
                        case "String":
                            selectedGameObject.SetProperty(propName, txtBox_PropertyValue.Text, PropertyType.String);
                            break;
                        case "Number":
                            selectedGameObject.SetProperty(propName, txtBox_PropertyValue.Text, PropertyType.Number);
                            break;
                        case "Boolean":
                            selectedGameObject.SetProperty(propName, txtBox_PropertyValue.Text, PropertyType.Bool);
                            break;
                    }
                    break;
                case false:
                    selectedGameObject.RemoveProperty(listBox_Properties.SelectedItem.ToString());
                    switch (type)
                    {
                        case "String":
                            selectedGameObject.AddProperty(new Property(PropertyType.String,propName,txtBox_PropertyValue.Text));
                            break;
                        case "Number":
                            selectedGameObject.AddProperty(new Property(PropertyType.Number, propName, txtBox_PropertyValue.Text));
                            break;
                        case "Boolean":
                            selectedGameObject.AddProperty(new Property(PropertyType.Bool, propName, txtBox_PropertyValue.Text));
                            break;
                    }
                    break;
            }

        }

        private bool IsPropertyValueValid(string value)
        {
            if (value == "Number" )
            {
                try
                {
                    double.Parse(txtBox_PropertyValue.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("String is not a number, try again", "Double Parse Exception", MessageBoxButtons.OK);
                    return false;
                }

            }
            if (value == "Boolean")
            {
                try
                {
                    bool.Parse(txtBox_PropertyValue.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("String is not a boolean, try again", "Boolean parse exception",
                        MessageBoxButtons.OK);
                    return false;
                }

            }
            return true;
        }

        private Dictionary<string, bool> IsTypeSelected()
        {
            Dictionary<string, bool> returnDictionary = new Dictionary<string, bool>();
            if (radio_String.Checked)
            {
                returnDictionary.Add("String", true);
            }
            if (radio_Number.Checked)
            {
                returnDictionary.Add("Number", true);
            }
            if (radion_Boolean.Checked)
            {
                returnDictionary.Add("Boolean", true);
            }
            return returnDictionary;
        }

        private void ClearPropertyFields()
        {
            txtBox_PropertyName.Text = string.Empty;
            txtBox_PropertyValue.Text = string.Empty;
            radio_Number.Checked = false;
            radio_String.Checked = false;
            radion_Boolean.Checked = false;
        }

        private void btn_CloneObject_Click(object sender, EventArgs e)
        {
            GameObject clonedGameObject = selectedGameObject.CloneGameObject();
            int number = 1;
            clonedGameObject.Name = GetUnusedObjectName(clonedGameObject.Name, number);
            Observer.ObserveGameObject(clonedGameObject);
            AddGameObjectToDisplay(clonedGameObject);
            
        }

        private string GetUnusedObjectName(string objectName, int counter)
        {
            while (true)
            {
                if (!Observer.DoesGameObjectNameExist(objectName + counter) && !DisplayObjectList.ContainsKey(objectName + counter)) return objectName + counter;
                counter++;
            }
        }

        private void btn_DeleteProperty_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete " + selectedProperty.Name + " from GameObject " +
                selectedGameObject.Name, "Delete Property", MessageBoxButtons.YesNo);
            RemovePropertyFromDisplayWindow(selectedProperty.Name);
            switch (result)
            {
                case DialogResult.Yes:
                    if (!selectedGameObject.DoesPropertyExist(selectedProperty.Name))
                    {
                        return;
                    }
                    selectedGameObject.RemoveProperty(selectedProperty.Name);
                    break;
                case DialogResult.No:
                    return;
                default:
                    return;
            }
            SaveSelectedGameObject();
        }

        private void btn_CloneProperty_Click(object sender, EventArgs e)
        {
            Property clonedProperty = selectedProperty.CloneProperty();
            int counter = 1;
            clonedProperty.Name = GetUnusedPropertyName(clonedProperty.Name,counter);
            AddPropertyToDisplayWindow(clonedProperty);
            selectedGameObject.AddProperty(clonedProperty);
            SaveSelectedGameObject();
        }

        private string GetUnusedPropertyName(string name, int counter)
        {
            while (true)
            {
                if (!selectedGameObject.DoesPropertyExist(name + counter) && !displayObjectPropertiesList.ContainsKey(name + counter)) return name + counter;
                counter++;
            }
        }

        private void DisableGameObjectEntry()
        {
            btn_CloneObject.Enabled = false;
            btn_DeleteGameObject.Enabled = false;
            btn_SaveObject.Enabled = false;
            txtBox_GameObjectName.Enabled = false;
        }

        private void EnableGameObjectEntry()
        {
            btn_CloneObject.Enabled = true;
            btn_DeleteGameObject.Enabled = true;
            btn_SaveObject.Enabled = true;
            txtBox_GameObjectName.Enabled = true;
        }

        private void DisableGamePropertyEntry()
        {
            btn_CloneProperty.Enabled = false;
            btn_DeleteProperty.Enabled = false;
            btn_SaveProperty.Enabled = false;
            txtBox_PropertyName.Enabled = false;
            txtBox_PropertyValue.Enabled = false;
            grpBox_Type.Enabled = false;
        }

        private void EnableGamePropertyEntry()
        {
            btn_CloneProperty.Enabled = true;
            btn_DeleteProperty.Enabled = true;
            btn_SaveProperty.Enabled = true;
            txtBox_PropertyName.Enabled = true;
            txtBox_PropertyValue.Enabled = true;
            grpBox_Type.Enabled = true;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearGameObjectListBox();
            ObserverData observerData = Observer.GetObserverData();
            Response response = fileDialog.SaveFile(observerData, extension, name);
            SaveDirectory = response.DirectoryPath;
            EnableAll();
        }

        private void loadObsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Response response = fileDialog.LoadFile<ObserverData>(extension, name);
            if (!response.ValidData) return;

            currentObserverData = (ObserverData)response.Data;
            SaveDirectory = response.DirectoryPath;
            getGameObjects(currentObserverData);
            EnableAll();
        }

        private void saveObsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentObserverData == null) return;
            currentObserverData = Observer.GetObserverData();
            Archive.SaveData(currentObserverData, SaveDirectory);
        }

        private void GameObjecteEditor_Load(object sender, EventArgs e)
        {

        }

    }
}
