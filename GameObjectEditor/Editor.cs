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
        private GameObserver Observer = GameObserver.Instance;
        private GameArchive Archive = GameArchive.Instance;

        private Dictionary<string, GameObject> DisplayObjectList = new Dictionary<string, GameObject>();
        private Dictionary<string, Property> displayObjectPropertiesList = new Dictionary<string, Property>();

        private string SaveDirectory = @"C:\";
        private GameObject selectedGameObject;
        private Property selectedProperty;
        private GameData currentGameData;
        public GameObjecteEditor()
        {
            InitializeComponent();
            DisableAll();
        }
        

        #region helper GameObject methods
        private void getGameObjects(GameData gameData)
        {
            ClearGameObjectListBox();
            foreach (KeyValuePair<string, GameObject> obj in gameData.ObserverData.ActiveObjects)
            {
                Observer.ObserveGameObject(obj.Value, ObjectStatus.Active);
                DisplayObjectList.Add(obj.Key, obj.Value);
            }
            foreach (KeyValuePair<string, GameObject> obj in gameData.ObserverData.InactiveObjects)
            {
                Observer.ObserveGameObject(obj.Value, ObjectStatus.Inactive);
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

        private void RemoveGameObjectFromDisplay(string name)
        {
            DisplayObjectList.Remove(name);
            listBox_GameObjects.Items.Remove(name);
        }

        private void SetObjectStatus(bool status)
        {
            if (status)
            {
                radio_Active.Checked = true;
                radio_Inactive.Checked = false;
            }
            else
            {
                radio_Active.Checked = false;
                radio_Inactive.Checked = true;
            }
        }
        #endregion

        #region GCD buttons
        private void btn_NewGCD_Click(object sender, EventArgs e)
        {
            ClearGameObjectListBox();
            Response response = fileDialog.SaveFile(new GameData(Observer.GetObserverData()));
            SaveDirectory = response.DirectoryPath;
            EnableAll();
        }
        private void btn_LoadGCD_Click(object sender, EventArgs e)
        {
            Response response = fileDialog.LoadFile();
            if (!response.ValidData) return;

            currentGameData = response.GameData;
            SaveDirectory = response.DirectoryPath;
            getGameObjects(currentGameData);
            EnableAll();
        }

        private void btn_SaveGCD_Click(object sender, EventArgs e)
        {
            currentGameData.ObserverData = Observer.GetObserverData();
            Archive.SaveData(currentGameData, SaveDirectory);
        }
        #endregion

        #region GameObject Buttons
        private void btn_NewGameObject_Click(object sender, EventArgs e)
        {
            NewGameObject newObjectForm = new NewGameObject();
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
            if (!radio_Active.Checked && !radio_Inactive.Checked)
            {
                MessageBox.Show("GameObject must have a status", "No status", MessageBoxButtons.OK);
                return;
            }

            selectedGameObject.Name = txtBox_GameObjectName.Text;
            RemoveGameObjectFromDisplay(objectName);
            bool test = Observer.UnobserveGameObject(objectName);
            switch (doesGameObjectExist)
            {
                case true:
                    switch (radio_Active.Checked)
                    {
                        case true:
                            Observer.ObserveGameObject(selectedGameObject, ObjectStatus.Active);
                            AddGameObjectToDisplay(selectedGameObject);
                            break;
                    }
                    switch (radio_Inactive.Checked)
                    {
                        case true:
                            Observer.ObserveGameObject(selectedGameObject, ObjectStatus.Inactive);
                            AddGameObjectToDisplay(selectedGameObject);
                            break;
                    }
                    break;
                case false:
                    switch (radio_Active.Checked)
                    {
                        case true:
                            Observer.ObserveGameObject(selectedGameObject, ObjectStatus.Active);
                            AddGameObjectToDisplay(selectedGameObject);
                            break;
                    }
                    switch (radio_Inactive.Checked)
                    {
                        case true:
                            Observer.ObserveGameObject(selectedGameObject, ObjectStatus.Inactive);
                            AddGameObjectToDisplay(selectedGameObject);
                            break;
                    }
                    break;
            }

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
            btn_CloneObject.Enabled = false;
            btn_DeleteGameObject.Enabled = false;
            btn_DeleteProperty.Enabled = false;
            btn_Export.Enabled = false;
            btn_ImportFromGCD.Enabled = false;
            btn_LoadImage.Enabled = false;
            btn_NewGameObject.Enabled = false;
            btn_NewProperty.Enabled = false;
            btn_SaveGCD.Enabled = false;
            btn_SaveObject.Enabled = false;
            btn_SaveProperty.Enabled = false;
            grpBox_Status.Enabled = false;
            grpBox_Type.Enabled = false;
            btn_CloneProperty.Enabled = false;
        }

        private void EnableAll()
        {
            btn_CloneObject.Enabled = true;
            btn_DeleteGameObject.Enabled = true;
            btn_DeleteProperty.Enabled = true;
            btn_Export.Enabled = true;
            btn_ImportFromGCD.Enabled = true;
            btn_LoadImage.Enabled = true;
            btn_NewGameObject.Enabled = true;
            btn_NewProperty.Enabled = true;
            btn_SaveGCD.Enabled = true;
            btn_SaveObject.Enabled = true;
            btn_SaveProperty.Enabled = true;
            grpBox_Status.Enabled = true;
            grpBox_Type.Enabled = true;
            btn_CloneProperty.Enabled = true;
        }
        #endregion

        #region Listbox EventHandlers
        private void listObjectBox_OnSelect(object sender, EventArgs args)
        {
            string gameObjectName = (string)listBox_GameObjects.SelectedItem;
            if (string.IsNullOrEmpty(gameObjectName)) return;
            
            txtBox_GameObjectName.Text = gameObjectName;
            
            GameObject gameObject;
            DisplayObjectList.TryGetValue(gameObjectName, out gameObject);
            if (gameObject == null)
            {
                MessageBox.Show("Null GameObject", "Null GameObject", MessageBoxButtons.OK);
                return;
            }
            selectedGameObject = gameObject;
            ObjectStatus status = Observer.GetGameObjectStatus(gameObjectName);
            switch (status)
            {
                case ObjectStatus.Active:
                    SetObjectStatus(true);
                    break;
                case ObjectStatus.Inactive:
                    SetObjectStatus(false);
                    break;
                case ObjectStatus.Error:
                    radio_Active.Checked = false;
                    radio_Inactive.Checked = false;
                    break;
            }
            ClearPropertyFields();
            FillPropertyBox(gameObject.GetAllProperties());
            if (selectedGameObject.Image == null)
            {
                pic_IconRep.Image = null;
                return;
            }
            pic_IconRep.Image = selectedGameObject.Image.ConvertBinaryToImage();
            SetImageSize();
        }

        private void listPropertiesBox_OnSelect(object sender, EventArgs args)
        {
            string propertyName = (string)listBox_Properties.SelectedItem;
            if (string.IsNullOrEmpty(propertyName)) return;

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
            newPropWindow.ShowDialog();
            newPropWindow.Closed += delegate(object o, EventArgs args)
            {
                if (!newPropWindow.ValidProperty) return;
                selectedGameObject.AddProperty(newPropWindow.ReturnProperty);
                SaveSelectedGameObject();
                AddPropertyToDisplayWindow(newPropWindow.ReturnProperty);
            };
            
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
            if (radio_Active.Checked && !radio_Inactive.Checked)
            {
                Observer.ObserveGameObject(clonedGameObject, ObjectStatus.Active);
            }
            else if (!radio_Active.Checked && radio_Inactive.Checked)
            {
                Observer.ObserveGameObject(clonedGameObject, ObjectStatus.Inactive);
            }
            else
            {
                MessageBox.Show("Cannot set GameObject status", "Invalid GameObject status", MessageBoxButtons.OK);
                return;
            }
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

        private void btn_LoadImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog newOpenFileDialog = new OpenFileDialog {InitialDirectory = @"C:\"})
            {
                switch (newOpenFileDialog.ShowDialog())
                {
                    case DialogResult.OK:
                        FileStream stream = File.OpenRead(newOpenFileDialog.FileName);                        
                        Image image = Image.FromStream(stream);
                        selectedGameObject.SetImage(image);
                        pic_IconRep.Image = image;
                        SetImageSize();
                        break;
                }
            }
        }

        private void SetImageSize()
        {
            if (pic_IconRep.Image.Size.Height > pic_IconRep.Height || pic_IconRep.Size.Width > pic_IconRep.Width)
            {
                pic_IconRep.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pic_IconRep.SizeMode = PictureBoxSizeMode.CenterImage;
            }
        }


    }
}
