namespace FileEncrypter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnPath = new System.Windows.Forms.Button();
            this.btnDecrypth = new System.Windows.Forms.Button();
            this.btnEncrypth = new System.Windows.Forms.Button();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbEncryptionKey = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(12, 12);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(115, 32);
            this.btnPath.TabIndex = 0;
            this.btnPath.Text = "Select File Path";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // btnDecrypth
            // 
            this.btnDecrypth.Location = new System.Drawing.Point(12, 138);
            this.btnDecrypth.Name = "btnDecrypth";
            this.btnDecrypth.Size = new System.Drawing.Size(115, 54);
            this.btnDecrypth.TabIndex = 1;
            this.btnDecrypth.Text = "DECRYPTH";
            this.btnDecrypth.UseVisualStyleBackColor = true;
            this.btnDecrypth.Click += new System.EventHandler(this.btnDecrypth_Click);
            // 
            // btnEncrypth
            // 
            this.btnEncrypth.Location = new System.Drawing.Point(12, 198);
            this.btnEncrypth.Name = "btnEncrypth";
            this.btnEncrypth.Size = new System.Drawing.Size(115, 54);
            this.btnEncrypth.TabIndex = 2;
            this.btnEncrypth.Text = "ENCRYPTH";
            this.btnEncrypth.UseVisualStyleBackColor = true;
            this.btnEncrypth.Click += new System.EventHandler(this.btnEncrypth_Click);
            // 
            // tbStatus
            // 
            this.tbStatus.Location = new System.Drawing.Point(142, 12);
            this.tbStatus.Multiline = true;
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.ReadOnly = true;
            this.tbStatus.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbStatus.Size = new System.Drawing.Size(369, 240);
            this.tbStatus.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Encryption Key";
            // 
            // tbEncryptionKey
            // 
            this.tbEncryptionKey.Location = new System.Drawing.Point(12, 87);
            this.tbEncryptionKey.MaxLength = 8;
            this.tbEncryptionKey.Name = "tbEncryptionKey";
            this.tbEncryptionKey.Size = new System.Drawing.Size(115, 23);
            this.tbEncryptionKey.TabIndex = 5;
            this.tbEncryptionKey.Text = "xxxxxxxx";
            this.tbEncryptionKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbEncryptionKey.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbEncryptionKey_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 262);
            this.Controls.Add(this.tbEncryptionKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbStatus);
            this.Controls.Add(this.btnEncrypth);
            this.Controls.Add(this.btnDecrypth);
            this.Controls.Add(this.btnPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encryption Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.Button btnDecrypth;
        private System.Windows.Forms.Button btnEncrypth;
        private System.Windows.Forms.TextBox tbStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbEncryptionKey;
    }
}
