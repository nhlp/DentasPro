namespace Dentas_Pro.UI.Geography
{
    partial class Geo_UCX
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FuLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.FuLookUpEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // FuLookUpEdit
            // 
            this.FuLookUpEdit.Location = new System.Drawing.Point(3, 3);
            this.FuLookUpEdit.Name = "FuLookUpEdit";
            this.FuLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.FuLookUpEdit.Size = new System.Drawing.Size(130, 20);
            this.FuLookUpEdit.TabIndex = 0;
            // 
            // Geo_UCX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FuLookUpEdit);
            this.Name = "Geo_UCX";
            this.Size = new System.Drawing.Size(135, 25);
            ((System.ComponentModel.ISupportInitialize)(this.FuLookUpEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit FuLookUpEdit;
    }
}
