namespace Dentas_Pro.UI.Base
{
    partial class Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            this.User_Name_TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.User_Password_TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.User_Name_LabelControl = new DevExpress.XtraEditors.LabelControl();
            this.User_Password_LabelControl = new DevExpress.XtraEditors.LabelControl();
            this.Enter_SimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.Cancel_SimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.User_Name_TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.User_Password_TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // User_Name_TextEdit
            // 
            this.User_Name_TextEdit.Location = new System.Drawing.Point(101, 37);
            this.User_Name_TextEdit.Name = "User_Name_TextEdit";
            this.User_Name_TextEdit.Size = new System.Drawing.Size(124, 20);
            this.User_Name_TextEdit.TabIndex = 0;
            this.User_Name_TextEdit.ToolTip = "Kullanıcı adınızı seçinizi. Listede kullanıcı adınız yok ise \"IK\" ile iletişime g" +
    "eçiniz.";
            this.User_Name_TextEdit.EditValueChanged += new System.EventHandler(this.User_Name_TextEdit_EditValueChanged);
            this.User_Name_TextEdit.Leave += new System.EventHandler(this.User_Name_TextEdit_Leave);
            // 
            // User_Password_TextEdit
            // 
            this.User_Password_TextEdit.Location = new System.Drawing.Point(101, 87);
            this.User_Password_TextEdit.Name = "User_Password_TextEdit";
            this.User_Password_TextEdit.Properties.PasswordChar = '*';
            this.User_Password_TextEdit.Size = new System.Drawing.Size(124, 20);
            this.User_Password_TextEdit.TabIndex = 1;
            this.User_Password_TextEdit.ToolTip = "Parolanızı yazınız.";
            // 
            // User_Name_LabelControl
            // 
            this.User_Name_LabelControl.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.User_Name_LabelControl.Location = new System.Drawing.Point(35, 39);
            this.User_Name_LabelControl.Name = "User_Name_LabelControl";
            this.User_Name_LabelControl.Size = new System.Drawing.Size(55, 13);
            this.User_Name_LabelControl.TabIndex = 3;
            this.User_Name_LabelControl.Text = "Kullanıcı Adı";
            // 
            // User_Password_LabelControl
            // 
            this.User_Password_LabelControl.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.User_Password_LabelControl.Location = new System.Drawing.Point(35, 94);
            this.User_Password_LabelControl.Name = "User_Password_LabelControl";
            this.User_Password_LabelControl.Size = new System.Drawing.Size(30, 13);
            this.User_Password_LabelControl.TabIndex = 4;
            this.User_Password_LabelControl.Text = "Parola";
            // 
            // Enter_SimpleButton
            // 
            this.Enter_SimpleButton.Image = global::Dentas_Pro.UI.Properties.Resources.Login_Form_Enter_Button;
            this.Enter_SimpleButton.Location = new System.Drawing.Point(21, 141);
            this.Enter_SimpleButton.Name = "Enter_SimpleButton";
            this.Enter_SimpleButton.Size = new System.Drawing.Size(75, 40);
            this.Enter_SimpleButton.TabIndex = 5;
            this.Enter_SimpleButton.Text = "Giriş";
            this.Enter_SimpleButton.Click += new System.EventHandler(this.Enter_SimpleButton_Click);
            // 
            // Cancel_SimpleButton
            // 
            this.Cancel_SimpleButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_SimpleButton.Image = global::Dentas_Pro.UI.Properties.Resources.Login_Form_Cancel_Button;
            this.Cancel_SimpleButton.Location = new System.Drawing.Point(159, 140);
            this.Cancel_SimpleButton.Name = "Cancel_SimpleButton";
            this.Cancel_SimpleButton.Size = new System.Drawing.Size(75, 40);
            this.Cancel_SimpleButton.TabIndex = 6;
            this.Cancel_SimpleButton.Text = "İptal";
            this.Cancel_SimpleButton.Click += new System.EventHandler(this.Cancel_SimpleButton_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = global::Dentas_Pro.UI.Properties.Resources.forgettten_Password;
            this.simpleButton1.Location = new System.Drawing.Point(417, 151);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(41, 34);
            this.simpleButton1.TabIndex = 7;
            this.simpleButton1.ToolTip = "Şifremi unuttum !...";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::Dentas_Pro.UI.Properties.Resources.Login_Form_Dentaş_Logo;
            this.pictureEdit1.Location = new System.Drawing.Point(264, 21);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Size = new System.Drawing.Size(188, 123);
            this.pictureEdit1.TabIndex = 2;
            // 
            // Login_Form
            // 
            this.AcceptButton = this.Enter_SimpleButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel_SimpleButton;
            this.ClientSize = new System.Drawing.Size(462, 190);
            this.ControlBox = false;
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.Cancel_SimpleButton);
            this.Controls.Add(this.Enter_SimpleButton);
            this.Controls.Add(this.User_Password_LabelControl);
            this.Controls.Add(this.User_Name_LabelControl);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.User_Password_TextEdit);
            this.Controls.Add(this.User_Name_TextEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Girişi";
            this.Load += new System.EventHandler(this.Login_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.User_Name_TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.User_Password_TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit User_Name_TextEdit;
        private DevExpress.XtraEditors.TextEdit User_Password_TextEdit;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl User_Name_LabelControl;
        private DevExpress.XtraEditors.LabelControl User_Password_LabelControl;
        private DevExpress.XtraEditors.SimpleButton Enter_SimpleButton;
        private DevExpress.XtraEditors.SimpleButton Cancel_SimpleButton;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}