namespace Dentas_Pro.UI.Report
{
    partial class Annual_Permit_Used_Unused_Form
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel1 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel2 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            this.DentasProDataSet4 = new Dentas_Pro.UI.DentasProDataSet4();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.rp_Department_Permit_UsageTableAdapter = new Dentas_Pro.UI.DentasProDataSet4TableAdapters.Rp_Department_Permit_UsageTableAdapter();
            this.rpDepartmentPermitUsageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DentasProDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpDepartmentPermitUsageBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DentasProDataSet4
            // 
            this.DentasProDataSet4.DataSetName = "DentasProDataSet4";
            this.DentasProDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chartControl1
            // 
            this.chartControl1.AppearanceNameSerializable = "Gray";
            this.chartControl1.DataAdapter = this.rp_Department_Permit_UsageTableAdapter;
            this.chartControl1.DataSource = this.rpDepartmentPermitUsageBindingSource;
            xyDiagram1.AxisX.Range.AlwaysShowZeroLevel = true;
            xyDiagram1.AxisX.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram1.AxisX.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Range.AlwaysShowZeroLevel = true;
            xyDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram1.AxisY.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PaletteBaseColorNumber = 5;
            this.chartControl1.PaletteName = "Nature Colors";
            series1.DataSource = this.DentasProDataSet4;
            sideBySideBarSeriesLabel1.LineVisible = true;
            series1.Label = sideBySideBarSeriesLabel1;
            series1.Name = "Departman";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            sideBySideBarSeriesLabel2.LineVisible = true;
            this.chartControl1.SeriesTemplate.Label = sideBySideBarSeriesLabel2;
            this.chartControl1.Size = new System.Drawing.Size(792, 479);
            this.chartControl1.TabIndex = 0;
            chartTitle1.Text = "Kullanılmamış \"İzin Gün Sayısı\" Grafiği ";
            this.chartControl1.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // rp_Department_Permit_UsageTableAdapter
            // 
            this.rp_Department_Permit_UsageTableAdapter.ClearBeforeFill = true;
            // 
            // rpDepartmentPermitUsageBindingSource
            // 
            this.rpDepartmentPermitUsageBindingSource.DataMember = "Rp_Department_Permit_Usage";
            this.rpDepartmentPermitUsageBindingSource.DataSource = this.DentasProDataSet4;
            // 
            // Annual_Permit_Used_Unused_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 479);
            this.Controls.Add(this.chartControl1);
            this.Name = "Annual_Permit_Used_Unused_Form";
            this.Text = "İzin Performans Ekranı";
            this.Load += new System.EventHandler(this.Annual_Permit_Used_Unused_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DentasProDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpDepartmentPermitUsageBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DentasProDataSet4TableAdapters.Rp_Department_Permit_UsageTableAdapter rp_Department_Permit_UsageTableAdapter;
        private DentasProDataSet4 DentasProDataSet4;
        private System.Windows.Forms.BindingSource rpDepartmentPermitUsageBindingSource;

    }
}