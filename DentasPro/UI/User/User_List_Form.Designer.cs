﻿namespace Dentas_Pro.UI.User
{
    partial class User_List_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_List_Form));
            this.Search_SimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.User_List_GridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Clean_SimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.User_Citizen_Id_TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.User_Name_TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.Registration_Number_TextEdit = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.User_List_GridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.User_Citizen_Id_TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.User_Name_TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Registration_Number_TextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Search_SimpleButton
            // 
            this.Search_SimpleButton.Image = global::Dentas_Pro.UI.Properties.Resources.Search_32_32;
            this.Search_SimpleButton.Location = new System.Drawing.Point(2, 190);
            this.Search_SimpleButton.Name = "Search_SimpleButton";
            this.Search_SimpleButton.Size = new System.Drawing.Size(85, 33);
            this.Search_SimpleButton.TabIndex = 6;
            this.Search_SimpleButton.Text = "Ara";
            // 
            // User_List_GridControl
            // 
            this.User_List_GridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.User_List_GridControl.Location = new System.Drawing.Point(0, 0);
            this.User_List_GridControl.MainView = this.gridView1;
            this.User_List_GridControl.Name = "User_List_GridControl";
            this.User_List_GridControl.Size = new System.Drawing.Size(543, 387);
            this.User_List_GridControl.TabIndex = 0;
            this.User_List_GridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.User_List_GridControl.Load += new System.EventHandler(this.User_List_GridControl_Load);
            this.User_List_GridControl.DoubleClick += new System.EventHandler(this.User_List_GridControl_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.User_List_GridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.ClearFindOnClose = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // Clean_SimpleButton
            // 
            this.Clean_SimpleButton.Image = global::Dentas_Pro.UI.Properties.Resources.Temizle_32_32;
            this.Clean_SimpleButton.Location = new System.Drawing.Point(93, 190);
            this.Clean_SimpleButton.Name = "Clean_SimpleButton";
            this.Clean_SimpleButton.Size = new System.Drawing.Size(85, 33);
            this.Clean_SimpleButton.TabIndex = 7;
            this.Clean_SimpleButton.Text = "Temizle";
            // 
            // User_Citizen_Id_TextEdit
            // 
            this.User_Citizen_Id_TextEdit.EditValue = " ";
            this.User_Citizen_Id_TextEdit.Location = new System.Drawing.Point(22, 150);
            this.User_Citizen_Id_TextEdit.Name = "User_Citizen_Id_TextEdit";
            this.User_Citizen_Id_TextEdit.Size = new System.Drawing.Size(116, 20);
            this.User_Citizen_Id_TextEdit.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(26, 131);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(55, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Tc Kimlik No";
            // 
            // User_Name_TextEdit
            // 
            this.User_Name_TextEdit.Location = new System.Drawing.Point(22, 99);
            this.User_Name_TextEdit.Name = "User_Name_TextEdit";
            this.User_Name_TextEdit.Size = new System.Drawing.Size(116, 20);
            this.User_Name_TextEdit.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(26, 29);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(88, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Personel Sicil Kodu";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.xtraTabControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.User_List_GridControl);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(734, 387);
            this.splitContainerControl1.SplitterPosition = 186;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(186, 387);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.Clean_SimpleButton);
            this.xtraTabPage1.Controls.Add(this.Search_SimpleButton);
            this.xtraTabPage1.Controls.Add(this.User_Citizen_Id_TextEdit);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.User_Name_TextEdit);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.Registration_Number_TextEdit);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(180, 359);
            this.xtraTabPage1.Text = "Arama";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(26, 80);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(59, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Personel Adı";
            // 
            // Registration_Number_TextEdit
            // 
            this.Registration_Number_TextEdit.Location = new System.Drawing.Point(22, 48);
            this.Registration_Number_TextEdit.Name = "Registration_Number_TextEdit";
            this.Registration_Number_TextEdit.Size = new System.Drawing.Size(116, 20);
            this.Registration_Number_TextEdit.TabIndex = 1;
            // 
            // User_List_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 387);
            this.Controls.Add(this.splitContainerControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "User_List_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Listesi Formu";
            this.Load += new System.EventHandler(this.User_List_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.User_List_GridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.User_Citizen_Id_TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.User_Name_TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Registration_Number_TextEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton Search_SimpleButton;
        private DevExpress.XtraGrid.GridControl User_List_GridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton Clean_SimpleButton;
        private DevExpress.XtraEditors.TextEdit User_Citizen_Id_TextEdit;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit User_Name_TextEdit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit Registration_Number_TextEdit;
    }
}