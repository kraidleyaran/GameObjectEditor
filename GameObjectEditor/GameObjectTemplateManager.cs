using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using GameObjectLib;
using GameObserverLib;
using FileDialogLib;
using FileDialogLib.Objects;
using GameArchiveLib;

namespace GameObjectEditor
{
    public partial class GameObjectTemplateManager : Form
    {
        private Property selectedProperty;
        private bool arePropFieldsActive = false;
        private PropertyType currentType;

        private GameObject selectedObject;
        private GameObserver Observer = new GameObserver();

        private string LoadDirectory = "";

        private Dictionary<string, GameObject> currentTemplates = new Dictionary<string, GameObject>();
        private Dictionary<string, Property> currentProperties = new Dictionary<string, Property>();
        private Dictionary<string, string> DefaultFileNames = new Dictionary<string, string>();

        private GameFileDialog gameFileDialog = new GameFileDialog();

        private GameArchive Archive = GameArchive.Instance;
        public GameObjectTemplateManager()
        {
            InitializeComponent();
            DisableGameObjectControls();
            DisablePropertyControls();
            
        }

        private void GameObjectTemplateManager_Load(object sender, EventArgs e)
        {
            LoadDirectory = Directory.GetCurrentDirectory() + @"\Templates";
            if (!Directory.Exists(LoadDirectory))
            {
                Directory.CreateDirectory("Templates");
            }
            SetInitialDirectory();
            LoadTemplatesFromFolder();
        }

        private void SetInitialDirectory()
        {
            gameFileDialog.InitialDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase) + @"\Templates";
        }
        private void LoadTemplatesFromFolder()
        {
            string[] paths = Directory.GetFiles(LoadDirectory);
            foreach (GameObject gameObject in paths.Select(path => Archive.LoadData<GameObject>(path)))
            {
                switch (AddGameObject(gameObject))
                {
                    case false:
                        break;
                }
            }
        }

        private void DisableGameObjectControls()
        {
            btn_CloneTemplate.Enabled = false;
            btn_SaveTemplate.Enabled = false;
            txtBox_TemplateName.Enabled = false;
        }

        private void EnableGameObjectControls()
        {
            btn_CloneTemplate.Enabled = true;
            btn_SaveTemplate.Enabled = true;
            txtBox_TemplateName.Enabled = true;
        }

        private void DisablePropertyControls()
        {
            btn_SaveProperty.Enabled = false;
            btn_CloneProperty.Enabled = false;
            btn_DeleteProperty.Enabled = false;
            grpBox_Type.Enabled = false;
            grpBox_Property.Enabled = false;
            arePropFieldsActive = false;
        }

        private void EnablePropertyControls()
        {
            btn_SaveProperty.Enabled = true;
            btn_CloneProperty.Enabled = true;
            btn_DeleteProperty.Enabled = true;
            grpBox_Type.Enabled = true;
            grpBox_Property.Enabled = true;
            arePropFieldsActive = true;
        }

        private void btn_NewTemplate_Click(object sender, EventArgs e)
        {
            
            NewGameObject newGameObject = new NewGameObject(Observer);
            newGameObject.ShowDialog();
            switch (newGameObject.ValidObject)
            {
                case true:
                    Response response = SaveTemplate(newGameObject.ReturnGameObject);
                    if (!response.ValidData)
                    {
                        return;
                    }
                    Observer.ObserveGameObject(newGameObject.ReturnGameObject);
                    listBox_Templates.Items.Add(newGameObject.ReturnGameObject.Name);
                    currentTemplates.Add(newGameObject.ReturnGameObject.Name,newGameObject.ReturnGameObject);
                    return;
                case false:
                    return;
            }
            
        }

