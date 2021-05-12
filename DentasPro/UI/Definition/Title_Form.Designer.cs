namespace Dentas_Pro.UI.User
{
    partial class Title_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Title_Form));
            this.Title_GroupControl = new DevExpress.XtraEditors.GroupControl();
            this.Title_Description_LabelControl = new DevExpress.XtraEditors.LabelControl();
            this.Title_Description_MemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.Title_Name_TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Title_Name_LabelControl = new DevExpress.XtraEditors.LabelControl();
            this.Title_Code_TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Title_Code_LabelControl = new DevExpress.XtraEditors.LabelControl();
            this.Action_GroupControl = new DevExpress.XtraEditors.GroupControl();
            this.Delete_SimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.Save_SimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.Close_SimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.Title_GridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Obj_Id_GridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Code_GridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Name_GridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Description_GridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Title_GroupControl)).BeginInit();
            this.Title_GroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Title_Description_MemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Title_Name_TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Title_Code_TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Action_GroupControl)).BeginInit();
            this.Action_GroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Title_GridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Title_GroupControl
            // 
            this.Title_GroupControl.Controls.Add(this.Title_Description_LabelControl);
            this.Title_GroupControl.Controls.Add(this.Title_Description_MemoEdit);
            this.Title_GroupControl.Controls.Add(this.Title_Name_TextEdit);
            this.Title_GroupControl.Controls.Add(this.Title_Name_LabelControl);
            this.Title_GroupControl.Controls.Add(this.Title_Code_TextEdit);
            this.Title_GroupControl.Controls.Add(this.Title_Code_LabelControl);
            this.Title_GroupControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title_GroupControl.Location = new System.Drawing.Point(0, 0);
            this.Title_GroupControl.Name = "Title_GroupControl";
            this.Title_GroupControl.Size = new System.Drawing.Size(375, 100);
            this.Title_GroupControl.TabIndex = 0;
            this.Title_GroupControl.Text = "Ünvan";
            // 
            // Title_Description_LabelControl
            // 
            this.Title_Description_LabelControl.Location = new System.Drawing.Point(163, 34);
            this.Title_Description_LabelControl.Name = "Title_Description_LabelControl";
            this.Title_Description_LabelControl.Size = new System.Drawing.Size(41, 13);
            this.Title_Description_LabelControl.TabIndex = 5;
            this.Title_Description_LabelControl.Text = "Açıklama";
            // 
            // Title_Description_MemoEdit
            // 
            this.Title_Description_MemoEdit.Location = new System.Drawing.Point(210, 26);
            this.Title_Description_MemoEdit.Name = "Title_Description_MemoEdit";
            this.Title_Description_MemoEdit.Size = new System.Drawing.Size(146, 68);
            this.Title_Description_MemoEdit.TabIndex = 4;
            // 
            // Title_Name_TextEdit
            // 
            this.Title_Name_TextEdit.Location = new System.Drawing.Point(43, 66);
            this.Title_Name_TextEdit.Name = "Title_Name_TextEdit";
            this.Title_Name_TextEdit.Size = new System.Drawing.Size(100, 20);
            this.Title_Name_TextEdit.TabIndex = 3;
            // 
            // Title_Name_LabelControl
            // 
            this.Title_Name_LabelControl.Location = new System.Drawing.Point(12, 71);
            this.Title_Name_LabelControl.Name = "Title_Name_LabelControl";
            this.Title_Name_LabelControl.Size = new System.Drawing.Size(13, 13);
            this.Title_Name_LabelControl.TabIndex = 2;
            this.Title_Name_LabelControl.Text = "Ad";
            // 
            // Title_Code_TextEdit
            // 
            this.Title_Code_TextEdit.Location = new System.Drawing.Point(43, 31);
            this.Title_Code_TextEdit.Name = "Title_Code_TextEdit";
            this.Title_Code_TextEdit.Size = new System.Drawing.Size(100, 20);
            this.Title_Code_TextEdit.TabIndex = 1;
            // 
            // Title_Code_LabelControl
            // 
            this.Title_Code_LabelControl.Location = new System.Drawing.Point(12, 36);
            this.Title_Code_LabelControl.Name = "Title_Code_LabelControl";
            this.Title_Code_LabelControl.Size = new System.Drawing.Size(18, 13);
            this.Title_Code_LabelControl.TabIndex = 0;
            this.Title_Code_LabelControl.Text = "Kod";
            // 
            // Action_GroupControl
            // 
            this.Action_GroupControl.Controls.Add(this.Delete_SimpleButton);
            this.Action_GroupControl.Controls.Add(this.Save_SimpleButton);
            this.Action_GroupControl.Controls.Add(this.Close_SimpleButton);
            this.Action_GroupControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Action_GroupControl.Location = new System.Drawing.Point(0, 317);
            this.Action_GroupControl.Name = "Action_GroupControl";
            this.Action_GroupControl.Size = new System.Drawing.Size(375, 75);
            this.Action_GroupControl.TabIndex = 1;
            this.Action_GroupControl.Text = "İşlemler";
            // 
            // Delete_SimpleButton
            // 
            this.Delete_SimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Delete_SimpleButton.Image = global::Dentas_Pro.UI.Properties.Resources.Sil_buton_32X32;
            this.Delete_SimpleButton.Location = new System.Drawing.Point(286, 29);
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
            this.Save_SimpleButton.Location = new System.Drawing.Point(52, 29);
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
            this.Close_SimpleButton.Location = new System.Drawing.Point(170, 27);
            this.Close_SimpleButton.Name = "Close_SimpleButton";
            this.Close_SimpleButton.Size = new System.Drawing.Size(75, 41);
            this.Close_SimpleButton.TabIndex = 8;
            this.Close_SimpleButton.Text = "Kapat";
            this.Close_SimpleButton.Click += new System.EventHandler(this.Close_SimpleButton_Click);
            // 
            // Title_GridControl
            // 
            this.Title_GridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Title_GridControl.Location = new System.Drawing.Point(0, 100);
            this.Title_GridControl.MainView = this.gridView1;
            this.Title_GridControl.Name = "Title_GridControl";
            this.Title_GridControl.Size = new System.Drawing.Size(375, 217);
            this.Title_GridControl.TabIndex = 2;
            this.Title_GridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Obj_Id_GridColumn,
            this.Code_GridColumn,
            this.Name_GridColumn,
            this.Description_GridColumn});
            this.gridView1.GridControl = this.Title_GridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // Obj_Id_GridColumn
            // 
            this.Obj_Id_GridColumn.Caption = "Id";
            this.Obj_Id_GridColumn.FieldName = "Obj_Id";
            this.Obj_Id_GridColumn.Name = "Obj_Id_GridColumn";
            this.Obj_Id_GridColumn.OptionsColumn.AllowEdit = false;
            this.Obj_Id_GridColumn.OptionsColumn.AllowFocus = false;
            this.Obj_Id_GridColumn.OptionsColumn.FixedWidth = true;
            // 
            // Code_GridColumn
            // 
            this.Code_GridColumn.Caption = "Kodu";
            this.Code_GridColumn.FieldName = "Code";
            this.Code_GridColumn.Name = "Code_GridColumn";
            this.Code_GridColumn.Visible = true;
            this.Code_GridColumn.VisibleIndex = 0;
            this.Code_GridColumn.Width = 59;
            // 
            // Name_GridColumn
            // 
            this.Name_GridColumn.Caption = "Adı";
            this.Name_GridColumn.FieldName = "Name";
            this.Name_GridColumn.Name = "Name_GridColumn";
            this.Name_GridColumn.Visible = true;
            this.Name_GridColumn.VisibleIndex = 1;
            this.Name_GridColumn.Width = 92;
            // 
            // Description_GridColumn
            // 
            this.Description_GridColumn.Caption = "Açıklama";
            this.Description_GridColumn.FieldName = "Description";
            this.Description_GridColumn.Name = "Description_GridColumn";
            this.Description_GridColumn.Visible = true;
            this.Description_GridColumn.VisibleIndex = 2;
            this.Description_GridColumn.Width = 206;
            // 
            // Title_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 392);
            this.Controls.Add(this.Title_GridControl);
            this.Controls.Add(this.Action_GroupControl);
            this.Controls.Add(this.Title_GroupControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Title_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ünvan Kayıt Form";
            this.Load += new System.EventHandler(this.User_Title_Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Title_GroupControl)).EndInit();
            this.Title_GroupControl.ResumeLayout(false);
            this.Title_GroupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Title_Description_MemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Title_Name_TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Title_Code_TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Action_GroupControl)).EndInit();
            this.Action_GroupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Title_GridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl Title_GroupControl;
        private DevExpress.XtraEditors.GroupControl Action_GroupControl;
        private DevExpress.XtraGrid.GridControl Title_GridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton Delete_SimpleButton;
        private DevExpress.XtraEditors.SimpleButton Save_SimpleButton;
        private DevExpress.XtraEditors.SimpleButton Close_SimpleButton;
        private DevExpress.XtraEditors.MemoEdit Title_Description_MemoEdit;
        private DevExpress.XtraEditors.TextEdit Title_Name_TextEdit;
        private DevExpress.XtraEditors.LabelControl Title_Name_LabelControl;
        private DevExpress.XtraEditors.TextEdit Title_Code_TextEdit;
        private DevExpress.XtraEditors.LabelControl Title_Code_LabelControl;
        private DevExpress.XtraEditors.LabelControl Title_Description_LabelControl;
        private DevExpress.XtraGrid.Columns.GridColumn Obj_Id_GridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn Code_GridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn Name_GridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn Description_GridColumn;
    }
}