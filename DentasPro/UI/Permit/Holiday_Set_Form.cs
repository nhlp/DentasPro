namespace Dentas_Pro.UI.Permit
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;

    using DevExpress.XtraEditors;
    using System.Data.SqlClient;

    public partial class Holiday_Set_Form : XtraForm
    {
        public Holiday_Set_Form()
        {
            InitializeComponent();

        }
        public bool Choose = false;

        SqlConnection sql_Connection = new SqlConnection("Server=10.168.0.26;Database=DentasPro;uid=sa;pwd=dentas;");
        SqlCommand sql_Command; 

        string Holiday_Name, Holiday_Description, Holiday_Date;
        string[] Holiday_Detail;

        public string[] Holiday_Activity(string query) 
        {
            Holiday_Detail = null;
            sql_Command = new SqlCommand(query, sql_Connection);

            SqlDataReader Coming_Value;
            sql_Connection.Open();

            try
            {
                Coming_Value = sql_Command.ExecuteReader();

                while (Coming_Value.Read())
                {
                    Holiday_Name = Coming_Value[0].ToString();
                    Holiday_Description = Coming_Value[1].ToString();
                    Holiday_Date = Coming_Value[2].ToString();
                    Holiday_Detail = new string[] { Holiday_Name, Holiday_Description, Holiday_Date };
                }
                return Holiday_Detail;

            }
            catch (Exception exception)
            {
                throw;
            }
            finally 
            {
                sql_Connection.Close();
            }
 
        }

        public void Holiday_Activity_Time(MonthCalendar Mc) 
        {
            sql_Command = new SqlCommand("Select Activity_Date From Holiday_Activity", sql_Connection);
            SqlDataReader Coming_Value;

            sql_Connection.Open();

            try
            {
                Coming_Value = sql_Command.ExecuteReader();

                while (Coming_Value.Read())
                {
                    Mc.AddBoldedDate(DateTime.Parse(Coming_Value["Activity_Date"].ToString()));
                }
                Mc.UpdateBoldedDates();
            }
            catch (Exception excepiton)
            {
                MessageBox.Show(excepiton.Message);
            }

        }



        private void Holiday_Set_Form_Load(object sender, EventArgs e)
        {
            try
            {
                Holiday_Activity_Time(Holiday_Set_MonthCalendar);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }


        public void Set_Activity_Date_() 
        {
            Activity_Insert_PopUp_Form activity_Insert_PopUp_Form = new Activity_Insert_PopUp_Form();
            activity_Insert_PopUp_Form.Activity_Date_TextEdit.Text = Holiday_Set_MonthCalendar.SelectionStart.ToShortDateString();
            activity_Insert_PopUp_Form.ShowDialog();
        }

        private void Holiday_Set_MonthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            Set_Activity_Date_();

        }





    }
}
