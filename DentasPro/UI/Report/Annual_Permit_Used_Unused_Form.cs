namespace Dentas_Pro.UI.Report
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Text;
    using System.Windows.Forms;
    
    using DevExpress.XtraEditors;
    
    using Dentas_Pro.UI.Base;
    using System.Data.SqlClient;

    public partial class Annual_Permit_Used_Unused_Form : Base_Form
    {
        public Annual_Permit_Used_Unused_Form()
        {
            InitializeComponent();
            Execute_The_Current_SP();
        }

        private void Annual_Permit_Used_Unused_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DentasProDataSet4.Rp_Department_Permit_Usage' table. You can move, or remove it, as needed.
            this.rp_Department_Permit_UsageTableAdapter.Fill(this.DentasProDataSet4.Rp_Department_Permit_Usage);
            // TODO: This line of code loads data into the 'DentasProDataSet3.Annual_Permit' table. You can move, or remove it, as needed.
        }

        public void Execute_The_Current_SP() 
        {
            try
            {
                /*
                 * Developer:   İrfan Dölek
                 * Dev_Date :   2015_04_28
                 * Description: Datayı toplamaasın diye kod commentlendi. ekrana basılan grafik datası manuel table'a girilmiş data.
                 *              Uygulama Live'a alınmadan önce bu kod'u uncomment yap.
                 */

                //SqlConnection sql_Connection = new SqlConnection("Server=10.168.0.26;Database=DentasPro;uid=sa;pwd=dentas;");
                //sql_Connection.Open();

                //SqlCommand sql_Command = new SqlCommand();
                //sql_Command.Connection = sql_Connection;
                //sql_Command.CommandType = CommandType.StoredProcedure;
                //sql_Command.CommandText = "Department_Permit_Usage";
                //sql_Command.ExecuteNonQuery();

                //sql_Connection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}