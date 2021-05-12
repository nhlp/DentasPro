namespace Dentas_Pro.UI.Recycle
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Text;
    using System.Windows.Forms;
    using System.Data.SqlClient;

    using DevExpress.XtraEditors;
    using Dentas_Pro.UI.Base;
    using System.Data.Odbc;

    public partial class Recycle_Accounting_Form : Base_Form
    {
        public Recycle_Accounting_Form()
        {
            InitializeComponent();
        }

        public void Get_The_Material() 
        {
            string connString = @"DSN=Test_Db_Mfg;DB=denprod;UID=cetinkab;PWD=dentas;";
            string sql = @"Select cm_sort From Cm_mstr'";
            OdbcConnection conn = null;
            OdbcDataReader reader = null;

            try
            {
                // Open connection 
                conn = new OdbcConnection(connString);
                conn.Open();
                // Execute the query
                OdbcCommand cmd = new OdbcCommand(sql, conn);
                reader = cmd.ExecuteReader();
                // Display output header

                Name_Surname_TextEdit.Text = reader.GetString(0);
              
                //while (reader.Read())
                //{
                //    // Console.WriteLine("{0}|{1}", reader["cm_addr"].ToString().PadLeft(8), reader["cm_sort"].ToString().PadLeft(8));
                //    Console.WriteLine(reader["code_value"].ToString().PadLeft(8));
                //}
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
            }
            //finally
            //{
            //    // Close connection 
            //    reader.Close();
            //    conn.Close();
            //}


            

            //SqlCommand sqlCommand = new SqlCommand("Select cm_sort From Cm_mstr", sqlConnection);

            //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            //if (sqlDataReader.Read())
            //{
            //    Name_Surname_TextEdit.Text = sqlDataReader.GetString(0);
            //}

            

        }

        public void Set_The_AutoSuggestion(TextEdit textEdit)
        {

            string connString = @"DSN=Test_Db_Mfg;DB=denprod;UID=cetinkab;PWD=dentas;";
            string sql = @"Select cm_sort From Cm_mstr'";
            OdbcConnection conn = null;
            OdbcDataReader reader = null;


            try
            {
                conn = new OdbcConnection(connString);
                conn.Open();
                OdbcCommand cmd = new OdbcCommand(sql, conn);

                reader = cmd.ExecuteReader();

               
                while (reader.Read())
                {
                    Name_Surname_TextEdit.MaskBox.AutoCompleteCustomSource.Add(reader["cm_sort"].ToString());
                    Name_Surname_TextEdit.MaskBox.AutoCompleteMode = AutoCompleteMode.Suggest;
                    Name_Surname_TextEdit.MaskBox.AutoCompleteSource = AutoCompleteSource.CustomSource;

                }
                reader.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Tavsiye dilecek Müşteri kaydı yok");/*=exception.ToString());*/
            }

        }


        private void Name_Surname_TextEdit_EditValueChanged(object sender, EventArgs e)
        {
            Set_The_AutoSuggestion(Name_Surname_TextEdit);

        }
    }
}