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

    using DevExpress.XtraEditors;
    using Dentas_Pro.UI.Base;
    using DevExpress.XtraGrid.Views.Grid;
    using System.Data.SqlClient;
    using Dentas_Pro.UI.DAL_Function;
    using DevExpress.Data;
    using DevExpress.XtraGrid.Columns;
    using DevExpress.XtraGrid.Views.Layout;

    public partial class Daily_Hour_Permit_Form : DevExpress.XtraEditors.XtraForm
    {
        public Daily_Hour_Permit_Form()
        {
            InitializeComponent();
            Name_Surname_TextEdit.Enabled = false;         
            Getting_For_Open_Up_User_Name_Surname_Instead_Obj_Id(Login_Form.Login_User_Obj_Id);
        }

        #region Fields

        public bool Edit = false;
        public int User_Obj_Id = -1;
        public int Daily_Hour_Permit_Obj_Id = -1;
        public int Permit_Used_User_Name_Obj_Id = -1;
        public int Choose_Obj_Id = -1;
        public int Department_Responsible_Obj_Id = -1;
        public int Department_Manager_Obj_Id = -1;
        public int Department_Obj_Id = -1;
        public int Expense_Group_Obj_Id = -1;
        public int Title_Obj_Id = -1;
        public int Permit_Reason_Obj_Id = -1;
        #endregion

        DAL_Function.Sql_Server_DB_From_DentasProDataContext sql_Server_Db_From_Follow_Up_Data_context = new DAL_Function.Sql_Server_DB_From_DentasProDataContext();
        DAL_Function.Get_The_Form get_The_Forms = new DAL_Function.Get_The_Form();
        DAL_Function.Messages messages = new DAL_Function.Messages();
        UI.Mail.Send_An_E_Mail send_An_E_Mail = new Mail.Send_An_E_Mail();

        #region Events

        public void Getting_For_Saved_Daily_Hour_List(int Obj_Id)
        {
            try
            {
                /* Gelen Obj_Id > 0 dan ise bı işleri yap da diyebiliriz.*/
                Edit = true;
                Daily_Hour_Permit_Obj_Id = Obj_Id;
                DAL_Function.Daily_Hour_Permit daily_Hour_Permit = (sql_Server_Db_From_Follow_Up_Data_context.Daily_Hour_Permits.First(s => s.Obj_Id == Daily_Hour_Permit_Obj_Id));

                Name_Surname_TextEdit.Text = daily_Hour_Permit.User_Obj_Id.ToString();
                Department_Name_TextEdit.Text = daily_Hour_Permit.Department_Obj_Id.ToString();
                Job_Title_TextEdit.Text = daily_Hour_Permit.Title_Obj_Id.ToString();
                Department_Responsible_TextEdit.Text = daily_Hour_Permit.Department_Chief_Obj_Id.ToString();
                Department_Manager_TextEdit.Text = daily_Hour_Permit.Department_Manager_Obj_Id.ToString();
                Start_Date_DateEdit.Text = daily_Hour_Permit.Permit_Start_Time.Value.ToString("dd.MM.yyyy");
                End_Date_DateEdit.Text = daily_Hour_Permit.Permit_End_Time.Value.ToString("dd.MM.yyyy");
                Permit_Type_ComboBoxEdit.Text = daily_Hour_Permit.Permit_Type;
                Permit_Reason_ButtonEdit.Text = daily_Hour_Permit.Permit_Reason_Obj_Id.ToString();

                /*
                 * 2015_04_14_14:25
                 * İzin onay notları
                 */
                Department_Manager_Apporoval_Description_MemoEdit.Text = daily_Hour_Permit.Department_Manager_Apporoval_Description;
                Department_Responsible_Approval_Description_MemoEdit.Text = daily_Hour_Permit.Department_Responsible_Approval_Description;
                Human_Resource_Approval_Description_MemoEdit.Text = daily_Hour_Permit.Human_Resource_Approval_Description;
                Wet_Signature_Description_MemoEdit.Text = daily_Hour_Permit.Wet_Signature_Description;




                Getting_For_Department_Name_Instead_Obj_Id(daily_Hour_Permit.Department_Obj_Id.Value);
                Getting_For_Title_Name_Instead_Obj_Id(daily_Hour_Permit.Title_Obj_Id.Value);
                Getting_For_Permit_Used_User_Name_Instead_Obj_Id(daily_Hour_Permit.User_Obj_Id.Value);
                Getting_For_Permit_Reason_Name_Instead_Obj_Id(daily_Hour_Permit.Permit_Reason_Obj_Id.Value);

                Start_Hour_TimeEdit.Text = daily_Hour_Permit.Permit_Start_Hour;
                End_Hour_TimeEdit.Text = daily_Hour_Permit.Permit_End_Hour;

                Description_MemoEdit.Text = daily_Hour_Permit.Description;



                if (daily_Hour_Permit.Paraph_Human_Resource_Situation == true)
                {
                    Human_Resource_Approval_ComboBoxEdit.Text = "Onaylandı";
                }
                if (daily_Hour_Permit.Paraph_Human_Resource_Situation == false)
                {
                    Human_Resource_Approval_ComboBoxEdit.Text = "Onaylanmadı";
                }




                if (daily_Hour_Permit.Approval_Department_Responsible_Situation == true)
                {
                    Department_Responsible_Approval_ComboBoxEdit.SelectedIndex = 1;
                }
                if (daily_Hour_Permit.Approval_Department_Responsible_Situation == false)
                {
                    Department_Responsible_Approval_ComboBoxEdit.SelectedIndex = 2;
                }




                if (daily_Hour_Permit.Approval_Department_Manager_Situation == true)
                {
                    Department_Manager_Apporoval_ComboBoxEdit.Text = "Onaylandı";
                }
                if (daily_Hour_Permit.Approval_Department_Manager_Situation == false)
                {
                    Department_Manager_Apporoval_ComboBoxEdit.Text = "Onaylanmadı";
                }

                if (daily_Hour_Permit.Wet_Signature_Situation == true)
                {
                    Wet_Signature_ComboBoxEdit.Text = "Alındı";
                }
                if (daily_Hour_Permit.Wet_Signature_Situation == false)
                {
                    Wet_Signature_ComboBoxEdit.Text = "Alınmadı";
                }


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
                    Getting_For_Open_Up_Department_Manager_Name_Surname_Instead_Obj_Id(daily_Hour_Permit.Department_Manager_Obj_Id.Value);
                    Department_Responsible_LabelControl.Visible = false;
                    Department_Responsible_TextEdit.Visible = false;
                }
                else
                {
                    Getting_For_Open_Up_Department_Responsible_Name_Surname_Instead_Obj_Id(daily_Hour_Permit.Department_Chief_Obj_Id.Value);
                    Getting_For_Open_Up_Department_Manager_Name_Surname_Instead_Obj_Id(daily_Hour_Permit.Department_Manager_Obj_Id.Value);
                    Department_Responsible_LabelControl.Visible = true;
                    Department_Responsible_TextEdit.Visible = true;
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

        public void Getting_For_Permit_Reason_Name_Instead_Obj_Id(int Obj_Id)
        {
            try
            {
                Permit_Reason_Obj_Id = Obj_Id;
                DAL_Function.Permit_Reason permit_Reason = sql_Server_Db_From_Follow_Up_Data_context.Permit_Reasons.First(s => s.Obj_Id == Permit_Reason_Obj_Id);

                Permit_Reason_ButtonEdit.Text = permit_Reason.Name;
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
                DAL_Function.User user = sql_Server_Db_From_Follow_Up_Data_context.Users.First(s => s.Obj_Id == Department_Manager_Obj_Id);

                Department_Manager_TextEdit.Text = user.Full_Name;
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

                Department_Responsible_TextEdit.Text = user.Full_Name;
            }
            catch (Exception exception)
            {
                //MessageBox.Show("Departman sorumlusu atanmamış !..", "Departman Sorumlusu Boş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void End_Date_DateEdit_Leave(object sender, EventArgs e)
        {
            Calculate_The_Permit_Age_Day();
            DateDiff_Is_Positive();
        }

        public void DateDiff_Is_Positive()
        {
            DateTime start = DateTime.Parse(Start_Date_DateEdit.Text);
            DateTime end = DateTime.Parse(End_Date_DateEdit.Text);

            //    TimeSpan timeSpan = end.Subtract(start);
            //    int Login_Obj_Id = Login_Form.Login_User_Obj_Id;


            if (end < start)
            {
                MessageBox.Show("İlk Tarihten Küçük Tarih Seçemezsiniz..");
                End_Date_DateEdit.Focus();
            }
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
                Department_Responsible_TextEdit.Text = user.Department_Responsible_Obj_Id.Value.ToString();
                Department_Manager_TextEdit.Text = user.Department_Manager_Obj_Id.Value.ToString();



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
                    Department_Responsible_TextEdit.Visible = false;
                    Department_Responsible_LabelControl.Visible = false;
                }
                if (user.Department_Manager_Obj_Id == -1)
                {
                    MessageBox.Show("Personele 'Departman Müdürü' atanmamış", "EKSİK BİLGİ...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Save_SimpleButton.Enabled = false;
                }
                else
                {
                    Getting_For_Open_Up_Department_Manager_Name_Surname_Instead_Obj_Id(user.Department_Manager_Obj_Id.Value);
                }


            }
            catch (Exception exception)
            {

                messages.Error(exception);
            }
            Set_The_Control_Visible();
        }

        private void Choose_The_Daily_Hour_Permit_ButtonEdit_Click(object sender, EventArgs e)
        {
            int Obj_Id = get_The_Forms.Daily_Hour_Permit_List_Form(true);

            if (Obj_Id > 0)
            {
                Getting_For_Saved_Daily_Hour_List(Obj_Id);
                Manager_Approved_Disable_The_Controls();
                Manager_Doesnt_Approved_Enable_The_Controls();
            }
            MainMDIForm.Cross = -1;
        }

        public void Getting_For_Permit_Reason(int Obj_Id)
        {
            try
            {
                Edit = true;
                Permit_Reason_Obj_Id = Obj_Id;
                DAL_Function.Permit_Reason permit_Reason = sql_Server_Db_From_Follow_Up_Data_context.Permit_Reasons.First(s => s.Obj_Id == Permit_Reason_Obj_Id);

                Permit_Reason_ButtonEdit.Text = permit_Reason.Name;
            }
            catch (Exception)
            {
                throw;
            }
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
            Daily_Hour_Permit_GroupControl.Enabled = false;
        }
        #endregion

        #region Button Click Events

        private void Clean_The_Control_Value_SimpleButton_Click(object sender, EventArgs e)
        {
            Clean_The_Control();
            Save_SimpleButton.Enabled = true;

        }

        private void Permit_Reason_ButtonEdit_Click(object sender, EventArgs e)
        {
            int Obj_Id = get_The_Forms.Permit_Reason_Form(true);

            if (Obj_Id > 0)
            {
                Getting_For_Permit_Reason(Obj_Id);
            }
            MainMDIForm.Cross = -1;
        }

        private void Save_SimpleButton_Click(object sender, EventArgs e)
        {
            if (Daily_Hour_Permit_Obj_Id < 0)
            {
                Get_Data_From_UI();
            }
            else if (Edit && Department_Obj_Id > 0 && messages.Update() == DialogResult.Yes)
            {
                Update_Data_From_DB();
            }
        }

        private void Close_SimpleButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Delete_SimpleButton_Click(object sender, EventArgs e)
        {
            if (Edit && Daily_Hour_Permit_Obj_Id > 0 && messages.Delete() == DialogResult.Yes)
            {
                Delete_the_Record();
            }
        }
        #endregion

        #region Methods

        public void Get_Data_From_UI()
        {
            if (Name_Surname_TextEdit.Text == "" || Name_Surname_TextEdit.Text == null)
            {
                MessageBox.Show("İzim seçmelisiniz..", "İsim Bilgisi Eksik", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Name_Surname_TextEdit.Focus();
                return;
            }
            else if (Start_Date_DateEdit.Text == "" || Start_Date_DateEdit.Text == null)
            {
                MessageBox.Show("İzin başlangıç tarihini seçmelisini..", "İzin Başlangıç Tarihi eksik", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                /*İmleç konumlanıyor*/
                Start_Date_DateEdit.Focus();
                return;
            }
            else if (End_Date_DateEdit.Text == "" || End_Date_DateEdit.Text == null)
            {
                MessageBox.Show("İzin bitiş tarihini seçmelisiniz..", "İzin Bitiş Tarihi Eksik", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                End_Date_DateEdit.Focus();
                return;
            }

            else if (Permit_Reason_ButtonEdit.Text == "" || Permit_Reason_ButtonEdit.Text == null)
            {
                MessageBox.Show("İzin sebebi seçmelisiniz..", "İzin Sebebi Eksik", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Permit_Reason_ButtonEdit.Focus();
                return;
            }

            else if (Permit_Type_ComboBoxEdit.Text == "" || Permit_Type_ComboBoxEdit.Text == null)
            {
                MessageBox.Show("İzin türü seçmelisiniz..", "İzin Türü Eksik", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Permit_Type_ComboBoxEdit.Focus();
                return;
            }
            else if (Department_Responsible_TextEdit.Text == "" || Department_Responsible_TextEdit.Text == null)
            {
                MessageBox.Show("Departman sorumlusunu seçmelisiniz..", "Departman Sorumlusu Eksik", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Department_Responsible_TextEdit.Focus();
                return;
            }
            else if (Department_Manager_TextEdit.Text == "" || Department_Manager_TextEdit.Text == null)
            {
                MessageBox.Show("Departman yöneticisini seçmelisiniz..", "Departman Yöneticisi Eksik", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Department_Manager_TextEdit.Focus();
                return;
            }

            try
            {
                DAL_Function.Daily_Hour_Permit daily_Hour_Permit = new DAL_Function.Daily_Hour_Permit();

                daily_Hour_Permit.User_Obj_Id = User_Obj_Id;
                daily_Hour_Permit.Permit_Start_Time = DateTime.Parse(Start_Date_DateEdit.Text);
                daily_Hour_Permit.Permit_End_Time = DateTime.Parse(End_Date_DateEdit.Text);

                if (Start_Hour_TimeEdit.Text == "")
                {
                    daily_Hour_Permit.Permit_Start_Hour = "00:00";
                }
                else
                {
                    daily_Hour_Permit.Permit_Start_Hour = Start_Hour_TimeEdit.Text;
                }
                if (End_Hour_TimeEdit.Text == "")
                {
                    daily_Hour_Permit.Permit_End_Hour = "00:00";
                }
                else
                {
                    daily_Hour_Permit.Permit_End_Hour = End_Hour_TimeEdit.Text;
                }
                daily_Hour_Permit.Permit_Reason_Obj_Id = Permit_Reason_Obj_Id;
                daily_Hour_Permit.Permit_Type = Permit_Type_ComboBoxEdit.Text;
                daily_Hour_Permit.Description = Description_MemoEdit.Text;

                /*
                 * İzin onay notları
                 * 2015_04_14
                 */
                daily_Hour_Permit.Department_Manager_Apporoval_Description = Department_Manager_Apporoval_Description_MemoEdit.Text;
                daily_Hour_Permit.Department_Responsible_Approval_Description = Department_Responsible_Approval_Description_MemoEdit.Text;
                daily_Hour_Permit.Human_Resource_Approval_Description = Human_Resource_Approval_Description_MemoEdit.Text;
                daily_Hour_Permit.Wet_Signature_Description = Wet_Signature_Description_MemoEdit.Text;

                daily_Hour_Permit.Department_Chief_Obj_Id = Department_Responsible_Obj_Id;
                daily_Hour_Permit.Department_Obj_Id = Department_Obj_Id;
                daily_Hour_Permit.Department_Manager_Obj_Id = Department_Manager_Obj_Id;
                daily_Hour_Permit.Title_Obj_Id = Title_Obj_Id;

                /*Value: 1 ise True*/
                if (Department_Responsible_Approval_ComboBoxEdit.SelectedIndex == 1)
                {
                    daily_Hour_Permit.Approval_Department_Responsible_Situation = true;
                }
                //Department_Responsible_Approval_ComboBoxEdit.SelectedIndex == 2
                if (Department_Responsible_Approval_ComboBoxEdit.SelectedIndex == 2)
                {
                    daily_Hour_Permit.Approval_Department_Responsible_Situation = false;
                }



                if (Department_Manager_Apporoval_ComboBoxEdit.SelectedIndex == 1)
                {
                    daily_Hour_Permit.Approval_Department_Manager_Situation = true;
                }

                if (Department_Manager_Apporoval_ComboBoxEdit.SelectedIndex == 2)
                {
                    daily_Hour_Permit.Approval_Department_Manager_Situation = false;
                }


                if (Human_Resource_Approval_ComboBoxEdit.SelectedIndex == 1)
                {
                    daily_Hour_Permit.Paraph_Human_Resource_Situation = true;
                }

                if (Human_Resource_Approval_ComboBoxEdit.SelectedIndex == 2)
                {
                    daily_Hour_Permit.Paraph_Human_Resource_Situation = false;
                }

                if (Wet_Signature_ComboBoxEdit.SelectedIndex==1)
                {
                    daily_Hour_Permit.Wet_Signature_Situation = true;
                }

                if (Wet_Signature_ComboBoxEdit.SelectedIndex==2)
                {
                    daily_Hour_Permit.Wet_Signature_Situation = false;
                }

                daily_Hour_Permit.Insert_User = Login_Form.Login_User_Obj_Id;
                daily_Hour_Permit.Insert_Time = DateTime.Now;
                if (Calculate_The_Permit_Age_Day())
                {
                    return;
                }

                if (Permit_Reason_ButtonEdit.Text == "Diğer" && string.IsNullOrEmpty( Description_MemoEdit.Text))
                {
                    MessageBox.Show("Lütfen açıklama giriniz..");
                    Description_MemoEdit.Focus();
                        return;
                }

                sql_Server_Db_From_Follow_Up_Data_context.Daily_Hour_Permits.InsertOnSubmit(daily_Hour_Permit);
                sql_Server_Db_From_Follow_Up_Data_context.SubmitChanges();
                messages.New_Record("İzin kaydınız başarı ile yapıldı");
                Clean_The_Control();
                //Daily_Hour_Permit_GroupControl.Enabled = true;
                Choose_The_Daily_Hour_Permit_ButtonEdit.Enabled = true;

                /*
                İzin Formllarının onay adımları hiyerarşik olsun."Yönetmen" onaylamadan "Müdür" onaylayamasın gibi..
                1. Yönetmen
                2. Müdür
                3. IK
                 */

                send_An_E_Mail.Send_An_E_Mail_(User_Obj_Id, From_Mail_(), From_Mail_(), "Günlük izin Talebi", From_Full_Name_() + " tarafından Günlük & Saatlik İzin Talebi Yapıldı");

                if (daily_Hour_Permit.Department_Chief_Obj_Id != 1)
                {
                    //return;
                }
                else
                {
                    send_An_E_Mail.Send_An_E_Mail_(User_Obj_Id, From_Mail_(), to_Mail_Department_Responsible(daily_Hour_Permit.Department_Chief_Obj_Id), "Günlük izin Talebi", From_Full_Name_() + " tarafından Günlük & Saatlik İzin Talebi Yapıldı");
                }

                if (daily_Hour_Permit.Department_Manager_Obj_Id != -1)
                {
                    send_An_E_Mail.Send_An_E_Mail_(User_Obj_Id, From_Mail_(), to_Mail_Department_Manager(daily_Hour_Permit.Department_Manager_Obj_Id), "Günlük izin Talebi", From_Full_Name_() + " tarafından Günlük & Saatlik İzin Talebi Yapıldı");
                }

            }
            catch (Exception exception)
            {
                messages.Error(exception);
            }
        }

        public string From_Mail_()
        {
            int Login_Obj_Id = Login_Form.Login_User_Obj_Id;
            string From_Mail = string.Empty;


            SqlConnection sqlConnection = new SqlConnection("Server=10.168.0.26;Database=DentasPro;uid=sa;pwd=dentas;");
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand("Select E_Mail From [User] where Obj_Id = '" + Login_Obj_Id + "'", sqlConnection);

            SqlParameter param = new SqlParameter();
            param.ParameterName = "@Login_Obj_Id";
            param.Value = Login_Obj_Id;

            sqlCommand.Parameters.Add(param);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    From_Mail = sqlDataReader.GetString(0);
                }
            }
            return From_Mail;
        }

        /// <summary>
        /// Yazılıyor henüz..
        /// 2015_04_13:11_13
        /// <returns></returns>
        public string to_Mail_Department_Responsible(int? Department_Responsible_Obj_Id)
        {
            int? Login_Obj_Id = Department_Responsible_Obj_Id;
            string From_Mail = string.Empty;


            SqlConnection sqlConnection = new SqlConnection("Server=10.168.0.26;Database=DentasPro;uid=sa;pwd=dentas;");
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand("Select E_Mail From [User] where Obj_Id = '" + Login_Obj_Id + "'", sqlConnection);

            SqlParameter param = new SqlParameter();
            param.ParameterName = "@Login_Obj_Id";
            param.Value = Login_Obj_Id;

            sqlCommand.Parameters.Add(param);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    From_Mail = sqlDataReader.GetString(0);
                }
            }
            return From_Mail;
        }

        public string to_Mail_Department_Manager(int? Department_Manager_Obj_Id)
        {
            int? Login_Obj_Id = Department_Manager_Obj_Id;
            string From_Mail = string.Empty;


            SqlConnection sqlConnection = new SqlConnection("Server=10.168.0.26;Database=DentasPro;uid=sa;pwd=dentas;");
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand("Select E_Mail From [User] where Obj_Id = '" + Login_Obj_Id + "'", sqlConnection);

            SqlParameter param = new SqlParameter();
            param.ParameterName = "@Login_Obj_Id";
            param.Value = Login_Obj_Id;

            sqlCommand.Parameters.Add(param);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    From_Mail = sqlDataReader.GetString(0);
                }
            }
            return From_Mail;
        }

        public string Permit_Owner(int? Permit_Owner_User_Obj_Id)
        {
            int? Login_Obj_Id = Permit_Owner_User_Obj_Id;
            string From_Mail = string.Empty;


            SqlConnection sqlConnection = new SqlConnection("Server=10.168.0.26;Database=DentasPro;uid=sa;pwd=dentas;");
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand("Select E_Mail From [User] where Obj_Id = '" + Login_Obj_Id + "'", sqlConnection);

            SqlParameter param = new SqlParameter();
            param.ParameterName = "@Login_Obj_Id";
            param.Value = Login_Obj_Id;

            sqlCommand.Parameters.Add(param);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    From_Mail = sqlDataReader.GetString(0);
                }
            }
            return From_Mail;
        }

        public string From_Full_Name_()
        {
            int Login_Obj_Id = Login_Form.Login_User_Obj_Id;
            string From_Mail = string.Empty;


            SqlConnection sqlConnection = new SqlConnection("Server=10.168.0.26;Database=DentasPro;uid=sa;pwd=dentas;");
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand("Select Full_Name From [User] where Obj_Id = '" + Login_Obj_Id + "'", sqlConnection);

            SqlParameter param = new SqlParameter();
            param.ParameterName = "@Login_Obj_Id";
            param.Value = Login_Obj_Id;

            sqlCommand.Parameters.Add(param);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    From_Mail = sqlDataReader.GetString(0);
                }
            }
            return From_Mail;
        }



        public void Update_Data_From_DB()
        {
            try
            {
                DAL_Function.Daily_Hour_Permit daily_Hour_Permit = sql_Server_Db_From_Follow_Up_Data_context.Daily_Hour_Permits.First(s => s.Obj_Id == Daily_Hour_Permit_Obj_Id);

                /*daily_Hour_Permit.User_Obj_Id = User_Obj_Id;*/
                daily_Hour_Permit.Permit_Start_Time = DateTime.Parse(Start_Hour_TimeEdit.Text);
                daily_Hour_Permit.Permit_End_Time = DateTime.Parse(End_Hour_TimeEdit.Text);
                daily_Hour_Permit.Permit_Start_Hour = Start_Hour_TimeEdit.Text;
                daily_Hour_Permit.Permit_End_Hour = End_Hour_TimeEdit.Text;
                daily_Hour_Permit.Permit_Reason_Obj_Id = Permit_Reason_Obj_Id;
                daily_Hour_Permit.Permit_Type = Permit_Type_ComboBoxEdit.Text;
                daily_Hour_Permit.Description = Description_MemoEdit.Text;

                daily_Hour_Permit.Department_Manager_Apporoval_Description = Department_Manager_Apporoval_Description_MemoEdit.Text;
                daily_Hour_Permit.Department_Responsible_Approval_Description = Department_Responsible_Approval_Description_MemoEdit.Text;
                daily_Hour_Permit.Human_Resource_Approval_Description = Human_Resource_Approval_Description_MemoEdit.Text;
                daily_Hour_Permit.Wet_Signature_Description = Wet_Signature_Description_MemoEdit.Text;

                daily_Hour_Permit.Department_Chief_Obj_Id = Department_Responsible_Obj_Id;
                daily_Hour_Permit.Department_Obj_Id = Department_Obj_Id;
                daily_Hour_Permit.Department_Manager_Obj_Id = Department_Manager_Obj_Id;
                daily_Hour_Permit.Update_Time = DateTime.Now;
                daily_Hour_Permit.Update_User = Login_Form.Login_User_Obj_Id;

                /*Value: 1 ise True*/
                if (Department_Responsible_Approval_ComboBoxEdit.SelectedIndex == 1)
                {
                    daily_Hour_Permit.Approval_Department_Responsible_Situation = true;
                }

                if (Department_Responsible_Approval_ComboBoxEdit.SelectedIndex == 2)
                {
                    daily_Hour_Permit.Approval_Department_Responsible_Situation = false;
                }




                if (Department_Manager_Apporoval_ComboBoxEdit.SelectedIndex == 1)
                {
                    daily_Hour_Permit.Approval_Department_Manager_Situation = true;
                }

                if (Department_Manager_Apporoval_ComboBoxEdit.SelectedIndex == 2)
                {
                    daily_Hour_Permit.Approval_Department_Manager_Situation = false;
                }




                if (Human_Resource_Approval_ComboBoxEdit.SelectedIndex == 1)
                {
                    daily_Hour_Permit.Paraph_Human_Resource_Situation = true;
                }

                if (Human_Resource_Approval_ComboBoxEdit.SelectedIndex == 2)
                {
                    daily_Hour_Permit.Paraph_Human_Resource_Situation = false;
                }

                if (Wet_Signature_ComboBoxEdit.SelectedIndex == 1)
                {
                    daily_Hour_Permit.Wet_Signature_Situation = true;
                }

                if (Wet_Signature_ComboBoxEdit.SelectedIndex == 2)
                {
                    daily_Hour_Permit.Wet_Signature_Situation = false;
                }

                /*İzin Departman Müdürü tarafından onaylanmış ise İzin talebi yapana mail gönderiyoruz*/
                if (Department_Manager_Apporoval_ComboBoxEdit.SelectedIndex == 1)
                {
                    send_An_E_Mail.Send_An_E_Mail_(User_Obj_Id, From_Mail_(), Permit_Owner(daily_Hour_Permit.User_Obj_Id), "Günlük & saatlik izin talebiniz Departman Müdürü tarafından onaylandı", "Günlük & Saatlik İzin Onay");
                }

                /*Deparman Sorumlusu Onaylandığında*/
                if (Department_Responsible_Approval_ComboBoxEdit.SelectedIndex == 1)
                {
                    send_An_E_Mail.Send_An_E_Mail_(User_Obj_Id, From_Mail_(), Permit_Owner(daily_Hour_Permit.User_Obj_Id), "Günlük & saatlik izin talebiniz Departman Sorumlunuz tarafından onaylandı", "Günlük & Saatlik İzin Onay");
                }

                /*İnsan kaynakları onayladığında*/
                if (Human_Resource_Approval_ComboBoxEdit.SelectedIndex == 1)
                {
                    send_An_E_Mail.Send_An_E_Mail_(User_Obj_Id, From_Mail_(), Permit_Owner(daily_Hour_Permit.User_Obj_Id), "Günlük & saatlik izin talebiniz İnsan Kaynakları tarafından onaylandı", "Günlük & Saatlik İzin Onay");
                }


                sql_Server_Db_From_Follow_Up_Data_context.SubmitChanges();
                messages.Update(true);
                Clean_The_Control();
                Daily_Hour_Permit_GroupControl.Enabled = true;

            }
            catch (Exception exception)
            {
                messages.Error(exception);
            }
        }

        public void Delete_the_Record()
        {
            try
            {
                sql_Server_Db_From_Follow_Up_Data_context.Daily_Hour_Permits.DeleteOnSubmit(sql_Server_Db_From_Follow_Up_Data_context.Daily_Hour_Permits.First(s => s.Obj_Id == Daily_Hour_Permit_Obj_Id));

                int Choosen_Daily_Hour_Permit_Obj_Id = Daily_Hour_Permit_Obj_Id;
                bool Situation;

                SqlConnection sqlConnection = new SqlConnection("Server=10.168.0.26;Database=DentasPro;uid=sa;pwd=dentas;");
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("Select Approval_Department_Manager_Situation, Approval_Department_Responsible_Situation From [Daily_Hour_Permit] where Obj_Id = '" + Choosen_Daily_Hour_Permit_Obj_Id + "'", sqlConnection);

                SqlParameter param = new SqlParameter();
                param.ParameterName = "@Choosen_Daily_Hour_Permit_Obj_Id";
                param.Value = Choosen_Daily_Hour_Permit_Obj_Id;

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                if (Login_Form.Login_User_Obj_Id != 18 && Login_Form.Login_User_Obj_Id != 19)
                {
                    if (sqlDataReader.HasRows)
                    {
                        while (sqlDataReader.Read() != null)
                        {
                            Situation = sqlDataReader.GetBoolean(0);
                            if (!Situation)
                            {
                                sql_Server_Db_From_Follow_Up_Data_context.SubmitChanges();
                                Clean_The_Control();
                            }
                            else
                            {
                                MessageBox.Show("İzin Departman Müdürü tarafından onaylanmış." + "\n" + "İnsan kaynakları ile irtibata geçiniz, silinemez", "İzin silinemez", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                        }
                    }
                }

                if (Login_Form.Login_User_Obj_Id != 18 && Login_Form.Login_User_Obj_Id != 19)
                {
                    if (sqlDataReader.HasRows)
                    {
                        while (sqlDataReader.Read())
                        {
                            Situation = sqlDataReader.GetBoolean(1);
                            if (!Situation)
                            {
                                sql_Server_Db_From_Follow_Up_Data_context.SubmitChanges();
                                Clean_The_Control();
                            }
                            else
                            {
                                MessageBox.Show("İzin Departman Yönetmeni tarafından onaylanmış." + "\n" + "İnsan kaynakları ile irtibata geçiniz, silinemez", "İzin silinemez", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                        }
                    }
                }

                if (Login_Form.Login_User_Obj_Id == 18 || Login_Form.Login_User_Obj_Id == 19)
                {
                    if (sqlDataReader.HasRows)
                    {
                        while (sqlDataReader.Read())
                        {
                            Situation = sqlDataReader.GetBoolean(0);
                            if (Situation)
                            {
                                sql_Server_Db_From_Follow_Up_Data_context.SubmitChanges();
                                Clean_The_Control();
                            }
                        }
                    }
                }

                if (Login_Form.Login_User_Obj_Id == 18 || Login_Form.Login_User_Obj_Id == 19)
                {
                    if (sqlDataReader.HasRows)
                    {
                        while (sqlDataReader.Read() != null)
                        {
                            Situation = sqlDataReader.GetBoolean(1);
                            if (Situation)
                            {
                                sql_Server_Db_From_Follow_Up_Data_context.SubmitChanges();
                                Clean_The_Control();
                            }
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                messages.Error(exception);
            }
            Choose_The_Daily_Hour_Permit_ButtonEdit.Visible = true;

        }

        private void Clean_The_Control()
        {
            foreach (Control control in User_Knowledge_GroupControl.Controls)
            {
                if (control is DevExpress.XtraEditors.TextEdit || control is DevExpress.XtraEditors.ButtonEdit)
                {
                    control.Text = string.Empty;
                }
            }

            foreach (Control control in Permit_Detail_GroupControl.Controls)
            {
                if (control is DevExpress.XtraEditors.TextEdit || control is DevExpress.XtraEditors.ButtonEdit)
                {
                    control.Text = string.Empty;
                }
            }

            foreach (Control control in Approval_GroupControl.Controls)
            {
                if (control is DevExpress.XtraEditors.TextEdit || control is DevExpress.XtraEditors.ButtonEdit)
                {
                    control.Text = string.Empty;
                }
            }

            Edit = false;

            Department_Obj_Id = -1;
            Permit_Reason_Obj_Id = -1;
            Title_Obj_Id = -1;
            User_Obj_Id = -1;
            Department_Responsible_Obj_Id = -1;
            Department_Manager_Obj_Id = -1;

            Department_Manager_Apporoval_ComboBoxEdit.SelectedIndex = 0;
            Department_Responsible_Approval_ComboBoxEdit.SelectedIndex = 0;
            Human_Resource_Approval_ComboBoxEdit.SelectedIndex = 0;
            Wet_Signature_ComboBoxEdit.SelectedIndex = 0;

            Department_Responsible_Approval_Description_MemoEdit.Text = string.Empty;
            Department_Manager_Apporoval_Description_MemoEdit.Text = string.Empty;
            Human_Resource_Approval_Description_MemoEdit.Text = string.Empty;
            Wet_Signature_Description_MemoEdit.Text = string.Empty;


            Department_Responsible_Approval_ComboBoxEdit.Visible = true;
            Department_Responsible_LabelControl.Visible = true;
            Daily_Hour_Permit_GroupControl.Enabled = true;
            Manager_Doesnt_Approved_Enable_The_Controls();
            MainMDIForm.Cross = -1;
        }

        /// <summary>
        /// Yöneticilere Onay kontrollerini açıyoruz..
        /// </summary>
        public void Set_The_Control_Visible()
        {
            //Annual_Permit_Form annual_Permit_Form = new Annual_Permit_Form();

            /*Çağatay, Armağan, Celal, Fatma, Tuğba, */
            if (Login_Form.Login_User_Obj_Id == 8 || Login_Form.Login_User_Obj_Id == 9 || Login_Form.Login_User_Obj_Id == 13 || Login_Form.Login_User_Obj_Id == 16 || Login_Form.Login_User_Obj_Id == 17)
            {
                Department_Manager_GroupControl.Enabled = false;
                Department_Responsible_GroupControl.Enabled = false;
                Human_Resource_GroupControl.Enabled = true;
                Wet_Signature_GroupControl.Enabled = true;
                return;
            }

            if (this.Job_Title_TextEdit.Text.Contains("Direktör") == true)
            {
                Department_Manager_GroupControl.Enabled = true;
                Department_Responsible_GroupControl.Enabled = false;
                Human_Resource_GroupControl.Enabled = false;
                Wet_Signature_GroupControl.Enabled = false;

                return;
            }

            if (this.Job_Title_TextEdit.Text.Contains("Müdür") == true)
            {
                Department_Manager_GroupControl.Enabled = true;
                Department_Responsible_GroupControl.Enabled = false;
                Human_Resource_GroupControl.Enabled = false;
                Wet_Signature_GroupControl.Enabled = false;

                return;
            }

            if (this.Job_Title_TextEdit.Text.Contains("Yönetmen") == true)
            {
                Department_Manager_GroupControl.Enabled = false;
                Department_Responsible_GroupControl.Enabled = true;
                Human_Resource_GroupControl.Enabled = false;
                Wet_Signature_GroupControl.Enabled = false;

                return;
            }

            if (this.Job_Title_TextEdit.Text.Contains("Direktör") == false || this.Job_Title_TextEdit.Text.Contains("Müdür") == false || this.Job_Title_TextEdit.Text.Contains("Yönetmen") == true)
            {
                Department_Manager_GroupControl.Enabled = false;
                Department_Responsible_GroupControl.Enabled = false;
                Human_Resource_GroupControl.Enabled = false;
                Wet_Signature_GroupControl.Enabled = false;

                return;
            }
        }


        public bool Calculate_The_Permit_Age_Day()
        {
            DateTime start = DateTime.Parse(Start_Date_DateEdit.Text);
            DateTime end = DateTime.Parse(End_Date_DateEdit.Text);

            TimeSpan timeSpan = end.Subtract(start);

            if (timeSpan.Days > 3)
            {
                MessageBox.Show("3 işi gününden fazla izin kullanamazsını..", "İzin Gün Sayınız...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                End_Date_DateEdit.Focus();
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        private void Manager_Approved_Disable_The_Controls()
        {
            if (Department_Manager_Apporoval_ComboBoxEdit.SelectedIndex == 1)
            {
                Start_Date_DateEdit.Enabled = false;
                End_Date_DateEdit.Enabled = false;
                Start_Hour_TimeEdit.Enabled = false;
                End_Hour_TimeEdit.Enabled = false;
                Permit_Type_ComboBoxEdit.Enabled = false;
                Permit_Reason_ButtonEdit.Enabled = false;
                Description_MemoEdit.Enabled = false;
            }
        }

        private void Manager_Doesnt_Approved_Enable_The_Controls()
        {
            if (Department_Manager_Apporoval_ComboBoxEdit.SelectedIndex != 1)
            {
                Start_Date_DateEdit.Enabled = true;
                End_Date_DateEdit.Enabled = true;
                Start_Hour_TimeEdit.Enabled = true;
                End_Hour_TimeEdit.Enabled = true;
                Permit_Type_ComboBoxEdit.Enabled = true;
                Permit_Reason_ButtonEdit.Enabled = true;
                Description_MemoEdit.Enabled = true;
            }
        }

        //private void Human_Resource_Approval_ComboBoxEdit_Click(object sender, EventArgs e)
        //{
        //    if (Department_Manager_Apporoval_ComboBoxEdit.SelectedIndex != 1)
        //    {
        //        MessageBox.Show("Departman müdürü onaylamadan.. onaylama yapıyorsunuz!...", "Onaylama Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //        Human_Resource_Approval_ComboBoxEdit.Focus();
        //        //Human_Resource_Approval_ComboBoxEdit.SelectedIndex = 0;
        //        return;
        //    }

        //    }
        
    }
}
