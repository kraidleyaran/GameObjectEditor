namespace GameObjectEditor
{
    partial class GameObjecteEditor
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
            this.listBox_GameObjects = new System.Windows.Forms.ListBox();
            this.listBox_Properties = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Properties = new System.Windows.Forms.Label();
            this.btn_NewGCD = new System.Windows.Forms.Button();
            this.btn_LoadGCD = new System.Windows.Forms.Button();
            this.btn_SaveGCD = new System.Windows.Forms.Button();
            this.btn_Export = new System.Windows.Forms.Button();
            this.btn_NewGameObject = new System.Windows.Forms.Button();
            this.btn_DeleteGameObject = new System.Windows.Forms.Button();
            this.txtBox_PropertyValue = new System.Windows.Forms.TextBox();
            this.lbl_PropertyValue = new System.Windows.Forms.Label();
            this.btn_NewProperty = new System.Windows.Forms.Button();
            this.btn_DeleteProperty = new System.Windows.Forms.Button();
            this.pic_IconRep = new System.Windows.Forms.PictureBox();
            this.grpBox_Type = new System.Windows.Forms.GroupBox();
            this.radion_Boolean = new System.Windows.Forms.RadioButton();
            this.radio_Number = new System.Windows.Forms.RadioButton();
            this.radio_String = new System.Windows.Forms.RadioButton();
            this.btn_LoadImage = new System.Windows.Forms.Button();
            this.lbl_Icon = new System.Windows.Forms.Label();
            this.btn_SaveProperty = new System.Windows.Forms.Button();
            this.btn_CloneObject = new System.Windows.Forms.Button();
            this.btn_SaveObject = new System.Windows.Forms.Button();
            this.txtBox_GameObjectName = new System.Windows.Forms.TextBox();
            this.lbl_SelectedGameObject = new System.Windows.Forms.Label();
            this.txtBox_PropertyName = new System.Windows.Forms.TextBox();
            this.lbl_PropertyName = new System.Windows.Forms.Label();
            this.btn_CloneProperty = new System.Windows.Forms.Button();
            this.btn_ImportFromGCD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_IconRep)).BeginInit();
            this.grpBox_Type.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_GameObjects
            // 
            this.listBox_GameObjects.FormattingEnabled = true;
            this.listBox_GameObjects.Location = new System.Drawing.Point(330, 76);
            this.listBox_GameObjects.Name = "listBox_GameObjects";
            this.listBox_GameObjects.Size = new System.Drawing.Size(200, 537);
            this.listBox_GameObjects.TabIndex = 0;
            this.listBox_GameObjects.SelectedIndexChanged += new System.EventHandler(this.listObjectBox_OnSelect);
            // 
            // listBox_Properties
            // 
            this.listBox_Properties.FormattingEnabled = true;
            this.listBox_Properties.Location = new System.Drawing.Point(572, 76);
            this.listBox_Properties.Name = "listBox_Properties";
            this.listBox_Properties.Size = new System.Drawing.Size(195, 537);
            this.listBox_Properties.TabIndex = 1;
            this.listBox_Properties.SelectedIndexChanged += new System.EventHandler(this.listPropertiesBox_OnSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(387, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Game Objects";
            // 
            // lbl_Properties
            // 
            this.lbl_Properties.AutoSize = true;
            this.lbl_Properties.Location = new System.Drawing.Point(640, 60);
            this.lbl_Properties.Name = "lbl_Properties";
            this.lbl_Properties.Size = new System.Drawing.Size(54, 13);
            this.lbl_Properties.TabIndex = 3;
            this.lbl_Properties.Text = "Properties";
            // 
            // btn_NewGCD
            // 
            this.btn_NewGCD.Location = new System.Drawing.Point(23, 12);
            this.btn_NewGCD.Name = "btn_NewGCD";
            this.btn_NewGCD.Size = new System.Drawing.Size(75, 23);
            this.btn_NewGCD.TabIndex = 4;
            this.btn_NewGCD.Text = "New Obs";
            this.btn_NewGCD.UseVisualStyleBackColor = true;
            this.btn_NewGCD.Click += new System.EventHandler(this.btn_NewGCD_Click);
            // 
            // btn_LoadGCD
            // 
            this.btn_LoadGCD.Location = new System.Drawing.Point(104, 12);
            this.btn_LoadGCD.Name = "btn_LoadGCD";
            this.btn_LoadGCD.Size = new System.Drawing.Size(75, 23);
            this.btn_LoadGCD.TabIndex = 5;
            this.btn_LoadGCD.Text = "Load Obs";
            this.btn_LoadGCD.UseVisualStyleBackColor = true;
            this.btn_LoadGCD.Click += new System.EventHandler(this.btn_LoadGCD_Click);
            // 
            // btn_SaveGCD
            // 
            this.btn_SaveGCD.Location = new System.Drawing.Point(185, 12);
            this.btn_SaveGCD.Name = "btn_SaveGCD";
            this.btn_SaveGCD.Size = new System.Drawing.Size(75, 23);
            this.btn_SaveGCD.TabIndex = 6;
            this.btn_SaveGCD.Text = "Save Obs";
            this.btn_SaveGCD.UseVisualStyleBackColor = true;
            this.btn_SaveGCD.Click += new System.EventHandler(this.btn_SaveGCD_Click);
            // 
            // btn_Export
            // 
            this.btn_Export.Location = new System.Drawing.Point(291, 12);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(103, 23);
            this.btn_Export.TabIndex = 7;
            this.btn_Export.Text = "Export to GCD";
            this.btn_Export.UseVisualStyleBackColor = true;
            // 
            // btn_NewGameObject
            // 
            this.btn_NewGameObject.Location = new System.Drawing.Point(94, 76);
            this.btn_NewGameObject.Name = "btn_NewGameObject";
            this.btn_NewGameObject.Size = new System.Drawing.Size(116, 23);
            this.btn_NewGameObject.TabIndex = 8;
            this.btn_NewGameObject.Text = "New Game Object";
            this.btn_NewGameObject.UseVisualStyleBackColor = true;
            this.btn_NewGameObject.Click += new System.EventHandler(this.btn_NewGameObject_Click);
            // 
            // btn_DeleteGameObject
            // 
            this.btn_DeleteGameObject.Location = new System.Drawing.Point(103, 233);
            this.btn_DeleteGameObject.Name = "btn_DeleteGameObject";
            this.btn_DeleteGameObject.Size = new System.Drawing.Size(114, 23);
            this.btn_DeleteGameObject.TabIndex = 9;
            this.btn_DeleteGameObject.Text = "Delete Game Object";
            this.btn_DeleteGameObject.UseVisualStyleBackColor = true;
            this.btn_DeleteGameObject.Click += new System.EventHandler(this.btn_DeleteGameObject_Click);
            // 
            // txtBox_PropertyValue
            // 
            this.txtBox_PropertyValue.Location = new System.Drawing.Point(789, 236);
            this.txtBox_PropertyValue.Name = "txtBox_PropertyValue";
            this.txtBox_PropertyValue.Size = new System.Drawing.Size(244, 20);
            this.txtBox_PropertyValue.TabIndex = 10;
            // 
            // lbl_PropertyValue
            // 
            this.lbl_PropertyValue.AutoSize = true;
            this.lbl_PropertyValue.Location = new System.Drawing.Point(868, 221);
            this.lbl_PropertyValue.Name = "lbl_PropertyValue";
            this.lbl_PropertyValue.Size = new System.Drawing.Size(76, 13);
            this.lbl_PropertyValue.TabIndex = 11;
            this.lbl_PropertyValue.Text = "Property Value";
            // 
            // btn_NewProperty
            // 
            this.btn_NewProperty.Location = new System.Drawing.Point(861, 125);
            this.btn_NewProperty.Name = "btn_NewProperty";
            this.btn_NewProperty.Size = new System.Drawing.Size(89, 23);
            this.btn_NewProperty.TabIndex = 12;
            this.btn_NewProperty.Text = "New Property";
            this.btn_NewProperty.UseVisualStyleBackColor = true;
            this.btn_NewProperty.Click += new System.EventHandler(this.btn_NewProperty_Click);
            // 
            // btn_DeleteProperty
            // 
            this.btn_DeleteProperty.Location = new System.Drawing.Point(872, 356);
            this.btn_DeleteProperty.Name = "btn_DeleteProperty";
            this.btn_DeleteProperty.Size = new System.Drawing.Size(92, 23);
            this.btn_DeleteProperty.TabIndex = 13;
            this.btn_DeleteProperty.Text = "Delete Property";
            this.btn_DeleteProperty.UseVisualStyleBackColor = true;
            this.btn_DeleteProperty.Click += new System.EventHandler(this.btn_DeleteProperty_Click);
            // 
            // pic_IconRep
            // 
            this.pic_IconRep.Location = new System.Drawing.Point(23, 391);
            this.pic_IconRep.Name = "pic_IconRep";
            this.pic_IconRep.Size = new System.Drawing.Size(272, 189);
            this.pic_IconRep.TabIndex = 14;
            this.pic_IconRep.TabStop = false;
            // 
            // grpBox_Type
            // 
            this.grpBox_Type.Controls.Add(this.radion_Boolean);
            this.grpBox_Type.Controls.Add(this.radio_Number);
            this.grpBox_Type.Controls.Add(this.radio_String);
            this.grpBox_Type.Location = new System.Drawing.Point(806, 260);
            this.grpBox_Type.Name = "grpBox_Type";
            this.grpBox_Type.Size = new System.Drawing.Size(200, 47);
            this.grpBox_Type.TabIndex = 15;
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
            // btn_LoadImage
            // 
            this.btn_LoadImage.Location = new System.Drawing.Point(122, 586);
            this.btn_LoadImage.Name = "btn_LoadImage";
            this.btn_LoadImage.Size = new System.Drawing.Size(75, 23);
            this.btn_LoadImage.TabIndex = 16;
            this.btn_LoadImage.Text = "Load Image";
            this.btn_LoadImage.UseVisualStyleBackColor = true;
            this.btn_LoadImage.Click += new System.EventHandler(this.btn_LoadImage_Click);
            // 
            // lbl_Icon
            // 
            this.lbl_Icon.AutoSize = true;
            this.lbl_Icon.Location = new System.Drawing.Point(130, 375);
            this.lbl_Icon.Name = "lbl_Icon";
            this.lbl_Icon.Size = new System.Drawing.Size(58, 13);
            this.lbl_Icon.TabIndex = 17;
            this.lbl_Icon.Text = "Editor Icon";
            // 
            // btn_SaveProperty
            // 
            this.btn_SaveProperty.Location = new System.Drawing.Point(813, 318);
            this.btn_SaveProperty.Name = "btn_SaveProperty";
            this.btn_SaveProperty.Size = new System.Drawing.Size(95, 23);
            this.btn_SaveProperty.TabIndex = 18;
            this.btn_SaveProperty.Text = "Save Property";
            this.btn_SaveProperty.UseVisualStyleBackColor = true;
            this.btn_SaveProperty.Click += new System.EventHandler(this.btn_SaveProperty_Click);
            // 
            // btn_CloneObject
            // 
            this.btn_CloneObject.Location = new System.Drawing.Point(169, 196);
            this.btn_CloneObject.Name = "btn_CloneObject";
            this.btn_CloneObject.Size = new System.Drawing.Size(117, 23);
            this.btn_CloneObject.TabIndex = 19;
            this.btn_CloneObject.Text = "Clone Game Object";
            this.btn_CloneObject.UseVisualStyleBackColor = true;
            this.btn_CloneObject.Click += new System.EventHandler(this.btn_CloneObject_Click);
            // 
            // btn_SaveObject
            // 
            this.btn_SaveObject.Location = new System.Drawing.Point(38, 197);
            this.btn_SaveObject.Name = "btn_SaveObject";
            this.btn_SaveObject.Size = new System.Drawing.Size(114, 23);
            this.btn_SaveObject.TabIndex = 20;
            this.btn_SaveObject.Text = "Save Game Object";
            this.btn_SaveObject.UseVisualStyleBackColor = true;
            this.btn_SaveObject.Click += new System.EventHandler(this.btn_SaveObject_Click);
            // 
            // txtBox_GameObjectName
            // 
            this.txtBox_GameObjectName.Location = new System.Drawing.Point(50, 154);
            this.txtBox_GameObjectName.Name = "txtBox_GameObjectName";
            this.txtBox_GameObjectName.Size = new System.Drawing.Size(224, 20);
            this.txtBox_GameObjectName.TabIndex = 21;
            // 
            // lbl_SelectedGameObject
            // 
            this.lbl_SelectedGameObject.AutoSize = true;
            this.lbl_SelectedGameObject.Location = new System.Drawing.Point(101, 138);
            this.lbl_SelectedGameObject.Name = "lbl_SelectedGameObject";
            this.lbl_SelectedGameObject.Size = new System.Drawing.Size(114, 13);
            this.lbl_SelectedGameObject.TabIndex = 22;
            this.lbl_SelectedGameObject.Text = "Selected Game Object";
            // 
            // txtBox_PropertyName
            // 
            this.txtBox_PropertyName.Location = new System.Drawing.Point(789, 187);
            this.txtBox_PropertyName.Name = "txtBox_PropertyName";
            this.txtBox_PropertyName.Size = new System.Drawing.Size(244, 20);
            this.txtBox_PropertyName.TabIndex = 24;
            // 
            // lbl_PropertyName
            // 
            this.lbl_PropertyName.AutoSize = true;
            this.lbl_PropertyName.Location = new System.Drawing.Point(868, 171);
            this.lbl_PropertyName.Name = "lbl_PropertyName";
            this.lbl_PropertyName.Size = new System.Drawing.Size(77, 13);
            this.lbl_PropertyName.TabIndex = 25;
            this.lbl_PropertyName.Text = "Property Name";
            // 
            // btn_CloneProperty
            // 
            this.btn_CloneProperty.Location = new System.Drawing.Point(929, 318);
            this.btn_CloneProperty.Name = "btn_CloneProperty";
            this.btn_CloneProperty.Size = new System.Drawing.Size(104, 23);
            this.btn_CloneProperty.TabIndex = 26;
            this.btn_CloneProperty.Text = "Clone Property";
            this.btn_CloneProperty.UseVisualStyleBackColor = true;
            this.btn_CloneProperty.Click += new System.EventHandler(this.btn_CloneProperty_Click);
            // 
            // btn_ImportFromGCD
            // 
            this.btn_ImportFromGCD.Location = new System.Drawing.Point(401, 11);
            this.btn_ImportFromGCD.Name = "btn_ImportFromGCD";
            this.btn_ImportFromGCD.Size = new System.Drawing.Size(97, 23);
            this.btn_ImportFromGCD.TabIndex = 27;
            this.btn_ImportFromGCD.Text = "Import from GCD";
            this.btn_ImportFromGCD.UseVisualStyleBackColor = true;
            // 
            // GameObjecteEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 620);
            this.Controls.Add(this.btn_ImportFromGCD);
            this.Controls.Add(this.btn_CloneProperty);
            this.Controls.Add(this.lbl_PropertyName);
            this.Controls.Add(this.txtBox_PropertyName);
            this.Controls.Add(this.lbl_SelectedGameObject);
            this.Controls.Add(this.txtBox_GameObjectName);
            this.Controls.Add(this.btn_SaveObject);
            this.Controls.Add(this.btn_CloneObject);
            this.Controls.Add(this.btn_SaveProperty);
            this.Controls.Add(this.lbl_Icon);
            this.Controls.Add(this.btn_LoadImage);
            this.Controls.Add(this.grpBox_Type);
            this.Controls.Add(this.pic_IconRep);
            this.Controls.Add(this.btn_DeleteProperty);
            this.Controls.Add(this.btn_NewProperty);
            this.Controls.Add(this.lbl_PropertyValue);
            this.Controls.Add(this.txtBox_PropertyValue);
            this.Controls.Add(this.btn_DeleteGameObject);
            this.Controls.Add(this.btn_NewGameObject);
            this.Controls.Add(this.btn_Export);
            this.Controls.Add(this.btn_SaveGCD);
            this.Controls.Add(this.btn_LoadGCD);
            this.Controls.Add(this.btn_NewGCD);
            this.Controls.Add(this.lbl_Properties);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_Properties);
            this.Controls.Add(this.listBox_GameObjects);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(1078, 658);
            this.MinimumSize = new System.Drawing.Size(1078, 658);
            this.Name = "GameObjecteEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Object Editor";
            ((System.ComponentModel.ISupportInitialize)(this.pic_IconRep)).EndInit();
            this.grpBox_Type.ResumeLayout(false);
            this.grpBox_Type.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_GameObjects;
        private System.Windows.Forms.ListBox listBox_Properties;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Properties;
        private System.Windows.Forms.Button btn_NewGCD;
        private System.Windows.Forms.Button btn_LoadGCD;
        private System.Windows.Forms.Button btn_SaveGCD;
        private System.Windows.Forms.Button btn_Export;
        private System.Windows.Forms.Button btn_NewGameObject;
        private System.Windows.Forms.Button btn_DeleteGameObject;
        private System.Windows.Forms.TextBox txtBox_PropertyValue;
        private System.Windows.Forms.Label lbl_PropertyValue;
        private System.Windows.Forms.Button btn_NewProperty;
        private System.Windows.Forms.Button btn_DeleteProperty;
        private System.Windows.Forms.PictureBox pic_IconRep;
        private System.Windows.Forms.GroupBox grpBox_Type;
        private System.Windows.Forms.RadioButton radion_Boolean;
        private System.Windows.Forms.RadioButton radio_Number;
        private System.Windows.Forms.RadioButton radio_String;
        private System.Windows.Forms.Button btn_LoadImage;
        private System.Windows.Forms.Label lbl_Icon;
        private System.Windows.Forms.Button btn_SaveProperty;
        private System.Windows.Forms.Button btn_CloneObject;
        private System.Windows.Forms.Button btn_SaveObject;
        private System.Windows.Forms.TextBox txtBox_GameObjectName;
        private System.Windows.Forms.Label lbl_SelectedGameObject;
        private System.Windows.Forms.TextBox txtBox_PropertyName;
        private System.Windows.Forms.Label lbl_PropertyName;
        private System.Windows.Forms.Button btn_CloneProperty;
        private System.Windows.Forms.Button btn_ImportFromGCD;
    }
}

