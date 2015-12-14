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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.grpBox_Property = new System.Windows.Forms.GroupBox();
            this.grpBox_Type = new System.Windows.Forms.GroupBox();
            this.rdo_String = new System.Windows.Forms.RadioButton();
            this.rdo_Number = new System.Windows.Forms.RadioButton();
            this.rdo_Boolean = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_SaveTemplate = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            // 
            // listBox_Properties
            // 
            this.listBox_Properties.FormattingEnabled = true;
            this.listBox_Properties.Location = new System.Drawing.Point(474, 65);
            this.listBox_Properties.Name = "listBox_Properties";
            this.listBox_Properties.Size = new System.Drawing.Size(169, 355);
            this.listBox_Properties.TabIndex = 1;
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
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(5, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(272, 20);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(5, 69);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(272, 20);
            this.textBox2.TabIndex = 9;
            // 
            // grpBox_Property
            // 
            this.grpBox_Property.Controls.Add(this.grpBox_Type);
            this.grpBox_Property.Controls.Add(this.textBox1);
            this.grpBox_Property.Controls.Add(this.textBox2);
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
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(654, 219);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(89, 23);
            this.btn_Save.TabIndex = 12;
            this.btn_Save.Text = "Save Property";
            this.btn_Save.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(842, 219);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Clone Property";
            this.button2.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpBox_Property);
            this.Controls.Add(this.btn_NewTemplate);
            this.Controls.Add(this.listBox_Properties);
            this.Controls.Add(this.listBox_Templates);
            this.Controls.Add(this.menuStrip_Main);
            this.MainMenuStrip = this.menuStrip_Main;
            this.Name = "GameObjectTemplateManager";
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox grpBox_Property;
        private System.Windows.Forms.GroupBox grpBox_Type;
        private System.Windows.Forms.RadioButton rdo_Boolean;
        private System.Windows.Forms.RadioButton rdo_Number;
        private System.Windows.Forms.RadioButton rdo_String;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_SaveTemplate;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_DeleteProperty;
        private System.Windows.Forms.Button btn_NewProperty;
        private System.Windows.Forms.Label lbl_Templates;
        private System.Windows.Forms.Label lbl_Properties;
    }
}