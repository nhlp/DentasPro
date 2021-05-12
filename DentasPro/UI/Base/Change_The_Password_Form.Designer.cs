namespace Dentas_Pro.UI.Base
{
    partial class Change_The_Password_Form
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
            this.Change_The_Passwod_SimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.First_Password_TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Second_Password_TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.First_Password_TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Second_Password_TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Change_The_Passwod_SimpleButton
            // 
            this.Change_The_Passwod_SimpleButton.Location = new System.Drawing.Point(63, 96);
            this.Change_The_Passwod_SimpleButton.Name = "Change_The_Passwod_SimpleButton";
            this.Change_The_Passwod_SimpleButton.Size = new System.Drawing.Size(82, 23);
            this.Change_The_Passwod_SimpleButton.TabIndex = 0;
            this.Change_The_Passwod_SimpleButton.Text = "Şifreyi Değiştir";
            this.Change_The_Passwod_SimpleButton.Click += new System.EventHandler(this.Change_The_Passwod_SimpleButton_Click);
            // 
            // First_Password_TextEdit
            // 
            this.First_Password_TextEdit.Location = new System.Drawing.Point(98, 23);
            this.First_Password_TextEdit.Name = "First_Password_TextEdit";
            this.First_Password_TextEdit.Properties.PasswordChar = '*';
            this.First_Password_TextEdit.Size = new System.Drawing.Size(76, 20);
            this.First_Password_TextEdit.TabIndex = 1;
            // 
            // Second_Password_TextEdit
            // 
            this.Second_Password_TextEdit.Location = new System.Drawing.Point(98, 58);
            this.Second_Password_TextEdit.Name = "Second_Password_TextEdit";
            this.Second_Password_TextEdit.Properties.PasswordChar = '*';
            this.Second_Password_TextEdit.Size = new System.Drawing.Size(78, 20);
            this.Second_Password_TextEdit.TabIndex = 2;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::Dentas_Pro.UI.Properties.Resources.Login_Form_Dentaş_Logo;
            this.pictureEdit1.Location = new System.Drawing.Point(181, 45);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(138, 60);
            this.pictureEdit1.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(45, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Yeni Şifre";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 62);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(87, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Yeni Şifre (Tekrar)";
            // 
            // Change_The_Password_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 145);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.Second_Password_TextEdit);
            this.Controls.Add(this.First_Password_TextEdit);
            this.Controls.Add(this.Change_The_Passwod_SimpleButton);
            this.Name = "Change_The_Password_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şifre Değiştirme Ekranı";
            ((System.ComponentModel.ISupportInitialize)(this.First_Password_TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Second_Password_TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton Change_The_Passwod_SimpleButton;
        private DevExpress.XtraEditors.TextEdit First_Password_TextEdit;
        public DevExpress.XtraEditors.TextEdit Second_Password_TextEdit;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}