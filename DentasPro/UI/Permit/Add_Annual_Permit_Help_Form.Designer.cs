namespace Dentas_Pro.UI.Permit
{
    partial class Add_Annual_Permit_Help_Form
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
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.memoEdit2 = new DevExpress.XtraEditors.MemoEdit();
            this.memoEdit3 = new DevExpress.XtraEditors.MemoEdit();
            this.memoEdit4 = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit4.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // memoEdit1
            // 
            this.memoEdit1.EditValue = "Yeni personel\'e izin ekliyor olabilirsiniz. İzin açıklmasına \"Devir Bakiye\" yazıl" +
    "abilir.";
            this.memoEdit1.Enabled = false;
            this.memoEdit1.Location = new System.Drawing.Point(19, 12);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Size = new System.Drawing.Size(247, 67);
            this.memoEdit1.TabIndex = 0;
            // 
            // memoEdit2
            // 
            this.memoEdit2.EditValue = "Sehven yanlış izin kullandırmadan kaynakalanan izin olabilir. İzin açıklmasına \"x" +
    "yz tarihinden kaynaklanan izinden dolayı\" gibi bir açıklama yazılabilir.";
            this.memoEdit2.Enabled = false;
            this.memoEdit2.Location = new System.Drawing.Point(19, 98);
            this.memoEdit2.Name = "memoEdit2";
            this.memoEdit2.Size = new System.Drawing.Size(247, 67);
            this.memoEdit2.TabIndex = 1;
            // 
            // memoEdit3
            // 
            this.memoEdit3.EditValue = "Herhangi bir sebeple yeni izin hak ettirilecek ise sebebi ile beraber \"... ... de" +
    "n dolayı izin hak ettirilmiştir\" gibi açıklama yazılabilir.";
            this.memoEdit3.Enabled = false;
            this.memoEdit3.Location = new System.Drawing.Point(19, 183);
            this.memoEdit3.Name = "memoEdit3";
            this.memoEdit3.Size = new System.Drawing.Size(247, 67);
            this.memoEdit3.TabIndex = 2;
            // 
            // memoEdit4
            // 
            this.memoEdit4.EditValue = "... ... ... ... ... .. .. .. ";
            this.memoEdit4.Enabled = false;
            this.memoEdit4.Location = new System.Drawing.Point(19, 268);
            this.memoEdit4.Name = "memoEdit4";
            this.memoEdit4.Size = new System.Drawing.Size(247, 67);
            this.memoEdit4.TabIndex = 3;
            // 
            // Add_Annual_Permit_Help_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 350);
            this.Controls.Add(this.memoEdit4);
            this.Controls.Add(this.memoEdit3);
            this.Controls.Add(this.memoEdit2);
            this.Controls.Add(this.memoEdit1);
            this.Name = "Add_Annual_Permit_Help_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İzin Ekleme Yardım ..";
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit4.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private DevExpress.XtraEditors.MemoEdit memoEdit2;
        private DevExpress.XtraEditors.MemoEdit memoEdit3;
        private DevExpress.XtraEditors.MemoEdit memoEdit4;
    }
}