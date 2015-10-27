using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameObjectLib;

namespace GameObjectEditor
{
    public partial class NewGameObjectProperty : Form
    {
        private const string String = "String";
        private const string Number = "Number";
        private const string Boolean = "Boolean";
        public NewGameObjectProperty(GameObject gameObject)
        {
            InitializeComponent();
            currentGameObject = gameObject;
        }

        public Property ReturnProperty;
        public bool ValidProperty = false;
        private GameObject currentGameObject;
        private void btn_OK_Click(object sender, EventArgs e)
        {
            string propName = txtBox_PropertyName.Text;
            bool propExist = currentGameObject.DoesPropertyExist(propName);
            if (propExist)
            {
                MessageBox.Show("Property name " + propName + " already exists in GameObject " + currentGameObject.Name);
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
            }
            string type = typeSelected.First().Key;
            if (!IsPropertyValueValid(type))
            {
                return;
            }

            switch (type)
            {
                case String:
                    ReturnProperty = new Property(PropertyType.String, propName, txtBox_PropertyValue.Text);
                    break;
                case Number:
                    ReturnProperty = new Property(PropertyType.Number, propName, txtBox_PropertyValue.Text);
                    break;
                case Boolean:
                    ReturnProperty = new Property(PropertyType.Bool, propName, txtBox_PropertyValue.Text);
                    break;
            }
            ValidProperty = true;
            Close();

        }

        private bool IsPropertyValueValid(string type)
        {
            if (type == Number)
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
            if (type == Boolean)
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
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            ValidProperty = false;
            Close();
        }

        private Dictionary<string, bool> IsTypeSelected()
        {
            Dictionary<string, bool> returnDictionary = new Dictionary<string, bool>();
            if (radio_String.Checked)
            {
                returnDictionary.Add(String, true);
            }
            if (radio_Number.Checked)
            {
                returnDictionary.Add(Number, true);
            }
            if (radion_Boolean.Checked)
            {
                returnDictionary.Add(Boolean, true);
            }
            return returnDictionary;
        }
    }

}
