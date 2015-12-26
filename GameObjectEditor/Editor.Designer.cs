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
            this.btn_NewGameObject = new System.Windows.Forms.Button();
            this.btn_DeleteGameObject = new System.Windows.Forms.Button();
            this.txtBox_PropertyValue = new System.Windows.Forms.TextBox();
            this.lbl_PropertyValue = new System.Windows.Forms.Label();
            this.btn_NewProperty = new System.Windows.Forms.Button();
            this.btn_DeleteProperty = new System.Windows.Forms.Button();
            this.grpBox_Type = new System.Windows.Forms.GroupBox();
            this.radion_Boolean = new System.Windows.Forms.RadioButton();
            this.radio_Number = new System.Windows.Forms.RadioButton();
            this.radio_String = new System.Windows.Forms.RadioButton();
            this.btn_SaveProperty = new System.Windows.Forms.Button();
            this.btn_CloneObject = new System.Windows.Forms.Button();
            this.btn_SaveObject = new System.Windows.Forms.Button();
            this.txtBox_GameObjectName = new System.Windows.Forms.TextBox();
            this.lbl_SelectedGameObject = new System.Windows.Forms.Label();
            this.txtBox_PropertyName = new System.Windows.Forms.TextBox();
            this.lbl_PropertyName = new System.Windows.Forms.Label();
            this.btn_CloneProperty = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadObsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveObsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsObsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.templateManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_NewFromTemplate = new System.Windows.Forms.Button();
            this.btn_CreateTemplateFromGameObject = new System.Windows.Forms.Button();
            this.grpBox_Type.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_GameObjects
            // 
            this.listBox_GameObjects.FormattingEnabled = true;
            this.listBox_GameObjects.Location = new System.Drawing.Point(307, 49);
            this.listBox_GameObjects.Name = "listBox_GameObjects";
            this.listBox_GameObjects.Size = new System.Drawing.Size(200, 329);
            this.listBox_GameObjects.TabIndex = 0;
            this.listBox_GameObjects.SelectedIndexChanged += new System.EventHandler(this.listObjectBox_OnSelect);
            // 
            // listBox_Properties
            // 
            this.listBox_Properties.FormattingEnabled = true;
            this.listBox_Properties.Location = new System.Drawing.Point(549, 49);
            this.listBox_Properties.Name = "listBox_Properties";
            this.listBox_Properties.Size = new System.Drawing.Size(195, 329);
            this.listBox_Properties.TabIndex = 1;
            this.listBox_Properties.SelectedIndexChanged += new System.EventHandler(this.listPropertiesBox_OnSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(364, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Game Objects";
            // 
            // lbl_Properties
            // 
            this.lbl_Properties.AutoSize = true;
            this.lbl_Properties.Location = new System.Drawing.Point(617, 33);
            this.lbl_Properties.Name = "lbl_Properties";
            this.lbl_Properties.Size = new System.Drawing.Size(54, 13);
            this.lbl_Properties.TabIndex = 3;
            this.lbl_Properties.Text = "Properties";
            // 
            // btn_NewGameObject
            // 
            this.btn_NewGameObject.Location = new System.Drawing.Point(18, 59);
            this.btn_NewGameObject.Name = "btn_NewGameObject";
            this.btn_NewGameObject.Size = new System.Drawing.Size(116, 23);
            this.btn_NewGameObject.TabIndex = 8;
            this.btn_NewGameObject.Text = "New Game Object";
            this.btn_NewGameObject.UseVisualStyleBackColor = true;
            this.btn_NewGameObject.Click += new System.EventHandler(this.btn_NewGameObject_Click);
            // 
            // btn_DeleteGameObject
            // 
            this.btn_DeleteGameObject.Location = new System.Drawing.Point(101, 200);
            this.btn_DeleteGameObject.Name = "btn_DeleteGameObject";
            this.btn_DeleteGameObject.Size = new System.Drawing.Size(114, 23);
            this.btn_DeleteGameObject.TabIndex = 9;
            this.btn_DeleteGameObject.Text = "Delete Game Object";
            this.btn_DeleteGameObject.UseVisualStyleBackColor = true;
            this.btn_DeleteGameObject.Click += new System.EventHandler(this.btn_DeleteGameObject_Click);
            // 
            // txtBox_PropertyValue
            // 
            this.txtBox_PropertyValue.Location = new System.Drawing.Point(769, 160);
            this.txtBox_PropertyValue.Name = "txtBox_PropertyValue";
            this.txtBox_PropertyValue.Size = new System.Drawing.Size(244, 20);
            this.txtBox_PropertyValue.TabIndex = 10;
            // 
            // lbl_PropertyValue
            // 
            this.lbl_PropertyValue.AutoSize = true;
            this.lbl_PropertyValue.Location = new System.Drawing.Point(848, 145);
            this.lbl_PropertyValue.Name = "lbl_PropertyValue";
            this.lbl_PropertyValue.Size = new System.Drawing.Size(76, 13);
            this.lbl_PropertyValue.TabIndex = 11;
            this.lbl_PropertyValue.Text = "Property Value";
            // 
            // btn_NewProperty
            // 
            this.btn_NewProperty.Location = new System.Drawing.Point(841, 49);
            this.btn_NewProperty.Name = "btn_NewProperty";
            this.btn_NewProperty.Size = new System.Drawing.Size(89, 23);
            this.btn_NewProperty.TabIndex = 12;
            this.btn_NewProperty.Text = "New Property";
            this.btn_NewProperty.UseVisualStyleBackColor = true;
            this.btn_NewProperty.Click += new System.EventHandler(this.btn_NewProperty_Click);
            // 
            // btn_DeleteProperty
            // 
            this.btn_DeleteProperty.Location = new System.Drawing.Point(840, 292);
            this.btn_DeleteProperty.Name = "btn_DeleteProperty";
            this.btn_DeleteProperty.Size = new System.Drawing.Size(92, 23);
            this.btn_DeleteProperty.TabIndex = 13;
            this.btn_DeleteProperty.Text = "Delete Property";
            this.btn_DeleteProperty.UseVisualStyleBackColor = true;
            this.btn_DeleteProperty.Click += new System.EventHandler(this.btn_DeleteProperty_Click);
            // 
            // grpBox_Type
            // 
            this.grpBox_Type.Controls.Add(this.radion_Boolean);
            this.grpBox_Type.Controls.Add(this.radio_Number);
            this.grpBox_Type.Controls.Add(this.radio_String);
            this.grpBox_Type.Location = new System.Drawing.Point(794, 186);
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
            this.radio_Number.CheckedChanged += new System.EventHandler(this.radio_Number_CheckedChanged);
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
            this.radio_String.CheckedChanged += new System.EventHandler(this.radio_String_CheckedChanged);
            // 
            // btn_SaveProperty
            // 
            this.btn_SaveProperty.Location = new System.Drawing.Point(781, 250);
            this.btn_SaveProperty.Name = "btn_SaveProperty";
            this.btn_SaveProperty.Size = new System.Drawing.Size(95, 23);
            this.btn_SaveProperty.TabIndex = 18;
            this.btn_SaveProperty.Text = "Save Property";
            this.btn_SaveProperty.UseVisualStyleBackColor = true;
            this.btn_SaveProperty.Click += new System.EventHandler(this.btn_SaveProperty_Click);
            // 
            // btn_CloneObject
            // 
            this.btn_CloneObject.Location = new System.Drawing.Point(159, 168);
            this.btn_CloneObject.Name = "btn_CloneObject";
            this.btn_CloneObject.Size = new System.Drawing.Size(117, 23);
            this.btn_CloneObject.TabIndex = 19;
            this.btn_CloneObject.Text = "Clone Game Object";
            this.btn_CloneObject.UseVisualStyleBackColor = true;
            this.btn_CloneObject.Click += new System.EventHandler(this.btn_CloneObject_Click);
            // 
            // btn_SaveObject
            // 
            this.btn_SaveObject.Location = new System.Drawing.Point(39, 168);
            this.btn_SaveObject.Name = "btn_SaveObject";
            this.btn_SaveObject.Size = new System.Drawing.Size(114, 23);
            this.btn_SaveObject.TabIndex = 20;
            this.btn_SaveObject.Text = "Save Game Object";
            this.btn_SaveObject.UseVisualStyleBackColor = true;
            this.btn_SaveObject.Click += new System.EventHandler(this.btn_SaveObject_Click);
            // 
            // txtBox_GameObjectName
            // 
            this.txtBox_GameObjectName.Location = new System.Drawing.Point(40, 126);
            this.txtBox_GameObjectName.Name = "txtBox_GameObjectName";
            this.txtBox_GameObjectName.Size = new System.Drawing.Size(224, 20);
            this.txtBox_GameObjectName.TabIndex = 21;
            // 
            // lbl_SelectedGameObject
            // 
            this.lbl_SelectedGameObject.AutoSize = true;
            this.lbl_SelectedGameObject.Location = new System.Drawing.Point(91, 110);
            this.lbl_SelectedGameObject.Name = "lbl_SelectedGameObject";
            this.lbl_SelectedGameObject.Size = new System.Drawing.Size(114, 13);
            this.lbl_SelectedGameObject.TabIndex = 22;
            this.lbl_SelectedGameObject.Text = "Selected Game Object";
            // 
            // txtBox_PropertyName
            // 
            this.txtBox_PropertyName.Location = new System.Drawing.Point(769, 111);
            this.txtBox_PropertyName.Name = "txtBox_PropertyName";
            this.txtBox_PropertyName.Size = new System.Drawing.Size(244, 20);
            this.txtBox_PropertyName.TabIndex = 24;
            // 
            // lbl_PropertyName
            // 
            this.lbl_PropertyName.AutoSize = true;
            this.lbl_PropertyName.Location = new System.Drawing.Point(848, 95);
            this.lbl_PropertyName.Name = "lbl_PropertyName";
            this.lbl_PropertyName.Size = new System.Drawing.Size(77, 13);
            this.lbl_PropertyName.TabIndex = 25;
            this.lbl_PropertyName.Text = "Property Name";
            // 
            // btn_CloneProperty
            // 
            this.btn_CloneProperty.Location = new System.Drawing.Point(897, 250);
            this.btn_CloneProperty.Name = "btn_CloneProperty";
            this.btn_CloneProperty.Size = new System.Drawing.Size(104, 23);
            this.btn_CloneProperty.TabIndex = 26;
            this.btn_CloneProperty.Text = "Clone Property";
            this.btn_CloneProperty.UseVisualStyleBackColor = true;
            this.btn_CloneProperty.Click += new System.EventHandler(this.btn_CloneProperty_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.templateManagerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1062, 24);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.loadObsToolStripMenuItem,
            this.saveObsToolStripMenuItem,
            this.saveAsObsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // loadObsToolStripMenuItem
            // 
            this.loadObsToolStripMenuItem.Name = "loadObsToolStripMenuItem";
            this.loadObsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadObsToolStripMenuItem.Text = "Load";
            this.loadObsToolStripMenuItem.Click += new System.EventHandler(this.loadObsToolStripMenuItem_Click);
            // 
            // saveObsToolStripMenuItem
            // 
            this.saveObsToolStripMenuItem.Name = "saveObsToolStripMenuItem";
            this.saveObsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveObsToolStripMenuItem.Text = "Save";
            this.saveObsToolStripMenuItem.Click += new System.EventHandler(this.saveObsToolStripMenuItem_Click);
            // 
            // saveAsObsToolStripMenuItem
            // 
            this.saveAsObsToolStripMenuItem.Name = "saveAsObsToolStripMenuItem";
            this.saveAsObsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAsObsToolStripMenuItem.Text = "Save As";
            this.saveAsObsToolStripMenuItem.Click += new System.EventHandler(this.saveAsObsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // templateManagerToolStripMenuItem
            // 
            this.templateManagerToolStripMenuItem.Name = "templateManagerToolStripMenuItem";
            this.templateManagerToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.templateManagerToolStripMenuItem.Text = "Template Manager";
            this.templateManagerToolStripMenuItem.Click += new System.EventHandler(this.templateManagerToolStripMenuItem_Click);
            // 
            // btn_NewFromTemplate
            // 
            this.btn_NewFromTemplate.Location = new System.Drawing.Point(158, 59);
            this.btn_NewFromTemplate.Name = "btn_NewFromTemplate";
            this.btn_NewFromTemplate.Size = new System.Drawing.Size(123, 23);
            this.btn_NewFromTemplate.TabIndex = 28;
            this.btn_NewFromTemplate.Text = "New From Template";
            this.btn_NewFromTemplate.UseVisualStyleBackColor = true;
            this.btn_NewFromTemplate.Click += new System.EventHandler(this.btn_NewFromTemplate_Click);
            // 
            // btn_CreateTemplateFromGameObject
            // 
            this.btn_CreateTemplateFromGameObject.Location = new System.Drawing.Point(63, 280);
            this.btn_CreateTemplateFromGameObject.Name = "btn_CreateTemplateFromGameObject";
            this.btn_CreateTemplateFromGameObject.Size = new System.Drawing.Size(187, 23);
            this.btn_CreateTemplateFromGameObject.TabIndex = 29;
            this.btn_CreateTemplateFromGameObject.Text = "Create Template from Object";
            this.btn_CreateTemplateFromGameObject.UseVisualStyleBackColor = true;
            this.btn_CreateTemplateFromGameObject.Click += new System.EventHandler(this.btn_CreateTemplateFromGameObject_Click);
            // 
            // GameObjecteEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 393);
            this.Controls.Add(this.btn_CreateTemplateFromGameObject);
            this.Controls.Add(this.btn_NewFromTemplate);
            this.Controls.Add(this.btn_CloneProperty);
            this.Controls.Add(this.lbl_PropertyName);
            this.Controls.Add(this.txtBox_PropertyName);
            this.Controls.Add(this.lbl_SelectedGameObject);
            this.Controls.Add(this.txtBox_GameObjectName);
            this.Controls.Add(this.btn_SaveObject);
            this.Controls.Add(this.btn_CloneObject);
            this.Controls.Add(this.btn_SaveProperty);
            this.Controls.Add(this.grpBox_Type);
            this.Controls.Add(this.btn_DeleteProperty);
            this.Controls.Add(this.btn_NewProperty);
            this.Controls.Add(this.lbl_PropertyValue);
            this.Controls.Add(this.txtBox_PropertyValue);
            this.Controls.Add(this.btn_DeleteGameObject);
            this.Controls.Add(this.btn_NewGameObject);
            this.Controls.Add(this.lbl_Properties);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_Properties);
            this.Controls.Add(this.listBox_GameObjects);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1078, 431);
            this.MinimumSize = new System.Drawing.Size(1078, 431);
            this.Name = "GameObjecteEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Object Editor";
            this.Load += new System.EventHandler(this.GameObjecteEditor_Load);
            this.grpBox_Type.ResumeLayout(false);
            this.grpBox_Type.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_GameObjects;
        private System.Windows.Forms.ListBox listBox_Properties;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Properties;
        private System.Windows.Forms.Button btn_NewGameObject;
        private System.Windows.Forms.Button btn_DeleteGameObject;
        private System.Windows.Forms.TextBox txtBox_PropertyValue;
        private System.Windows.Forms.Label lbl_PropertyValue;
        private System.Windows.Forms.Button btn_NewProperty;
        private System.Windows.Forms.Button btn_DeleteProperty;
        private System.Windows.Forms.GroupBox grpBox_Type;
        private System.Windows.Forms.RadioButton radion_Boolean;
        private System.Windows.Forms.RadioButton radio_Number;
        private System.Windows.Forms.RadioButton radio_String;
        private System.Windows.Forms.Button btn_SaveProperty;
        private System.Windows.Forms.Button btn_CloneObject;
        private System.Windows.Forms.Button btn_SaveObject;
        private System.Windows.Forms.TextBox txtBox_GameObjectName;
        private System.Windows.Forms.Label lbl_SelectedGameObject;
        private System.Windows.Forms.TextBox txtBox_PropertyName;
        private System.Windows.Forms.Label lbl_PropertyName;
        private System.Windows.Forms.Button btn_CloneProperty;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadObsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveObsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem templateManagerToolStripMenuItem;
        private System.Windows.Forms.Button btn_NewFromTemplate;
        private System.Windows.Forms.Button btn_CreateTemplateFromGameObject;
        private System.Windows.Forms.ToolStripMenuItem saveAsObsToolStripMenuItem;
    }
}

