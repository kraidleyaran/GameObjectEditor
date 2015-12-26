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
    public partial class NewNameWindow : Form
    {
        public string ReturnName = "";
        private List<string> Names;
        public NewNameWindow(List<string> names)
        {
            InitializeComponent();
            Names = names;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (Names.Contains(txtBox_Name.Text))
            {
                MessageBox.Show(txtBox_Name.Text + " already exists. Try again");
                return;
            }
            DialogResult = DialogResult.OK;
            ReturnName = txtBox_Name.Text;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }


    }
}
