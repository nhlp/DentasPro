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
    using System.Globalization;
    using System.Data.OleDb;

    using Dentas_Pro.UI.Base;
    using Dentas_Pro.UI.DAL_Function;

    using DevExpress.XtraEditors;
    using DevExpress.Data;
    using DevExpress.XtraGrid.Columns;
    using DevExpress.XtraGrid.Views.Layout;
    using DevExpress.XtraGrid.Views.Grid;

    public partial class Annual_Permit_Form : DevExpress.XtraEditors.XtraForm
    {
        public Annual_Permit_Form()
        {
            InitializeComponent();
            Name_Surname_TextEdit.Enabled = false;
            Set_The_Comboboxes_To_Choose();
            Manager_Approved_Disable_The_Controls();
            Getting_For_Open_Up_User_Name_Surname_Instead_Obj_Id(Login_Form.Login_User_Obj_Id);
            //Set_The_Control_Visible();
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

        /*Selected_Index_chanced event'i kullanıldığında bu kod aktifleştirilecek*/
        //public int Country_Obj_Id = -1;

        public int Country_Obj_Id = 212;
        public int City_Obj_Id = -1;
        /// <summary>
        /// İlçe
        /// </summary>
        public int County_Obj_Id = -1;
        public int Neighborhood_Obj_Id = -1;

        #endregion

        DAL_Function.Sql_Server_DB_From_DentasProDataContext sql_Server_Db_From_Follow_Up_Data_context = new DAL_Function.Sql_Server_DB_From_DentasProDataContext();
        DAL_Function.Get_The_Form get_The_Forms = new DAL_Function.Get_The_Form();
        DAL_Function.Messages messages = new DAL_Function.Messages();
        UI.Mail.Send_An_E_Mail send_An_E_Mail = new Mail.Send_An_E_Mail();

        #region Events

        public void Getting_For_Saved_Annual_List(int Obj_Id)
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
                Department_Responsible_TextEdit.Text = annual_Permit.Department_Chief_Obj_Id.ToString();
                Department_Manager_TextEdit.Text = annual_Permit.Department_Manager_Obj_Id.ToString();
                Start_Date_DateEdit.Text = annual_Permit.Permit_Start_Time.Value.ToString("dd.MM.yyyy");
                End_Date_DateEdit.Text = annual_Permit.Permit_End_Time.Value.ToString("dd.MM.yyyy");
                //Permit_Type_ComboBoxEdit.Text = annual_Permit.Permit_Type;
                //Permit_Reason_ButtonEdit.Text = annual_Permit.Permit_Reason_Obj_Id.ToString();
                //Total_Permit_Allowed_TextEdit.Text = Get_The_Accumulated_Permit_count_for_Historic_Annual_List(Obj_Id).ToString();

                Department_Manager_Apporoval_Description_MemoEdit.Text = annual_Permit.Department_Manager_Apporoval_Description;
                Department_Responsible_Approval_Description_MemoEdit.Text = annual_Permit.Department_Responsible_Approval_Description;
                Human_Resource_Approval_Description_MemoEdit.Text = annual_Permit.Human_Resource_Approval_Description;
                Wet_Signature_Description_MemoEdit.Text = annual_Permit.Wet_Signature_Description;

                City_ComboBoxEdit.Text = annual_Permit.City_Name;
                County_ComboBoxEdit.Text = annual_Permit.County_Name;
                Neighbrhood_ComboBoxEdit.Text = annual_Permit.Neighbrhood_Name;
                Address_Descrition_MemoEdit.Text = annual_Permit.Address_Descrition;
                Phone_Number_1_Area_Code_TextEdit.Text = annual_Permit.Phone_Number_1_Area_Code;
                Phone_Number_1_TextEdit.Text = annual_Permit.Phone_Number_1;
                Phone_Number_2_Area_Code_TextEdit.Text = annual_Permit.Phone_Number_2_Area_Code;
                Phone_Number_2_TextEdit.Text = annual_Permit.Phone_Number_2;

                Getting_For_Department_Name_Instead_Obj_Id(annual_Permit.Department_Obj_Id.Value);
                Getting_For_Title_Name_Instead_Obj_Id(annual_Permit.Title_Obj_Id.Value);
                Getting_For_Permit_Used_User_Name_Instead_Obj_Id(annual_Permit.User_Obj_Id.Value);
                Getting_For_Country_Name_Instead_Obj_Id(annual_Permit.Country_Obj_Id.Value);
                //Getting_For_City_Name_Instead_Obj_Id(annual_Permit.City_Obj_Id.Value);


                //Getting_For_Permit_Reason_Name_Instead_Obj_Id(annual_Permit.Permit_Reason_Obj_Id.Value);

                //Get_The_Total_Permit_Allowed();

                Update_Used_Annuel_Permit_Day_Count(User_Obj_Id);


                //Start_Hour_TimeEdit.Text = annual_Permit.Permit_Start_Hour;
                //End_Hour_TimeEdit.Text = annual_Permit.Permit_End_Hour;

                Description_MemoEdit.Text = annual_Permit.Description;



                if (annual_Permit.Paraph_Human_Resource_Situation == true)
                {
                    Human_Resource_Approval_ComboBoxEdit.Text = "Onaylandı";
                }
                if (annual_Permit.Paraph_Human_Resource_Situation == false)
                {
                    Human_Resource_Approval_ComboBoxEdit.Text = "Onaylanmadı";
                }


                if (annual_Permit.Approval_Department_Responsible_Situation == true)
                {
                    Department_Responsible_Approval_ComboBoxEdit.SelectedIndex = 1;
                }
                if (annual_Permit.Approval_Department_Responsible_Situation == false)
                {
                    Department_Responsible_Approval_ComboBoxEdit.SelectedIndex = 2;
                }




                if (annual_Permit.Approval_Department_Manager_Situation == true)
                {
                    Department_Manager_Apporoval_ComboBoxEdit.Text = "Onaylandı";
                }
                if (annual_Permit.Approval_Department_Manager_Situation == false)
                {
                    Department_Manager_Apporoval_ComboBoxEdit.Text = "Onaylanmadı";
                }

                if (annual_Permit.Wet_Signature_Situation == true)
                {
                    Wet_Signature_ComboBoxEdit.Text = "Alındı";
                }
                if (annual_Permit.Wet_Signature_Situation == false)
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
                    Getting_For_Open_Up_Department_Manager_Name_Surname_Instead_Obj_Id(annual_Permit.Department_Manager_Obj_Id.Value);
                    Department_Responsible_LabelControl.Visible = false;
                    Department_Responsible_TextEdit.Visible = false;
                }
                else
                {
                    Getting_For_Open_Up_Department_Responsible_Name_Surname_Instead_Obj_Id(annual_Permit.Department_Chief_Obj_Id.Value);
                    Getting_For_Open_Up_Department_Manager_Name_Surname_Instead_Obj_Id(annual_Permit.Department_Manager_Obj_Id.Value);
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

        public void Getting_For_Country_Name_Instead_Obj_Id(int Obj_Id)
        {
            try
            {
                Country_Obj_Id = Obj_Id;
                DAL_Function.Country country = sql_Server_Db_From_Follow_Up_Data_context.Countries.First(s => s.Obj_Id == Country_Obj_Id);
                Country_ComboBoxEdit.Text = country.Name;
            }
            catch (Exception exception)
            {

                throw;
            }
        }

        public void Getting_For_City_Name_Instead_Obj_Id(int Obj_Id)
        {
            try
            {
                City_Obj_Id = Obj_Id;
                DAL_Function.City_Little city_Little = sql_Server_Db_From_Follow_Up_Data_context.City_Littles.First(s => s.Obj_Id == City_Obj_Id);
                City_ComboBoxEdit.Text = city_Little.Name_Up;
            }
            catch (Exception exception)
            {

                throw;
            }
        }

        public void Getting_For_County_Name_Instead_Obj_Id(int Obj_Id)
        {
            try
            {
                County_Obj_Id = Obj_Id;
                DAL_Function.County_Little county_Little = sql_Server_Db_From_Follow_Up_Data_context.County_Littles.First(s => s.Obj_Id == County_Obj_Id);
                County_ComboBoxEdit.Text = county_Little.Name;
            }
            catch (Exception exception)
            {

                throw;
            }
        }

        //public void Getting_For_Permit_Reason_Name_Instead_Obj_Id(int Obj_Id)
        //{
        //    try
        //    {
        //        Permit_Reason_Obj_Id = Obj_Id;
        //        DAL_Function.Permit_Reason permit_Reason = sql_Server_Db_From_Follow_Up_Data_context.Permit_Reasons.First(s => s.Obj_Id == Permit_Reason_Obj_Id);

        //        Permit_Reason_ButtonEdit.Text = permit_Reason.Name;
        //    }
        //    catch (Exception exception)
        //    {
        //        throw;
        //    }
        //}

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
            /*
             * Ç.Pancaroğlu
             * İstendiği kadar izin kullanılabilir
             */
            //check_The_Permit_Day_Total();
            DateDiff_Is_Positive();
            Used_Annuel_Permit_Day();
            Is_PermitDay_Holiday();
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
                Permit_Knowledge_Form permit_Knowledge_Form = new UI.User.Permit_Knowledge_Form();

                //This_Year_Permit_Count_TextEdit.Text = permit_Knowledge_Form.Annual_Permit_Calculating(Obj_Id).ToString();

                /*Toplam izni ekran göstermeye çalış.*/
                Total_Permit_Allowed_TextEdit.Text = Get_The_Total_Permit_Allowed(User_Obj_Id).ToString();



                Getting_For_Department_Name_Instead_Obj_Id(user.Department_Obj_Id.Value);
                Getting_For_Title_Name_Instead_Obj_Id(user.Title_Obj_Id.Value);


                //if (user.Title_Obj_Id == 11 && user.Title_Obj_Id == 12)
                //{
                //    MessageBox.Show("Personele 'Departman Sorumlusu' atanmamış", "EKSİK BİLGİ...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    Save_SimpleButton.Enabled = false;
                //}
                /*else*/
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

        public void Choose_The_annual_Permit_ButtonEdit_Click(object sender, EventArgs e)
        {
            int Obj_Id = get_The_Forms.Annual_Permit_List_Form(true);

            if (Obj_Id > 0)
            {
                Getting_For_Saved_Annual_List(Obj_Id);
                Manager_Approved_Disable_The_Controls();
                Manager_Doesnt_Approved_Enable_The_Controls();
                Used_Annuel_Permit_Day();
                Total_Permit_Allowed_TextEdit.Text = Get_The_Total_Permit_Allowed(Permit_Used_User_Name_Obj_Id).ToString();
            }
            MainMDIForm.Cross = -1;
        }

        //public void Getting_For_Permit_Reason(int Obj_Id)
        //{
        //    try
        //    {
        //        Edit = true;
        //        Permit_Reason_Obj_Id = Obj_Id;
        //        DAL_Function.Permit_Reason permit_Reason = sql_Server_Db_From_Follow_Up_Data_context.Permit_Reasons.First(s => s.Obj_Id == Permit_Reason_Obj_Id);

        //        Permit_Reason_ButtonEdit.Text = permit_Reason.Name;
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}

        private void Name_Surname_TextEdit_Click(object sender, EventArgs e)
        {
            int Obj_Id = get_The_Forms.User_List(true);

            if (Obj_Id > 0)
            {
                Getting_For_Open_Up_User_Name_Surname_Instead_Obj_Id(Obj_Id);
            }
            MainMDIForm.Cross = -1;
            /*Listeden isim seçip kayıt girilmeye başlandı ise kayıtlı bir izin seçilmeyecek demektir.*/
            Annual_Permit_GroupControl.Enabled = false;
        }
        #endregion

        #region Button Click Events

        private void Clean_The_Control_Value_SimpleButton_Click(object sender, EventArgs e)
        {
            Clean_The_Control();
            Save_SimpleButton.Enabled = true;
            Manager_Doesnt_Approved_Enable_The_Controls();
        }

        //private void Permit_Reason_ButtonEdit_Click(object sender, EventArgs e)
        //{
        //    int Obj_Id = get_The_Forms.Permit_Reason_Form(true);

        //    if (Obj_Id > 0)
        //    {
        //        Getting_For_Permit_Reason(Obj_Id);
        //    }
        //    MainMDIForm.Cross = -1;
        //}

        private void Save_SimpleButton_Click(object sender, EventArgs e)
        {
            if (annual_Permit_Obj_Id < 0)
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
            if (Edit && annual_Permit_Obj_Id > 0 && messages.Delete() == DialogResult.Yes)
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

            else if (Department_Manager_TextEdit.Text == "" || Department_Manager_TextEdit.Text == null)
            {
                MessageBox.Show("Departman yöneticisini seçmelisiniz..", "Departman Yöneticisi Eksik", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Department_Manager_TextEdit.Focus();
                return;
            }

            try
            {
                //DAL_Function.annual_Permit annual_Permit = new DAL_Function.annual_Permit();
                DAL_Function.Annual_Permit annual_Permit = new Annual_Permit();

                annual_Permit.User_Obj_Id = User_Obj_Id;

                annual_Permit.Permit_Start_Time = DateTime.Parse(Start_Date_DateEdit.Text);
                annual_Permit.Permit_End_Time = DateTime.Parse(End_Date_DateEdit.Text);
                annual_Permit.Description = Description_MemoEdit.Text;
                annual_Permit.Department_Chief_Obj_Id = Department_Responsible_Obj_Id;
                annual_Permit.Department_Obj_Id = Department_Obj_Id;
                annual_Permit.Department_Manager_Obj_Id = Department_Manager_Obj_Id;
                annual_Permit.Title_Obj_Id = Title_Obj_Id;

                annual_Permit.Country_Obj_Id = Country_Obj_Id;
                annual_Permit.City_Name = City_ComboBoxEdit.Text;
                annual_Permit.County_Name = County_ComboBoxEdit.Text;
                annual_Permit.Neighbrhood_Name = Neighbrhood_ComboBoxEdit.Text;
                annual_Permit.Address_Descrition = Address_Descrition_MemoEdit.Text;

                annual_Permit.Phone_Number_1_Area_Code = Phone_Number_1_Area_Code_TextEdit.Text;
                annual_Permit.Phone_Number_1 = Phone_Number_1_TextEdit.Text;

                annual_Permit.Phone_Number_2_Area_Code = Phone_Number_2_Area_Code_TextEdit.Text;
                annual_Permit.Phone_Number_2 = Phone_Number_2_TextEdit.Text;

                annual_Permit.Department_Manager_Apporoval_Description = Department_Manager_Apporoval_Description_MemoEdit.Text;
                annual_Permit.Department_Responsible_Approval_Description = Department_Responsible_Approval_Description_MemoEdit.Text;
                annual_Permit.Human_Resource_Approval_Description = Human_Resource_Approval_Description_MemoEdit.Text;
                annual_Permit.Wet_Signature_Description = Wet_Signature_Description_MemoEdit.Text;


                annual_Permit.Accumulated_Permit_count_Knowledge_Data = Get_The_Accumulated_Permit_count_for_Historic_Annual_List(User_Obj_Id);
                annual_Permit.Permitted_Use_Knowledge_Data = Get_The_Permitted_Use_Knowledge_Data_for_Historic_Annual_List(User_Obj_Id);


                /*Value: 1 ise True*/
                if (Department_Responsible_Approval_ComboBoxEdit.SelectedIndex == 1)
                {
                    annual_Permit.Approval_Department_Responsible_Situation = true;
                }
                //Department_Responsible_Approval_ComboBoxEdit.SelectedIndex == 2
                if (Department_Responsible_Approval_ComboBoxEdit.SelectedIndex == 2)
                {
                    annual_Permit.Approval_Department_Responsible_Situation = false;
                }

                if (Department_Manager_Apporoval_ComboBoxEdit.SelectedIndex == 1)
                {
                    annual_Permit.Approval_Department_Manager_Situation = true;
                }

                if (Department_Manager_Apporoval_ComboBoxEdit.SelectedIndex == 2)
                {
                    annual_Permit.Approval_Department_Manager_Situation = false;
                }

                if (Human_Resource_Approval_ComboBoxEdit.SelectedIndex == 1)
                {
                    annual_Permit.Paraph_Human_Resource_Situation = true;
                }

                if (Human_Resource_Approval_ComboBoxEdit.SelectedIndex == 2)
                {
                    annual_Permit.Paraph_Human_Resource_Situation = false;
                }
                if (Wet_Signature_ComboBoxEdit.SelectedIndex == 1)
                {
                    annual_Permit.Wet_Signature_Situation = true;
                }
                if (Wet_Signature_ComboBoxEdit.SelectedIndex == 2)
                {
                    annual_Permit.Wet_Signature_Situation = false;
                }

                annual_Permit.Insert_User = Login_Form.Login_User_Obj_Id;
                annual_Permit.Insert_Time = DateTime.Now;

                #region Description
                /*Description: 15.5.2015 Tarihinde IK ile yapılan "Durum Değerlendirme Toplantısında"
                 *              Fatma Dayı tarafından bu fonksiyonun devre dışı bırakılmasını talep etti
                 */
                #endregion                //if (Get_The_Accumulated_Permit_Total_Count_for_OverFlow(annual_Permit.User_Obj_Id) < -5)

                sql_Server_Db_From_Follow_Up_Data_context.Annual_Permits.InsertOnSubmit(annual_Permit);
                sql_Server_Db_From_Follow_Up_Data_context.SubmitChanges();
                messages.New_Record("İzin talebiniz alınmış ve ilgili yöneticilere iletilmiştir. Süreç tamamlandıktan sonra Onaylandı/Onaylanmadı bilgisi mail olarak tarafınıza bildirilecektir.");
                Clean_The_Control();
                //annual_Permit_GroupControl.Enabled = true;
                Choose_The_Annual_Permit_ButtonEdit.Enabled = true;
                //send_An_E_Mail.Send_An_E_Mail_(User,


                //send_An_E_Mail.Send_An_E_Mail_(User_Obj_Id, From_Mail_(), From_Mail_(), "İzin Talebi", From_Full_Name_() + " tarafından Yıllık İzin Talebi Yapıldı");

                if (annual_Permit.Department_Chief_Obj_Id != -1)
                {
                    send_An_E_Mail.Send_An_E_Mail_(User_Obj_Id, From_Mail_(), to_Mail_Department_Responsible(annual_Permit.Department_Chief_Obj_Id), "Yıllık İzin Talebi", From_Full_Name_() + " tarafından yıllık İzin Talebi Yapıldı");
                }
                

                if (annual_Permit.Department_Manager_Obj_Id != -1)
                {
                    send_An_E_Mail.Send_An_E_Mail_(User_Obj_Id, From_Mail_(), to_Mail_Department_Manager(annual_Permit.Department_Manager_Obj_Id), "Yıllık izin Talebi", From_Full_Name_() + " tarafından yıllık İzin Talebi Yapıldı");
                }

                //Developed 2015_06_09 for hr staff
                //send_An_E_Mail.Send_An_E_Mail_(User_Obj_Id, From_Mail_(), to_Mail_Hr_Staff(8), "Yıllık izin talebi", From_Full_Name_() + " tarafından yıllık izin talebi yapıldı");
                //send_An_E_Mail.Send_An_E_Mail_(User_Obj_Id, From_Mail_(), to_Mail_Hr_Staff(9), "Yıllık izin talebi", From_Full_Name_() + " tarafından yıllık izin talebi yapıldı");
                //send_An_E_Mail.Send_An_E_Mail_(User_Obj_Id, From_Mail_(), to_Mail_Hr_Staff(13), "Yıllık izin talebi", From_Full_Name_() + " tarafından yıllık izin talebi yapıldı");
                //send_An_E_Mail.Send_An_E_Mail_(User_Obj_Id, From_Mail_(), to_Mail_Hr_Staff(16), "Yıllık izin talebi", From_Full_Name_() + " tarafından yıllık izin talebi yapıldı");



                


            }
            catch (Exception exception)
            {
                messages.Error(exception);
            }
        }

        public void Update_Data_From_DB()
        {
            try
            {
                DAL_Function.Annual_Permit annual_Permit = sql_Server_Db_From_Follow_Up_Data_context.Annual_Permits.First(s => s.Obj_Id == annual_Permit_Obj_Id);

                annual_Permit.Permit_Start_Time = DateTime.Parse(Start_Date_DateEdit.Text);
                annual_Permit.Permit_End_Time = DateTime.Parse(End_Date_DateEdit.Text);
                annual_Permit.Description = Description_MemoEdit.Text;

                annual_Permit.Department_Manager_Apporoval_Description = Department_Manager_Apporoval_Description_MemoEdit.Text;
                annual_Permit.Department_Responsible_Approval_Description = Department_Responsible_Approval_Description_MemoEdit.Text;
                annual_Permit.Human_Resource_Approval_Description = Human_Resource_Approval_Description_MemoEdit.Text;
                annual_Permit.Wet_Signature_Description = Wet_Signature_Description_MemoEdit.Text;

                annual_Permit.Department_Chief_Obj_Id = Department_Responsible_Obj_Id;
                annual_Permit.Department_Obj_Id = Department_Obj_Id;
                annual_Permit.Department_Manager_Obj_Id = Department_Manager_Obj_Id;
                annual_Permit.Update_Time = DateTime.Now;
                annual_Permit.Update_User = Login_Form.Login_User_Obj_Id;

                annual_Permit.Country_Obj_Id = Country_Obj_Id;
                annual_Permit.City_Name = City_ComboBoxEdit.Text;
                annual_Permit.County_Name = County_ComboBoxEdit.Text;
                annual_Permit.Neighbrhood_Name = Neighbrhood_ComboBoxEdit.Text;
                annual_Permit.Address_Descrition = Address_Descrition_MemoEdit.Text;

                annual_Permit.Phone_Number_1_Area_Code = Phone_Number_1_Area_Code_TextEdit.Text;
                annual_Permit.Phone_Number_1 = Phone_Number_1_TextEdit.Text;

                annual_Permit.Phone_Number_2_Area_Code = Phone_Number_2_Area_Code_TextEdit.Text;
                annual_Permit.Phone_Number_2 = Phone_Number_2_TextEdit.Text;

                /*Value: 1 ise True*/
                if (Department_Responsible_Approval_ComboBoxEdit.SelectedIndex == 1)
                {
                    annual_Permit.Approval_Department_Responsible_Situation = true;
                }

                if (Department_Responsible_Approval_ComboBoxEdit.SelectedIndex == 2)
                {
                    annual_Permit.Approval_Department_Responsible_Situation = false;
                }


                if (Department_Manager_Apporoval_ComboBoxEdit.SelectedIndex == 1)
                {
                    annual_Permit.Approval_Department_Manager_Situation = true;
                }

                if (Department_Manager_Apporoval_ComboBoxEdit.SelectedIndex == 2)
                {
                    annual_Permit.Approval_Department_Manager_Situation = false;
                }


                if (Human_Resource_Approval_ComboBoxEdit.SelectedIndex == 1)
                {
                    annual_Permit.Paraph_Human_Resource_Situation = true;
                }

                if (Human_Resource_Approval_ComboBoxEdit.SelectedIndex == 2)
                {
                    annual_Permit.Paraph_Human_Resource_Situation = false;
                }

                /*İzin Departman Müdürü tarafından onaylanmış ise İzin talebi yapana mail gönderiyoruz*/
                if (Department_Manager_Apporoval_ComboBoxEdit.SelectedIndex == 1)
                {
                    send_An_E_Mail.Send_An_E_Mail_(User_Obj_Id, From_Mail_(), Permit_Owner(annual_Permit.User_Obj_Id), "Yıllık izin talebiniz Departman Müdürü tarafından onaylandı", "Yönetici İzin Onay");
                }

                /*Deparman Sorumlusu Onaylandığında*/
                if (Department_Responsible_Approval_ComboBoxEdit.SelectedIndex == 1)
                {
                    send_An_E_Mail.Send_An_E_Mail_(User_Obj_Id, From_Mail_(), Permit_Owner(annual_Permit.User_Obj_Id), "Yıllık izin talebiniz Departman Sorumlunuz tarafından onaylandı", "Yönetmen İzin Onay");
                }

                /*İnsan kaynakları onayladığında*/
                if (Human_Resource_Approval_ComboBoxEdit.SelectedIndex == 1)
                {
                    send_An_E_Mail.Send_An_E_Mail_(User_Obj_Id, From_Mail_(), Permit_Owner(annual_Permit.User_Obj_Id), "Yıllık izin talebiniz İnsan Kaynakları tarafından onaylandı", "IK İzin Onay");

                    /*#################################################################################
                     * Date: 2015_04_10_10:25                                                         #
                     * Description:_Bayram_Ç.                                                         #
                     *          Ancak IK onayladığında "Birikmiş İzin Gün Sayısı" nda eksilme olacak. #
                     *          Talep edilen izin gün sayısı  - "Toplam_İzin_Gün_Sayısı" -- Olacak .. #
                     *#################################################################################
                     */

                    Update_Used_Annuel_Permit_Day_Count(int.Parse(annual_Permit.User_Obj_Id.ToString()));
                    Update_The_Permitted_Use(int.Parse(annual_Permit.User_Obj_Id.ToString()));
                    //Decrement_The_Used_Permit();
                    annual_Permit.Accumulated_Permit_count_Knowledge_Data = Get_The_Accumulated_Permit_count_for_Historic_Annual_List(int.Parse(annual_Permit.User_Obj_Id.ToString()));
                    annual_Permit.Permitted_Use_Knowledge_Data = Get_The_Permitted_Use_Knowledge_Data_for_Historic_Annual_List(int.Parse(annual_Permit.User_Obj_Id.ToString()));
                    Update_Permitted_Use_With_Zero(int.Parse(annual_Permit.User_Obj_Id.ToString()));

                    //annual_Permit.Permitted_Use_Knowledge_Data = 0;
                }

                if (Wet_Signature_ComboBoxEdit.SelectedIndex == 1)
                {
                    annual_Permit.Wet_Signature_Situation = true;
                }
                if (Wet_Signature_ComboBoxEdit.SelectedIndex == 2)
                {
                    annual_Permit.Wet_Signature_Situation = false;
                }

                sql_Server_Db_From_Follow_Up_Data_context.SubmitChanges();
                messages.Update(true);
                Clean_The_Control();
                Annual_Permit_GroupControl.Enabled = true;

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
        /// İzni isteyen kişi
        /// </summary>
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

        /// <summary>
        /// Yazılıyor: henüz.. 2015_04_13:11_13
        ///            Bitti :)2015_04_13:16_10
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

        public string to_Mail_Hr_Staff(int? Hr_Staff_Obj_Id)
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

        public void Delete_the_Record()
        {
            try
            {
                sql_Server_Db_From_Follow_Up_Data_context.Annual_Permits.DeleteOnSubmit(sql_Server_Db_From_Follow_Up_Data_context.Annual_Permits.First(s => s.Obj_Id == annual_Permit_Obj_Id));

                int Choosen_annual_Permit_Obj_Id = annual_Permit_Obj_Id;
                bool Situation;

                SqlConnection sqlConnection = new SqlConnection("Server=10.168.0.26;Database=DentasPro;uid=sa;pwd=dentas;");
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("Select Approval_Department_Manager_Situation, Approval_Department_Responsible_Situation From [annual_Permit] where Obj_Id = '" + Choosen_annual_Permit_Obj_Id + "'", sqlConnection);

                SqlParameter param = new SqlParameter();
                param.ParameterName = "@Choosen_annual_Permit_Obj_Id";
                param.Value = Choosen_annual_Permit_Obj_Id;

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                /*Çağatay, Armağan, Celal, Fatma D, Tuğba, */
                if (Login_Form.Login_User_Obj_Id != 8 && Login_Form.Login_User_Obj_Id != 9 && Login_Form.Login_User_Obj_Id != 13 && Login_Form.Login_User_Obj_Id != 16 && Login_Form.Login_User_Obj_Id != 17)
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

                //if (Login_Form.Login_User_Obj_Id != 18 && Login_Form.Login_User_Obj_Id != 19)
                //{
                //    if (sqlDataReader.HasRows)
                //    {
                //        while (sqlDataReader.Read())
                //        {
                //            Situation = sqlDataReader.GetBoolean(1);
                //            if (!Situation)
                //            {
                //                sql_Server_Db_From_Follow_Up_Data_context.SubmitChanges();
                //                Clean_The_Control();
                //            }
                //            else
                //            {
                //                MessageBox.Show("İzin Departman Yönetmeni tarafından onaylanmış." + "\n" + "İnsan kaynakları ile irtibata geçiniz, silinemez", "İzin silinemez", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //                return;
                //            }
                //        }
                //    }
                //}

                if (Login_Form.Login_User_Obj_Id == 8 || Login_Form.Login_User_Obj_Id == 9 || Login_Form.Login_User_Obj_Id == 13 || Login_Form.Login_User_Obj_Id == 16 || Login_Form.Login_User_Obj_Id == 17)
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

                if (Login_Form.Login_User_Obj_Id == 8 || Login_Form.Login_User_Obj_Id == 9 || Login_Form.Login_User_Obj_Id == 13 || Login_Form.Login_User_Obj_Id == 16 || Login_Form.Login_User_Obj_Id == 17)
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
            Choose_The_Annual_Permit_ButtonEdit.Visible = true;

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

            foreach (Control control in Communication_GroupControl.Controls)
            {
                if (control is DevExpress.XtraEditors.ComboBoxEdit || control is DevExpress.XtraEditors.MemoEdit || control is DevExpress.XtraEditors.TextEdit)
                {
                    control.Text = string.Empty;
                }
            }
            //This_Year_Permit_Count_TextEdit.Text = string.Empty;
            Total_Permit_Allowed_TextEdit.Text = string.Empty;
            Department_Responsible_Approval_Description_MemoEdit.Text = string.Empty;
            Department_Manager_Apporoval_Description_MemoEdit.Text = string.Empty;
            Human_Resource_Approval_Description_MemoEdit.Text = string.Empty;
            Wet_Signature_Description_MemoEdit.Text = string.Empty;
            Used_Day_Count_TextEdit.Text = string.Empty;


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


            Department_Responsible_Approval_ComboBoxEdit.Visible = true;
            Department_Responsible_LabelControl.Visible = true;
            Annual_Permit_GroupControl.Enabled = true;
            MainMDIForm.Cross = -1;
        }

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

        //public bool check_The_Permit_Day_Total()
        //{
        //    DateTime start = DateTime.Parse(Start_Date_DateEdit.Text);
        //    DateTime end = DateTime.Parse(End_Date_DateEdit.Text);

        //    TimeSpan timeSpan = end.Subtract(start);
        //    int Login_Obj_Id = Login_Form.Login_User_Obj_Id;

        //    SqlConnection sqlConnection = new SqlConnection("Server=10.168.0.26;Database=DentasPro;uid=sa;pwd=dentas;");
        //    sqlConnection.Open();

        //    SqlCommand sqlCommand = new SqlCommand("Select Total_Permit_Allowed From [Annual_Permit] where Obj_Id = '" + Login_Obj_Id + "'", sqlConnection);

        //    SqlParameter param = new SqlParameter();
        //    param.ParameterName = "@Login_Obj_Id";
        //    param.Value = Login_Obj_Id;

        //    sqlCommand.Parameters.Add(param);

        //    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();


        //    if (sqlDataReader.HasRows)
        //    {
        //        while (sqlDataReader.Read())
        //        {
        //            if (timeSpan > sqlDataReader.GetTimeSpan(0))
        //            {
        //                MessageBox.Show("Olmaz");
        //            }
        //            //Logined_User_Name_SurName_BarButtonItem.Caption = sqlDataReader.GetString(0);
        //        }
        //    }
        //    //string Login_User

        //    int new_Permit = sqlDataReader.GetInt32(0);




        //    if (timeSpan.Days > new_Permit)
        //    {
        //        MessageBox.Show("Hak ettiğinizden fazla yıllık izin kullanamazsınız..", "İzin Gün Sayınız...", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        End_Date_DateEdit.Focus();
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}


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
        private void Annual_Permit_Form_Load(object sender, EventArgs e)
        {
            try
            {
                Geo_Knowledge_Load_to_Control(City_ComboBoxEdit, "Select Name_Up From City_Little", "Name_Up");

            }
            catch (Exception exception)
            {
            }

            Embed_The_Coutry();
        }

        /// <summary>
        /// 2015_03_15_14:25
        /// Ülke'yi doğrudan embeded ediyoruz. Daha sonra talep olur ise bu kontrol'ü de
        /// dynamic hale getirebiliriz.
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
                    Country_ComboBoxEdit.Text = sqlDataReader.GetString(0);
                }
            }
            //string Login_User = sqlCommand;
            //Logined_User_Name_SurName_BarButtonItem.Caption = Login_User;

        }
        #endregion
        private void Country_ComboBoxEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
             * Eğer diğer ülkelerde istenir ise bı kod çalışsın ama şimdilik statik olarak asdece Türkiye set olsun
            Country_Obj_Id = Country_ComboBoxEdit.SelectedIndex;
           */
        }

        private void City_ComboBoxEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Embed_The_Coutry();
                //KontrolAktar(ilceListe, "select ilceAdi from ilceler where sehirID='" + VeriGetir("select sehirID from sehir where sehiradiUpper='" + ilListe.SelectedItem.ToString() + "'", "sehirID") + "'", "ilceAdi");
                Geo_Knowledge_Load_to_Control(County_ComboBoxEdit, "Select Name From County_Little where City_Obj_Id='" + Get_Values("Select Obj_Id From City_Little where Name_Up='" + City_ComboBoxEdit.SelectedItem.ToString() + "'", "Obj_Id") + "'", "Name");
                City_Obj_Id = City_ComboBoxEdit.SelectedIndex;
                City_Obj_Id = City_Obj_Id + 1;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// İlçeler görede mahalleri dolduruyoruz
        /// </summary>
        private void County_ComboBoxEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Geo_Knowledge_Load_to_Control(Neighbrhood_ComboBoxEdit, "Select Name From Neighborhood_Little where  City_Obj_Id='" + Get_Values("Select Obj_Id From City_Little where Name_Up='" + City_ComboBoxEdit.SelectedItem.ToString() + "'", "Obj_Id") + "' and County_Obj_Id='" + Get_Values("select Obj_Id from County_Little where Name='" + County_ComboBoxEdit.SelectedItem.ToString() + "'", "Obj_Id") + "'", "Name");
                //County_Obj_Id = Geo_Knowledge_Load_to_Control(County_ComboBoxEdit.SelectedIndex,);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void Neighbrhood_ComboBoxEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            Neighborhood_Obj_Id = Neighbrhood_ComboBoxEdit.SelectedIndex;
            Neighborhood_Obj_Id = Neighborhood_Obj_Id + 1;
        }

        private void Address_Descrition_MemoEdit_EditValueChanged(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// "İlk önce : Kullanılan izin gün sayısı"  - "Toplam izin adedinden" düşüyoruz..
        /// </summary>
        public int Update_Used_Annuel_Permit_Day_Count(int Selected_User_Obj_Id)
        {
            DateTime start = DateTime.Parse(Start_Date_DateEdit.Text);
            DateTime end = DateTime.Parse(End_Date_DateEdit.Text);

            int Rest_Permit = 0;

            /*Kullanılmış izin gün sayısını buluyoruz.*/
            int Used_Permit_Day_Count = ((TimeSpan)(end - start)).Days + 0;

            int Login_Obj_Id = Selected_User_Obj_Id;

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
                    int Getted_Total_Permit = sqlDataReader.GetInt32(0);

                    Rest_Permit = (Getted_Total_Permit) - Used_Permit_Day_Count - Is_PermitDay_Holiday(); /*Varsa tatil gününüde izne dahil etmiyoruz.*/
                }
            }

            /*Kalan birikmiş izin gün sayısını güncelliyoruz*/
            SqlCommand sqlCommand_2 = new SqlCommand("Update [User] Set Accumulated_Permit_count = '" + Rest_Permit + "'  where Obj_Id = '" + Login_Obj_Id + "'", sqlConnection);

            SqlParameter param_2 = new SqlParameter();
            param.ParameterName = "@Rest_Permit";
            param.Value = Rest_Permit;
            sqlDataReader.Close();

            SqlDataReader sqlDataReader_2 = sqlCommand_2.ExecuteReader();

            if (sqlDataReader_2.HasRows)
            {
                while (sqlDataReader_2.Read())
                {
                    Rest_Permit = sqlDataReader_2.GetInt32(0);
                }
            }
            return Rest_Permit;
        }

        /// <summary>
        /// Kullanılacak izin gün adedini hesaplıyoruz ve ekrana basıyoruz.
        /// </summary>
        public void Used_Annuel_Permit_Day()
        {
            DateTime start = DateTime.Parse(Start_Date_DateEdit.Text);
            DateTime end = DateTime.Parse(End_Date_DateEdit.Text);

            int Rest_Permit = 0;

            /*Kullanılmış izin gün sayısını buluyoruz.*/
            int Used_Permit_Day_Count = ((TimeSpan)(end - start)).Days + 0;

            Used_Day_Count_TextEdit.Text = (Used_Permit_Day_Count - Is_PermitDay_Holiday()).ToString();
        }

        /// <summary>
        /// Bu iki tarih aralığında olan tarihler count ediliyor.. Daha sonra
        /// Yukardaki metoda çıkartılacak.
        /// </summary>
        /// <param name="Start_Date"></param>
        /// <param name="End_Date"></param>
        public int Is_PermitDay_Holiday()
        {
            DateTime start = DateTime.Parse(Start_Date_DateEdit.Text);
            DateTime end = DateTime.Parse(End_Date_DateEdit.Text);

            string new_Start = start.ToString("yyyy.MM.dd");
            string new_end = end.ToString("yyyy.MM.dd");

            int Holiday_Count = 0;

            SqlConnection sqlConnection = new SqlConnection("Server=10.168.0.26;Database=DentasPro;uid=sa;pwd=dentas;");
            sqlConnection.Open();

            //SqlCommand sqlCommand = new SqlCommand("Update [User] Set Permitted_Use = '" + Used_Permit_Day_Count + "'  where Obj_Id = '" + Login_Obj_Id + "'", sqlConnection);
            /*Tatil olan günlerin sayısını bulduk*/
            SqlCommand sql_Command = new SqlCommand("Select Count(*) From dbo.Fn_Date_Is_Exists('" + new_Start + "','" + new_end + "' )", sqlConnection);

            SqlDataReader sqlDataReader = sql_Command.ExecuteReader();

            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    Holiday_Count = sqlDataReader.GetInt32(0);
                }
            }
            return Holiday_Count;
        }

        /// <summary>
        /// Kullanılacak izin gün adedinin bakiyeden düşüyoruz.
        /// </summary>
        public int Update_The_Permitted_Use(int Selected_User_Obj_Id)
        {
            DateTime start = DateTime.Parse(Start_Date_DateEdit.Text);
            DateTime end = DateTime.Parse(End_Date_DateEdit.Text);

            int Rest_Permit = 0;

            /*Kullanılmış izin gün sayısını buluyoruz.*/
            int Used_Permit_Day_Count = ((TimeSpan)(end - start)).Days + 0;

            int Login_Obj_Id = Selected_User_Obj_Id;

            SqlConnection sqlConnection = new SqlConnection("Server=10.168.0.26;Database=DentasPro;uid=sa;pwd=dentas;");
            sqlConnection.Open();

            /*Kalan birikmiş izin gün sayısını güncelliyoruz*/
            SqlCommand sqlCommand = new SqlCommand("Update [User] Set Permitted_Use = '" + Used_Permit_Day_Count + "'  where Obj_Id = '" + Login_Obj_Id + "'", sqlConnection);

            SqlParameter param_2 = new SqlParameter();
            param_2.ParameterName = "@Used_Permit_Day_Count";
            param_2.Value = Used_Permit_Day_Count;

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    Used_Permit_Day_Count = sqlDataReader.GetInt32(0);
                }
            }
            return Used_Permit_Day_Count;
        }

        /// <summary>
        /// Kullanılmış izin gün sayısını db'ye assigne ediyoruz.
        /// </summary>
        public int? Decrement_The_Used_Permit()
        {
            try
            {
                DAL_Function.User user = sql_Server_Db_From_Follow_Up_Data_context.Users.First(s => s.Obj_Id == Permit_Used_User_Name_Obj_Id);

                int Assing;

                user.Accumulated_Permit_count = user.Accumulated_Permit_count - Update_Used_Annuel_Permit_Day_Count(Permit_Used_User_Name_Obj_Id);
                return user.Permitted_Use = Update_Used_Annuel_Permit_Day_Count(Permit_Used_User_Name_Obj_Id);
            }
            catch (Exception exception)
            {
                throw;
            }
        }

        public int Get_The_Accumulated_Permit_count_for_Historic_Annual_List(int Selected_User_Obj_Id)
        {
            int Rest_Permit = 0;

            int Login_Obj_Id = Selected_User_Obj_Id;

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
                    int Getted_Total_Permit = sqlDataReader.GetInt32(0);
                    Rest_Permit = Getted_Total_Permit;
                }
            }
            return Rest_Permit;
        }

        public int Get_The_Permitted_Use_Knowledge_Data_for_Historic_Annual_List(int Selected_User_Obj_Id)
        {

            try
            {
                int Permitted_Used = 0;

                int Login_Obj_Id = Selected_User_Obj_Id;

                SqlConnection sqlConnection = new SqlConnection("Server=10.168.0.26;Database=DentasPro;uid=sa;pwd=dentas;");
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("Select Permitted_Use From [User] where Obj_Id = '" + Login_Obj_Id + "'", sqlConnection);

                SqlParameter param = new SqlParameter();
                param.ParameterName = "@Login_Obj_Id";
                param.Value = Login_Obj_Id;

                sqlCommand.Parameters.Add(param);

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                if (sqlDataReader.HasRows)
                {
                    while (sqlDataReader.Read())
                    {
                        int Getted_Permitted_Used = sqlDataReader.GetInt32(0);
                        Permitted_Used = Getted_Permitted_Used;
                    }
                }
                return Permitted_Used;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int Update_Permitted_Use_With_Zero(int Selected_User_Obj_Id)
        {
            DateTime start = DateTime.Parse(Start_Date_DateEdit.Text);
            DateTime end = DateTime.Parse(End_Date_DateEdit.Text);

            int Rest_Permit = 0;

            /*Kullanılmış izin gün sayısını buluyoruz.*/
            int Used_Permit_Day_Count = 0;

            int Login_Obj_Id = Selected_User_Obj_Id;

            SqlConnection sqlConnection = new SqlConnection("Server=10.168.0.26;Database=DentasPro;uid=sa;pwd=dentas;");
            sqlConnection.Open();

            /*Kalan birikmiş izin gün sayısını güncelliyoruz*/
            SqlCommand sqlCommand = new SqlCommand("Update [User] Set Permitted_Use = '" + Used_Permit_Day_Count + "'  where Obj_Id = '" + Login_Obj_Id + "'", sqlConnection);

            SqlParameter param_2 = new SqlParameter();
            param_2.ParameterName = "@Used_Permit_Day_Count";
            param_2.Value = Used_Permit_Day_Count;

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    Used_Permit_Day_Count = sqlDataReader.GetInt32(0);
                }
            }

            return Used_Permit_Day_Count;
        }

        /// <summary>
        /// Personelin topla izin gün sayısı -5'in altına düşemez.
        /// </summary>
        public int Get_The_Accumulated_Permit_Total_Count_for_OverFlow(int? Selected_User_Obj_Id)
        {
            DateTime start = DateTime.Parse(Start_Date_DateEdit.Text);
            DateTime end = DateTime.Parse(End_Date_DateEdit.Text);

            int Rest_Permit = 0;

            /*Kullanılmış izin gün sayısını buluyoruz.*/
            int Used_Permit_Day_Count = ((TimeSpan)(end - start)).Days + 0;

            int? Login_Obj_Id = Selected_User_Obj_Id;

            SqlConnection sqlConnection = new SqlConnection("Server=10.168.0.26;Database=DentasPro;uid=sa;pwd=dentas;");
            sqlConnection.Open();

            /*Kalan birikmiş izin gün sayısını güncelliyoruz*/
            SqlCommand sqlCommand = new SqlCommand("Select Accumulated_Permit_count From [User] where Obj_Id = '" + Login_Obj_Id + "'", sqlConnection);

            SqlParameter param_2 = new SqlParameter();
            param_2.ParameterName = "@Used_Permit_Day_Count";
            param_2.Value = Used_Permit_Day_Count;

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    Rest_Permit = sqlDataReader.GetInt32(0) - Used_Permit_Day_Count;

                    if (Rest_Permit < -5)
                    {
                        MessageBox.Show("Sahip olduğunuz izin gün sayınız -5'in altına düşüyor" + Environment.NewLine + "                Yıllık izin kullanamazsınız  ", "İzin Gün Sayınızı Aşıyorsunuz!.. ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //MessageBox.Show(MessageBoxIcon.Warning,"Sahip olduğunuz izin gün sayınız -5'in altına düşüyor" +Environment.NewLine +"           Yıllık izin kullanamazsınız",MessageBoxButtons.OK);
                    }
                }
            }
            return Rest_Permit;
        }

        /// <summary>
        /// 2015_03_31
        /// Kalan izin gün sayısını ekrana bas
        /// </summary>
        private int Get_The_Total_Permit_Allowed(int Selected_User_Obj_Id)
        {
            int Login_Obj_Id = Selected_User_Obj_Id;

            int Total_Permit_Allowed = 0;

            SqlConnection sqlConnection = new SqlConnection("Server=10.168.0.26;Database=DentasPro;uid=sa;pwd=dentas;");
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand("Select Accumulated_Permit_count_Knowledge_Data From [Annual_Permit] where User_Obj_Id = '" + Login_Obj_Id + "'", sqlConnection);

            SqlParameter param = new SqlParameter();
            param.ParameterName = "@Login_Obj_Id";
            param.Value = Login_Obj_Id;

            sqlCommand.Parameters.Add(param);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    Total_Permit_Allowed = sqlDataReader.GetInt32(0);
                }
            }
            return Total_Permit_Allowed;
            //string Login_User = sqlCommand;
            //Logined_User_Name_SurName_BarButtonItem.Caption = Login_User; }
        }

        //private void Department_Manager_Apporoval_ComboBoxEdit_SelectedValueChanged(object sender, EventArgs e)
        //{
        //    if ( Human_Resource_Approval_ComboBoxEdit.SelectedIndex != 1 )
        //    {
        //        MessageBox.Show("IK onaylamadan.. onaylama yapamazsınız!...", "Onaylama Yapamazsınız", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //        Department_Manager_Apporoval_ComboBoxEdit.SelectedIndex = 0;
        //    }
        //}

        private void Set_The_Comboboxes_To_Choose()
        {
            Department_Responsible_Approval_ComboBoxEdit.SelectedIndex = 0;
            Department_Manager_Apporoval_ComboBoxEdit.SelectedIndex = 0;
            Human_Resource_Approval_ComboBoxEdit.SelectedIndex = 0;
            Wet_Signature_ComboBoxEdit.SelectedIndex = 0;
        }

        /// <summary>
        /// Development_Date: 2015_05_20
        /// Description_Note: Ik ekibi talep etmişti.. Departman md. onaylamadan
        ///                   IK onaylama yapamasın..
        /// 
        /// </summary>
        //private void Human_Resource_Approval_ComboBoxEdit_Click(object sender, EventArgs e)
        //{
        //    if (Department_Manager_Apporoval_ComboBoxEdit.SelectedIndex != 1)
        //    {
        //        MessageBox.Show("Departman müdürü onaylamadan.. onaylama yapıyorsunuz!...", "Onaylama Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //        //Human_Resource_Approval_ComboBoxEdit.SelectedIndex = 0;
        //        //return;
        //    }
        //}

        /// <summary>
        /// Development Date
        /// Eğer departman müdürü onaylamış ise izin formunda güncelleme yapılamasın
        /// So :) Diasble the all control..
        /// </summary>
        private void Manager_Approved_Disable_The_Controls()
        {
            if (Department_Manager_Apporoval_ComboBoxEdit.SelectedIndex == 1)
            {
                Start_Date_DateEdit.Enabled = false;
                End_Date_DateEdit.Enabled = false;
                Description_MemoEdit.Enabled = false;
                Country_ComboBoxEdit.Enabled = false;
                City_ComboBoxEdit.Enabled = false;
                County_ComboBoxEdit.Enabled = false;
                Neighbrhood_ComboBoxEdit.Enabled = false;
                Phone_Number_1_Area_Code_TextEdit.Enabled = false;
                Phone_Number_1_TextEdit.Enabled = false;
                Phone_Number_2_Area_Code_TextEdit.Enabled = false;
                Phone_Number_2_TextEdit.Enabled = false;
            }
        }

        private void Manager_Doesnt_Approved_Enable_The_Controls()
        {
            if (Department_Manager_Apporoval_ComboBoxEdit.SelectedIndex != 1)
            {
                Start_Date_DateEdit.Enabled = true;
                End_Date_DateEdit.Enabled = true;
                Description_MemoEdit.Enabled = true;
                Country_ComboBoxEdit.Enabled = true;
                City_ComboBoxEdit.Enabled = true;
                County_ComboBoxEdit.Enabled = true;
                Neighbrhood_ComboBoxEdit.Enabled = true;
                Phone_Number_1_Area_Code_TextEdit.Enabled = true;
                Phone_Number_1_TextEdit.Enabled = true;
                Phone_Number_2_Area_Code_TextEdit.Enabled = true;
                Phone_Number_2_TextEdit.Enabled = true;
            }
        }

            }
}
