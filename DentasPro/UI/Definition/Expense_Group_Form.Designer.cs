namespace Dentas_Pro.UI.Definition
{
    partial class Expense_Group_Form
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
            this.Actions_GroupControl = new DevExpress.XtraEditors.GroupControl();
            this.Delete_SimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.Save_SimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.Close_SimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.Expense_Code_TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Expense_GridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Department_Code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Departman_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DescriptionGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.Expense_Description_LabelControl = new DevExpress.XtraEditors.LabelControl();
            this.Expense_Description_MemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.Department_GroupControl = new DevExpress.XtraEditors.GroupControl();
            this.Expense_Name_TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Expense_Name_LabelControl = new DevExpress.XtraEditors.LabelControl();
            this.Expense_Code_LabelControl = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.Actions_GroupControl)).BeginInit();
            this.Actions_GroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Expense_Code_TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Expense_GridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Expense_Description_MemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Department_GroupControl)).BeginInit();
            this.Department_GroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Expense_Name_TextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Actions_GroupControl
            // 
            this.Actions_GroupControl.Controls.Add(this.Delete_SimpleButton);
            this.Actions_GroupControl.Controls.Add(this.Save_SimpleButton);
            this.Actions_GroupControl.Controls.Add(this.Close_SimpleButton);
            this.Actions_GroupControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Actions_GroupControl.Location = new System.Drawing.Point(2, 315);
            this.Actions_GroupControl.Name = "Actions_GroupControl";
            this.Actions_GroupControl.Size = new System.Drawing.Size(373, 71);
            this.Actions_GroupControl.TabIndex = 1;
            this.Actions_GroupControl.Text = "İşlemler";
            // 
            // Delete_SimpleButton
            // 
            this.Delete_SimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Delete_SimpleButton.Image = global::Dentas_Pro.UI.Properties.Resources.Sil_buton_32X32;
            this.Delete_SimpleButton.Location = new System.Drawing.Point(284, 27);
            this.Delete_SimpleButton.Name = "Delete_SimpleButton";
            this.Delete_SimpleButton.Size = new System.Drawing.Size(75, 37);
            this.Delete_SimpleButton.TabIndex = 6;
            this.Delete_SimpleButton.Text = "Sil";
            this.Delete_SimpleButton.Click += new System.EventHandler(this.Delete_SimpleButton_Click_1);
            // 
            // Save_SimpleButton
            // 
            this.Save_SimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Save_SimpleButton.Image = global::Dentas_Pro.UI.Properties.Resources.Kaydet_buton_32X32;
            this.Save_SimpleButton.Location = new System.Drawing.Point(50, 27);
            this.Save_SimpleButton.Name = "Save_SimpleButton";
            this.Save_SimpleButton.Size = new System.Drawing.Size(81, 37);
            this.Save_SimpleButton.TabIndex = 4;
            this.Save_SimpleButton.Text = "Kaydet";
            this.Save_SimpleButton.Click += new System.EventHandler(this.Save_SimpleButton_Click_1);
            // 
            // Close_SimpleButton
            // 
            this.Close_SimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Close_SimpleButton.Image = global::Dentas_Pro.UI.Properties.Resources.Kapat_buton_32X32;
            this.Close_SimpleButton.Location = new System.Drawing.Point(168, 25);
            this.Close_SimpleButton.Name = "Close_SimpleButton";
            this.Close_SimpleButton.Size = new System.Drawing.Size(75, 41);
            this.Close_SimpleButton.TabIndex = 5;
            this.Close_SimpleButton.Text = "Kapat";
            this.Close_SimpleButton.Click += new System.EventHandler(this.Close_SimpleButton_Click_1);
            // 
            // Expense_Code_TextEdit
            // 
            this.Expense_Code_TextEdit.Location = new System.Drawing.Point(48, 33);
            this.Expense_Code_TextEdit.Name = "Expense_Code_TextEdit";
            this.Expense_Code_TextEdit.Size = new System.Drawing.Size(119, 20);
            this.Expense_Code_TextEdit.TabIndex = 1;
            // 
            // Expense_GridControl
            // 
            this.Expense_GridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Expense_GridControl.Location = new System.Drawing.Point(2, 22);
            this.Expense_GridControl.MainView = this.gridView1;
            this.Expense_GridControl.Name = "Expense_GridControl";
            this.Expense_GridControl.Size = new System.Drawing.Size(373, 364);
            this.Expense_GridControl.TabIndex = 0;
            this.Expense_GridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.Department_Code,
            this.Departman_Name,
            this.DescriptionGridColumn});
            this.gridView1.GridControl = this.Expense_GridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick_1);
            // 
            // Id
            // 
            this.Id.Caption = "Id";
            this.Id.FieldName = "Obj_Id";
            this.Id.Name = "Id";
            // 
            // Department_Code
            // 
            this.Department_Code.Caption = "Harcama Grubu Kodu";
            this.Department_Code.FieldName = "Code";
            this.Department_Code.Name = "Department_Code";
            this.Department_Code.OptionsColumn.AllowEdit = false;
            this.Department_Code.OptionsColumn.AllowFocus = false;
            this.Department_Code.OptionsColumn.FixedWidth = true;
            this.Department_Code.Visible = true;
            this.Department_Code.VisibleIndex = 0;
            this.Department_Code.Width = 30;
            // 
            // Departman_Name
            // 
            this.Departman_Name.Caption = "Harcama Grubu Adı";
            this.Departman_Name.FieldName = "Name";
            this.Departman_Name.Name = "Departman_Name";
            this.Departman_Name.OptionsColumn.AllowEdit = false;
            this.Departman_Name.OptionsColumn.AllowFocus = false;
            this.Departman_Name.OptionsColumn.FixedWidth = true;
            this.Departman_Name.Visible = true;
            this.Departman_Name.VisibleIndex = 1;
            this.Departman_Name.Width = 50;
            // 
            // DescriptionGridColumn
            // 
            this.DescriptionGridColumn.Caption = "Açıklama";
            this.DescriptionGridColumn.FieldName = "Description";
            this.DescriptionGridColumn.MinWidth = 200;
            this.DescriptionGridColumn.Name = "DescriptionGridColumn";
            this.DescriptionGridColumn.OptionsColumn.AllowEdit = false;
            this.DescriptionGridColumn.OptionsColumn.AllowFocus = false;
            this.DescriptionGridColumn.OptionsColumn.FixedWidth = true;
            this.DescriptionGridColumn.Visible = true;
            this.DescriptionGridColumn.VisibleIndex = 2;
            this.DescriptionGridColumn.Width = 100;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.Actions_GroupControl);
            this.groupControl2.Controls.Add(this.Expense_GridControl);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 108);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(377, 388);
            this.groupControl2.TabIndex = 3;
            // 
            // Expense_Description_LabelControl
            // 
            this.Expense_Description_LabelControl.Location = new System.Drawing.Point(174, 36);
            this.Expense_Description_LabelControl.Name = "Expense_Description_LabelControl";
            this.Expense_Description_LabelControl.Size = new System.Drawing.Size(41, 13);
            this.Expense_Description_LabelControl.TabIndex = 5;
            this.Expense_Description_LabelControl.Text = "Açıklama";
            // 
            // Expense_Description_MemoEdit
            // 
            this.Expense_Description_MemoEdit.Location = new System.Drawing.Point(221, 25);
            this.Expense_Description_MemoEdit.Name = "Expense_Description_MemoEdit";
            this.Expense_Description_MemoEdit.Size = new System.Drawing.Size(151, 69);
            this.Expense_Description_MemoEdit.TabIndex = 4;
            // 
            // Department_GroupControl
            // 
            this.Department_GroupControl.Controls.Add(this.Expense_Description_LabelControl);
            this.Department_GroupControl.Controls.Add(this.Expense_Description_MemoEdit);
            this.Department_GroupControl.Controls.Add(this.Expense_Name_TextEdit);
            this.Department_GroupControl.Controls.Add(this.Expense_Name_LabelControl);
            this.Department_GroupControl.Controls.Add(this.Expense_Code_TextEdit);
            this.Department_GroupControl.Controls.Add(this.Expense_Code_LabelControl);
            this.Department_GroupControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.Department_GroupControl.Location = new System.Drawing.Point(0, 0);
            this.Department_GroupControl.Name = "Department_GroupControl";
            this.Department_GroupControl.Size = new System.Drawing.Size(377, 108);
            this.Department_GroupControl.TabIndex = 2;
            this.Department_GroupControl.Text = "Harcama";
            // 
            // Expense_Name_TextEdit
            // 
            this.Expense_Name_TextEdit.Location = new System.Drawing.Point(48, 74);
            this.Expense_Name_TextEdit.Name = "Expense_Name_TextEdit";
            this.Expense_Name_TextEdit.Size = new System.Drawing.Size(119, 20);
            this.Expense_Name_TextEdit.TabIndex = 3;
            // 
            // Expense_Name_LabelControl
            // 
            this.Expense_Name_LabelControl.Location = new System.Drawing.Point(14, 77);
            this.Expense_Name_LabelControl.Name = "Expense_Name_LabelControl";
            this.Expense_Name_LabelControl.Size = new System.Drawing.Size(15, 13);
            this.Expense_Name_LabelControl.TabIndex = 2;
            this.Expense_Name_LabelControl.Text = "Adı";
            // 
            // Expense_Code_LabelControl
            // 
            this.Expense_Code_LabelControl.Location = new System.Drawing.Point(14, 36);
            this.Expense_Code_LabelControl.Name = "Expense_Code_LabelControl";
            this.Expense_Code_LabelControl.Size = new System.Drawing.Size(24, 13);
            this.Expense_Code_LabelControl.TabIndex = 0;
            this.Expense_Code_LabelControl.Text = "Kodu";
            // 
            // Expense_Group_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 496);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.Department_GroupControl);
            this.Name = "Expense_Group_Form";
            this.Text = "Harcama ve Gurup Tanım Formu";
            this.Load += new System.EventHandler(this.Expense_Group_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Actions_GroupControl)).EndInit();
            this.Actions_GroupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Expense_Code_TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Expense_GridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Expense_Description_MemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Department_GroupControl)).EndInit();
            this.Department_GroupControl.ResumeLayout(false);
            this.Department_GroupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Expense_Name_TextEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl Actions_GroupControl;
        private DevExpress.XtraEditors.SimpleButton Delete_SimpleButton;
        private DevExpress.XtraEditors.SimpleButton Save_SimpleButton;
        private DevExpress.XtraEditors.SimpleButton Close_SimpleButton;
        private DevExpress.XtraEditors.TextEdit Expense_Code_TextEdit;
        private DevExpress.XtraGrid.GridControl Expense_GridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn Department_Code;
        private DevExpress.XtraGrid.Columns.GridColumn Departman_Name;
        private DevExpress.XtraGrid.Columns.GridColumn DescriptionGridColumn;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl Expense_Description_LabelControl;
        private DevExpress.XtraEditors.MemoEdit Expense_Description_MemoEdit;
        private DevExpress.XtraEditors.GroupControl Department_GroupControl;
        private DevExpress.XtraEditors.TextEdit Expense_Name_TextEdit;
        private DevExpress.XtraEditors.LabelControl Expense_Name_LabelControl;
        private DevExpress.XtraEditors.LabelControl Expense_Code_LabelControl;
    }
}