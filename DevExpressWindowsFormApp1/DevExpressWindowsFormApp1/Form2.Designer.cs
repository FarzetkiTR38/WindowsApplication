namespace DevExpressWindowsFormApp1
{
    partial class Form2
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
            this.EpostaLabel = new DevExpress.XtraEditors.LabelControl();
            this.EpostaTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.PasswordLabel = new DevExpress.XtraEditors.LabelControl();
            this.PasswordTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.EpostaTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // EpostaLabel
            // 
            this.EpostaLabel.Location = new System.Drawing.Point(294, 126);
            this.EpostaLabel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EpostaLabel.Name = "EpostaLabel";
            this.EpostaLabel.Size = new System.Drawing.Size(48, 16);
            this.EpostaLabel.TabIndex = 15;
            this.EpostaLabel.Text = "E-posta:";
            // 
            // EpostaTextEdit
            // 
            this.EpostaTextEdit.Location = new System.Drawing.Point(294, 153);
            this.EpostaTextEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EpostaTextEdit.Name = "EpostaTextEdit";
            this.EpostaTextEdit.Size = new System.Drawing.Size(244, 22);
            this.EpostaTextEdit.TabIndex = 11;
            this.EpostaTextEdit.EditValueChanged += new System.EventHandler(this.EpostaTextEdit_EditValueChanged);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Location = new System.Drawing.Point(294, 192);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(79, 16);
            this.PasswordLabel.TabIndex = 13;
            this.PasswordLabel.Text = "Şifreyi giriniz:";
            // 
            // PasswordTextEdit
            // 
            this.PasswordTextEdit.Location = new System.Drawing.Point(294, 220);
            this.PasswordTextEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PasswordTextEdit.Name = "PasswordTextEdit";
            this.PasswordTextEdit.Size = new System.Drawing.Size(244, 22);
            this.PasswordTextEdit.TabIndex = 12;
            this.PasswordTextEdit.EditValueChanged += new System.EventHandler(this.PasswordTextEdit_EditValueChanged);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(354, 295);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(118, 36);
            this.simpleButton1.TabIndex = 16;
            this.simpleButton1.Text = "ONAYLA";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 477);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.EpostaLabel);
            this.Controls.Add(this.EpostaTextEdit);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.PasswordTextEdit);
            this.Name = "Form2";
            this.Text = "G";
            ((System.ComponentModel.ISupportInitialize)(this.EpostaTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl EpostaLabel;
        private DevExpress.XtraEditors.TextEdit EpostaTextEdit;
        private DevExpress.XtraEditors.LabelControl PasswordLabel;
        private DevExpress.XtraEditors.TextEdit PasswordTextEdit;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}