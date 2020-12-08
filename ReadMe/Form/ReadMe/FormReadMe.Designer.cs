namespace ReadMe {
    partial class FormReadMe {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.ButtonOpenFile = new System.Windows.Forms.Button();
            this.RichTextBoxOutput = new System.Windows.Forms.RichTextBox();
            this.RadioButtonAdmin = new System.Windows.Forms.RadioButton();
            this.RadioButtonUser = new System.Windows.Forms.RadioButton();
            this.RadioButtonGuest = new System.Windows.Forms.RadioButton();
            this.GroupBoxFileUserRole = new System.Windows.Forms.GroupBox();
            this.GroupBoxFileReadMode = new System.Windows.Forms.GroupBox();
            this.GroupBoxFileType = new System.Windows.Forms.GroupBox();
            this.RadioButtonJson = new System.Windows.Forms.RadioButton();
            this.RadioButtonXml = new System.Windows.Forms.RadioButton();
            this.RadioButtonTxt = new System.Windows.Forms.RadioButton();
            this.RadioButtonEncrypted = new System.Windows.Forms.RadioButton();
            this.RadioButtonPlainText = new System.Windows.Forms.RadioButton();
            this.GroupBoxFileUserRole.SuspendLayout();
            this.GroupBoxFileReadMode.SuspendLayout();
            this.GroupBoxFileType.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonOpenFile
            // 
            this.ButtonOpenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonOpenFile.Location = new System.Drawing.Point(19, 343);
            this.ButtonOpenFile.Name = "ButtonOpenFile";
            this.ButtonOpenFile.Size = new System.Drawing.Size(115, 37);
            this.ButtonOpenFile.TabIndex = 0;
            this.ButtonOpenFile.Text = "Open file";
            this.ButtonOpenFile.UseVisualStyleBackColor = true;
            this.ButtonOpenFile.Click += new System.EventHandler(this.ButtonOpenFile_Click);
            // 
            // RichTextBoxOutput
            // 
            this.RichTextBoxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RichTextBoxOutput.Location = new System.Drawing.Point(255, 12);
            this.RichTextBoxOutput.Name = "RichTextBoxOutput";
            this.RichTextBoxOutput.Size = new System.Drawing.Size(749, 452);
            this.RichTextBoxOutput.TabIndex = 1;
            this.RichTextBoxOutput.Text = "";
            // 
            // RadioButtonAdmin
            // 
            this.RadioButtonAdmin.AutoSize = true;
            this.RadioButtonAdmin.Checked = true;
            this.RadioButtonAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RadioButtonAdmin.Location = new System.Drawing.Point(26, 25);
            this.RadioButtonAdmin.Name = "RadioButtonAdmin";
            this.RadioButtonAdmin.Size = new System.Drawing.Size(65, 21);
            this.RadioButtonAdmin.TabIndex = 3;
            this.RadioButtonAdmin.TabStop = true;
            this.RadioButtonAdmin.Text = "Admin";
            this.RadioButtonAdmin.UseVisualStyleBackColor = true;
            // 
            // RadioButtonUser
            // 
            this.RadioButtonUser.AutoSize = true;
            this.RadioButtonUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RadioButtonUser.Location = new System.Drawing.Point(26, 52);
            this.RadioButtonUser.Name = "RadioButtonUser";
            this.RadioButtonUser.Size = new System.Drawing.Size(56, 21);
            this.RadioButtonUser.TabIndex = 4;
            this.RadioButtonUser.Text = "User";
            this.RadioButtonUser.UseVisualStyleBackColor = true;
            // 
            // RadioButtonGuest
            // 
            this.RadioButtonGuest.AutoSize = true;
            this.RadioButtonGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RadioButtonGuest.Location = new System.Drawing.Point(26, 79);
            this.RadioButtonGuest.Name = "RadioButtonGuest";
            this.RadioButtonGuest.Size = new System.Drawing.Size(64, 21);
            this.RadioButtonGuest.TabIndex = 5;
            this.RadioButtonGuest.Text = "Guest";
            this.RadioButtonGuest.UseVisualStyleBackColor = true;
            // 
            // GroupBoxFileUserRole
            // 
            this.GroupBoxFileUserRole.Controls.Add(this.RadioButtonAdmin);
            this.GroupBoxFileUserRole.Controls.Add(this.RadioButtonGuest);
            this.GroupBoxFileUserRole.Controls.Add(this.RadioButtonUser);
            this.GroupBoxFileUserRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GroupBoxFileUserRole.Location = new System.Drawing.Point(19, 220);
            this.GroupBoxFileUserRole.Name = "GroupBoxFileUserRole";
            this.GroupBoxFileUserRole.Size = new System.Drawing.Size(230, 117);
            this.GroupBoxFileUserRole.TabIndex = 8;
            this.GroupBoxFileUserRole.TabStop = false;
            this.GroupBoxFileUserRole.Text = "Select file user role";
            // 
            // GroupBoxFileReadMode
            // 
            this.GroupBoxFileReadMode.Controls.Add(this.RadioButtonEncrypted);
            this.GroupBoxFileReadMode.Controls.Add(this.RadioButtonPlainText);
            this.GroupBoxFileReadMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GroupBoxFileReadMode.Location = new System.Drawing.Point(19, 130);
            this.GroupBoxFileReadMode.Name = "GroupBoxFileReadMode";
            this.GroupBoxFileReadMode.Size = new System.Drawing.Size(230, 84);
            this.GroupBoxFileReadMode.TabIndex = 9;
            this.GroupBoxFileReadMode.TabStop = false;
            this.GroupBoxFileReadMode.Text = "Select file read mode";
            // 
            // GroupBoxFileType
            // 
            this.GroupBoxFileType.Controls.Add(this.RadioButtonJson);
            this.GroupBoxFileType.Controls.Add(this.RadioButtonXml);
            this.GroupBoxFileType.Controls.Add(this.RadioButtonTxt);
            this.GroupBoxFileType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GroupBoxFileType.Location = new System.Drawing.Point(19, 12);
            this.GroupBoxFileType.Name = "GroupBoxFileType";
            this.GroupBoxFileType.Size = new System.Drawing.Size(230, 112);
            this.GroupBoxFileType.TabIndex = 11;
            this.GroupBoxFileType.TabStop = false;
            this.GroupBoxFileType.Text = "Select file type";
            // 
            // RadioButtonJson
            // 
            this.RadioButtonJson.AutoSize = true;
            this.RadioButtonJson.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RadioButtonJson.Location = new System.Drawing.Point(22, 81);
            this.RadioButtonJson.Name = "RadioButtonJson";
            this.RadioButtonJson.Size = new System.Drawing.Size(59, 22);
            this.RadioButtonJson.TabIndex = 2;
            this.RadioButtonJson.Text = "Json";
            this.RadioButtonJson.UseVisualStyleBackColor = true;
            // 
            // RadioButtonXml
            // 
            this.RadioButtonXml.AutoSize = true;
            this.RadioButtonXml.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RadioButtonXml.Location = new System.Drawing.Point(22, 53);
            this.RadioButtonXml.Name = "RadioButtonXml";
            this.RadioButtonXml.Size = new System.Drawing.Size(52, 22);
            this.RadioButtonXml.TabIndex = 1;
            this.RadioButtonXml.Text = "Xml";
            this.RadioButtonXml.UseVisualStyleBackColor = true;
            // 
            // RadioButtonTxt
            // 
            this.RadioButtonTxt.AutoSize = true;
            this.RadioButtonTxt.Checked = true;
            this.RadioButtonTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RadioButtonTxt.Location = new System.Drawing.Point(22, 25);
            this.RadioButtonTxt.Name = "RadioButtonTxt";
            this.RadioButtonTxt.Size = new System.Drawing.Size(46, 22);
            this.RadioButtonTxt.TabIndex = 0;
            this.RadioButtonTxt.TabStop = true;
            this.RadioButtonTxt.Text = "Txt";
            this.RadioButtonTxt.UseVisualStyleBackColor = true;
            // 
            // RadioButtonEncrypted
            // 
            this.RadioButtonEncrypted.AutoSize = true;
            this.RadioButtonEncrypted.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RadioButtonEncrypted.Location = new System.Drawing.Point(19, 56);
            this.RadioButtonEncrypted.Name = "RadioButtonEncrypted";
            this.RadioButtonEncrypted.Size = new System.Drawing.Size(96, 22);
            this.RadioButtonEncrypted.TabIndex = 10;
            this.RadioButtonEncrypted.Text = "Encryption";
            this.RadioButtonEncrypted.UseVisualStyleBackColor = true;
            // 
            // RadioButtonPlainText
            // 
            this.RadioButtonPlainText.AutoSize = true;
            this.RadioButtonPlainText.Checked = true;
            this.RadioButtonPlainText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RadioButtonPlainText.Location = new System.Drawing.Point(19, 28);
            this.RadioButtonPlainText.Name = "RadioButtonPlainText";
            this.RadioButtonPlainText.Size = new System.Drawing.Size(85, 22);
            this.RadioButtonPlainText.TabIndex = 8;
            this.RadioButtonPlainText.TabStop = true;
            this.RadioButtonPlainText.Text = "Plain text";
            this.RadioButtonPlainText.UseVisualStyleBackColor = true;
            // 
            // FormReadMe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 476);
            this.Controls.Add(this.GroupBoxFileType);
            this.Controls.Add(this.GroupBoxFileReadMode);
            this.Controls.Add(this.ButtonOpenFile);
            this.Controls.Add(this.GroupBoxFileUserRole);
            this.Controls.Add(this.RichTextBoxOutput);
            this.Name = "FormReadMe";
            this.Text = "ReadMe";
            this.GroupBoxFileUserRole.ResumeLayout(false);
            this.GroupBoxFileUserRole.PerformLayout();
            this.GroupBoxFileReadMode.ResumeLayout(false);
            this.GroupBoxFileReadMode.PerformLayout();
            this.GroupBoxFileType.ResumeLayout(false);
            this.GroupBoxFileType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonOpenFile;
        private System.Windows.Forms.RichTextBox RichTextBoxOutput;
        private System.Windows.Forms.RadioButton RadioButtonAdmin;
        private System.Windows.Forms.RadioButton RadioButtonUser;
        private System.Windows.Forms.RadioButton RadioButtonGuest;
        private System.Windows.Forms.GroupBox GroupBoxFileUserRole;
        private System.Windows.Forms.GroupBox GroupBoxFileReadMode;
        private System.Windows.Forms.GroupBox GroupBoxFileType;
        private System.Windows.Forms.RadioButton RadioButtonJson;
        private System.Windows.Forms.RadioButton RadioButtonXml;
        private System.Windows.Forms.RadioButton RadioButtonTxt;
        private System.Windows.Forms.RadioButton RadioButtonEncrypted;
        private System.Windows.Forms.RadioButton RadioButtonPlainText;
    }
}

