namespace Dentas_Pro.UI.User
{

    partial class Wating_Annual_Approval_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Wating_Annual_Approval_Form));
            this.Department_GroupControl = new DevExpress.XtraEditors.GroupControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.Department_Description_MemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.Department_Name_TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.Department_Code_TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.Delete_SimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.Close_SimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.Save_SimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.Actions_GroupControl = new DevExpress.XtraEditors.GroupControl();
            this.Clean_The_Control_Value_SimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.Department_GridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Department_Code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Departman_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DescriptionGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Department_GroupControl)).BeginInit();
            this.Department_GroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Department_Description_MemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Department_Name_TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Department_Code_TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Actions_GroupControl)).BeginInit();
            this.Actions_GroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Department_GridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Department_GroupControl
            // 
            this.Department_GroupControl.Controls.Add(this.labelControl3);
            this.Department_GroupControl.Controls.Add(this.Department_Description_MemoEdit);
            this.Department_GroupControl.Controls.Add(this.Department_Name_TextEdit);
            this.Department_GroupControl.Controls.Add(this.labelControl2);
            this.Department_GroupControl.Controls.Add(this.Department_Code_TextEdit);
            this.Department_GroupControl.Controls.Add(this.labelControl1);
            this.Department_GroupControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.Department_GroupControl.Location = new System.Drawing.Point(0, 0);
            this.Department_GroupControl.Name = "Department_GroupControl";
            this.Department_GroupControl.Size = new System.Drawing.Size(368, 125);
            this.Department_GroupControl.TabIndex = 0;
            this.Department_GroupControl.Text = "Departman";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(174, 36);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(41, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Açıklama";
            // 
            // Department_Description_MemoEdit
            // 
            this.Department_Description_MemoEdit.Location = new System.Drawing.Point(221, 25);
            this.Department_Description_MemoEdit.Name = "Department_Description_MemoEdit";
            this.Department_Description_MemoEdit.Size = new System.Drawing.Size(140, 69);
            this.Department_Description_MemoEdit.TabIndex = 4;
            // 
            // Department_Name_TextEdit
            // 
            this.Department_Name_TextEdit.Location = new System.Drawing.Point(48, 74);
            this.Department_Name_TextEdit.Name = "Department_Name_TextEdit";
            this.Department_Name_TextEdit.Size = new System.Drawing.Size(119, 20);
            this.Department_Name_TextEdit.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(14, 77);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(15, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Adı";
            // 
            // Department_Code_TextEdit
            // 
            this.Department_Code_TextEdit.Location = new System.Drawing.Point(48, 33);
            this.Department_Code_TextEdit.Name = "Department_Code_TextEdit";
            this.Department_Code_TextEdit.Size = new System.Drawing.Size(119, 20);
            this.Department_Code_TextEdit.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(14, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Kodu";
            // 
            // Delete_SimpleButton
            // 
            this.Delete_SimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Delete_SimpleButton.Image = global::Dentas_Pro.UI.Properties.Resources.Sil_buton_32X32;
            this.Delete_SimpleButton.Location = new System.Drawing.Point(285, 27);
            this.Delete_SimpleButton.Name = "Delete_SimpleButton";
            this.Delete_SimpleButton.Size = new System.Drawing.Size(75, 37);
            this.Delete_SimpleButton.TabIndex = 6;
            this.Delete_SimpleButton.Text = "Sil";
            this.Delete_SimpleButton.Click += new System.EventHandler(this.Delete_SimpleButton_Click);
            // 
            // Close_SimpleButton
            // 
            this.Close_SimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Close_SimpleButton.Image = global::Dentas_Pro.UI.Properties.Resources.Kapat_buton_32X32;
            this.Close_SimpleButton.Location = new System.Drawing.Point(202, 25);
            this.Close_SimpleButton.Name = "Close_SimpleButton";
            this.Close_SimpleButton.Size = new System.Drawing.Size(75, 41);
            this.Close_SimpleButton.TabIndex = 5;
            this.Close_SimpleButton.Text = "Kapat";
            this.Close_SimpleButton.Click += new System.EventHandler(this.Close_SimpleButton_Click);
            // 
            // Save_SimpleButton
            // 
            this.Save_SimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Save_SimpleButton.Image = global::Dentas_Pro.UI.Properties.Resources.Kaydet_buton_32X32;
            this.Save_SimpleButton.Location = new System.Drawing.Point(112, 27);
            this.Save_SimpleButton.Name = "Save_SimpleButton";
            this.Save_SimpleButton.Size = new System.Drawing.Size(81, 37);
            this.Save_SimpleButton.TabIndex = 4;
            this.Save_SimpleButton.Text = "Kaydet";
            this.Save_SimpleButton.Click += new System.EventHandler(this.Save_SimpleButton_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.Actions_GroupControl);
            this.groupControl2.Controls.Add(this.Department_GridControl);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 125);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(368, 338);
            this.groupControl2.TabIndex = 1;
            // 
            // Actions_GroupControl
            // 
            this.Actions_GroupControl.Controls.Add(this.Clean_The_Control_Value_SimpleButton);
            this.Actions_GroupControl.Controls.Add(this.Delete_SimpleButton);
            this.Actions_GroupControl.Controls.Add(this.Save_SimpleButton);
            this.Actions_GroupControl.Controls.Add(this.Close_SimpleButton);
            this.Actions_GroupControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Actions_GroupControl.Location = new System.Drawing.Point(2, 265);
            this.Actions_GroupControl.Name = "Actions_GroupControl";
            this.Actions_GroupControl.Size = new System.Drawing.Size(364, 71);
            this.Actions_GroupControl.TabIndex = 1;
            this.Actions_GroupControl.Text = "İşlemler";
            // 
            // Clean_The_Control_Value_SimpleButton
            // 
            this.Clean_The_Control_Value_SimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Clean_The_Control_Value_SimpleButton.Image = global::Dentas_Pro.UI.Properties.Resources.Clean_button_32_32;
            this.Clean_The_Control_Value_SimpleButton.Location = new System.Drawing.Point(3, 29);
            this.Clean_The_Control_Value_SimpleButton.Name = "Clean_The_Control_Value_SimpleButton";
            this.Clean_The_Control_Value_SimpleButton.Size = new System.Drawing.Size(81, 37);
            this.Clean_The_Control_Value_SimpleButton.TabIndex = 7;
            this.Clean_The_Control_Value_SimpleButton.Text = "Temizle";
            this.Clean_The_Control_Value_SimpleButton.Click += new System.EventHandler(this.Clean_The_Control_Value_SimpleButton_Click);
            // 
            // Department_GridControl
            // 
            this.Department_GridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Department_GridControl.Location = new System.Drawing.Point(2, 22);
            this.Department_GridControl.MainView = this.gridView1;
            this.Department_GridControl.Name = "Department_GridControl";
            this.Department_GridControl.Size = new System.Drawing.Size(364, 237);
            this.Department_GridControl.TabIndex = 0;
            this.Department_GridControl.UseEmbeddedNavigator = true;
            this.Department_GridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.Department_Code,
            this.Departman_Name,
            this.DescriptionGridColumn});
            this.gridView1.GridControl = this.Department_GridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // Id
            // 
            this.Id.Caption = "Id";
            this.Id.FieldName = "Obj_Id";
            this.Id.Name = "Id";
            this.Id.OptionsColumn.FixedWidth = true;
            // 
            // Department_Code
            // 
            this.Department_Code.Caption = "Departman Kodu";
            this.Department_Code.FieldName = "Code";
            this.Department_Code.Name = "Department_Code";
            this.Department_Code.OptionsColumn.AllowEdit = false;
            this.Department_Code.OptionsColumn.AllowFocus = false;
            this.Department_Code.OptionsColumn.FixedWidth = true;
            this.Department_Code.Visible = true;
            this.Department_Code.VisibleIndex = 0;
            this.Department_Code.Width = 53;
            // 
            // Departman_Name
            // 
            this.Departman_Name.Caption = "Departman Adı";
            this.Departman_Name.FieldName = "Name";
            this.Departman_Name.Name = "Departman_Name";
            this.Departman_Name.OptionsColumn.AllowEdit = false;
            this.Departman_Name.OptionsColumn.AllowFocus = false;
            this.Departman_Name.OptionsColumn.FixedWidth = true;
            this.Departman_Name.Visible = true;
            this.Departman_Name.VisibleIndex = 1;
            this.Departman_Name.Width = 49;
            // 
            // DescriptionGridColumn
            // 
            this.DescriptionGridColumn.Caption = "Açıklama";
            this.DescriptionGridColumn.FieldName = "Description";
            this.DescriptionGridColumn.Name = "DescriptionGridColumn";
            this.DescriptionGridColumn.OptionsColumn.AllowEdit = false;
            this.DescriptionGridColumn.OptionsColumn.AllowFocus = false;
            this.DescriptionGridColumn.OptionsColumn.FixedWidth = true;
            this.DescriptionGridColumn.Visible = true;
            this.DescriptionGridColumn.VisibleIndex = 2;
            this.DescriptionGridColumn.Width = 150;
            // 
            // Department_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 463);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.Department_GroupControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Department_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Departman Kayıt Formu";
            this.Load += new System.EventHandler(this.User_Departman_Register_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Department_GroupControl)).EndInit();
            this.Department_GroupControl.ResumeLayout(false);
            this.Department_GroupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Department_Description_MemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Department_Name_TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Department_Code_TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Actions_GroupControl)).EndInit();
            this.Actions_GroupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Department_GridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl Department_GroupControl;
        private DevExpress.XtraEditors.SimpleButton Delete_SimpleButton;
        private DevExpress.XtraEditors.SimpleButton Close_SimpleButton;
        private DevExpress.XtraEditors.SimpleButton Save_SimpleButton;
        private DevExpress.XtraEditors.TextEdit Department_Name_TextEdit;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit Department_Code_TextEdit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl Department_GridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl Actions_GroupControl;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn Department_Code;
        private DevExpress.XtraGrid.Columns.GridColumn Departman_Name;
        private DevExpress.XtraEditors.MemoEdit Department_Description_MemoEdit;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.Columns.GridColumn DescriptionGridColumn;
        private DevExpress.XtraEditors.SimpleButton Clean_The_Control_Value_SimpleButton;
    }
}