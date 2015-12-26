namespace GameObjectEditor
{
    partial class GameObjectTemplateManager
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
            this.listBox_Templates = new System.Windows.Forms.ListBox();
            this.listBox_Properties = new System.Windows.Forms.ListBox();
            this.txtBox_TemplateName = new System.Windows.Forms.TextBox();
            this.btn_NewTemplate = new System.Windows.Forms.Button();
            this.btn_CloneTemplate = new System.Windows.Forms.Button();
            this.menuStrip_Main = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_DefaultValue = new System.Windows.Forms.Label();
            this.txtBox_PropertyName = new System.Windows.Forms.TextBox();
            this.txtBox_PropertyValue = new System.Windows.Forms.TextBox();
            this.grpBox_Property = new System.Windows.Forms.GroupBox();
            this.grpBox_Type = new System.Windows.Forms.GroupBox();
            this.rdo_Boolean = new System.Windows.Forms.RadioButton();
            this.rdo_Number = new System.Windows.Forms.RadioButton();
            this.rdo_String = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_SaveTemplate = new System.Windows.Forms.Button();
            this.btn_SaveProperty = new System.Windows.Forms.Button();
            this.btn_CloneProperty = new System.Windows.Forms.Button();
            this.btn_DeleteProperty = new System.Windows.Forms.Button();
            this.btn_NewProperty = new System.Windows.Forms.Button();
            this.lbl_Templates = new System.Windows.Forms.Label();
            this.lbl_Properties = new System.Windows.Forms.Label();
            this.menuStrip_Main.SuspendLayout();
            this.grpBox_Property.SuspendLayout();
            this.grpBox_Type.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_Templates
            // 
            this.listBox_Templates.FormattingEnabled = true;
            this.listBox_Templates.Location = new System.Drawing.Point(271, 65);
            this.listBox_Templates.Name = "listBox_Templates";
            this.listBox_Templates.Size = new System.Drawing.Size(169, 355);
            this.listBox_Templates.TabIndex = 0;
            this.listBox_Templates.SelectedIndexChanged += new System.EventHandler(this.listBox_Templates_SelectedIndexChanged);
            // 
            // listBox_Properties
            // 
            this.listBox_Properties.FormattingEnabled = true;
            this.listBox_Properties.Location = new System.Drawing.Point(474, 65);
            this.listBox_Properties.Name = "listBox_Properties";
            this.listBox_Properties.Size = new System.Drawing.Size(169, 355);
            this.listBox_Properties.TabIndex = 1;
            this.listBox_Properties.SelectedIndexChanged += new System.EventHandler(this.listBox_Properties_SelectedIndexChanged);
            // 
            // txtBox_TemplateName
            // 
            this.txtBox_TemplateName.Location = new System.Drawing.Point(6, 29);
            this.txtBox_TemplateName.Name = "txtBox_TemplateName";
            this.txtBox_TemplateName.Size = new System.Drawing.Size(232, 20);
            this.txtBox_TemplateName.TabIndex = 2;
            // 
            // btn_NewTemplate
            // 
            this.btn_NewTemplate.Location = new System.Drawing.Point(84, 177);
            this.btn_NewTemplate.Name = "btn_NewTemplate";
            this.btn_NewTemplate.Size = new System.Drawing.Size(96, 23);
            this.btn_NewTemplate.TabIndex = 4;
            this.btn_NewTemplate.Text = "New Template";
            this.btn_NewTemplate.UseVisualStyleBackColor = true;
            this.btn_NewTemplate.Click += new System.EventHandler(this.btn_NewTemplate_Click);
            // 
            // btn_CloneTemplate
            // 
            this.btn_CloneTemplate.Location = new System.Drawing.Point(120, 66);
            this.btn_CloneTemplate.Name = "btn_CloneTemplate";
            this.btn_CloneTemplate.Size = new System.Drawing.Size(93, 23);
            this.btn_CloneTemplate.TabIndex = 5;
            this.btn_CloneTemplate.Text = "Clone Template";
            this.btn_CloneTemplate.UseVisualStyleBackColor = true;
            // 
            // menuStrip_Main
            // 
            this.menuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Main.Name = "menuStrip_Main";
            this.menuStrip_Main.Size = new System.Drawing.Size(943, 24);
            this.menuStrip_Main.TabIndex = 6;
            this.menuStrip_Main.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // lbl_DefaultValue
            // 
            this.lbl_DefaultValue.AutoSize = true;
            this.lbl_DefaultValue.Location = new System.Drawing.Point(101, 47);
            this.lbl_DefaultValue.Name = "lbl_DefaultValue";
            this.lbl_DefaultValue.Size = new System.Drawing.Size(71, 13);
            this.lbl_DefaultValue.TabIndex = 7;
            this.lbl_DefaultValue.Text = "Default Value";
            // 
            // txtBox_PropertyName
            // 
            this.txtBox_PropertyName.Location = new System.Drawing.Point(5, 19);
            this.txtBox_PropertyName.Name = "txtBox_PropertyName";
            this.txtBox_PropertyName.Size = new System.Drawing.Size(272, 20);
            this.txtBox_PropertyName.TabIndex = 8;
            // 
            // txtBox_PropertyValue
            // 
            this.txtBox_PropertyValue.Location = new System.Drawing.Point(5, 69);
            this.txtBox_PropertyValue.Name = "txtBox_PropertyValue";
            this.txtBox_PropertyValue.Size = new System.Drawing.Size(272, 20);
            this.txtBox_PropertyValue.TabIndex = 9;
            // 
            // grpBox_Property
            // 
            this.grpBox_Property.Controls.Add(this.grpBox_Type);
            this.grpBox_Property.Controls.Add(this.txtBox_PropertyName);
            this.grpBox_Property.Controls.Add(this.txtBox_PropertyValue);
            this.grpBox_Property.Controls.Add(this.lbl_DefaultValue);
            this.grpBox_Property.Location = new System.Drawing.Point(649, 57);
            this.grpBox_Property.Name = "grpBox_Property";
            this.grpBox_Property.Size = new System.Drawing.Size(283, 156);
            this.grpBox_Property.TabIndex = 10;
            this.grpBox_Property.TabStop = false;
            this.grpBox_Property.Text = "Property";
            // 
            // grpBox_Type
            // 
            this.grpBox_Type.Controls.Add(this.rdo_Boolean);
            this.grpBox_Type.Controls.Add(this.rdo_Number);
            this.grpBox_Type.Controls.Add(this.rdo_String);
            this.grpBox_Type.Location = new System.Drawing.Point(5, 101);
            this.grpBox_Type.Name = "grpBox_Type";
            this.grpBox_Type.Size = new System.Drawing.Size(272, 49);
            this.grpBox_Type.TabIndex = 10;
            this.grpBox_Type.TabStop = false;
            this.grpBox_Type.Text = "Type";
            // 
            // rdo_Boolean
            // 
            this.rdo_Boolean.AutoSize = true;
            this.rdo_Boolean.Location = new System.Drawing.Point(192, 19);
            this.rdo_Boolean.Name = "rdo_Boolean";
            this.rdo_Boolean.Size = new System.Drawing.Size(64, 17);
            this.rdo_Boolean.TabIndex = 2;
            this.rdo_Boolean.TabStop = true;
            this.rdo_Boolean.Text = "Boolean";
            this.rdo_Boolean.UseVisualStyleBackColor = true;
            this.rdo_Boolean.CheckedChanged += new System.EventHandler(this.rdo_Boolean_CheckedChanged);
            // 
            // rdo_Number
            // 
            this.rdo_Number.AutoSize = true;
            this.rdo_Number.Location = new System.Drawing.Point(101, 19);
            this.rdo_Number.Name = "rdo_Number";
            this.rdo_Number.Size = new System.Drawing.Size(62, 17);
            this.rdo_Number.TabIndex = 1;
            this.rdo_Number.TabStop = true;
            this.rdo_Number.Text = "Number";
            this.rdo_Number.UseVisualStyleBackColor = true;
            this.rdo_Number.CheckedChanged += new System.EventHandler(this.rdo_Number_CheckedChanged);
            // 
            // rdo_String
            // 
            this.rdo_String.AutoSize = true;
            this.rdo_String.Location = new System.Drawing.Point(15, 19);
            this.rdo_String.Name = "rdo_String";
            this.rdo_String.Size = new System.Drawing.Size(52, 17);
            this.rdo_String.TabIndex = 0;
            this.rdo_String.TabStop = true;
            this.rdo_String.Text = "String";
            this.rdo_String.UseVisualStyleBackColor = true;
            this.rdo_String.CheckedChanged += new System.EventHandler(this.rdo_String_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_SaveTemplate);
            this.groupBox1.Controls.Add(this.txtBox_TemplateName);
            this.groupBox1.Controls.Add(this.btn_CloneTemplate);
            this.groupBox1.Location = new System.Drawing.Point(12, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Template";
            // 
            // btn_SaveTemplate
            // 
            this.btn_SaveTemplate.Location = new System.Drawing.Point(26, 66);
            this.btn_SaveTemplate.Name = "btn_SaveTemplate";
            this.btn_SaveTemplate.Size = new System.Drawing.Size(88, 23);
            this.btn_SaveTemplate.TabIndex = 6;
            this.btn_SaveTemplate.Text = "Save Template";
            this.btn_SaveTemplate.UseVisualStyleBackColor = true;
            this.btn_SaveTemplate.Click += new System.EventHandler(this.btn_SaveTemplate_Click);
            // 
            // btn_SaveProperty
            // 
            this.btn_SaveProperty.Location = new System.Drawing.Point(654, 219);
            this.btn_SaveProperty.Name = "btn_SaveProperty";
            this.btn_SaveProperty.Size = new System.Drawing.Size(89, 23);
            this.btn_SaveProperty.TabIndex = 12;
            this.btn_SaveProperty.Text = "Save Property";
            this.btn_SaveProperty.UseVisualStyleBackColor = true;
            this.btn_SaveProperty.Click += new System.EventHandler(this.btn_SaveProperty_Click);
            // 
            // btn_CloneProperty
            // 
            this.btn_CloneProperty.Location = new System.Drawing.Point(842, 219);
            this.btn_CloneProperty.Name = "btn_CloneProperty";
            this.btn_CloneProperty.Size = new System.Drawing.Size(89, 23);
            this.btn_CloneProperty.TabIndex = 13;
            this.btn_CloneProperty.Text = "Clone Property";
            this.btn_CloneProperty.UseVisualStyleBackColor = true;
            // 
            // btn_DeleteProperty
            // 
            this.btn_DeleteProperty.Location = new System.Drawing.Point(749, 219);
            this.btn_DeleteProperty.Name = "btn_DeleteProperty";
            this.btn_DeleteProperty.Size = new System.Drawing.Size(88, 23);
            this.btn_DeleteProperty.TabIndex = 14;
            this.btn_DeleteProperty.Text = "Delete Property";
            this.btn_DeleteProperty.UseVisualStyleBackColor = true;
            // 
            // btn_NewProperty
            // 
            this.btn_NewProperty.Location = new System.Drawing.Point(744, 278);
            this.btn_NewProperty.Name = "btn_NewProperty";
            this.btn_NewProperty.Size = new System.Drawing.Size(97, 23);
            this.btn_NewProperty.TabIndex = 15;
            this.btn_NewProperty.Text = "New Property";
            this.btn_NewProperty.UseVisualStyleBackColor = true;
            this.btn_NewProperty.Click += new System.EventHandler(this.btn_NewProperty_Click);
            // 
            // lbl_Templates
            // 
            this.lbl_Templates.AutoSize = true;
            this.lbl_Templates.Location = new System.Drawing.Point(297, 38);
            this.lbl_Templates.Name = "lbl_Templates";
            this.lbl_Templates.Size = new System.Drawing.Size(121, 13);
            this.lbl_Templates.TabIndex = 16;
            this.lbl_Templates.Text = "Game Object Templates";
            // 
            // lbl_Properties
            // 
            this.lbl_Properties.AutoSize = true;
            this.lbl_Properties.Location = new System.Drawing.Point(532, 38);
            this.lbl_Properties.Name = "lbl_Properties";
            this.lbl_Properties.Size = new System.Drawing.Size(54, 13);
            this.lbl_Properties.TabIndex = 17;
            this.lbl_Properties.Text = "Properties";
            // 
            // GameObjectTemplateManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 436);
            this.Controls.Add(this.lbl_Properties);
            this.Controls.Add(this.lbl_Templates);
            this.Controls.Add(this.btn_NewProperty);
            this.Controls.Add(this.btn_DeleteProperty);
            this.Controls.Add(this.btn_CloneProperty);
            this.Controls.Add(this.btn_SaveProperty);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpBox_Property);
            this.Controls.Add(this.btn_NewTemplate);
            this.Controls.Add(this.listBox_Properties);
            this.Controls.Add(this.listBox_Templates);
            this.Controls.Add(this.menuStrip_Main);
            this.MainMenuStrip = this.menuStrip_Main;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(959, 474);
            this.MinimumSize = new System.Drawing.Size(959, 474);
            this.Name = "GameObjectTemplateManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Object Template Manager";
            this.Load += new System.EventHandler(this.GameObjectTemplateManager_Load);
            this.menuStrip_Main.ResumeLayout(false);
            this.menuStrip_Main.PerformLayout();
            this.grpBox_Property.ResumeLayout(false);
            this.grpBox_Property.PerformLayout();
            this.grpBox_Type.ResumeLayout(false);
            this.grpBox_Type.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Templates;
        private System.Windows.Forms.ListBox listBox_Properties;
        private System.Windows.Forms.TextBox txtBox_TemplateName;
        private System.Windows.Forms.Button btn_NewTemplate;
        private System.Windows.Forms.Button btn_CloneTemplate;
        private System.Windows.Forms.MenuStrip menuStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lbl_DefaultValue;
        private System.Windows.Forms.TextBox txtBox_PropertyName;
        private System.Windows.Forms.TextBox txtBox_PropertyValue;
        private System.Windows.Forms.GroupBox grpBox_Property;
        private System.Windows.Forms.GroupBox grpBox_Type;
        private System.Windows.Forms.RadioButton rdo_Boolean;
        private System.Windows.Forms.RadioButton rdo_Number;
        private System.Windows.Forms.RadioButton rdo_String;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_SaveTemplate;
        private System.Windows.Forms.Button btn_SaveProperty;
        private System.Windows.Forms.Button btn_CloneProperty;
        private System.Windows.Forms.Button btn_DeleteProperty;
        private System.Windows.Forms.Button btn_NewProperty;
        private System.Windows.Forms.Label lbl_Templates;
        private System.Windows.Forms.Label lbl_Properties;
    }
}