        private void listBox_Templates_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_Templates.SelectedItem == null)
            {
                DisableGameObjectControls();
                return;
            }
            string objectName = listBox_Templates.SelectedItem.ToString();
            if (arePropFieldsActive)
            {
                SavePropertyFields();
            }
            ClearPropertyFields();
            EnableGameObjectControls();
            selectedObject = currentTemplates[objectName];
            DisplayObjectPropertiers(selectedObject);
            txtBox_TemplateName.Text = selectedObject.Name;
        }

        private void DisplayObjectPropertiers(GameObject gameObject) 
        {
            currentProperties = gameObject.GetAllProperties();
            listBox_Properties.Items.Clear();
            foreach (KeyValuePair<string, Property> pair in currentProperties)
            {
                listBox_Properties.Items.Add(pair.Key);
            }
        }

        private void listBox_Properties_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_Properties.SelectedItem == null)
            {
                DisablePropertyControls();
                selectedProperty = null;
                ClearPropertyFields();
                return;
            }
            EnablePropertyControls();
            string propertyName = listBox_Properties.SelectedItem.ToString();
            selectedProperty = currentProperties[propertyName];
            txtBox_PropertyName.Text = selectedProperty.Name;
            txtBox_PropertyValue.Text = selectedProperty.Value;
            CheckRadioButton(selectedProperty.Type);
        }

        private void CheckRadioButton(PropertyType type)
        {
            currentType = type;
            switch (type)
            {
                case PropertyType.Bool:
                    rdo_Boolean.Checked = true;
                    rdo_Number.Checked = false;
                    rdo_String.Checked = false;
                    return;
                case PropertyType.Number:
                    rdo_Boolean.Checked = false;
                    rdo_Number.Checked = true;
                    rdo_String.Checked = false;
                    return;
                case PropertyType.String:
                    rdo_Boolean.Checked = false;
                    rdo_Number.Checked = false;
                    rdo_String.Checked = true;
                    return;
                default:
                    MessageBox.Show("Invalid type");
                    return;
            }
        }

        private void btn_NewProperty_Click(object sender, EventArgs e)
        {
            if (selectedObject == null) return;
            NewGameObjectProperty newProperty = new NewGameObjectProperty(selectedObject);
            newProperty.ShowDialog();
            switch (newProperty.ValidProperty)
            {
                case true:
                    selectedObject.AddProperty(newProperty.ReturnProperty);
                    listBox_Properties.Items.Add(newProperty.ReturnProperty.Name);
                    return;
                case false:
                    return;
            }
        }

        private void SavePropertyFields()
        {
            if (selectedProperty == null) return;
            if (!selectedObject.DoesPropertyExist(txtBox_PropertyName.Text))
            {
                Property newProperty = new Property(currentType, txtBox_PropertyName.Text, txtBox_PropertyValue.Text);
                selectedObject.AddProperty(newProperty);
                return;
            }
            if (!CheckForPropertyChange()) return;
            switch (MessageBox.Show("Are you sure you want to overwrite " + txtBox_PropertyName.Text + "?", "Overwrite Property", MessageBoxButtons.OKCancel))
            {
                case DialogResult.OK:
                    selectedObject.SetProperty(txtBox_PropertyName.Text, txtBox_PropertyValue.Text, currentType);
                    break;
                case DialogResult.Cancel:
                    return;
            }
        }

        private bool CheckForPropertyChange()
        {
            if (selectedProperty.Name != txtBox_PropertyName.Text) return true;
            if (selectedProperty.Value != txtBox_PropertyValue.Text) return true;
            return false;
        }
        private void btn_SaveProperty_Click(object sender, EventArgs e)
        {
            SavePropertyFields();
        }

        private void rdo_Boolean_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_Boolean.Checked)
            {
                CheckRadioButton(PropertyType.Bool);
            }
        }

        private void rdo_Number_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_Number.Checked)
            {
                CheckRadioButton(PropertyType.Number);
            }
        }

        private void rdo_String_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_String.Checked)
            {
                CheckRadioButton(PropertyType.String);
            }
        }

        private void btn_SaveTemplate_Click(object sender, EventArgs e)
        {
            SaveTemplate(selectedObject);
        }

        private Response SaveTemplate(GameObject gameObject)
        {
            string defaultName = "";
            switch (DefaultFileNames.ContainsKey(gameObject.Name))
            {
                case true:
                    defaultName = DefaultFileNames[gameObject.Name];
                    break;
                case false:
                    defaultName = gameObject.Name;
                    break;
                
            }

            return gameFileDialog.SaveFile(gameObject, "got", "Game Object Template", defaultName);
        }

        private bool AddGameObject(GameObject gameObject)
        {
            if (Observer.DoesGameObjectNameExist(gameObject.Name)) return false;
            Observer.ObserveGameObject(gameObject);
            listBox_Templates.Items.Add(gameObject.Name);
            currentTemplates.Add(gameObject.Name, gameObject);
            return true;
        }

        private void ClearPropertyFields()
        {
            txtBox_PropertyName.Text = "";
            txtBox_PropertyValue.Text = "";
            rdo_Number.Checked = false;
            rdo_String.Checked = false;
            rdo_Boolean.Checked = false;
            DisablePropertyControls();
        }


       
    }
}
