namespace GameObjectEditor
{
    partial class NewGameObject
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Create = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.txtBox_Name = new System.Windows.Forms.TextBox();
            this.lbl_ObjectName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Create
            // 
            this.btn_Create.Location = new System.Drawing.Point(43, 62);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(75, 23);
            this.btn_Create.TabIndex = 0;
            this.btn_Create.Text = "Create";
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(150, 62);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 1;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // txtBox_Name
            // 
            this.txtBox_Name.Location = new System.Drawing.Point(12, 25);
            this.txtBox_Name.Name = "txtBox_Name";
            this.txtBox_Name.Size = new System.Drawing.Size(251, 20);
            this.txtBox_Name.TabIndex = 2;
            // 
            // lbl_ObjectName
            // 
            this.lbl_ObjectName.AutoSize = true;
            this.lbl_ObjectName.Location = new System.Drawing.Point(84, 9);
            this.lbl_ObjectName.Name = "lbl_ObjectName";
            this.lbl_ObjectName.Size = new System.Drawing.Size(100, 13);
            this.lbl_ObjectName.TabIndex = 3;
            this.lbl_ObjectName.Text = "Game Object Name";
            // 
            // NewGameObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 118);
            this.Controls.Add(this.lbl_ObjectName);
            this.Controls.Add(this.txtBox_Name);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Create);
            this.Name = "NewGameObject";
            this.Text = "New Game Object";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.TextBox txtBox_Name;
        private System.Windows.Forms.Label lbl_ObjectName;
    }
}