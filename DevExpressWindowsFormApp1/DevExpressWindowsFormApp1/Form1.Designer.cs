namespace DevExpressWindowsFormApp1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PasswordTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.PasswordAgainTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.PasswordLabel = new DevExpress.XtraEditors.LabelControl();
            this.PasswordAgainLabel = new DevExpress.XtraEditors.LabelControl();
            this.EpostaTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.EpostaLabel = new DevExpress.XtraEditors.LabelControl();
            this.BirthDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.BirthDateLabel = new DevExpress.XtraEditors.LabelControl();
            this.UsernameLabel = new DevExpress.XtraEditors.LabelControl();
            this.UsernameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PasswordTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordAgainTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpostaTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BirthDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BirthDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsernameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // PasswordTextEdit
            // 
            this.PasswordTextEdit.Location = new System.Drawing.Point(215, 171);
            this.PasswordTextEdit.Name = "PasswordTextEdit";
            this.PasswordTextEdit.Size = new System.Drawing.Size(195, 22);
            this.PasswordTextEdit.TabIndex = 2;
            this.PasswordTextEdit.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            // 
            // PasswordAgainTextEdit
            // 
            this.PasswordAgainTextEdit.Location = new System.Drawing.Point(215, 222);
            this.PasswordAgainTextEdit.Name = "PasswordAgainTextEdit";
            this.PasswordAgainTextEdit.Size = new System.Drawing.Size(195, 22);
            this.PasswordAgainTextEdit.TabIndex = 3;
            this.PasswordAgainTextEdit.EditValueChanged += new System.EventHandler(this.textEdit2_EditValueChanged);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(268, 317);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(94, 29);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "ONAYLA";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Location = new System.Drawing.Point(215, 149);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(79, 16);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Text = "Şifreyi giriniz:";
            this.PasswordLabel.Click += new System.EventHandler(this.labelControl1_Click_1);
            // 
            // PasswordAgainLabel
            // 
            this.PasswordAgainLabel.Location = new System.Drawing.Point(215, 200);
            this.PasswordAgainLabel.Name = "PasswordAgainLabel";
            this.PasswordAgainLabel.Size = new System.Drawing.Size(127, 16);
            this.PasswordAgainLabel.TabIndex = 4;
            this.PasswordAgainLabel.Text = "Şifreyi giriniz (tekrar):";
            // 
            // EpostaTextEdit
            // 
            this.EpostaTextEdit.Location = new System.Drawing.Point(215, 118);
            this.EpostaTextEdit.Name = "EpostaTextEdit";
            this.EpostaTextEdit.Size = new System.Drawing.Size(195, 22);
            this.EpostaTextEdit.TabIndex = 1;
            this.EpostaTextEdit.EditValueChanged += new System.EventHandler(this.EpostaTextEdit_EditValueChanged);
            // 
            // EpostaLabel
            // 
            this.EpostaLabel.Location = new System.Drawing.Point(215, 96);
            this.EpostaLabel.Name = "EpostaLabel";
            this.EpostaLabel.Size = new System.Drawing.Size(48, 16);
            this.EpostaLabel.TabIndex = 6;
            this.EpostaLabel.Text = "E-posta:";
            this.EpostaLabel.Click += new System.EventHandler(this.labelControl3_Click);
            // 
            // BirthDateEdit
            // 
            this.BirthDateEdit.EditValue = null;
            this.BirthDateEdit.Location = new System.Drawing.Point(215, 273);
            this.BirthDateEdit.Name = "BirthDateEdit";
            this.BirthDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.BirthDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.BirthDateEdit.Size = new System.Drawing.Size(195, 22);
            this.BirthDateEdit.TabIndex = 4;
            // 
            // BirthDateLabel
            // 
            this.BirthDateLabel.Location = new System.Drawing.Point(215, 251);
            this.BirthDateLabel.Name = "BirthDateLabel";
            this.BirthDateLabel.Size = new System.Drawing.Size(82, 16);
            this.BirthDateLabel.TabIndex = 8;
            this.BirthDateLabel.Text = "Doğum Tarihi:";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.Location = new System.Drawing.Point(215, 46);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(73, 16);
            this.UsernameLabel.TabIndex = 9;
            this.UsernameLabel.Text = "Kullanıcı Adı:";
            this.UsernameLabel.Click += new System.EventHandler(this.labelControl5_Click);
            // 
            // UsernameTextEdit
            // 
            this.UsernameTextEdit.Location = new System.Drawing.Point(215, 68);
            this.UsernameTextEdit.Name = "UsernameTextEdit";
            this.UsernameTextEdit.Size = new System.Drawing.Size(195, 22);
            this.UsernameTextEdit.TabIndex = 0;
            this.UsernameTextEdit.EditValueChanged += new System.EventHandler(this.UsernameTextEdit_EditValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.UsernameTextEdit);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.BirthDateLabel);
            this.Controls.Add(this.BirthDateEdit);
            this.Controls.Add(this.EpostaLabel);
            this.Controls.Add(this.EpostaTextEdit);
            this.Controls.Add(this.PasswordAgainLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.PasswordAgainTextEdit);
            this.Controls.Add(this.PasswordTextEdit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PasswordTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordAgainTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpostaTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BirthDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BirthDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsernameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit PasswordTextEdit;
        private DevExpress.XtraEditors.TextEdit PasswordAgainTextEdit;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl PasswordLabel;
        private DevExpress.XtraEditors.LabelControl PasswordAgainLabel;
        private DevExpress.XtraEditors.TextEdit EpostaTextEdit;
        private DevExpress.XtraEditors.LabelControl EpostaLabel;
        private DevExpress.XtraEditors.DateEdit BirthDateEdit;
        private DevExpress.XtraEditors.LabelControl BirthDateLabel;
        private DevExpress.XtraEditors.LabelControl UsernameLabel;
        private DevExpress.XtraEditors.TextEdit UsernameTextEdit;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
    }
}

