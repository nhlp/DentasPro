namespace Dentas_Pro.UI.User
{
    partial class Permit_Reason_Form
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
            this.Permit_Type_GroupControl = new DevExpress.XtraEditors.GroupControl();
            this.Description_LabelControl = new DevExpress.XtraEditors.LabelControl();
            this.Permit_Reason_Description_MemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.Permit_Reason_Name_TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Permit_Reason_Code_TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.Action_GroupControl = new DevExpress.XtraEditors.GroupControl();
            this.Delete_SimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.Save_SimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.Close_SimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.Permit_Reason_GridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id_GridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Code_GridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Name_GridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DescriptionGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Permit_Type_GroupControl)).BeginInit();
            this.Permit_Type_GroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Permit_Reason_Description_MemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Permit_Reason_Name_TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Permit_Reason_Code_TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Action_GroupControl)).BeginInit();
            this.Action_GroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Permit_Reason_GridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Permit_Type_GroupControl
            // 
            this.Permit_Type_GroupControl.Controls.Add(this.Description_LabelControl);
            this.Permit_Type_GroupControl.Controls.Add(this.Permit_Reason_Description_MemoEdit);
            this.Permit_Type_GroupControl.Controls.Add(this.Permit_Reason_Name_TextEdit);
            this.Permit_Type_GroupControl.Controls.Add(this.Permit_Reason_Code_TextEdit);
            this.Permit_Type_GroupControl.Controls.Add(this.labelControl2);
            this.Permit_Type_GroupControl.Controls.Add(this.labelControl1);
            this.Permit_Type_GroupControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.Permit_Type_GroupControl.Location = new System.Drawing.Point(0, 0);
            this.Permit_Type_GroupControl.Name = "Permit_Type_GroupControl";
            this.Permit_Type_GroupControl.Size = new System.Drawing.Size(369, 100);
            this.Permit_Type_GroupControl.TabIndex = 0;
            this.Permit_Type_GroupControl.Text = "İzin Tür";
            // 
            // Description_LabelControl
            // 
            this.Description_LabelControl.Location = new System.Drawing.Point(167, 35);
            this.Description_LabelControl.Name = "Description_LabelControl";
            this.Description_LabelControl.Size = new System.Drawing.Size(41, 13);
            this.Description_LabelControl.TabIndex = 5;
            this.Description_LabelControl.Text = "Açıklama";
            // 
            // Permit_Reason_Description_MemoEdit
            // 
            this.Permit_Reason_Description_MemoEdit.Location = new System.Drawing.Point(219, 26);
            this.Permit_Reason_Description_MemoEdit.Name = "Permit_Reason_Description_MemoEdit";
            this.Permit_Reason_Description_MemoEdit.Size = new System.Drawing.Size(138, 70);
            this.Permit_Reason_Description_MemoEdit.TabIndex = 4;
            // 
            // Permit_Reason_Name_TextEdit
            // 
            this.Permit_Reason_Name_TextEdit.Location = new System.Drawing.Point(39, 69);
            this.Permit_Reason_Name_TextEdit.Name = "Permit_Reason_Name_TextEdit";
            this.Permit_Reason_Name_TextEdit.Size = new System.Drawing.Size(100, 20);
            this.Permit_Reason_Name_TextEdit.TabIndex = 3;
            // 
            // Permit_Reason_Code_TextEdit
            // 
            this.Permit_Reason_Code_TextEdit.Location = new System.Drawing.Point(39, 32);
            this.Permit_Reason_Code_TextEdit.Name = "Permit_Reason_Code_TextEdit";
            this.Permit_Reason_Code_TextEdit.Size = new System.Drawing.Size(100, 20);
            this.Permit_Reason_Code_TextEdit.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(5, 72);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(15, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Adı";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Kodu";
            // 
            // Action_GroupControl
            // 
            this.Action_GroupControl.Controls.Add(this.Delete_SimpleButton);
            this.Action_GroupControl.Controls.Add(this.Save_SimpleButton);
            this.Action_GroupControl.Controls.Add(this.Close_SimpleButton);
            this.Action_GroupControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Action_GroupControl.Location = new System.Drawing.Point(0, 385);
            this.Action_GroupControl.Name = "Action_GroupControl";
            this.Action_GroupControl.Size = new System.Drawing.Size(369, 74);
            this.Action_GroupControl.TabIndex = 1;
            this.Action_GroupControl.Text = "İşlemler";
            // 
            // Delete_SimpleButton
            // 
            this.Delete_SimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Delete_SimpleButton.Image = global::Dentas_Pro.UI.Properties.Resources.Sil_buton_32X32;
            this.Delete_SimpleButton.Location = new System.Drawing.Point(286, 28);
            this.Delete_SimpleButton.Name = "Delete_SimpleButton";
            this.Delete_SimpleButton.Size = new System.Drawing.Size(75, 37);
            this.Delete_SimpleButton.TabIndex = 9;
            this.Delete_SimpleButton.Text = "Sil";
            this.Delete_SimpleButton.Click += new System.EventHandler(this.Delete_SimpleButton_Click);
            // 
            // Save_SimpleButton
            // 
            this.Save_SimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Save_SimpleButton.Image = global::Dentas_Pro.UI.Properties.Resources.Kaydet_buton_32X32;
            this.Save_SimpleButton.Location = new System.Drawing.Point(52, 28);
            this.Save_SimpleButton.Name = "Save_SimpleButton";
            this.Save_SimpleButton.Size = new System.Drawing.Size(81, 37);
            this.Save_SimpleButton.TabIndex = 7;
            this.Save_SimpleButton.Text = "Kaydet";
            this.Save_SimpleButton.Click += new System.EventHandler(this.Save_SimpleButton_Click);
            // 
            // Close_SimpleButton
            // 
            this.Close_SimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Close_SimpleButton.Image = global::Dentas_Pro.UI.Properties.Resources.Kapat_buton_32X32;
            this.Close_SimpleButton.Location = new System.Drawing.Point(170, 26);
            this.Close_SimpleButton.Name = "Close_SimpleButton";
            this.Close_SimpleButton.Size = new System.Drawing.Size(75, 41);
            this.Close_SimpleButton.TabIndex = 8;
            this.Close_SimpleButton.Text = "Kapat";
            this.Close_SimpleButton.Click += new System.EventHandler(this.Close_SimpleButton_Click);
            // 
            // Permit_Reason_GridControl
            // 
            this.Permit_Reason_GridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Permit_Reason_GridControl.Location = new System.Drawing.Point(0, 100);
            this.Permit_Reason_GridControl.MainView = this.gridView1;
            this.Permit_Reason_GridControl.Name = "Permit_Reason_GridControl";
            this.Permit_Reason_GridControl.Size = new System.Drawing.Size(369, 285);
            this.Permit_Reason_GridControl.TabIndex = 2;
            this.Permit_Reason_GridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id_GridColumn,
            this.Code_GridColumn,
            this.Name_GridColumn,
            this.DescriptionGridColumn});
            this.gridView1.GridControl = this.Permit_Reason_GridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // Id_GridColumn
            // 
            this.Id_GridColumn.Caption = "Obj_Id";
            this.Id_GridColumn.FieldName = "Obj_Id";
            this.Id_GridColumn.Name = "Id_GridColumn";
            // 
            // Code_GridColumn
            // 
            this.Code_GridColumn.Caption = "İzin Tür Kodu";
            this.Code_GridColumn.FieldName = "Code";
            this.Code_GridColumn.Name = "Code_GridColumn";
            this.Code_GridColumn.OptionsColumn.AllowEdit = false;
            this.Code_GridColumn.OptionsColumn.AllowFocus = false;
            this.Code_GridColumn.OptionsColumn.FixedWidth = true;
            this.Code_GridColumn.Visible = true;
            this.Code_GridColumn.VisibleIndex = 0;
            this.Code_GridColumn.Width = 98;
            // 
            // Name_GridColumn
            // 
            this.Name_GridColumn.Caption = "İzin Tür Adı";
            this.Name_GridColumn.FieldName = "Name";
            this.Name_GridColumn.Name = "Name_GridColumn";
            this.Name_GridColumn.OptionsColumn.AllowEdit = false;
            this.Name_GridColumn.OptionsColumn.AllowFocus = false;
            this.Name_GridColumn.OptionsColumn.FixedWidth = true;
            this.Name_GridColumn.Visible = true;
            this.Name_GridColumn.VisibleIndex = 1;
            this.Name_GridColumn.Width = 115;
            // 
            // DescriptionGridColumn
            // 
            this.DescriptionGridColumn.Caption = "Açıklama";
            this.DescriptionGridColumn.FieldName = "Description";
            this.DescriptionGridColumn.Name = "DescriptionGridColumn";
            this.DescriptionGridColumn.Visible = true;
            this.DescriptionGridColumn.VisibleIndex = 2;
            this.DescriptionGridColumn.Width = 138;
            // 
            // Permit_Reason_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 459);
            this.Controls.Add(this.Permit_Reason_GridControl);
            this.Controls.Add(this.Action_GroupControl);
            this.Controls.Add(this.Permit_Type_GroupControl);
            this.Name = "Permit_Reason_Form";
            this.Text = "İzin Tür Form";
            this.Load += new System.EventHandler(this.Permit_Type_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Permit_Type_GroupControl)).EndInit();
            this.Permit_Type_GroupControl.ResumeLayout(false);
            this.Permit_Type_GroupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Permit_Reason_Description_MemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Permit_Reason_Name_TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Permit_Reason_Code_TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Action_GroupControl)).EndInit();
            this.Action_GroupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Permit_Reason_GridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl Permit_Type_GroupControl;
        private DevExpress.XtraEditors.GroupControl Action_GroupControl;
        private DevExpress.XtraGrid.GridControl Permit_Reason_GridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton Delete_SimpleButton;
        private DevExpress.XtraEditors.SimpleButton Save_SimpleButton;
        private DevExpress.XtraEditors.SimpleButton Close_SimpleButton;
        private DevExpress.XtraEditors.MemoEdit Permit_Reason_Description_MemoEdit;
        private DevExpress.XtraEditors.TextEdit Permit_Reason_Name_TextEdit;
        private DevExpress.XtraEditors.TextEdit Permit_Reason_Code_TextEdit;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl Description_LabelControl;
        private DevExpress.XtraGrid.Columns.GridColumn Id_GridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn Code_GridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn Name_GridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn DescriptionGridColumn;
    }
}