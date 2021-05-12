namespace Dentas_Pro.UI.Permit
{
    partial class Activity_Insert_PopUp_Form
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.Activity_Name_ComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.Activity_Date_TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Save_SimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.Delete_SimpleButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.Activity_Name_ComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Activity_Date_TextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Tarih";
            // 
            // Activity_Name_ComboBoxEdit
            // 
            this.Activity_Name_ComboBoxEdit.Location = new System.Drawing.Point(65, 46);
            this.Activity_Name_ComboBoxEdit.Name = "Activity_Name_ComboBoxEdit";
            this.Activity_Name_ComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Activity_Name_ComboBoxEdit.Properties.Items.AddRange(new object[] {
            "Resmi Tatil",
            "Dentaş Tatil"});
            this.Activity_Name_ComboBoxEdit.Size = new System.Drawing.Size(100, 20);
            this.Activity_Name_ComboBoxEdit.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 53);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Aktivite";
            // 
            // Activity_Date_TextEdit
            // 
            this.Activity_Date_TextEdit.Enabled = false;
            this.Activity_Date_TextEdit.Location = new System.Drawing.Point(65, 5);
            this.Activity_Date_TextEdit.Name = "Activity_Date_TextEdit";
            this.Activity_Date_TextEdit.Size = new System.Drawing.Size(100, 20);
            this.Activity_Date_TextEdit.TabIndex = 4;
            // 
            // Save_SimpleButton
            // 
            this.Save_SimpleButton.Location = new System.Drawing.Point(156, 82);
            this.Save_SimpleButton.Name = "Save_SimpleButton";
            this.Save_SimpleButton.Size = new System.Drawing.Size(54, 23);
            this.Save_SimpleButton.TabIndex = 5;
            this.Save_SimpleButton.Text = "Kaydet";
            this.Save_SimpleButton.Click += new System.EventHandler(this.Save_SimpleButton_Click);
            // 
            // Delete_SimpleButton
            // 
            this.Delete_SimpleButton.Location = new System.Drawing.Point(12, 82);
            this.Delete_SimpleButton.Name = "Delete_SimpleButton";
            this.Delete_SimpleButton.Size = new System.Drawing.Size(54, 23);
            this.Delete_SimpleButton.TabIndex = 6;
            this.Delete_SimpleButton.Text = "Sil";
            this.Delete_SimpleButton.Click += new System.EventHandler(this.Delete_SimpleButton_Click);
            // 
            // Activity_Insert_PopUp_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 117);
            this.Controls.Add(this.Delete_SimpleButton);
            this.Controls.Add(this.Save_SimpleButton);
            this.Controls.Add(this.Activity_Date_TextEdit);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.Activity_Name_ComboBoxEdit);
            this.Controls.Add(this.labelControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Activity_Insert_PopUp_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Etkinlik Girme Ekranı";
            ((System.ComponentModel.ISupportInitialize)(this.Activity_Name_ComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Activity_Date_TextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit Activity_Name_ComboBoxEdit;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        public DevExpress.XtraEditors.TextEdit Activity_Date_TextEdit;
        private DevExpress.XtraEditors.SimpleButton Save_SimpleButton;
        private DevExpress.XtraEditors.SimpleButton Delete_SimpleButton;
    }
}