namespace Dentas_Pro.UI.Permit
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Data.SqlClient;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;

    public partial class Activity_Insert_PopUp_Form : Form
    {

        public bool Edit = false;
        public int Choose_Obj_Id = -1;

        public Activity_Insert_PopUp_Form()
        {
            InitializeComponent();

        }

        DAL_Function.Sql_Server_DB_From_DentasProDataContext sql_Server_Db_From_Follow_Up_Data_context = new DAL_Function.Sql_Server_DB_From_DentasProDataContext();


        private void Get_Data_From_UI() 
        {
            DAL_Function.Holiday_Activity holiday_Activity = new DAL_Function.Holiday_Activity();


        }


        private void Save_SimpleButton_Click(object sender, EventArgs e)
        {
            try
            {

                DAL_Function.Holiday_Activity holiday_Activity = new DAL_Function.Holiday_Activity();

                if (sql_Server_Db_From_Follow_Up_Data_context.Holiday_Activities.Where(s => s.Activity_Date == DateTime.Parse(Activity_Date_TextEdit.Text)).Count()>0)
                {
                    MessageBox.Show("Bu tarihe olay girişi yapmışsınız");
                    return;
                }

                SqlConnection sqlConnection = new SqlConnection("Server=10.168.0.26;Database=DentasPro;uid=sa;pwd=dentas;");
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("Insert Into [Holiday_Activity] (Activity_Name,Activity_Date) Values (@Activity_Name,@Activity_Date)", sqlConnection);

                sqlCommand.Parameters.AddWithValue("@Activity_Name", Activity_Name_ComboBoxEdit.Text);
                sqlCommand.Parameters.AddWithValue("@Activity_Date", DateTime.Parse( Activity_Date_TextEdit.Text));

                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

                MessageBox.Show("Tatil kaydı yapıldı");
                this.Close();
                Refresh();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void Delete_SimpleButton_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection sqlConnection = new SqlConnection("Server=10.168.0.26;Database=DentasPro;uid=sa;pwd=dentas;");
                sqlConnection.Open();


                //DELETE FROM [dbo].[Daily_Hour_Permit] WHERE (([Obj_Id] = @Original_Obj_Id) AND ((@IsNull_User_Obj_Id = 1 AND [User_Obj_Id] IS NULL) OR ([User_Obj_Id] = @Original_User_Obj_Id)) AND ((@IsNull_Department_Obj_Id = 1 AND [Department_Obj_Id] IS NULL) OR ([Department_Obj_Id] = @Original_Department_Obj_Id)) AND ((@IsNull_Title_Obj_Id = 1 AND [Title_Obj_Id] IS NULL) OR ([Title_Obj_Id] = @Original_Title_Obj_Id)) AND ((@IsNull_Permit_Start_Time = 1 AND [Permit_Start_Time] IS NULL) OR ([Permit_Start_Time] = @Original_Permit_Start_Time)) AND ((@IsNull_Permit_End_Time = 1 AND [Permit_End_Time] IS NULL) OR ([Permit_End_Time] = @Original_Permit_End_Time)) AND ((@IsNull_StartUp_Work_Time = 1 AND [StartUp_Work_Time] IS NULL) OR ([StartUp_Work_Time] = @Original_StartUp_Work_Time)) AND ((@IsNull_Permit_Reason_Obj_Id = 1 AND [Permit_Reason_Obj_Id] IS NULL) OR ([Permit_Reason_Obj_Id] = @Original_Permit_Reason_Obj_Id)) AND ((@IsNull_Permit_Type = 1 AND [Permit_Type] IS NULL) OR ([Permit_Type] = @Original_Permit_Type)) AND ((@IsNull_Permit_Start_Hour = 1 AND [Permit_Start_Hour] IS NULL) OR ([Permit_Start_Hour] = @Original_Permit_Start_Hour)) AND ((@IsNull_Permit_End_Hour = 1 AND [Permit_End_Hour] IS NULL) OR ([Permit_End_Hour] = @Original_Permit_End_Hour)) AND ((@IsNull_Description = 1 AND [Description] IS NULL) OR ([Description] = @Original_Description)) AND ((@IsNull_Department_Chief = 1 AND [Department_Chief] IS NULL) OR ([Department_Chief] = @Original_Department_Chief)) AND ((@IsNull_Department_Manager = 1 AND [Department_Manager] IS NULL) OR ([Department_Manager] = @Original_Department_Manager)) AND ((@IsNull_Approval_User = 1 AND [Approval_User] IS NULL) OR ([Approval_User] = @Original_Approval_User)) AND ((@IsNull_Approval_Situation = 1 AND [Approval_Situation] IS NULL) OR ([Approval_Situation] = @Original_Approval_Situation)) AND ((@IsNull_Insert_User = 1 AND [Insert_User] IS NULL) OR ([Insert_User] = @Original_Insert_User)) AND ((@IsNull_Insert_Time = 1 AND [Insert_Time] IS NULL) OR ([Insert_Time] = @Original_Insert_Time)) AND ((@IsNull_Update_User = 1 AND [Update_User] IS NULL) OR ([Update_User] = @Original_Update_User)) AND ((@IsNull_Update_Time = 1 AND [Update_Time] IS NULL) OR ([Update_Time] = @Original_Update_Time)))
                SqlCommand sqlCommand = new SqlCommand("Delete [Holiday_Activity] where ([Activity_Date]) = @Activity_Date", sqlConnection);

                sqlCommand.Parameters.AddWithValue("@Activity_Name", Activity_Name_ComboBoxEdit.Text);
                sqlCommand.Parameters.AddWithValue("@Activity_Date", DateTime.Parse(Activity_Date_TextEdit.Text));

                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

                MessageBox.Show("Tatil kaydı silindi","Tatil Siliyorsunuz",MessageBoxButtons.OK,MessageBoxIcon.Question);
                this.Close();
            }
            catch (Exception exception)
            {
                throw;
            }

        }

        
    }
}
