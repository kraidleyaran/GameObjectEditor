namespace GameObjectEditor
{
    partial class NewGameObjectProperty
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
            this.lbl_PropertyName = new System.Windows.Forms.Label();
            this.txtBox_PropertyName = new System.Windows.Forms.TextBox();
            this.grpBox_Type = new System.Windows.Forms.GroupBox();
            this.radion_Boolean = new System.Windows.Forms.RadioButton();
            this.radio_Number = new System.Windows.Forms.RadioButton();
            this.radio_String = new System.Windows.Forms.RadioButton();
            this.lbl_PropertyValue = new System.Windows.Forms.Label();
            this.txtBox_PropertyValue = new System.Windows.Forms.TextBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.grpBox_Type.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_PropertyName
            // 
            this.lbl_PropertyName.AutoSize = true;
            this.lbl_PropertyName.Location = new System.Drawing.Point(91, 9);
            this.lbl_PropertyName.Name = "lbl_PropertyName";
            this.lbl_PropertyName.Size = new System.Drawing.Size(77, 13);
            this.lbl_PropertyName.TabIndex = 30;
            this.lbl_PropertyName.Text = "Property Name";
            // 
            // txtBox_PropertyName
            // 
            this.txtBox_PropertyName.Location = new System.Drawing.Point(12, 25);
            this.txtBox_PropertyName.Name = "txtBox_PropertyName";
            this.txtBox_PropertyName.Size = new System.Drawing.Size(244, 20);
            this.txtBox_PropertyName.TabIndex = 29;
            // 
            // grpBox_Type
            // 
            this.grpBox_Type.Controls.Add(this.radion_Boolean);
            this.grpBox_Type.Controls.Add(this.radio_Number);
            this.grpBox_Type.Controls.Add(this.radio_String);
            this.grpBox_Type.Location = new System.Drawing.Point(29, 98);
            this.grpBox_Type.Name = "grpBox_Type";
            this.grpBox_Type.Size = new System.Drawing.Size(200, 47);
            this.grpBox_Type.TabIndex = 28;
            this.grpBox_Type.TabStop = false;
            this.grpBox_Type.Text = "Type";
            // 
            // radion_Boolean
            // 
            this.radion_Boolean.AutoSize = true;
            this.radion_Boolean.Location = new System.Drawing.Point(133, 19);
            this.radion_Boolean.Name = "radion_Boolean";
            this.radion_Boolean.Size = new System.Drawing.Size(64, 17);
            this.radion_Boolean.TabIndex = 2;
            this.radion_Boolean.TabStop = true;
            this.radion_Boolean.Text = "Boolean";
            this.radion_Boolean.UseVisualStyleBackColor = true;
            // 
            // radio_Number
            // 
            this.radio_Number.AutoSize = true;
            this.radio_Number.Location = new System.Drawing.Point(65, 20);
            this.radio_Number.Name = "radio_Number";
            this.radio_Number.Size = new System.Drawing.Size(62, 17);
            this.radio_Number.TabIndex = 1;
            this.radio_Number.TabStop = true;
            this.radio_Number.Text = "Number";
            this.radio_Number.UseVisualStyleBackColor = true;
            // 
            // radio_String
            // 
            this.radio_String.AutoSize = true;
            this.radio_String.Location = new System.Drawing.Point(7, 20);
            this.radio_String.Name = "radio_String";
            this.radio_String.Size = new System.Drawing.Size(52, 17);
            this.radio_String.TabIndex = 0;
            this.radio_String.TabStop = true;
            this.radio_String.Text = "String";
            this.radio_String.UseVisualStyleBackColor = true;
            // 
            // lbl_PropertyValue
            // 
            this.lbl_PropertyValue.AutoSize = true;
            this.lbl_PropertyValue.Location = new System.Drawing.Point(91, 59);
            this.lbl_PropertyValue.Name = "lbl_PropertyValue";
            this.lbl_PropertyValue.Size = new System.Drawing.Size(76, 13);
            this.lbl_PropertyValue.TabIndex = 27;
            this.lbl_PropertyValue.Text = "Property Value";
            // 
            // txtBox_PropertyValue
            // 
            this.txtBox_PropertyValue.Location = new System.Drawing.Point(12, 74);
            this.txtBox_PropertyValue.Name = "txtBox_PropertyValue";
            this.txtBox_PropertyValue.Size = new System.Drawing.Size(244, 20);
            this.txtBox_PropertyValue.TabIndex = 26;
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(36, 160);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 31;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(137, 160);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 32;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // NewGameObjectProperty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 205);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.lbl_PropertyName);
            this.Controls.Add(this.txtBox_PropertyName);
            this.Controls.Add(this.grpBox_Type);
            this.Controls.Add(this.lbl_PropertyValue);
            this.Controls.Add(this.txtBox_PropertyValue);
            this.Name = "NewGameObjectProperty";
            this.Text = "NewGameObjectProperty";
            this.grpBox_Type.ResumeLayout(false);
            this.grpBox_Type.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_PropertyName;
        private System.Windows.Forms.TextBox txtBox_PropertyName;
        private System.Windows.Forms.GroupBox grpBox_Type;
        private System.Windows.Forms.RadioButton radion_Boolean;
        private System.Windows.Forms.RadioButton radio_Number;
        private System.Windows.Forms.RadioButton radio_String;
        private System.Windows.Forms.Label lbl_PropertyValue;
        private System.Windows.Forms.TextBox txtBox_PropertyValue;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;

    }
}