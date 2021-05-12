namespace Dentas_Pro.UI.Definition
{
    partial class Travel_Vehicle_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Travel_Vehicle_Form));
            this.Actions_GroupControl = new DevExpress.XtraEditors.GroupControl();
            this.Delete_SimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.Save_SimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.Close_SimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.Travel_Vehicle_GridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Travel_Vehicle_Code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Travel_Vehicle_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Travel_Vehicle_Type_GridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Travel_Vehicle_Description_GridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.Travel_Vehicle_Description_LabelControl = new DevExpress.XtraEditors.LabelControl();
            this.Travel_Vehicle_GroupControl = new DevExpress.XtraEditors.GroupControl();
            this.Travel_Vehicle_Name_TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Travel_Vehicle_Name_LabelControl = new DevExpress.XtraEditors.LabelControl();
            this.Travel_Vehicle_Description_MemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.Travel_Vehicle_Type_TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Travel_Vehicle_Type_LabelControl = new DevExpress.XtraEditors.LabelControl();
            this.Travel_Vehicle_Code_TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Travel_Vehicle_Code_LabelControl = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.Actions_GroupControl)).BeginInit();
            this.Actions_GroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Travel_Vehicle_GridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Travel_Vehicle_GroupControl)).BeginInit();
            this.Travel_Vehicle_GroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Travel_Vehicle_Name_TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Travel_Vehicle_Description_MemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Travel_Vehicle_Type_TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Travel_Vehicle_Code_TextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Actions_GroupControl
            // 
            this.Actions_GroupControl.Controls.Add(this.Delete_SimpleButton);
            this.Actions_GroupControl.Controls.Add(this.Save_SimpleButton);
            this.Actions_GroupControl.Controls.Add(this.Close_SimpleButton);
            this.Actions_GroupControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Actions_GroupControl.Location = new System.Drawing.Point(2, 307);
            this.Actions_GroupControl.Name = "Actions_GroupControl";
            this.Actions_GroupControl.Size = new System.Drawing.Size(389, 71);
            this.Actions_GroupControl.TabIndex = 1;
            this.Actions_GroupControl.Text = "İşlemler";
            // 
            // Delete_SimpleButton
            // 
            this.Delete_SimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Delete_SimpleButton.Image = global::Dentas_Pro.UI.Properties.Resources.Sil_buton_32X32;
            this.Delete_SimpleButton.Location = new System.Drawing.Point(300, 27);
            this.Delete_SimpleButton.Name = "Delete_SimpleButton";
            this.Delete_SimpleButton.Size = new System.Drawing.Size(75, 37);
            this.Delete_SimpleButton.TabIndex = 8;
            this.Delete_SimpleButton.Text = "Sil";
            this.Delete_SimpleButton.Click += new System.EventHandler(this.Delete_SimpleButton_Click);
            // 
            // Save_SimpleButton
            // 
            this.Save_SimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Save_SimpleButton.Image = global::Dentas_Pro.UI.Properties.Resources.Kaydet_buton_32X32;
            this.Save_SimpleButton.Location = new System.Drawing.Point(66, 27);
            this.Save_SimpleButton.Name = "Save_SimpleButton";
            this.Save_SimpleButton.Size = new System.Drawing.Size(81, 37);
            this.Save_SimpleButton.TabIndex = 6;
            this.Save_SimpleButton.Text = "Kaydet";
            this.Save_SimpleButton.Click += new System.EventHandler(this.Save_SimpleButton_Click);
            // 
            // Close_SimpleButton
            // 
            this.Close_SimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Close_SimpleButton.Image = global::Dentas_Pro.UI.Properties.Resources.Kapat_buton_32X32;
            this.Close_SimpleButton.Location = new System.Drawing.Point(184, 25);
            this.Close_SimpleButton.Name = "Close_SimpleButton";
            this.Close_SimpleButton.Size = new System.Drawing.Size(75, 41);
            this.Close_SimpleButton.TabIndex = 7;
            this.Close_SimpleButton.Text = "Kapat";
            this.Close_SimpleButton.Click += new System.EventHandler(this.Close_SimpleButton_Click);
            // 
            // Travel_Vehicle_GridControl
            // 
            this.Travel_Vehicle_GridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Travel_Vehicle_GridControl.Location = new System.Drawing.Point(2, 22);
            this.Travel_Vehicle_GridControl.MainView = this.gridView1;
            this.Travel_Vehicle_GridControl.Name = "Travel_Vehicle_GridControl";
            this.Travel_Vehicle_GridControl.Size = new System.Drawing.Size(389, 356);
            this.Travel_Vehicle_GridControl.TabIndex = 5;
            this.Travel_Vehicle_GridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.Travel_Vehicle_Code,
            this.Travel_Vehicle_Name,
            this.Travel_Vehicle_Type_GridColumn,
            this.Travel_Vehicle_Description_GridColumn});
            this.gridView1.GridControl = this.Travel_Vehicle_GridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // Id
            // 
            this.Id.Caption = "Id";
            this.Id.FieldName = "Obj_Id";
            this.Id.Name = "Id";
            // 
            // Travel_Vehicle_Code
            // 
            this.Travel_Vehicle_Code.Caption = "Araç Kodu";
            this.Travel_Vehicle_Code.FieldName = "Code";
            this.Travel_Vehicle_Code.Name = "Travel_Vehicle_Code";
            this.Travel_Vehicle_Code.OptionsColumn.AllowEdit = false;
            this.Travel_Vehicle_Code.OptionsColumn.AllowFocus = false;
            this.Travel_Vehicle_Code.OptionsColumn.FixedWidth = true;
            this.Travel_Vehicle_Code.Visible = true;
            this.Travel_Vehicle_Code.VisibleIndex = 0;
            this.Travel_Vehicle_Code.Width = 20;
            // 
            // Travel_Vehicle_Name
            // 
            this.Travel_Vehicle_Name.Caption = "Araç Adı";
            this.Travel_Vehicle_Name.FieldName = "Name";
            this.Travel_Vehicle_Name.Name = "Travel_Vehicle_Name";
            this.Travel_Vehicle_Name.OptionsColumn.AllowEdit = false;
            this.Travel_Vehicle_Name.OptionsColumn.AllowFocus = false;
            this.Travel_Vehicle_Name.OptionsColumn.FixedWidth = true;
            this.Travel_Vehicle_Name.Visible = true;
            this.Travel_Vehicle_Name.VisibleIndex = 1;
            this.Travel_Vehicle_Name.Width = 30;
            // 
            // Travel_Vehicle_Type_GridColumn
            // 
            this.Travel_Vehicle_Type_GridColumn.Caption = "Araç Türü";
            this.Travel_Vehicle_Type_GridColumn.FieldName = "Vehicle_Type";
            this.Travel_Vehicle_Type_GridColumn.Name = "Travel_Vehicle_Type_GridColumn";
            this.Travel_Vehicle_Type_GridColumn.OptionsColumn.AllowEdit = false;
            this.Travel_Vehicle_Type_GridColumn.OptionsColumn.AllowFocus = false;
            this.Travel_Vehicle_Type_GridColumn.OptionsColumn.FixedWidth = true;
            this.Travel_Vehicle_Type_GridColumn.Visible = true;
            this.Travel_Vehicle_Type_GridColumn.VisibleIndex = 2;
            this.Travel_Vehicle_Type_GridColumn.Width = 30;
            // 
            // Travel_Vehicle_Description_GridColumn
            // 
            this.Travel_Vehicle_Description_GridColumn.Caption = "Açıklama";
            this.Travel_Vehicle_Description_GridColumn.FieldName = "Description";
            this.Travel_Vehicle_Description_GridColumn.Name = "Travel_Vehicle_Description_GridColumn";
            this.Travel_Vehicle_Description_GridColumn.OptionsColumn.AllowEdit = false;
            this.Travel_Vehicle_Description_GridColumn.OptionsColumn.FixedWidth = true;
            this.Travel_Vehicle_Description_GridColumn.Visible = true;
            this.Travel_Vehicle_Description_GridColumn.VisibleIndex = 3;
            this.Travel_Vehicle_Description_GridColumn.Width = 250;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.Actions_GroupControl);
            this.groupControl2.Controls.Add(this.Travel_Vehicle_GridControl);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 124);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(393, 380);
            this.groupControl2.TabIndex = 3;
            // 
            // Travel_Vehicle_Description_LabelControl
            // 
            this.Travel_Vehicle_Description_LabelControl.Location = new System.Drawing.Point(174, 36);
            this.Travel_Vehicle_Description_LabelControl.Name = "Travel_Vehicle_Description_LabelControl";
            this.Travel_Vehicle_Description_LabelControl.Size = new System.Drawing.Size(41, 13);
            this.Travel_Vehicle_Description_LabelControl.TabIndex = 5;
            this.Travel_Vehicle_Description_LabelControl.Text = "Açıklama";
            // 
            // Travel_Vehicle_GroupControl
            // 
            this.Travel_Vehicle_GroupControl.Controls.Add(this.Travel_Vehicle_Name_TextEdit);
            this.Travel_Vehicle_GroupControl.Controls.Add(this.Travel_Vehicle_Name_LabelControl);
            this.Travel_Vehicle_GroupControl.Controls.Add(this.Travel_Vehicle_Description_LabelControl);
            this.Travel_Vehicle_GroupControl.Controls.Add(this.Travel_Vehicle_Description_MemoEdit);
            this.Travel_Vehicle_GroupControl.Controls.Add(this.Travel_Vehicle_Type_TextEdit);
            this.Travel_Vehicle_GroupControl.Controls.Add(this.Travel_Vehicle_Type_LabelControl);
            this.Travel_Vehicle_GroupControl.Controls.Add(this.Travel_Vehicle_Code_TextEdit);
            this.Travel_Vehicle_GroupControl.Controls.Add(this.Travel_Vehicle_Code_LabelControl);
            this.Travel_Vehicle_GroupControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.Travel_Vehicle_GroupControl.Location = new System.Drawing.Point(0, 0);
            this.Travel_Vehicle_GroupControl.Name = "Travel_Vehicle_GroupControl";
            this.Travel_Vehicle_GroupControl.Size = new System.Drawing.Size(393, 124);
            this.Travel_Vehicle_GroupControl.TabIndex = 2;
            this.Travel_Vehicle_GroupControl.Text = "Seyahat Aracı";
            // 
            // Travel_Vehicle_Name_TextEdit
            // 
            this.Travel_Vehicle_Name_TextEdit.Location = new System.Drawing.Point(48, 65);
            this.Travel_Vehicle_Name_TextEdit.Name = "Travel_Vehicle_Name_TextEdit";
            this.Travel_Vehicle_Name_TextEdit.Size = new System.Drawing.Size(119, 20);
            this.Travel_Vehicle_Name_TextEdit.TabIndex = 2;
            // 
            // Travel_Vehicle_Name_LabelControl
            // 
            this.Travel_Vehicle_Name_LabelControl.Location = new System.Drawing.Point(14, 68);
            this.Travel_Vehicle_Name_LabelControl.Name = "Travel_Vehicle_Name_LabelControl";
            this.Travel_Vehicle_Name_LabelControl.Size = new System.Drawing.Size(15, 13);
            this.Travel_Vehicle_Name_LabelControl.TabIndex = 6;
            this.Travel_Vehicle_Name_LabelControl.Text = "Adı";
            // 
            // Travel_Vehicle_Description_MemoEdit
            // 
            this.Travel_Vehicle_Description_MemoEdit.Location = new System.Drawing.Point(221, 25);
            this.Travel_Vehicle_Description_MemoEdit.Name = "Travel_Vehicle_Description_MemoEdit";
            this.Travel_Vehicle_Description_MemoEdit.Size = new System.Drawing.Size(143, 89);
            this.Travel_Vehicle_Description_MemoEdit.TabIndex = 4;
            // 
            // Travel_Vehicle_Type_TextEdit
            // 
            this.Travel_Vehicle_Type_TextEdit.Location = new System.Drawing.Point(67, 98);
            this.Travel_Vehicle_Type_TextEdit.Name = "Travel_Vehicle_Type_TextEdit";
            this.Travel_Vehicle_Type_TextEdit.Size = new System.Drawing.Size(100, 20);
            this.Travel_Vehicle_Type_TextEdit.TabIndex = 3;
            // 
            // Travel_Vehicle_Type_LabelControl
            // 
            this.Travel_Vehicle_Type_LabelControl.Location = new System.Drawing.Point(14, 101);
            this.Travel_Vehicle_Type_LabelControl.Name = "Travel_Vehicle_Type_LabelControl";
            this.Travel_Vehicle_Type_LabelControl.Size = new System.Drawing.Size(47, 13);
            this.Travel_Vehicle_Type_LabelControl.TabIndex = 2;
            this.Travel_Vehicle_Type_LabelControl.Text = "Araç Türü";
            // 
            // Travel_Vehicle_Code_TextEdit
            // 
            this.Travel_Vehicle_Code_TextEdit.Location = new System.Drawing.Point(48, 33);
            this.Travel_Vehicle_Code_TextEdit.Name = "Travel_Vehicle_Code_TextEdit";
            this.Travel_Vehicle_Code_TextEdit.Size = new System.Drawing.Size(119, 20);
            this.Travel_Vehicle_Code_TextEdit.TabIndex = 1;
            // 
            // Travel_Vehicle_Code_LabelControl
            // 
            this.Travel_Vehicle_Code_LabelControl.Location = new System.Drawing.Point(14, 36);
            this.Travel_Vehicle_Code_LabelControl.Name = "Travel_Vehicle_Code_LabelControl";
            this.Travel_Vehicle_Code_LabelControl.Size = new System.Drawing.Size(24, 13);
            this.Travel_Vehicle_Code_LabelControl.TabIndex = 0;
            this.Travel_Vehicle_Code_LabelControl.Text = "Kodu";
            // 
            // Travel_Vehicle_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 504);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.Travel_Vehicle_GroupControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Travel_Vehicle_Form";
            this.Text = "Seyahat Araç Tanım";
            this.Load += new System.EventHandler(this.Travel_Vehicle_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Actions_GroupControl)).EndInit();
            this.Actions_GroupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Travel_Vehicle_GridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Travel_Vehicle_GroupControl)).EndInit();
            this.Travel_Vehicle_GroupControl.ResumeLayout(false);
            this.Travel_Vehicle_GroupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Travel_Vehicle_Name_TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Travel_Vehicle_Description_MemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Travel_Vehicle_Type_TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Travel_Vehicle_Code_TextEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl Actions_GroupControl;
        private DevExpress.XtraEditors.SimpleButton Delete_SimpleButton;
        private DevExpress.XtraEditors.SimpleButton Save_SimpleButton;
        private DevExpress.XtraEditors.SimpleButton Close_SimpleButton;
        private DevExpress.XtraGrid.GridControl Travel_Vehicle_GridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn Travel_Vehicle_Code;
        private DevExpress.XtraGrid.Columns.GridColumn Travel_Vehicle_Name;
        private DevExpress.XtraGrid.Columns.GridColumn Travel_Vehicle_Type_GridColumn;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl Travel_Vehicle_Description_LabelControl;
        private DevExpress.XtraEditors.GroupControl Travel_Vehicle_GroupControl;
        private DevExpress.XtraEditors.TextEdit Travel_Vehicle_Name_TextEdit;
        private DevExpress.XtraEditors.LabelControl Travel_Vehicle_Name_LabelControl;
        private DevExpress.XtraEditors.MemoEdit Travel_Vehicle_Description_MemoEdit;
        private DevExpress.XtraEditors.TextEdit Travel_Vehicle_Type_TextEdit;
        private DevExpress.XtraEditors.LabelControl Travel_Vehicle_Type_LabelControl;
        private DevExpress.XtraEditors.TextEdit Travel_Vehicle_Code_TextEdit;
        private DevExpress.XtraEditors.LabelControl Travel_Vehicle_Code_LabelControl;
        private DevExpress.XtraGrid.Columns.GridColumn Travel_Vehicle_Description_GridColumn;
    }
}