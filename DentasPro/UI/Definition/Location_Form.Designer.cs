namespace Dentas_Pro.UI.Definition
{
    partial class Location_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Location_Form));
            this.Actions_GroupControl = new DevExpress.XtraEditors.GroupControl();
            this.Delete_SimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.Save_SimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.Close_SimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.Location_GroupControl = new DevExpress.XtraEditors.GroupControl();
            this.Location_Description_LabelControl = new DevExpress.XtraEditors.LabelControl();
            this.Location_Description_MemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.Location_Name_TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.Location_Code_TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Location_Code_LabelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.Location_GridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Obj_Id_GridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Location_Code_GridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Location_Name_GridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Location_Description_GridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Actions_GroupControl)).BeginInit();
            this.Actions_GroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Location_GroupControl)).BeginInit();
            this.Location_GroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Location_Description_MemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Location_Name_TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Location_Code_TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Location_GridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Actions_GroupControl
            // 
            this.Actions_GroupControl.Controls.Add(this.Delete_SimpleButton);
            this.Actions_GroupControl.Controls.Add(this.Save_SimpleButton);
            this.Actions_GroupControl.Controls.Add(this.Close_SimpleButton);
            this.Actions_GroupControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Actions_GroupControl.Location = new System.Drawing.Point(2, 598);
            this.Actions_GroupControl.Name = "Actions_GroupControl";
            this.Actions_GroupControl.Size = new System.Drawing.Size(497, 71);
            this.Actions_GroupControl.TabIndex = 1;
            this.Actions_GroupControl.Text = "İşlemler";
            // 
            // Delete_SimpleButton
            // 
            this.Delete_SimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Delete_SimpleButton.Image = global::Dentas_Pro.UI.Properties.Resources.Sil_buton_32X32;
            this.Delete_SimpleButton.Location = new System.Drawing.Point(408, 27);
            this.Delete_SimpleButton.Name = "Delete_SimpleButton";
            this.Delete_SimpleButton.Size = new System.Drawing.Size(75, 37);
            this.Delete_SimpleButton.TabIndex = 6;
            this.Delete_SimpleButton.Text = "Sil";
            this.Delete_SimpleButton.Click += new System.EventHandler(this.Delete_SimpleButton_Click);
            // 
            // Save_SimpleButton
            // 
            this.Save_SimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Save_SimpleButton.Image = global::Dentas_Pro.UI.Properties.Resources.Kaydet_buton_32X32;
            this.Save_SimpleButton.Location = new System.Drawing.Point(174, 27);
            this.Save_SimpleButton.Name = "Save_SimpleButton";
            this.Save_SimpleButton.Size = new System.Drawing.Size(81, 37);
            this.Save_SimpleButton.TabIndex = 4;
            this.Save_SimpleButton.Text = "Kaydet";
            this.Save_SimpleButton.Click += new System.EventHandler(this.Save_SimpleButton_Click);
            // 
            // Close_SimpleButton
            // 
            this.Close_SimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Close_SimpleButton.Image = global::Dentas_Pro.UI.Properties.Resources.Kapat_buton_32X32;
            this.Close_SimpleButton.Location = new System.Drawing.Point(292, 25);
            this.Close_SimpleButton.Name = "Close_SimpleButton";
            this.Close_SimpleButton.Size = new System.Drawing.Size(75, 41);
            this.Close_SimpleButton.TabIndex = 5;
            this.Close_SimpleButton.Text = "Kapat";
            this.Close_SimpleButton.Click += new System.EventHandler(this.Close_SimpleButton_Click);
            // 
            // Location_GroupControl
            // 
            this.Location_GroupControl.Controls.Add(this.Location_Description_LabelControl);
            this.Location_GroupControl.Controls.Add(this.Location_Description_MemoEdit);
            this.Location_GroupControl.Controls.Add(this.Location_Name_TextEdit);
            this.Location_GroupControl.Controls.Add(this.labelControl2);
            this.Location_GroupControl.Controls.Add(this.Location_Code_TextEdit);
            this.Location_GroupControl.Controls.Add(this.Location_Code_LabelControl1);
            this.Location_GroupControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.Location_GroupControl.Location = new System.Drawing.Point(0, 0);
            this.Location_GroupControl.Name = "Location_GroupControl";
            this.Location_GroupControl.Size = new System.Drawing.Size(501, 120);
            this.Location_GroupControl.TabIndex = 2;
            this.Location_GroupControl.Text = "Lokasyon";
            // 
            // Location_Description_LabelControl
            // 
            this.Location_Description_LabelControl.Location = new System.Drawing.Point(174, 36);
            this.Location_Description_LabelControl.Name = "Location_Description_LabelControl";
            this.Location_Description_LabelControl.Size = new System.Drawing.Size(41, 13);
            this.Location_Description_LabelControl.TabIndex = 5;
            this.Location_Description_LabelControl.Text = "Açıklama";
            // 
            // Location_Description_MemoEdit
            // 
            this.Location_Description_MemoEdit.Location = new System.Drawing.Point(221, 25);
            this.Location_Description_MemoEdit.Name = "Location_Description_MemoEdit";
            this.Location_Description_MemoEdit.Size = new System.Drawing.Size(140, 69);
            this.Location_Description_MemoEdit.TabIndex = 4;
            // 
            // Location_Name_TextEdit
            // 
            this.Location_Name_TextEdit.Location = new System.Drawing.Point(48, 74);
            this.Location_Name_TextEdit.Name = "Location_Name_TextEdit";
            this.Location_Name_TextEdit.Size = new System.Drawing.Size(119, 20);
            this.Location_Name_TextEdit.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(14, 77);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(15, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Adı";
            // 
            // Location_Code_TextEdit
            // 
            this.Location_Code_TextEdit.Location = new System.Drawing.Point(48, 33);
            this.Location_Code_TextEdit.Name = "Location_Code_TextEdit";
            this.Location_Code_TextEdit.Size = new System.Drawing.Size(119, 20);
            this.Location_Code_TextEdit.TabIndex = 1;
            // 
            // Location_Code_LabelControl1
            // 
            this.Location_Code_LabelControl1.Location = new System.Drawing.Point(14, 36);
            this.Location_Code_LabelControl1.Name = "Location_Code_LabelControl1";
            this.Location_Code_LabelControl1.Size = new System.Drawing.Size(24, 13);
            this.Location_Code_LabelControl1.TabIndex = 0;
            this.Location_Code_LabelControl1.Text = "Kodu";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.Location_GridControl);
            this.groupControl2.Controls.Add(this.Actions_GroupControl);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(501, 671);
            this.groupControl2.TabIndex = 3;
            // 
            // Location_GridControl
            // 
            this.Location_GridControl.Location = new System.Drawing.Point(2, 118);
            this.Location_GridControl.MainView = this.gridView1;
            this.Location_GridControl.Name = "Location_GridControl";
            this.Location_GridControl.Size = new System.Drawing.Size(499, 482);
            this.Location_GridControl.TabIndex = 2;
            this.Location_GridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Obj_Id_GridColumn,
            this.Location_Code_GridColumn,
            this.Location_Name_GridColumn,
            this.Location_Description_GridColumn});
            this.gridView1.GridControl = this.Location_GridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick_1);
            // 
            // Obj_Id_GridColumn
            // 
            this.Obj_Id_GridColumn.Caption = "Obj Id";
            this.Obj_Id_GridColumn.Name = "Obj_Id_GridColumn";
            // 
            // Location_Code_GridColumn
            // 
            this.Location_Code_GridColumn.Caption = "Lokasyon Kodu";
            this.Location_Code_GridColumn.FieldName = "Code";
            this.Location_Code_GridColumn.Name = "Location_Code_GridColumn";
            this.Location_Code_GridColumn.OptionsColumn.AllowEdit = false;
            this.Location_Code_GridColumn.OptionsColumn.AllowFocus = false;
            this.Location_Code_GridColumn.OptionsColumn.FixedWidth = true;
            this.Location_Code_GridColumn.Visible = true;
            this.Location_Code_GridColumn.VisibleIndex = 0;
            this.Location_Code_GridColumn.Width = 30;
            // 
            // Location_Name_GridColumn
            // 
            this.Location_Name_GridColumn.Caption = "Lokasyon Adı";
            this.Location_Name_GridColumn.FieldName = "Name";
            this.Location_Name_GridColumn.Name = "Location_Name_GridColumn";
            this.Location_Name_GridColumn.OptionsColumn.AllowEdit = false;
            this.Location_Name_GridColumn.OptionsColumn.AllowFocus = false;
            this.Location_Name_GridColumn.OptionsColumn.FixedWidth = true;
            this.Location_Name_GridColumn.Visible = true;
            this.Location_Name_GridColumn.VisibleIndex = 1;
            this.Location_Name_GridColumn.Width = 40;
            // 
            // Location_Description_GridColumn
            // 
            this.Location_Description_GridColumn.Caption = "Açıklama";
            this.Location_Description_GridColumn.FieldName = "Description";
            this.Location_Description_GridColumn.Name = "Location_Description_GridColumn";
            this.Location_Description_GridColumn.OptionsColumn.AllowEdit = false;
            this.Location_Description_GridColumn.OptionsColumn.AllowFocus = false;
            this.Location_Description_GridColumn.OptionsColumn.FixedWidth = true;
            this.Location_Description_GridColumn.Visible = true;
            this.Location_Description_GridColumn.VisibleIndex = 2;
            // 
            // Location_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 671);
            this.Controls.Add(this.Location_GroupControl);
            this.Controls.Add(this.groupControl2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Location_Form";
            this.Text = "Lokasyon Kayıt Formu";
            this.Load += new System.EventHandler(this.Location_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Actions_GroupControl)).EndInit();
            this.Actions_GroupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Location_GroupControl)).EndInit();
            this.Location_GroupControl.ResumeLayout(false);
            this.Location_GroupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Location_Description_MemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Location_Name_TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Location_Code_TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Location_GridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl Actions_GroupControl;
        private DevExpress.XtraEditors.SimpleButton Delete_SimpleButton;
        private DevExpress.XtraEditors.SimpleButton Save_SimpleButton;
        private DevExpress.XtraEditors.SimpleButton Close_SimpleButton;
        private DevExpress.XtraEditors.GroupControl Location_GroupControl;
        private DevExpress.XtraEditors.LabelControl Location_Description_LabelControl;
        private DevExpress.XtraEditors.MemoEdit Location_Description_MemoEdit;
        private DevExpress.XtraEditors.TextEdit Location_Name_TextEdit;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit Location_Code_TextEdit;
        private DevExpress.XtraEditors.LabelControl Location_Code_LabelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl Location_GridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Obj_Id_GridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn Location_Code_GridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn Location_Name_GridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn Location_Description_GridColumn;
    }
}