namespace Dentas_Pro.UI.Definition
{
    partial class Travel_Expense_Type_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Travel_Expense_Type_Form));
            this.Actions_GroupControl = new DevExpress.XtraEditors.GroupControl();
            this.Clean_SimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.Delete_SimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.Save_SimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.Close_SimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.Expense_Type_GridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Expense_Type_Code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Expense_Type_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Expense_Type_Description_GridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.Expense_Type_Description_LabelControl = new DevExpress.XtraEditors.LabelControl();
            this.Department_GroupControl = new DevExpress.XtraEditors.GroupControl();
            this.Expense_Type_Description_MemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.Expense_Type_Name_TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Expense_Type_Name_LabelControl = new DevExpress.XtraEditors.LabelControl();
            this.Expense_Type_Code_TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Expense_Type_Code_LabelControl = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.Actions_GroupControl)).BeginInit();
            this.Actions_GroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Expense_Type_GridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Department_GroupControl)).BeginInit();
            this.Department_GroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Expense_Type_Description_MemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Expense_Type_Name_TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Expense_Type_Code_TextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Actions_GroupControl
            // 
            this.Actions_GroupControl.Controls.Add(this.Clean_SimpleButton);
            this.Actions_GroupControl.Controls.Add(this.Delete_SimpleButton);
            this.Actions_GroupControl.Controls.Add(this.Save_SimpleButton);
            this.Actions_GroupControl.Controls.Add(this.Close_SimpleButton);
            this.Actions_GroupControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Actions_GroupControl.Location = new System.Drawing.Point(2, 326);
            this.Actions_GroupControl.Name = "Actions_GroupControl";
            this.Actions_GroupControl.Size = new System.Drawing.Size(361, 71);
            this.Actions_GroupControl.TabIndex = 1;
            this.Actions_GroupControl.Text = "İşlemler";
            // 
            // Clean_SimpleButton
            // 
            this.Clean_SimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Clean_SimpleButton.Image = global::Dentas_Pro.UI.Properties.Resources.Clean_button_32_32;
            this.Clean_SimpleButton.Location = new System.Drawing.Point(3, 27);
            this.Clean_SimpleButton.Name = "Clean_SimpleButton";
            this.Clean_SimpleButton.Size = new System.Drawing.Size(81, 37);
            this.Clean_SimpleButton.TabIndex = 7;
            this.Clean_SimpleButton.Text = "Temizle";
            this.Clean_SimpleButton.ToolTipTitle = "Evettttt";
            this.Clean_SimpleButton.Click += new System.EventHandler(this.Clean_SimpleButton_Click);
            // 
            // Delete_SimpleButton
            // 
            this.Delete_SimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Delete_SimpleButton.Image = global::Dentas_Pro.UI.Properties.Resources.Sil_buton_32X32;
            this.Delete_SimpleButton.Location = new System.Drawing.Point(281, 27);
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
            this.Save_SimpleButton.Location = new System.Drawing.Point(111, 27);
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
            this.Close_SimpleButton.Location = new System.Drawing.Point(198, 25);
            this.Close_SimpleButton.Name = "Close_SimpleButton";
            this.Close_SimpleButton.Size = new System.Drawing.Size(75, 41);
            this.Close_SimpleButton.TabIndex = 5;
            this.Close_SimpleButton.Text = "Kapat";
            this.Close_SimpleButton.Click += new System.EventHandler(this.Close_SimpleButton_Click);
            // 
            // Expense_Type_GridControl
            // 
            this.Expense_Type_GridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Expense_Type_GridControl.Location = new System.Drawing.Point(2, 22);
            this.Expense_Type_GridControl.MainView = this.gridView1;
            this.Expense_Type_GridControl.Name = "Expense_Type_GridControl";
            this.Expense_Type_GridControl.Size = new System.Drawing.Size(361, 375);
            this.Expense_Type_GridControl.TabIndex = 0;
            this.Expense_Type_GridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.Expense_Type_GridControl.DoubleClick += new System.EventHandler(this.Expense_Type_GridControl_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.Expense_Type_Code,
            this.Expense_Type_Name,
            this.Expense_Type_Description_GridColumn});
            this.gridView1.GridControl = this.Expense_Type_GridControl;
            this.gridView1.Name = "gridView1";
            // 
            // Id
            // 
            this.Id.Caption = "Id";
            this.Id.FieldName = "Obj_Id";
            this.Id.Name = "Id";
            // 
            // Expense_Type_Code
            // 
            this.Expense_Type_Code.Caption = "Harcama Türü Kodu";
            this.Expense_Type_Code.FieldName = "Code";
            this.Expense_Type_Code.Name = "Expense_Type_Code";
            this.Expense_Type_Code.OptionsColumn.AllowEdit = false;
            this.Expense_Type_Code.OptionsColumn.AllowFocus = false;
            this.Expense_Type_Code.OptionsColumn.FixedWidth = true;
            this.Expense_Type_Code.Visible = true;
            this.Expense_Type_Code.VisibleIndex = 0;
            this.Expense_Type_Code.Width = 20;
            // 
            // Expense_Type_Name
            // 
            this.Expense_Type_Name.Caption = "Harcama Türü Adı";
            this.Expense_Type_Name.FieldName = "Name";
            this.Expense_Type_Name.Name = "Expense_Type_Name";
            this.Expense_Type_Name.OptionsColumn.AllowEdit = false;
            this.Expense_Type_Name.OptionsColumn.AllowFocus = false;
            this.Expense_Type_Name.OptionsColumn.FixedWidth = true;
            this.Expense_Type_Name.Visible = true;
            this.Expense_Type_Name.VisibleIndex = 1;
            this.Expense_Type_Name.Width = 50;
            // 
            // Expense_Type_Description_GridColumn
            // 
            this.Expense_Type_Description_GridColumn.Caption = "Açıklama";
            this.Expense_Type_Description_GridColumn.FieldName = "Description";
            this.Expense_Type_Description_GridColumn.Name = "Expense_Type_Description_GridColumn";
            this.Expense_Type_Description_GridColumn.OptionsColumn.AllowEdit = false;
            this.Expense_Type_Description_GridColumn.OptionsColumn.AllowFocus = false;
            this.Expense_Type_Description_GridColumn.OptionsColumn.FixedWidth = true;
            this.Expense_Type_Description_GridColumn.Visible = true;
            this.Expense_Type_Description_GridColumn.VisibleIndex = 2;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.Actions_GroupControl);
            this.groupControl2.Controls.Add(this.Expense_Type_GridControl);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 108);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(365, 399);
            this.groupControl2.TabIndex = 3;
            // 
            // Expense_Type_Description_LabelControl
            // 
            this.Expense_Type_Description_LabelControl.Location = new System.Drawing.Point(174, 36);
            this.Expense_Type_Description_LabelControl.Name = "Expense_Type_Description_LabelControl";
            this.Expense_Type_Description_LabelControl.Size = new System.Drawing.Size(41, 13);
            this.Expense_Type_Description_LabelControl.TabIndex = 5;
            this.Expense_Type_Description_LabelControl.Text = "Açıklama";
            // 
            // Department_GroupControl
            // 
            this.Department_GroupControl.Controls.Add(this.Expense_Type_Description_LabelControl);
            this.Department_GroupControl.Controls.Add(this.Expense_Type_Description_MemoEdit);
            this.Department_GroupControl.Controls.Add(this.Expense_Type_Name_TextEdit);
            this.Department_GroupControl.Controls.Add(this.Expense_Type_Name_LabelControl);
            this.Department_GroupControl.Controls.Add(this.Expense_Type_Code_TextEdit);
            this.Department_GroupControl.Controls.Add(this.Expense_Type_Code_LabelControl);
            this.Department_GroupControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.Department_GroupControl.Location = new System.Drawing.Point(0, 0);
            this.Department_GroupControl.Name = "Department_GroupControl";
            this.Department_GroupControl.Size = new System.Drawing.Size(365, 108);
            this.Department_GroupControl.TabIndex = 2;
            this.Department_GroupControl.Text = "Departman";
            // 
            // Expense_Type_Description_MemoEdit
            // 
            this.Expense_Type_Description_MemoEdit.Location = new System.Drawing.Point(221, 25);
            this.Expense_Type_Description_MemoEdit.Name = "Expense_Type_Description_MemoEdit";
            this.Expense_Type_Description_MemoEdit.Size = new System.Drawing.Size(140, 69);
            this.Expense_Type_Description_MemoEdit.TabIndex = 4;
            // 
            // Expense_Type_Name_TextEdit
            // 
            this.Expense_Type_Name_TextEdit.Location = new System.Drawing.Point(48, 74);
            this.Expense_Type_Name_TextEdit.Name = "Expense_Type_Name_TextEdit";
            this.Expense_Type_Name_TextEdit.Size = new System.Drawing.Size(119, 20);
            this.Expense_Type_Name_TextEdit.TabIndex = 3;
            // 
            // Expense_Type_Name_LabelControl
            // 
            this.Expense_Type_Name_LabelControl.Location = new System.Drawing.Point(14, 77);
            this.Expense_Type_Name_LabelControl.Name = "Expense_Type_Name_LabelControl";
            this.Expense_Type_Name_LabelControl.Size = new System.Drawing.Size(15, 13);
            this.Expense_Type_Name_LabelControl.TabIndex = 2;
            this.Expense_Type_Name_LabelControl.Text = "Adı";
            // 
            // Expense_Type_Code_TextEdit
            // 
            this.Expense_Type_Code_TextEdit.Location = new System.Drawing.Point(48, 33);
            this.Expense_Type_Code_TextEdit.Name = "Expense_Type_Code_TextEdit";
            this.Expense_Type_Code_TextEdit.Size = new System.Drawing.Size(119, 20);
            this.Expense_Type_Code_TextEdit.TabIndex = 1;
            // 
            // Expense_Type_Code_LabelControl
            // 
            this.Expense_Type_Code_LabelControl.Location = new System.Drawing.Point(14, 36);
            this.Expense_Type_Code_LabelControl.Name = "Expense_Type_Code_LabelControl";
            this.Expense_Type_Code_LabelControl.Size = new System.Drawing.Size(24, 13);
            this.Expense_Type_Code_LabelControl.TabIndex = 0;
            this.Expense_Type_Code_LabelControl.Text = "Kodu";
            // 
            // Expense_Type_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 507);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.Department_GroupControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Expense_Type_Form";
            this.Text = "Harcama Türü Form";
            this.Load += new System.EventHandler(this.Expense_Type_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Actions_GroupControl)).EndInit();
            this.Actions_GroupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Expense_Type_GridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Department_GroupControl)).EndInit();
            this.Department_GroupControl.ResumeLayout(false);
            this.Department_GroupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Expense_Type_Description_MemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Expense_Type_Name_TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Expense_Type_Code_TextEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl Actions_GroupControl;
        private DevExpress.XtraEditors.SimpleButton Delete_SimpleButton;
        private DevExpress.XtraEditors.SimpleButton Save_SimpleButton;
        private DevExpress.XtraEditors.SimpleButton Close_SimpleButton;
        private DevExpress.XtraGrid.GridControl Expense_Type_GridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn Expense_Type_Code;
        private DevExpress.XtraGrid.Columns.GridColumn Expense_Type_Name;
        private DevExpress.XtraGrid.Columns.GridColumn Expense_Type_Description_GridColumn;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl Expense_Type_Description_LabelControl;
        private DevExpress.XtraEditors.GroupControl Department_GroupControl;
        private DevExpress.XtraEditors.MemoEdit Expense_Type_Description_MemoEdit;
        private DevExpress.XtraEditors.TextEdit Expense_Type_Name_TextEdit;
        private DevExpress.XtraEditors.LabelControl Expense_Type_Name_LabelControl;
        private DevExpress.XtraEditors.TextEdit Expense_Type_Code_TextEdit;
        private DevExpress.XtraEditors.LabelControl Expense_Type_Code_LabelControl;
        private DevExpress.XtraEditors.SimpleButton Clean_SimpleButton;
    }
}