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
using GameObserverLib;

namespace GameObjectEditor
{
    public partial class NewGameObject : Form
    {
        private GameObserver Observer = GameObserver.Instance;
        public GameObject ReturnGameObject;
        public bool ValidObject = false;
        public NewGameObject()
        {
            InitializeComponent();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            if (Observer.DoesGameObjectNameExist(txtBox_Name.Text))
            {
                MessageBox.Show("GameObject Name " + txtBox_Name.Text + " already exists", "Name exists", MessageBoxButtons.OK);
                return;
            }
            ReturnGameObject = new GameObject(txtBox_Name.Text);
            ValidObject = true;
            this.Close();
        }

        
    }
}
