namespace Dentas_Pro.UI.Permit
{
    partial class Holiday_Set_Form
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
            this.schedulerStorage1 = new DevExpress.XtraScheduler.SchedulerStorage(this.components);
            this.Holiday_Set_MonthCalendar = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).BeginInit();
            this.SuspendLayout();
            // 
            // Holiday_Set_MonthCalendar
            // 
            this.Holiday_Set_MonthCalendar.CalendarDimensions = new System.Drawing.Size(4, 3);
            this.Holiday_Set_MonthCalendar.Location = new System.Drawing.Point(5, 2);
            this.Holiday_Set_MonthCalendar.Name = "Holiday_Set_MonthCalendar";
            this.Holiday_Set_MonthCalendar.TabIndex = 1;
            //this.Holiday_Set_MonthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Holiday_Set_MonthCalendar_DateChanged);
            this.Holiday_Set_MonthCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.Holiday_Set_MonthCalendar_DateSelected);
            // 
            // Holiday_Set_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 472);
            this.Controls.Add(this.Holiday_Set_MonthCalendar);
            this.Name = "Holiday_Set_Form";
            this.Text = "Tatil Ayarla";
            this.Load += new System.EventHandler(this.Holiday_Set_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraScheduler.SchedulerStorage schedulerStorage1;
        public System.Windows.Forms.MonthCalendar Holiday_Set_MonthCalendar;
    }
}