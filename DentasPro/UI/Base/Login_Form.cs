/*Login formu*/
namespace Dentas_Pro.UI.Base
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

    public partial class Login_Form : DevExpress.XtraEditors.XtraForm
    {
        public Login_Form()
        {
            InitializeComponent();
            Set_The_AutoSuggestion(User_Name_TextEdit);
        }

        public static int Login_User_Obj_Id = -1;

        #region Comment
        /*Kullanıcının programa giriş yapma adeddi*/
        #endregion
        public int try_Times { get; set; }

        private void Cancel_SimpleButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Enter_SimpleButton_Click(object sender, EventArgs e)
        {
           
            Get_Title_Id();
            Get_Department_Id();

            SqlConnection sqlConnection = new SqlConnection("Server=10.168.0.26;Database=DentasPro;uid=sa;pwd=dentas;");
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand("Select Login_Name, Password, Obj_Id From [User] where Login_Name = '" + User_Name_TextEdit.Text + "'", sqlConnection);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    #region MyRegion
                    /*Kullanıcı bilgileri doğru ise*/
                    #endregion
                    if (User_Password_TextEdit.Text == sqlDataReader.GetString(1))
                    {
                        Login_User_Obj_Id = sqlDataReader.GetInt32(2); /*.GetString(2));*/
                        MainMDIForm mainMDIForm = new MainMDIForm();
                        mainMDIForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        try_Times++;
                        MessageBox.Show("Lütfen parolanızı kontrol ediniz");
                        if (try_Times == 3)
                        {
                            this.DialogResult = DialogResult.Cancel;
                            MessageBox.Show("Parolanızı 3 defa hatalı girdiniz.", "Program kapatılıyor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            this.Close();
                        }
                    }
                }
            }
            /*Eğer kontrollerde data yok ise*/
            else
            {
                if (User_Name_TextEdit.Text == string.Empty || User_Password_TextEdit.Text == string.Empty)
                {
                    try_Times++;
                    MessageBox.Show("Program giriş bilgilerinizi boş geçemezsiniz !..", "Giriş Bilgileri Kontrol", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (try_Times == 3)
                    {
                        this.DialogResult = DialogResult.Cancel;
                        MessageBox.Show("Kullanıcı bilgilerinizi 3 defa hatalı girdiniz.", "Program kapatılıyor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.Close();
                    }
                }
            }
        }

        /// <summary>
        /// ilk harfi küçük yazarsa bile biz onu büyük yapıp DB'ye gönderiyoruz.
        /// </summary>
        private void User_Name_TextEdit_Leave(object sender, EventArgs e)
        {
            Dentas_Pro.Framework.Common_Methods.Fitst_Letter_Upper_Case_Other_Lower(User_Name_TextEdit.Text);
        }

        public void Set_The_AutoSuggestion(TextEdit textEdit)
        {

            string Login_Name = string.Empty;
            SqlDataReader sql_DataReader;
            SqlCommand sql_Command;

            SqlConnection sqlConnection = new SqlConnection("Server=10.168.0.26;Database=DentasPro;uid=sa;pwd=dentas;");
            sqlConnection.Open();

            try
            {
                sql_Command = new SqlCommand("Select Login_Name From [User]", sqlConnection);
                sql_DataReader = sql_Command.ExecuteReader();

                while (sql_DataReader.Read())
                {
                    User_Name_TextEdit.MaskBox.AutoCompleteCustomSource.Add(sql_DataReader["Login_Name"].ToString());
                    User_Name_TextEdit.MaskBox.AutoCompleteMode = AutoCompleteMode.Suggest;
                    User_Name_TextEdit.MaskBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
                }
                sql_DataReader.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Tavsiye dilecek kullanıcı girişi yok");/*=exception.ToString());*/
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Forgetten_Password_Form forgetten_Password_Form = new Forgetten_Password_Form();
            forgetten_Password_Form.ShowDialog();
        }

        public int Get_Title_Id()
        {
            SqlConnection sqlConnection = new SqlConnection("Server=10.168.0.26;Database=DentasPro;uid=sa;pwd=dentas;");
            sqlConnection.Open();
            int Title_Obj_Id = 0;

            SqlCommand sqlCommand = new SqlCommand("Select Title_Obj_Id From [User] where Login_Name = '" + User_Name_TextEdit.Text + "'", sqlConnection);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                   Title_Obj_Id = sqlDataReader.GetInt32(0);
                }
            }

            return MainMDIForm.Title_Obj_Id = Title_Obj_Id;
        }

        public int Get_Department_Id()
        {
            SqlConnection sqlConnection = new SqlConnection("Server=10.168.0.26;Database=DentasPro;uid=sa;pwd=dentas;");
            sqlConnection.Open();
            int Department_Obj_Id = 0;

            SqlCommand sqlCommand = new SqlCommand("Select Department_Obj_Id From [User] where Login_Name = '" + User_Name_TextEdit.Text + "'", sqlConnection);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    Department_Obj_Id = sqlDataReader.GetInt32(0);
                }
            }

            return MainMDIForm.Department_Obj_Id  = Department_Obj_Id;
        }

        private void User_Name_TextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }

    }
}