using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameObjectEditor
{
    public partial class SelectTemplateWindow : Form
    {
        public string SelectedTemplate = "";
        public SelectTemplateWindow(List<string> templateNames)
        {
            InitializeComponent();
            AddTemplatesToDisplay(templateNames);
            DialogResult = DialogResult.Cancel;
        }

        private void AddTemplatesToDisplay(List<string> templateNames)
        {
            foreach (string name in templateNames)
            {
                cmboboxTemplates.Items.Add(name);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            SelectedTemplate = (string) cmboboxTemplates.SelectedItem;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
