namespace GameObjectEditor
{
    partial class SelectTemplateWindow
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
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cmboboxTemplates = new System.Windows.Forms.ComboBox();
            this.lbl_SelectTemplate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(79, 53);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(187, 53);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cmboboxTemplates
            // 
            this.cmboboxTemplates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboboxTemplates.FormattingEnabled = true;
            this.cmboboxTemplates.Location = new System.Drawing.Point(12, 26);
            this.cmboboxTemplates.Name = "cmboboxTemplates";
            this.cmboboxTemplates.Size = new System.Drawing.Size(319, 21);
            this.cmboboxTemplates.TabIndex = 2;
            // 
            // lbl_SelectTemplate
            // 
            this.lbl_SelectTemplate.AutoSize = true;
            this.lbl_SelectTemplate.Location = new System.Drawing.Point(128, 5);
            this.lbl_SelectTemplate.Name = "lbl_SelectTemplate";
            this.lbl_SelectTemplate.Size = new System.Drawing.Size(87, 13);
            this.lbl_SelectTemplate.TabIndex = 3;
            this.lbl_SelectTemplate.Text = "Select Template:";
            // 
            // SelectTemplateWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 88);
            this.Controls.Add(this.lbl_SelectTemplate);
            this.Controls.Add(this.cmboboxTemplates);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Name = "SelectTemplateWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Template";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cmboboxTemplates;
        private System.Windows.Forms.Label lbl_SelectTemplate;
    }
}