namespace Dentas_Pro.UI.User
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Linq;
    using System.Drawing;
    using System.Text;
    using System.Windows.Forms;
    using System.Data.SqlClient;

    using Dentas_Pro.UI.Base;
    using Dentas_Pro.UI.DAL_Function;

    using DevExpress.XtraEditors;
    using DevExpress.Data;
    using DevExpress.XtraGrid.Columns;
    using DevExpress.XtraGrid.Views.Layout;
    using DevExpress.XtraGrid.Views.Grid;
    using System.Globalization;
    using System.Data.OleDb;
    using Dentas_Pro.UI.Permit;

    public partial class Add_Annual_Permit_Form : Base_Form
    {
        public Add_Annual_Permit_Form()
        {
            InitializeComponent();
            //Set_The_Control_Visible();
            Getting_For_Open_Up_User_Name_Surname_Instead_Obj_Id(Login_Form.Login_User_Obj_Id);
            Get_The_Total_Permit_Allowed();
        }

        #region Fields

        public bool Edit = false;
        public int User_Obj_Id = -1;
        public int annual_Permit_Obj_Id = -1;
        public int Permit_Used_User_Name_Obj_Id = -1;
        public int Choose_Obj_Id = -1;
        public int Department_Responsible_Obj_Id = -1;
        public int Department_Manager_Obj_Id = -1;
        public int Department_Obj_Id = -1;
        public int Expense_Group_Obj_Id = -1;
        public int Title_Obj_Id = -1;
        public int Permit_Reason_Obj_Id = -1;
        public int Country_Obj_Id = -1;
        public int Permit_Year;
        public int Permit_Day;


        #endregion

        DAL_Function.Sql_Server_DB_From_DentasProDataContext sql_Server_Db_From_Follow_Up_Data_context = new DAL_Function.Sql_Server_DB_From_DentasProDataContext();

        DAL_Function.Get_The_Form get_The_Forms = new DAL_Function.Get_The_Form();
        DAL_Function.Messages messages = new DAL_Function.Messages();

        #region Events

        public void Getting_For_Permit_Knowledge(int Obj_Id)
        {
            try
            {
                /* Gelen Obj_Id > 0 dan ise bı işleri yap da diyebiliriz.*/
                Edit = true;
                annual_Permit_Obj_Id = Obj_Id;
                DAL_Function.Annual_Permit annual_Permit = (sql_Server_Db_From_Follow_Up_Data_context.Annual_Permits.First(s => s.Obj_Id == annual_Permit_Obj_Id));

                Name_Surname_TextEdit.Text = annual_Permit.User_Obj_Id.ToString();
                Department_Name_TextEdit.Text = annual_Permit.Department_Obj_Id.ToString();
                Job_Title_TextEdit.Text = annual_Permit.Title_Obj_Id.ToString();
                Job_Start_Date_DateEdit.Text = annual_Permit.Permit_Start_Time.ToString();

                Getting_For_Department_Name_Instead_Obj_Id(annual_Permit.Department_Obj_Id.Value);
                Getting_For_Title_Name_Instead_Obj_Id(annual_Permit.Title_Obj_Id.Value);
                Getting_For_Permit_Used_User_Name_Instead_Obj_Id(annual_Permit.User_Obj_Id.Value);
                //Getting_For_Permit_Reason_Name_Instead_Obj_Id(annual_Permit.Permit_Reason_Obj_Id.Value);





                #region Description

                /*
                 Aşağıdaki titile'daki ler için Departman sorulusu yok. Bu sebeple Departman sorumlusu kontrolünü kapatıyoruz.
                    7	Koordinatör                                       
                    8	Direktör                                          
                    9	Müdür                                             
                    10	Yönetmen                                          
                 */
                #endregion
                if (Title_Obj_Id == 7 || Title_Obj_Id == 8 || Title_Obj_Id == 9 || Title_Obj_Id == 10)
                {
                    Getting_For_Open_Up_Department_Manager_Name_Surname_Instead_Obj_Id(annual_Permit.Department_Manager_Obj_Id.Value);
                    //Department_Responsible_LabelControl.Visible = false;
                    //Department_Responsible_TextEdit.Visible = false;
                }
                else
                {
                    Getting_For_Open_Up_Department_Responsible_Name_Surname_Instead_Obj_Id(annual_Permit.Department_Chief_Obj_Id.Value);
                    Getting_For_Open_Up_Department_Manager_Name_Surname_Instead_Obj_Id(annual_Permit.Department_Manager_Obj_Id.Value);
                    //Department_Responsible_LabelControl.Visible = true;
                    //Department_Responsible_TextEdit.Visible = true;
                }

            }
            catch (Exception exception)
            {
                messages.Error(exception);
            }
        }




        public void Getting_For_Title_Name_Instead_Obj_Id(int Obj_Id)
        {
            try
            {
                Title_Obj_Id = Obj_Id;
                DAL_Function.Title title = sql_Server_Db_From_Follow_Up_Data_context.Titles.First(s => s.Obj_Id == Title_Obj_Id);

                Job_Title_TextEdit.Text = title.Name;
            }
            catch (Exception exception)
            {
                throw;
            }
        }

        public void Getting_For_Permit_Used_User_Name_Instead_Obj_Id(int Obj_Id)
        {
            try
            {
                Permit_Used_User_Name_Obj_Id = Obj_Id;
                DAL_Function.User user = sql_Server_Db_From_Follow_Up_Data_context.Users.First(s => s.Obj_Id == Permit_Used_User_Name_Obj_Id);

                Name_Surname_TextEdit.Text = user.Full_Name;
                Registration_Number_TextEdit.Text = user.Registration_Number;


            }
            catch (Exception exception)
            {
                throw;
            }
        }

        public void Getting_For_Department_Name_Instead_Obj_Id(int Obj_Id)
        {
            try
            {
                Department_Obj_Id = Obj_Id;
                DAL_Function.Department department = sql_Server_Db_From_Follow_Up_Data_context.Departments.First(s => s.Obj_Id == Department_Obj_Id);

                Department_Name_TextEdit.Text = department.Name;
            }
            catch (Exception exception)
            {
                throw;
            }
        }


        public void Getting_For_Open_Up_Department_Manager_Name_Surname_Instead_Obj_Id(int obj_Id)
        {
            try
            {
                Edit = true;
                Department_Manager_Obj_Id = obj_Id;

                //Department_Manager_TextEdit.Text = user.Full_Name;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Departman yöneticisi atanmamış!..", "Departman Yöneticisi Boş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Getting_For_Open_Up_Department_Responsible_Name_Surname_Instead_Obj_Id(int obj_Id)
        {
            try
            {
                Edit = true;
                Department_Responsible_Obj_Id = obj_Id;
                DAL_Function.User user = sql_Server_Db_From_Follow_Up_Data_context.Users.First(s => s.Obj_Id == Department_Responsible_Obj_Id);

                //Department_Responsible_TextEdit.Text = user.Full_Name;
            }
            catch (Exception exception)
            {
                //MessageBox.Show("Departman sorumlusu atanmamış !..", "Departman Sorumlusu Boş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void End_Date_DateEdit_Leave(object sender, EventArgs e)
        {
            //check_The_Permit_Day_Total();
        }

        public void Getting_For_Open_Up_User_Name_Surname_Instead_Obj_Id(int Obj_Id)
        {
            try
            {
                Edit = true;
                User_Obj_Id = Obj_Id;
                DAL_Function.User user = sql_Server_Db_From_Follow_Up_Data_context.Users.First(s => s.Obj_Id == User_Obj_Id);

                Name_Surname_TextEdit.Text = user.Full_Name;
                Department_Name_TextEdit.Text = user.Department_Obj_Id.Value.ToString();
                Job_Title_TextEdit.Text = user.Title_Obj_Id.Value.ToString();
                Registration_Number_TextEdit.Text = user.Registration_Number;

                /*
                 * Toplam bu sene kazanılan toplam izin
                 */
                //Total_Permit_Count_TextEdit.Text = Get_The_Total_Permit_Allowed(User_Obj_Id).ToString();


                /*
                 * Dev_Date : 2015_06_01
                 * By       :  İrfan Dölek
                 * Eğer personel izni hakketiyese Ekran dolarken set olunacak.
                 * Bu metod aslında "Yıllık izin formunda çalışmalı. Yıllık izin formu açıldığında yeni izinler hesaplanıp set olmalı."
                 */
                Staff_Has_Right_Annual_Permit(User_Obj_Id);

                /*Toplam kalan izin*/
                //Accumulated_Permit_Count_TextEdit.Text = user.Accumulated_Permit_count.ToString();

                Total_Annual_Permit_Count_TextEdit.Text = user.Accumulated_Permit_count.ToString();

                Job_Start_Date_DateEdit.Text = user.Job_Date_Of_Start.Value.ToString("dd.MM.yyyy");

                #region Desciption
                /*İzin hak ediş tarihini buluyoruz*/
                user.Job_Date_Of_Start.Value.AddDays(365).ToString();

                DateTime job = user.Job_Date_Of_Start.Value;

                Permit_Year = DateTime.Now.Year - job.Year;

                Permit_Deserve_Date_TextEdit.Text = user.Job_Date_Of_Start.Value.AddYears(Permit_Year).ToString("dd.MM.yyyy"); /*Meee*/
                #endregion

                //Permit_Deserve_Date_TextEdit.Text = DateTime.Now.AddDays(user.Job_Date_Of_Start);


                #region İzin hak kalan gün sayısını buluyoruz
                /*İzin hak kalan gün sayısını buluyoruz*/
                //user.Job_Date_Of_Start.Value.AddDays(365).ToString();

                DateTime Date_1 = DateTime.Parse(Permit_Deserve_Date_TextEdit.Text);
                DateTime Date_2 = DateTime.Now;

                TimeSpan Date_3 = Date_1 - Date_2;
                //Permit_Day = DateTime.Now.Day - job_1.Day;

                /*İzin hak etmeye kalan gün*/
                //Deserve_Day_TextEdit.Text = Date_3.ToString("dd");
                #endregion


                #region Bu yıl hak edilecek Yıllık izin gün sayısını buluyoruz
                //user.Job_Date_Of_Start.Value.AddDays(365).ToString();

                //Annual_Permit_Calculating(User_Obj_Id);

                //Permit_Day = DateTime.Now.Day - job_1.Day;

                /*Bu yıl hak edilecek gün sayısı*/
                #endregion

                //Department_Responsible_TextEdit.Text = user.Department_Responsible_Obj_Id.Value.ToString();
                //Department_Manager_TextEdit.Text = user.Department_Manager_Obj_Id.Value.ToString();

                Getting_For_Department_Name_Instead_Obj_Id(user.Department_Obj_Id.Value);
                Getting_For_Title_Name_Instead_Obj_Id(user.Title_Obj_Id.Value);


                //if (user.Title_Obj_Id == 11 && user.Title_Obj_Id == 12)
                //{
                //    MessageBox.Show("Personele 'Departman Sorumlusu' atanmamış", "EKSİK BİLGİ...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    Save_SimpleButton.Enabled = false;
                //}
                //else 
                if (Title_Obj_Id == 6 || Title_Obj_Id == 7 || Title_Obj_Id == 8 || Title_Obj_Id == 9 || Title_Obj_Id == 10 || Title_Obj_Id == 13)
                {
                    Getting_For_Open_Up_Department_Manager_Name_Surname_Instead_Obj_Id(user.Department_Manager_Obj_Id.Value);
                }
                else /*Uzman ve uyman yardımcısının departman sorumlusu olmalı.*/
                {
                    Getting_For_Open_Up_Department_Responsible_Name_Surname_Instead_Obj_Id(user.Department_Responsible_Obj_Id.Value);
                }
                if (user.Department_Responsible_Obj_Id.Value != -1)
                {
                    Getting_For_Open_Up_Department_Responsible_Name_Surname_Instead_Obj_Id(user.Department_Responsible_Obj_Id.Value);
                }
                /*Eğer kişi yönetmen ise departman sorumlusu kontrol'üne ihtiyaç yok*/
                if (user.Department_Responsible_Obj_Id.Value == -1)
                {
                    //Department_Responsible_TextEdit.Visible = false;
                    //Department_Responsible_LabelControl.Visible = false;
                }
                if (user.Department_Manager_Obj_Id == -1)
                {
                    MessageBox.Show("Personele 'Departman Müdürü' atanmamış", "EKSİK BİLGİ...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //Save_SimpleButton.Enabled = false;
                }
                else
                {
                    Getting_For_Open_Up_Department_Manager_Name_Surname_Instead_Obj_Id(user.Department_Manager_Obj_Id.Value);
                }


                #region İzin hesaplayıp bakiyeye assign etme

                DateTime Date_4 = DateTime.Parse(Job_Start_Date_DateEdit.Text);

                /*Eğer Personel'in işe giridği Ay ve current aydan büyük veya eşiti se &&
                 *                 Current day iş'e girdiği günden büyük veya = ise 
                 *                                  personel izni hak etmiş demektir.
                 */
                int Job_Enterence_Year = DateTime.Parse(Job_Start_Date_DateEdit.Text).Year;
                int Job_Enterence_Month = DateTime.Parse(Job_Start_Date_DateEdit.Text).Month;
                int Job_Enterence_Day = DateTime.Parse(Job_Start_Date_DateEdit.Text).Day;

                int Current_Year = DateTime.Now.Year;
                int Current_Month = DateTime.Now.Month;
                int Current_Day = DateTime.Now.Day;



                DateTime Date_5 = DateTime.Now;

                TimeSpan Date_6 = Date_5 - Date_4;

                //TimeSpan p_1 = Date_6;

                int Assigned_Year = DateTime.Now.Year;
                int Permit_Right_Year = DateTime.Parse(Permit_Deserve_Date_TextEdit.Text).Year;

                /*
                 * Dev_Date: 2015_06_02
                 * Description: Hak edilen izinler persoenlelrin bakiyelerine assig ediliyor
                 * Aşağıda  2 tarih arasındaki farkı gün cisinden bulan metod var. onu burda kullan. Get_The_Two_Dates_Diffrent();
                 */
                //if (Current_Year > Job_Enterence_Year && Current_Month > Job_Enterence_Month || Current_Month == Job_Enterence_Month && Current_Day > Job_Enterence_Day && Date_6 <= (TimeSpan.Parse("1825")))
                //{

                   
                //    /*Eğer izin assiged edilen yıl izin hak edilen yıldan büyük ise 1 sene geçmiş demektir o zaman yeni izin hak edecek demektir.*/

                //    if (Assigned_Year > Permit_Right_Year)
                //    {
                //        user.Assigned_Permit = 0;
                //    }

                //    /*Eğer sistemin yılı izin hak edilecek yıla eşit ise*/
                //    //if (Assigned_Year <= Permit_Right_Year && user.Assigned_Permit != -1)
                //    //{
                //    //    Total_Annual_Permit_Count_TextEdit.Text = "14";
                //    //    user.Accumulated_Permit_count = user.Accumulated_Permit_count + Int16.Parse(Total_Annual_Permit_Count_TextEdit.Text);
                //    //    //Accumulated_Permit_Count_TextEdit.Text = user.Accumulated_Permit_count.ToString();
                //    //    Total_Annual_Permit_Count_TextEdit.Text = "0";
                //    //    user.Assigned_Permit = -1;
                //    //}

                //    ///*Eğer 1 yıl geçmiş ise yeni izin hak edebilecek demektir. Bu bloğa girsin kod.*/
                //    //if (Assigned_Year > Permit_Right_Year && user.Assigned_Permit != -1)
                //    //{
                //    //    Total_Annual_Permit_Count_TextEdit.Text = "14";
                //    //    user.Accumulated_Permit_count = user.Accumulated_Permit_count + Int16.Parse(Total_Annual_Permit_Count_TextEdit.Text);
                //    //    //Accumulated_Permit_Count_TextEdit.Text = user.Accumulated_Permit_count.ToString();
                //    //    Total_Annual_Permit_Count_TextEdit.Text = "0";
                //    //    user.Assigned_Permit = -1;
                //    //}
                //}

                //if (Current_Year > Job_Enterence_Year && Current_Month > Job_Enterence_Month || Current_Month == Job_Enterence_Month && Current_Day > Job_Enterence_Day &&  Date_6 >= (TimeSpan.Parse("1825")) || Date_6 >= (TimeSpan.Parse("5475")))
                //{
                //    if (Assigned_Year > Permit_Right_Year)
                //    {
                //        user.Assigned_Permit = 0;
                //    }

                //    if (Assigned_Year <= Permit_Right_Year && user.Assigned_Permit != -1)
                //    {
                //        Total_Annual_Permit_Count_TextEdit.Text = "20";
                //        user.Accumulated_Permit_count = user.Accumulated_Permit_count + Int16.Parse(Total_Annual_Permit_Count_TextEdit.Text);
                //        //Accumulated_Permit_Count_TextEdit.Text = user.Accumulated_Permit_count.ToString();
                //        Total_Annual_Permit_Count_TextEdit.Text = "0";
                //        user.Assigned_Permit = -1;
                //    }

                //    /*Eğer 1 yıl geçmiş ise yeni izin hak edebilecek demektir. Bu bloğa girsin kod.*/
                //    if (Assigned_Year > Permit_Right_Year && user.Assigned_Permit != -1)
                //    {
                //        Total_Annual_Permit_Count_TextEdit.Text = "20";
                //        user.Accumulated_Permit_count = user.Accumulated_Permit_count + Int16.Parse(Total_Annual_Permit_Count_TextEdit.Text);
                //        //Accumulated_Permit_Count_TextEdit.Text = user.Accumulated_Permit_count.ToString();
                //        Total_Annual_Permit_Count_TextEdit.Text = "0";
                //        user.Assigned_Permit = -1;
                //    }

                //}

                //if (Current_Year > Job_Enterence_Year && Current_Month > Job_Enterence_Month || Current_Month == Job_Enterence_Month && Current_Day > Job_Enterence_Day && Date_6 >= (TimeSpan.Parse("5475")))
                //{
                //    if (Assigned_Year > Permit_Right_Year)
                //    {
                //        user.Assigned_Permit = 0;
                //    }

                //    if (Assigned_Year <= Permit_Right_Year && user.Assigned_Permit != -1)
                //    {
                //        Total_Annual_Permit_Count_TextEdit.Text = "26";
                //        user.Accumulated_Permit_count = user.Accumulated_Permit_count + Int16.Parse(Total_Annual_Permit_Count_TextEdit.Text);
                //        //Accumulated_Permit_Count_TextEdit.Text = user.Accumulated_Permit_count.ToString();
                //        Total_Annual_Permit_Count_TextEdit.Text = "0";
                //        user.Assigned_Permit = -1;
                //    }

                //    /*Eğer 1 yıl geçmiş ise yeni izin hak edebilecek demektir. Bu bloğa girsin kod.*/
                //    if (Assigned_Year > Permit_Right_Year && user.Assigned_Permit != -1)
                //    {
                //        Total_Annual_Permit_Count_TextEdit.Text = "26";
                //        user.Accumulated_Permit_count = user.Accumulated_Permit_count + Int16.Parse(Total_Annual_Permit_Count_TextEdit.Text);
                //        //Accumulated_Permit_Count_TextEdit.Text = user.Accumulated_Permit_count.ToString();
                //        Total_Annual_Permit_Count_TextEdit.Text = "0";
                //        user.Assigned_Permit = -1;
                //    }
                //}

                sql_Server_Db_From_Follow_Up_Data_context.SubmitChanges();
                #endregion
            }
            catch (Exception exception)
            {
                messages.Error(exception);
            }
        }



        public void Get_The_Two_Dates_Diffrent()
        {
            //Permit_Used_User_Name_Obj_Id = User_Obj_Id;
            //DAL_Function.User user = sql_Server_Db_From_Follow_Up_Data_context.Users.First(s => s.Obj_Id == Permit_Used_User_Name_Obj_Id);

            DateTime First_Date = DateTime.Parse(Job_Start_Date_DateEdit.Text);
            DateTime Current_Date = DateTime.Now.Date;

            TimeSpan Total_Time = Current_Date.Subtract(First_Date);
            int Total_Day = Convert.ToInt32(Total_Time.TotalDays);

        }

        /// <summary>
        /// Yıllık hak edilecek izin gün sayısı hesaplanıyor
        /// </summary>
        //public string Annual_Permit_Calculating(int Obj_Id)
        //{
        //    DateTime First_Date = DateTime.Parse(Job_Start_Date_DateEdit.Text);
        //    DateTime Current_Date = DateTime.Now.Date;

        //    TimeSpan Total_Time = Current_Date.Subtract(First_Date);
        //    int Total_Day = Convert.ToInt32(Total_Time.TotalDays);


        //    if (Total_Day <= (1825))
        //    {
        //        Total_Annual_Permit_Count_TextEdit.Text = "14";
        //    }

        //    if (Total_Day >= ((5475)))
        //    {
        //        Total_Annual_Permit_Count_TextEdit.Text = "26";

        //    }

        //    if (Total_Day >= ((1825)) && Total_Day<= ((5475)))
        //    {
        //        Total_Annual_Permit_Count_TextEdit.Text = "20";

        //    }

            

        //    return Total_Annual_Permit_Count_TextEdit.Text;
            
        //}

        //public string Total_Permit_Calculating(int Obj_Id)
        //{


        //    Total_Annual_Permit_Count_TextEdit.Text = string.Empty;

        //    return string.Empty;
        //}

        private void Choose_The_annual_Permit_ButtonEdit_Click(object sender, EventArgs e)
        {
            int Obj_Id = get_The_Forms.Annual_Permit_List_Form(true);

            if (Obj_Id > 0)
            {
                Getting_For_Permit_Knowledge(Obj_Id);
            }
            MainMDIForm.Cross = -1;
        }


        private void Name_Surname_TextEdit_Click(object sender, EventArgs e)
        {
            int Obj_Id = get_The_Forms.User_List(true);

            if (Obj_Id > 0)
            {
                Getting_For_Open_Up_User_Name_Surname_Instead_Obj_Id(Obj_Id);
            }
            MainMDIForm.Cross = -1;
            /*Listeden isim seçip kayıt girilmeye başlandı ise kayıtlı bir izin seçilmeyecek demektir.*/
            //Annual_Permit_GroupControl.Enabled = false;
        }
        #endregion

        
        #region Methods

        /// <summary>
        /// 2015_03_31
        /// Toplam birikmiş izin gün sayısını ekrana bas
        /// </summary>
        private void Get_The_Total_Permit_Allowed()
        {

            int Login_Obj_Id = Login_Form.Login_User_Obj_Id;


            SqlConnection sqlConnection = new SqlConnection("Server=10.168.0.26;Database=DentasPro;uid=sa;pwd=dentas;");
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand("Select Accumulated_Permit_count From [User] where Obj_Id = '" + Login_Obj_Id + "'", sqlConnection);

            SqlParameter param = new SqlParameter();
            param.ParameterName = "@Login_Obj_Id";
            param.Value = Login_Obj_Id;

            sqlCommand.Parameters.Add(param);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    //Total_Permit_Allowed_TextEdit.Text = sqlDataReader.GetString(0);
                }
            }
            //string Login_User = sqlCommand;
            //Logined_User_Name_SurName_BarButtonItem.Caption = Login_User;        }
        #endregion
        }

        /// <summary>
        /// Kalan izin adedi hesaplanıyor
        /// </summary>
        public static int Calculate_Annual_Permit_Remainig(DateTime birth_Time)
        {

            int age = DateTime.Now.Year - birth_Time.Year;

            if ((birth_Time.Month > DateTime.Now.Month) || (birth_Time.Month == DateTime.Now.Month && birth_Time.Day > DateTime.Now.Day))
                age--;

            return age;
        }

        /// <summary>
        /// 2015_04_02:17:13
        /// İrfan_d.
        /// Kontrl'e data aktarmak ...() için
        /// http://blog.xeasec.com/c-il-ilce-semt-mahalle-secimi-uygulamasi-veritabani.html
        /// </summary>
        public void Geo_Knowledge_Load_to_Control(ComboBoxEdit comboBoxEdit, string query, string column_Name)
        {
            comboBoxEdit.Properties.Items.Clear();

            SqlConnection sql_Connection = new SqlConnection("Server=10.168.0.26;Database=DentasPro;uid=sa;pwd=dentas;");
            SqlCommand sql_command;

            SqlDataAdapter sql_DataAdapter = new SqlDataAdapter(query, sql_Connection);

            try
            {
                sql_Connection.Open();
                sql_command = new SqlCommand(query, sql_Connection);

                SqlDataReader sql_DataReader = sql_command.ExecuteReader();

                while (sql_DataReader.Read())
                {
                    comboBoxEdit.Properties.Items.Add(sql_DataReader[column_Name].ToString());
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                sql_DataAdapter.Dispose();
                sql_Connection.Close();
            }
        }

        public string Get_Values(string query, string column_Name)
        {
            SqlConnection sql_Connection = new SqlConnection("Server=10.168.0.26;Database=DentasPro;uid=sa;pwd=dentas;");
            SqlCommand sql_command;

            sql_command = new SqlCommand(query, sql_Connection);

            SqlDataReader sql_DataReader;
            sql_Connection.Open();

            try
            {
                sql_DataReader = sql_command.ExecuteReader();
                if (sql_DataReader.Read())
                {
                    return sql_DataReader[column_Name].ToString();
                }
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
            sql_Connection.Close();
            return null;
        }

        /// <summary>
        /// City kontrolünü dolduruyoruz.
        /// </summary>

        private void Embed_The_Coutry()
        {
            int Country_Obj_Id = 212;


            SqlConnection sqlConnection = new SqlConnection("Server=10.168.0.26;Database=DentasPro;uid=sa;pwd=dentas;");
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand("Select Name From [Country] where Obj_Id = '" + Country_Obj_Id + "'", sqlConnection);

            SqlParameter param = new SqlParameter();
            param.ParameterName = "@Country_Obj_Id";
            param.Value = Country_Obj_Id;

            sqlCommand.Parameters.Add(param);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    //Logined_User_Name_SurName_BarButtonItem.Caption = sqlDataReader.GetString(0);
                    //Country_ComboBoxEdit.Text = sqlDataReader.GetString(0);
                }
            }
            //string Login_User = sqlCommand;
            //Logined_User_Name_SurName_BarButtonItem.Caption = Login_User;

        }

       

        //private int Get_The_Total_Permit_Allowed(int Selected_User_Obj_Id)
        //{
        //    int Login_Obj_Id = Selected_User_Obj_Id;

        //    int Total_Permit_Allowed = 0;

        //    SqlConnection sqlConnection = new SqlConnection("Server=10.168.0.26;Database=DentasPro;uid=sa;pwd=dentas;");
        //    sqlConnection.Open();

        //    SqlCommand sqlCommand = new SqlCommand("Select Accumulated_Permit_count_Knowledge_Data From [Annual_Permit] where User_Obj_Id = '" + Login_Obj_Id + "'", sqlConnection);

        //    SqlParameter param = new SqlParameter();
        //    param.ParameterName = "@Login_Obj_Id";
        //    param.Value = Login_Obj_Id;

        //    sqlCommand.Parameters.Add(param);

        //    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

        //    if (sqlDataReader.HasRows)
        //    {
        //        while (sqlDataReader.Read())
        //        {
        //            Total_Permit_Allowed = sqlDataReader.GetInt32(0);
        //        }
        //    }
        //    return Total_Permit_Allowed;
        //    //string Login_User = sqlCommand;
        //    //Logined_User_Name_SurName_BarButtonItem.Caption = Login_User;        }
        //}


        /**/
        /*
         * 1-İş'e giriş tarihini bul
         * 2-Bugünün tarihini bul
         *     eğer eşit ise
         *     user.Accumlated_PErmit_.... ya hak edilen izni ekle.
         */

        /// <summary>
        ///Dev_Date   : 2015_06_01
        ///Description : Eğer kullanıcının işe giriş tarihi bu güne eşit ise yen  izni hak etmiş demektir. Bakiyenin üzerine ekliyoruz.
        ///               Bu ekran otomatik olarak açılacak ki izin hesaplaması yapsın.
        /// </summary>
        public void Staff_Has_Right_Annual_Permit(int Obj_Id)
        {
            try
            {
                Permit_Used_User_Name_Obj_Id = Obj_Id;
                DAL_Function.User user = sql_Server_Db_From_Follow_Up_Data_context.Users.First(s => s.Obj_Id == Permit_Used_User_Name_Obj_Id);

                string Start_Job_Date = Job_Start_Date_DateEdit.Text;

                Name_Surname_TextEdit.Text = user.Full_Name;
                Registration_Number_TextEdit.Text = user.Registration_Number;
            }
            catch (Exception exception)
            {
                throw;
            }
        }

        public void Is_Authorized()
        {
            if (Login_Form.Login_User_Obj_Id != 17 && Login_Form.Login_User_Obj_Id != 9 && Login_Form.Login_User_Obj_Id != 8 && Login_Form.Login_User_Obj_Id != 1 && Login_Form.Login_User_Obj_Id != 16)
            {
                MessageBox.Show("Personel kayıt ekranına girmeye yetkili değilsiniz", "Yetki Kontrol", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }

        private void Add_New_Annual_Day(int Obj_Id)
        {
            Edit = true;
            User_Obj_Id = Obj_Id;
            DAL_Function.User user = sql_Server_Db_From_Follow_Up_Data_context.Users.First(s => s.Obj_Id == User_Obj_Id);
            
            int Last_Add_Permit = 0;

            if (string.IsNullOrEmpty(Adding_Annual_Permit_Day_TextEdit.Text))
            {
                Adding_Annual_Permit_Day_TextEdit.Text = string.Empty;
            }
            else
            {
                Last_Add_Permit = int.Parse(Adding_Annual_Permit_Day_TextEdit.Text) + int.Parse(Total_Annual_Permit_Count_TextEdit.Text);

            }
            if (string.IsNullOrEmpty( Description_Of_Adding_Annual_PermitMemoEdit.Text))
            {
                MessageBox.Show("Mutlaka açıklama yazmalısınız","İzin Açıklaması",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                Description_Of_Adding_Annual_PermitMemoEdit.Focus();
                return;
            }
            Total_Annual_Permit_Count_TextEdit.Text = Last_Add_Permit.ToString();
            user.Accumulated_Permit_count = int.Parse(Total_Annual_Permit_Count_TextEdit.Text);
            sql_Server_Db_From_Follow_Up_Data_context.SubmitChanges();

            Adding_Annual_Permit_Day_TextEdit.Text = string.Empty;
            
        }

        private void Save_SimpleButton_Click(object sender, EventArgs e)
        {
            Add_New_Annual_Day(User_Obj_Id);
        }

        private void Close_SimpleButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Help_Knowledge_SimpleButton_Click(object sender, EventArgs e)
        {
            Add_Annual_Permit_Help_Form add_Annual_Permit_Help_Form = new Add_Annual_Permit_Help_Form();
            add_Annual_Permit_Help_Form.Show();
        }

        private void Add_Annual_Permit_Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                Add_Annual_Permit_Help_Form add_Annual_Permit_Help_Form = new Add_Annual_Permit_Help_Form();
                add_Annual_Permit_Help_Form.ShowDialog();
                //travel_Expense_Help_Form.Show();
            }
        }


//user.Accumulated_Permit_count.ToString();            
    }

}
