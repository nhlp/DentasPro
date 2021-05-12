namespace Dentas_Pro.UI.User
{
    partial class Annual_Permit_List_Form
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
            this.components = new System.ComponentModel.Container();
            this.fuGridControl1 = new Dentas_Pro.UI.WinControl.FuGridControl(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Preview_SimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.Permit_Approval_Situation_ComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.Department_Type_ComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.Department_Type_LabelControl = new DevExpress.XtraEditors.LabelControl();
            this.Permit_Type_ComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.Clean_SimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            ((System.ComponentModel.ISupportInitialize)(this.fuGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Permit_Approval_Situation_ComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Department_Type_ComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Permit_Type_ComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fuGridControl1
            // 
            this.fuGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fuGridControl1.FuAllowColumnMoving = true;
            this.fuGridControl1.FuAllowColumnResizing = true;
            this.fuGridControl1.FuAllowFilter = true;
            this.fuGridControl1.FuAllowIncrementalSearch = false;
            this.fuGridControl1.FuAllowRowSizing = false;
            this.fuGridControl1.FuAllowSort = true;
            this.fuGridControl1.FuColumnAutoWidth = true;
            this.fuGridControl1.FuEditable = true;
            this.fuGridControl1.FuMultiSelect = false;
            this.fuGridControl1.FuNewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
            this.fuGridControl1.FuShowAutoFilterRows = false;
            this.fuGridControl1.FuShowColumnHeaders = true;
            this.fuGridControl1.FuShowFooter = false;
            this.fuGridControl1.FuShowGroupPanel = true;
            this.fuGridControl1.FuShowHorzLines = true;
            this.fuGridControl1.FuShowVertLines = true;
            this.fuGridControl1.Location = new System.Drawing.Point(0, 0);
            this.fuGridControl1.MainView = this.gridView1;
            this.fuGridControl1.Name = "fuGridControl1";
            this.fuGridControl1.Size = new System.Drawing.Size(638, 439);
            this.fuGridControl1.TabIndex = 0;
            this.fuGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.fuGridControl1.Load += new System.EventHandler(this.fuGridControl1_Load);
            this.fuGridControl1.DoubleClick += new System.EventHandler(this.fuGridControl1_DoubleClick_1);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.fuGridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridView1_RowStyle);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick_1);
            // 
            // Preview_SimpleButton
            // 
            this.Preview_SimpleButton.Image = global::Dentas_Pro.UI.Properties.Resources.Ön_izleme_button_32_32_;
            this.Preview_SimpleButton.Location = new System.Drawing.Point(44, 325);
            this.Preview_SimpleButton.Name = "Preview_SimpleButton";
            this.Preview_SimpleButton.Size = new System.Drawing.Size(85, 33);
            this.Preview_SimpleButton.TabIndex = 11;
            this.Preview_SimpleButton.Text = "Ön izle";
            this.Preview_SimpleButton.Click += new System.EventHandler(this.Preview_SimpleButton_Click_1);
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.Permit_Approval_Situation_ComboBoxEdit);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.Preview_SimpleButton);
            this.xtraTabPage1.Controls.Add(this.Department_Type_ComboBoxEdit);
            this.xtraTabPage1.Controls.Add(this.Department_Type_LabelControl);
            this.xtraTabPage1.Controls.Add(this.Permit_Type_ComboBoxEdit);
            this.xtraTabPage1.Controls.Add(this.Clean_SimpleButton);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(180, 411);
            this.xtraTabPage1.Text = "Arama";
            // 
            // Permit_Approval_Situation_ComboBoxEdit
            // 
            this.Permit_Approval_Situation_ComboBoxEdit.EditValue = "";
            this.Permit_Approval_Situation_ComboBoxEdit.Location = new System.Drawing.Point(22, 195);
            this.Permit_Approval_Situation_ComboBoxEdit.Name = "Permit_Approval_Situation_ComboBoxEdit";
            this.Permit_Approval_Situation_ComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Permit_Approval_Situation_ComboBoxEdit.Properties.Items.AddRange(new object[] {
            "Bekliyor",
            "Onaylandı"});
            this.Permit_Approval_Situation_ComboBoxEdit.Size = new System.Drawing.Size(116, 20);
            this.Permit_Approval_Situation_ComboBoxEdit.TabIndex = 13;
            this.Permit_Approval_Situation_ComboBoxEdit.SelectedIndexChanged += new System.EventHandler(this.Permit_Approval_Situation_ComboBoxEdit_SelectedIndexChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(26, 176);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(66, 13);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "Onay Durumu";
            // 
            // Department_Type_ComboBoxEdit
            // 
            this.Department_Type_ComboBoxEdit.EditValue = "";
            this.Department_Type_ComboBoxEdit.Location = new System.Drawing.Point(22, 96);
            this.Department_Type_ComboBoxEdit.Name = "Department_Type_ComboBoxEdit";
            this.Department_Type_ComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Department_Type_ComboBoxEdit.Properties.Items.AddRange(new object[] {
            "Bilgi Sistemleri",
            "Satış Pazarlama ",
            "İnsan Kaynakları",
            "Mali İşler",
            "Dentaş",
            "Lojistik ve Satınalma",
            "1.bölge Satış",
            "2.bölge Satış",
            "3.bölge Satış",
            "4.bölge Satış",
            "5.bölge Satış",
            "6.bölge Satış",
            "7.bölge Satış",
            "8.bölge Satış",
            "Adana Oluklu Bakım",
            "Adana Oluklu Destek Hiz.",
            "Adana Oluklu Fabrika",
            "Adana Oluklu Üretim",
            "Alacak Muhasebesi",
            "Bütçe ve Final Raporlama",
            "Çorlu Kağıt Bakım",
            "Çorlu Kağıt Fabrika",
            "Çorlu Kağıt Üretim",
            "Çorlu Oluklu Bakım",
            "Çorlu Oluklu Destek Hizmetleri",
            "Çorlu Oluklu Fabrika",
            "Çorlu Oluklu Üretim",
            "Denizli Kağıt Bakım",
            "Denizli Kağıt Fabrika",
            "Denizli Kağıt Üretim",
            "Denizli Oluklu Bakım",
            "Denizli Oluklu Destek Hizmetleri",
            "Denizli Oluklu Fabrika",
            "Denizli Oluklu Üretim",
            "Dış Satınalma",
            "Genel Muhasebe",
            "Genel Müdürlük",
            "Hammadde Ve Malzeme Ambarı",
            "İç Denetim",
            "İç Satınalma",
            "Kağıt Fabrikaları Üretim",
            "Kalite Ve Arge",
            "Kojenerasyon",
            "Mamul Ambar",
            "Mekanik Atölye",
            "Oluklu Fabrikaları Üretim",
            "Üretim Planlama"});
            this.Department_Type_ComboBoxEdit.Size = new System.Drawing.Size(116, 20);
            this.Department_Type_ComboBoxEdit.TabIndex = 10;
            this.Department_Type_ComboBoxEdit.SelectedIndexChanged += new System.EventHandler(this.Department_Type_ComboBoxEdit_SelectedIndexChanged_1);
            // 
            // Department_Type_LabelControl
            // 
            this.Department_Type_LabelControl.Location = new System.Drawing.Point(26, 76);
            this.Department_Type_LabelControl.Name = "Department_Type_LabelControl";
            this.Department_Type_LabelControl.Size = new System.Drawing.Size(53, 13);
            this.Department_Type_LabelControl.TabIndex = 9;
            this.Department_Type_LabelControl.Text = "Departman";
            // 
            // Permit_Type_ComboBoxEdit
            // 
            this.Permit_Type_ComboBoxEdit.EditValue = "";
            this.Permit_Type_ComboBoxEdit.Location = new System.Drawing.Point(22, 37);
            this.Permit_Type_ComboBoxEdit.Name = "Permit_Type_ComboBoxEdit";
            this.Permit_Type_ComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Permit_Type_ComboBoxEdit.Properties.Items.AddRange(new object[] {
            "Ücretli",
            "Ücretsiz"});
            this.Permit_Type_ComboBoxEdit.Size = new System.Drawing.Size(116, 20);
            this.Permit_Type_ComboBoxEdit.TabIndex = 8;
            this.Permit_Type_ComboBoxEdit.SelectedIndexChanged += new System.EventHandler(this.Permit_Type_ComboBoxEdit_SelectedIndexChanged_1);
            // 
            // Clean_SimpleButton
            // 
            this.Clean_SimpleButton.Image = global::Dentas_Pro.UI.Properties.Resources.Temizle_32_32;
            this.Clean_SimpleButton.Location = new System.Drawing.Point(44, 256);
            this.Clean_SimpleButton.Name = "Clean_SimpleButton";
            this.Clean_SimpleButton.Size = new System.Drawing.Size(85, 33);
            this.Clean_SimpleButton.TabIndex = 7;
            this.Clean_SimpleButton.Text = "Temizle";
            this.Clean_SimpleButton.Click += new System.EventHandler(this.Clean_SimpleButton_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(26, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(42, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "İzin Cinsi";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(186, 439);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.xtraTabControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.fuGridControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(829, 439);
            this.splitContainerControl1.SplitterPosition = 186;
            this.splitContainerControl1.TabIndex = 3;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // Annual_Permit_List_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 439);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "Annual_Permit_List_Form";
            this.Text = "Yıllık İzin Listesi";
            this.Load += new System.EventHandler(this.Annual_Permit_List_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fuGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Permit_Approval_Situation_ComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Department_Type_ComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Permit_Type_ComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private WinControl.FuGridControl fuGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton Preview_SimpleButton;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.ComboBoxEdit Department_Type_ComboBoxEdit;
        private DevExpress.XtraEditors.LabelControl Department_Type_LabelControl;
        private DevExpress.XtraEditors.ComboBoxEdit Permit_Type_ComboBoxEdit;
        private DevExpress.XtraEditors.SimpleButton Clean_SimpleButton;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.ComboBoxEdit Permit_Approval_Situation_ComboBoxEdit;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}