namespace Dentas_Pro.UI.Base
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Text;
    using System.Windows.Forms;
    using DevExpress.XtraEditors;
    using System.Data.SqlClient;

    /// <summary>
    /// Şifremi unutttum
    /// </summary>
    public partial class Forgetten_Password_Form : Base_Form
    {
        public Forgetten_Password_Form()
        {
            InitializeComponent();
            Set_The_AutoSuggestion_For_Mail(E_Mail_TextEdit);
        }

        UI.Mail.Send_An_E_Mail send_An_E_Mail = new Mail.Send_An_E_Mail();


        public void Set_The_AutoSuggestion_For_Mail(TextEdit textEdit)
        {

            string Login_Name = string.Empty;
            SqlDataReader sql_DataReader;
            SqlCommand sql_Command;

            SqlConnection sqlConnection = new SqlConnection("Server=10.168.0.26;Database=DentasPro;uid=sa;pwd=dentas;");
            sqlConnection.Open();

            try
            {
                sql_Command = new SqlCommand("Select E_Mail From [User]", sqlConnection);
                sql_DataReader = sql_Command.ExecuteReader();

                while (sql_DataReader.Read())
                {
                    E_Mail_TextEdit.MaskBox.AutoCompleteCustomSource.Add(sql_DataReader["E_Mail"].ToString());
                    E_Mail_TextEdit.MaskBox.AutoCompleteMode = AutoCompleteMode.Suggest;
                    E_Mail_TextEdit.MaskBox.AutoCompleteSource = AutoCompleteSource.CustomSource;

                }
                sql_DataReader.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Tavsiye dilecek kullanıcı girişi yok");/*=exception.ToString());*/
            }

        }

        private void Send_An_E_Mail_SimpleButton_Click(object sender, EventArgs e)
        {
            send_An_E_Mail.Send_An_E_Mail_For_Forgetten_Password(E_Mail_TextEdit.Text, "Şifrimi Unuttum", "dedede",Get_Selected_E_Mail("Şifreniz:"+ E_Mail_TextEdit.Text));
        }

        private string Get_Selected_E_Mail(string Selected_Forgetten_Password_Mail)
        {
            string Selected_Password = string.Empty; 

            SqlConnection sqlConnection = new SqlConnection("Server=10.168.0.26;Database=DentasPro;uid=sa;pwd=dentas;");
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand("Select Login_Name, Password, Obj_Id From [User] where E_Mail = '" + E_Mail_TextEdit.Text + "'", sqlConnection);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            if (sqlDataReader.HasRows)
                while (sqlDataReader.Read())
                {
                    Selected_Password = sqlDataReader.GetString(1);
                }
                return Selected_Password;
        }

    }


}
