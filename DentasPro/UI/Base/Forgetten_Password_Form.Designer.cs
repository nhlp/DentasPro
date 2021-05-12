namespace Dentas_Pro.UI.Base
{
    partial class Forgetten_Password_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forgetten_Password_Form));
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.Send_An_E_Mail_SimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.E_Mail_TextEdit = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.E_Mail_TextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // memoEdit1
            // 
            this.memoEdit1.EditValue = "Şifrenizin size yollanmasını için aşağıdaki kutuya \"Mail Adresi\" nizi yazıp \"Mail" +
                " Gönder\" butonuna basınız";
            this.memoEdit1.Enabled = false;
            this.memoEdit1.Location = new System.Drawing.Point(22, 16);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Size = new System.Drawing.Size(302, 56);
            this.memoEdit1.TabIndex = 2;
            // 
            // Send_An_E_Mail_SimpleButton
            // 
            this.Send_An_E_Mail_SimpleButton.Location = new System.Drawing.Point(131, 130);
            this.Send_An_E_Mail_SimpleButton.Name = "Send_An_E_Mail_SimpleButton";
            this.Send_An_E_Mail_SimpleButton.Size = new System.Drawing.Size(75, 23);
            this.Send_An_E_Mail_SimpleButton.TabIndex = 1;
            this.Send_An_E_Mail_SimpleButton.Text = "Mail Gönder";
            this.Send_An_E_Mail_SimpleButton.Click += new System.EventHandler(this.Send_An_E_Mail_SimpleButton_Click);
            // 
            // E_Mail_TextEdit
            // 
            this.E_Mail_TextEdit.Location = new System.Drawing.Point(69, 96);
            this.E_Mail_TextEdit.Name = "E_Mail_TextEdit";
            this.E_Mail_TextEdit.Size = new System.Drawing.Size(208, 20);
            this.E_Mail_TextEdit.TabIndex = 0;
            // 
            // Forgetten_Password_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 176);
            this.Controls.Add(this.memoEdit1);
            this.Controls.Add(this.Send_An_E_Mail_SimpleButton);
            this.Controls.Add(this.E_Mail_TextEdit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Forgetten_Password_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şifremi Unuttum";
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.E_Mail_TextEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit E_Mail_TextEdit;
        private DevExpress.XtraEditors.SimpleButton Send_An_E_Mail_SimpleButton;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
    }
}