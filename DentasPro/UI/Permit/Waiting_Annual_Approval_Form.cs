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
    using System.Data.SqlClient;

    using DevExpress.XtraEditors;
    using Dentas_Pro.UI.DAL_Function;
    using Dentas_Pro.UI.Base;
    using Dentas_Pro.UI.User;

    public partial class Waiting_Annual_Approval_Form : XtraForm
    {
        public Waiting_Annual_Approval_Form()
        {
            InitializeComponent();
        }

        DAL_Function.Sql_Server_DB_From_DentasProDataContext sql_Server_Db_From_DentasPro_Data_Context = new Sql_Server_DB_From_DentasProDataContext();
        DAL_Function.Get_The_Form get_The_Forms = new DAL_Function.Get_The_Form();
        Generator.Generate_Id generator_Id = new Generator.Generate_Id();
        DAL_Function.Messages messages = new Messages();
        UI.Mail.Send_An_E_Mail send_An_E_Mail = new Mail.Send_An_E_Mail();


        public bool Choose = false;
        public bool Edit = false;
        public int Choose_Obj_Id = -1;
        public int User_Obj_Id = -1;
        public int annual_Permit_Obj_Id = -1;
        public int Department_Responsible_Obj_Id = -1;
        public int Department_Manager_Obj_Id = -1;
        public int Department_Obj_Id = -1;
        public int Expense_Group_Obj_Id = -1;
        public int Title_Obj_Id = -1;
        public int Permit_Reason_Obj_Id = -1;


        private void Waiting_Annual_Approval_Form_Load(object sender, EventArgs e)
        {
            Get_The_Annual_Not_Approval_List();
        }

        private void Clean_The_Control_Value_SimpleButton_Click(object sender, EventArgs e)
        {
            Clean_The_Control();
        }

        public void Get_The_Annual_Not_Approval_List()
        {
            //var Get_Not_Approval = from s in sql_Server_Db_From_DentasPro_Data_Context.Annual_Permits
            //                       select s;

            //Annual_Approval_GridControl.DataSource = Get_Not_Approval;
            List_The_Annual_Permit_For_Permit_Type();
        }

        public void Update_From_UI()
        {
            try
            {
                DAL_Function.Annual_Permit annual_Permit = sql_Server_Db_From_DentasPro_Data_Context.Annual_Permits.First(s => s.Obj_Id == annual_Permit_Obj_Id);

                annual_Permit.Permit_Start_Time = DateTime.Parse(Permit_Start_Date_TextEdit.Text);
                annual_Permit.Permit_End_Time = DateTime.Parse(Permit_End_Date_TextEdit.Text);
                annual_Permit.Department_Manager_Apporoval_Description = Department_Manager_Description_MemoEdit.Text;
                annual_Permit.Department_Responsible_Approval_Description = Department_Supervisor_Description_MemoEdit.Text;
                annual_Permit.Human_Resource_Approval_Description = HR_Description_MemoEdit.Text;

                annual_Permit.Department_Chief_Obj_Id = Department_Responsible_Obj_Id;
                annual_Permit.Department_Obj_Id = Department_Obj_Id;
                annual_Permit.Department_Manager_Obj_Id = Department_Manager_Obj_Id;
                annual_Permit.Update_Time = DateTime.Now;
                annual_Permit.Update_User = Login_Form.Login_User_Obj_Id;


                /*Value: 1 ise True*/
                if (Department_Supervisor_Approval_ComboBoxEdit.SelectedIndex == 1)
                {
                    annual_Permit.Approval_Department_Responsible_Situation = true;
                }

                if (Department_Supervisor_Approval_ComboBoxEdit.SelectedIndex == 2)
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


                if (HR_Approval_ComboBoxEdit.SelectedIndex == 1)
                {
                    annual_Permit.Paraph_Human_Resource_Situation = true;
                }

                if (HR_Approval_ComboBoxEdit.SelectedIndex == 2)
                {
                    annual_Permit.Paraph_Human_Resource_Situation = false;
                }

                /*İzin Departman Müdürü tarafından onaylanmış ise İzin talebi yapana mail gönderiyoruz*/
                if (Department_Manager_Apporoval_ComboBoxEdit.SelectedIndex == 1)
                {
                    send_An_E_Mail.Send_An_E_Mail_(User_Obj_Id, From_Mail_(), Permit_Owner(annual_Permit.User_Obj_Id), "Yıllık izin talebiniz Departman Müdürü tarafından onaylandı", "Yıllık İzin Onay");
                }

                /*Deparman Sorumlusu Onaylandığında*/
                if (Department_Supervisor_Approval_ComboBoxEdit.SelectedIndex == 1)
                {
                    send_An_E_Mail.Send_An_E_Mail_(User_Obj_Id, From_Mail_(), Permit_Owner(annual_Permit.User_Obj_Id), "Yıllık izin talebiniz Departman Sorumlunuz tarafından onaylandı", "Yıllık İzin Onay");
                }

                /*İnsan kaynakları onayladığında*/
                if (HR_Approval_ComboBoxEdit.SelectedIndex == 1)
                {
                    send_An_E_Mail.Send_An_E_Mail_(User_Obj_Id, From_Mail_(), Permit_Owner(annual_Permit.User_Obj_Id), "Yıllık izin talebiniz İnsan Kaynakları tarafından onaylandı", "Yıllık İzin Onay");

                    /*
                     * Date: 2015_04_10_10:25
                     * Description:_Bayram_Ç.
                     *          Ancak IK onayladığında "Birikmiş İzin Gün Sayısı" nda eksilme olacak. 
                     *          Talep edilen izin gün sayısı  - "Toplam_İzin_Gün_Sayısı" -- Olacak ..
                     */

                    Update_Used_Annuel_Permit_Day_Count(int.Parse(annual_Permit.User_Obj_Id.ToString()));
                    Update_The_Permitted_Use(int.Parse(annual_Permit.User_Obj_Id.ToString()));
                    //Decrement_The_Used_Permit();
                    annual_Permit.Accumulated_Permit_count_Knowledge_Data = Get_The_Accumulated_Permit_count_for_Historic_Annual_List(int.Parse(annual_Permit.User_Obj_Id.ToString()));
                    annual_Permit.Permitted_Use_Knowledge_Data = Get_The_Permitted_Use_Knowledge_Data_for_Historic_Annual_List(int.Parse(annual_Permit.User_Obj_Id.ToString()));
                    Update_Permitted_Use_With_Zero(int.Parse(annual_Permit.User_Obj_Id.ToString()));

                    //annual_Permit.Permitted_Use_Knowledge_Data = 0;
                }

                sql_Server_Db_From_DentasPro_Data_Context.SubmitChanges();
                messages.Update(true);
                Clean_The_Control();

            }
            catch (Exception exception)
            {
                messages.Error(exception);
            }
        }

        private void Clean_The_Control()
        {
            Registration_Code_TextEdit.Text = string.Empty;
            Full_Name_TextEdit.Text = string.Empty;
            Permit_Start_Date_TextEdit.Text = string.Empty;
            Permit_End_Date_TextEdit.Text = string.Empty;
            Department_Manager_Apporoval_ComboBoxEdit.SelectedIndex = -1;
            Department_Supervisor_Approval_ComboBoxEdit.SelectedIndex = -1;
            HR_Approval_ComboBoxEdit.SelectedIndex = -1;
            Department_Manager_Description_MemoEdit.Text = string.Empty;
            Department_Supervisor_Description_MemoEdit.Text = string.Empty;
            HR_Description_MemoEdit.Text = string.Empty;
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

        /// <summary>
        /// Grid'in satırı tıkladığında: satırdaki kayıt seçiliyor.
        /// 2015_06_23
        /// </summary>
        public void Choice_The_Record(int Choice_Obj_Id)
        {
            try
            {
                Edit = true;
                if (Choice_Obj_Id == -1)
                {
                    Choice_Obj_Id = 4;
                }
                else
                {
                    annual_Permit_Obj_Id = Choice_Obj_Id;
                }

                annual_Permit_Obj_Id = Choice_Obj_Id;
                DAL_Function.Annual_Permit annual_Permit = (sql_Server_Db_From_DentasPro_Data_Context.Annual_Permits.First(s => s.Obj_Id == annual_Permit_Obj_Id));

                //Choose_Obj_Id = int.Parse(gridView1.GetFocusedRowCellValue("Sıra").ToString());
                Registration_Code_TextEdit.Text = gridView1.GetFocusedRowCellValue("Sicil_Numarası").ToString();
                Full_Name_TextEdit.Text = gridView1.GetFocusedRowCellValue("Ad_Soyad").ToString();

                Permit_Start_Date_TextEdit.Text = gridView1.GetFocusedRowCellValue("İzin_Başlangıç_Tarihi").ToString();
                Permit_End_Date_TextEdit.Text = gridView1.GetFocusedRowCellValue("İzin_Bitiş_Tarihi").ToString();

                //HR_Approval_ComboBoxEdit.Text = gridView1.GetFocusedRowCellValue("IK_Onay").ToString();
                //if (bool.Parse((gridView1.GetFocusedRowCellValue("IK_Onay").ToString())) != null)
                //{
                //    //HR_Approval_ComboBoxEdit.Text = "Onaylandı";
                //    HR_Approval_ComboBoxEdit.SelectedIndex = 1;
                //}
                //else if (!bool.Parse((gridView1.GetFocusedRowCellValue("IK_Onay").ToString())) != null)
                //{
                //    //HR_Approval_ComboBoxEdit.Text = "Onaylanmadı";
                //    HR_Approval_ComboBoxEdit.SelectedIndex = 2;
                //}

                
                if (annual_Permit.Paraph_Human_Resource_Situation == true)
                {
                    HR_Approval_ComboBoxEdit.Text = "Onaylandı";
                }
                if (annual_Permit.Paraph_Human_Resource_Situation == false)
                {
                    HR_Approval_ComboBoxEdit.Text = "Onaylanmadı";
                }


                if (annual_Permit.Approval_Department_Responsible_Situation == true)
                {
                    Department_Supervisor_Approval_ComboBoxEdit.SelectedIndex = 1;
                }
                if (annual_Permit.Approval_Department_Responsible_Situation == false)
                {
                    Department_Supervisor_Approval_ComboBoxEdit.SelectedIndex = 2;
                }



                if (annual_Permit.Approval_Department_Manager_Situation == true)
                {
                    Department_Manager_Apporoval_ComboBoxEdit.Text = "Onaylandı";
                }
                if (annual_Permit.Approval_Department_Manager_Situation == false)
                {
                    Department_Manager_Apporoval_ComboBoxEdit.Text = "Onaylanmadı";
                }

            }
            catch (Exception exception)
            {
                throw;
            }
        }

        public void List_The_Annual_Permit_For_Permit_Type()
        {
            /*
             * Dev_Date    : 2015_06_03
             * Description:if staff is manager
             */
            Annual_Permit_Form annual_Permit_Form = new Annual_Permit_Form();

            //if (annual_Permit_Form.Job_Title_TextEdit.Text.Contains("Müdür") == true) Title göre ekrandaki grid'i dolduruyoruz.
            //1 2 3 4 5 6 11 17 28 38 43 46 65 86 161 --> Müdürler
            //57 66 72 110 --> Direktörler

            if (MainMDIForm.Title_Obj_Id == 1 || MainMDIForm.Title_Obj_Id == 2 || MainMDIForm.Title_Obj_Id == 3 || MainMDIForm.Title_Obj_Id == 4 ||
                    MainMDIForm.Title_Obj_Id == 5 || MainMDIForm.Title_Obj_Id == 6 || MainMDIForm.Title_Obj_Id == 11 || MainMDIForm.Title_Obj_Id == 17 ||
                    MainMDIForm.Title_Obj_Id == 28 || MainMDIForm.Title_Obj_Id == 38 || MainMDIForm.Title_Obj_Id == 43 || MainMDIForm.Title_Obj_Id == 46 ||
                    MainMDIForm.Title_Obj_Id == 65 || MainMDIForm.Title_Obj_Id == 86 || MainMDIForm.Title_Obj_Id == 161 || MainMDIForm.Title_Obj_Id == 57 ||
                    MainMDIForm.Title_Obj_Id == 66 || MainMDIForm.Title_Obj_Id == 72 || MainMDIForm.Title_Obj_Id == 110
               )
            {
                var list = from ap in sql_Server_Db_From_DentasPro_Data_Context.Annual_Permits

                           join u in sql_Server_Db_From_DentasPro_Data_Context.Users on ap.User_Obj_Id equals u.Obj_Id
                           join d in sql_Server_Db_From_DentasPro_Data_Context.Departments on ap.Department_Obj_Id equals d.Obj_Id
                           /*join pr in sql_Server_Db_From_Follow_Up_Data_Context.Permit_Reasons on ap.Permit_Reason_Obj_Id equals pr.Obj_Id*/
                           orderby ap.Obj_Id descending
                           /*Where clause'unda bilgi işlem'i filtreliyoruz*/
                           where u.Department_Obj_Id == MainMDIForm.Department_Obj_Id
                           select new
                           {
                               Sıra = ap.Obj_Id,
                               Ad_Soyad = u.Full_Name,
                               Sicil_Numarası = u.Registration_Number,
                               Departman_Adı = d.Name,
                               İzin_Başlangıç_Tarihi = ap.Permit_Start_Time,
                               İzin_Bitiş_Tarihi = ap.Permit_End_Time,

                               Yönetici_Onay = ap.Approval_Department_Manager_Situation,
                               Yönetici_Not = ap.Department_Manager_Apporoval_Description,

                               Yönetmen_Onay = ap.Approval_Department_Responsible_Situation,
                               Yönetmen_Not = ap.Department_Responsible_Approval_Description,

                               IK_Onay = ap.Paraph_Human_Resource_Situation,
                               IK_Not = ap.Human_Resource_Approval_Description,
                               //Kullanılmış_İzin_Gün_Adedi = ap.Permitted_Use_Knowledge_Data,
                               //Bakiye = ap.Accumulated_Permit_count_Knowledge_Data
                           };
                Annual_Approval_GridControl.DataSource = list;


                HR_Approval_ComboBoxEdit.Enabled = false;
                HR_Description_MemoEdit.Enabled = false;
                Department_Supervisor_Approval_ComboBoxEdit.Enabled = false;
                Department_Supervisor_Description_MemoEdit.Enabled = false;

                return;
            }


            /*Yönetmen'ler*/
            //14 52 63 4 70 85 88 148 173 176
            if (MainMDIForm.Title_Obj_Id == 14 || MainMDIForm.Title_Obj_Id == 52 || MainMDIForm.Title_Obj_Id == 63 || MainMDIForm.Title_Obj_Id == 4 ||
                MainMDIForm.Title_Obj_Id == 70 || MainMDIForm.Title_Obj_Id == 85 || MainMDIForm.Title_Obj_Id == 88 || MainMDIForm.Title_Obj_Id == 148 ||
                MainMDIForm.Title_Obj_Id == 173 || MainMDIForm.Title_Obj_Id == 176)
            {
                var list = from ap in sql_Server_Db_From_DentasPro_Data_Context.Annual_Permits

                           join u in sql_Server_Db_From_DentasPro_Data_Context.Users on ap.User_Obj_Id equals u.Obj_Id
                           join d in sql_Server_Db_From_DentasPro_Data_Context.Departments on ap.Department_Obj_Id equals d.Obj_Id
                           /*join pr in sql_Server_Db_From_Follow_Up_Data_Context.Permit_Reasons on ap.Permit_Reason_Obj_Id equals pr.Obj_Id*/
                           orderby ap.Obj_Id descending
                           /*Where clause'unda bilgi işlem'i filtreliyoruz*/
                           where u.Department_Obj_Id == MainMDIForm.Department_Obj_Id
                           select new
                           {
                               Sıra = ap.Obj_Id,
                               Ad_Soyad = u.Full_Name,
                               Sicil_Numarası = u.Registration_Number,
                               /*u.Department_Obj_Id.Value,*/
                               Departman_Adı = d.Name,
                               İzin_Başlangıç_Tarihi = ap.Permit_Start_Time,
                               İzin_Bitiş_Tarihi = ap.Permit_End_Time,

                               Yönetici_Onay = ap.Approval_Department_Manager_Situation,
                               Yönetici_Not = ap.Department_Manager_Apporoval_Description,

                               Yönetmen_Onay = ap.Approval_Department_Responsible_Situation,
                               Yönetmen_Not = ap.Department_Responsible_Approval_Description,

                               IK_Onay = ap.Paraph_Human_Resource_Situation,
                               IK_Not = ap.Human_Resource_Approval_Description,

                               //Kullanılmış_İzin_Gün_Adedi = ap.Permitted_Use_Knowledge_Data,
                               //Bakiye = ap.Accumulated_Permit_count_Knowledge_Data
                           };
                Annual_Approval_GridControl.DataSource = list;

                Department_Manager_Apporoval_ComboBoxEdit.Enabled = false;
                Department_Manager_Description_MemoEdit.Enabled = false;
                HR_Approval_ComboBoxEdit.Enabled = false;
                HR_Description_MemoEdit.Enabled = false;

                return;
            }

            /*IK'cılar*/
            //46 47 48 52
            if (MainMDIForm.Title_Obj_Id == 46 || MainMDIForm.Title_Obj_Id == 47 || MainMDIForm.Title_Obj_Id == 48 || MainMDIForm.Title_Obj_Id == 52)
            {
                var list = from ap in sql_Server_Db_From_DentasPro_Data_Context.Annual_Permits

                           join u in sql_Server_Db_From_DentasPro_Data_Context.Users on ap.User_Obj_Id equals u.Obj_Id
                           join d in sql_Server_Db_From_DentasPro_Data_Context.Departments on ap.Department_Obj_Id equals d.Obj_Id
                           /*join pr in sql_Server_Db_From_Follow_Up_Data_Context.Permit_Reasons on ap.Permit_Reason_Obj_Id equals pr.Obj_Id*/
                           orderby ap.Obj_Id descending
                           /*Where clause'unda bilgi işlem'i filtreliyoruz*/
                           where u.Department_Obj_Id == MainMDIForm.Department_Obj_Id
                           select new
                           {
                               Sıra = ap.Obj_Id,
                               Ad_Soyad = u.Full_Name,
                               Sicil_Numarası = u.Registration_Number,
                               /*u.Department_Obj_Id.Value,*/
                               Departman_Adı = d.Name,
                               İzin_Başlangıç_Tarihi = ap.Permit_Start_Time,
                               İzin_Bitiş_Tarihi = ap.Permit_End_Time,

                               Yönetici_Onay = ap.Approval_Department_Manager_Situation,
                               Yönetici_Not = ap.Department_Manager_Apporoval_Description,

                               Yönetmen_Onay = ap.Approval_Department_Responsible_Situation,
                               Yönetmen_Not = ap.Department_Responsible_Approval_Description,

                               IK_Onay = ap.Paraph_Human_Resource_Situation,
                               IK_Not = ap.Human_Resource_Approval_Description,

                               //Kullanılmış_İzin_Gün_Adedi = ap.Permitted_Use_Knowledge_Data,
                               //Bakiye = ap.Accumulated_Permit_count_Knowledge_Data
                           };
                Annual_Approval_GridControl.DataSource = list;

                return;
            }


            /*Yukarda ID ile "direktörlerde" kontrol edildi..*/
            //if (annual_Permit_Form.Job_Title_TextEdit.Text.Contains("Direktör") == true)
            //{
            //    var list = from ap in sql_Server_Db_From_Follow_Up_Data_Context.Annual_Permits

            //               join u in sql_Server_Db_From_Follow_Up_Data_Context.Users on ap.User_Obj_Id equals u.Obj_Id
            //               join d in sql_Server_Db_From_Follow_Up_Data_Context.Departments on ap.Department_Obj_Id equals d.Obj_Id
            //               /*join pr in sql_Server_Db_From_Follow_Up_Data_Context.Permit_Reasons on ap.Permit_Reason_Obj_Id equals pr.Obj_Id*/
            //               orderby ap.Obj_Id descending
            //               /*Where clause'unda bilgi işlem'i filtreliyoruz*/
            //               where u.Department_Obj_Id == annual_Permit_Form.Department_Obj_Id
            //               select new
            //               {
            //                   Sıra = ap.Obj_Id,
            //                   Ad_Soyad = u.Full_Name,
            //                   Sicil_Numarası = u.Registration_Number,
            //                   /*u.Department_Obj_Id.Value,*/
            //                   Departman_Adı = d.Name,
            //                   İzin_Başlangıç_Tarihi = ap.Permit_Start_Time,
            //                   İzin_Bitiş_Tarihi = ap.Permit_End_Time,
            //                   /*ap.Permit_Type,*/
            //                   /*İzin_Sebebi = pr.Name,*/
            //                   //Bu_yıl_Hak_Edilen_İzin = u.This_Year_Permit_Count,
            //                   Kullanılmış_İzin_Gün_Adedi = ap.Permitted_Use_Knowledge_Data,
            //                   Bakiye = ap.Accumulated_Permit_count_Knowledge_Data
            //               };
            //    fuGridControl1.DataSource = list;
            //}


            /*Düz personel*/
            else
            {
                var list = from ap in sql_Server_Db_From_DentasPro_Data_Context.Annual_Permits

                           join u in sql_Server_Db_From_DentasPro_Data_Context.Users on ap.User_Obj_Id equals u.Obj_Id
                           join d in sql_Server_Db_From_DentasPro_Data_Context.Departments on ap.Department_Obj_Id equals d.Obj_Id
                           /*join pr in sql_Server_Db_From_Follow_Up_Data_Context.Permit_Reasons on ap.Permit_Reason_Obj_Id equals pr.Obj_Id*/
                           orderby ap.Obj_Id descending
                           /*Where clause'unda bilgi işlem'i filtreliyoruz*/
                           where u.Department_Obj_Id == MainMDIForm.Department_Obj_Id
                           select new
                           {
                               Sıra = ap.Obj_Id,
                               Ad_Soyad = u.Full_Name,
                               Sicil_Numarası = u.Registration_Number,
                               /*u.Department_Obj_Id.Value,*/
                               Departman_Adı = d.Name,
                               İzin_Başlangıç_Tarihi = ap.Permit_Start_Time,
                               İzin_Bitiş_Tarihi = ap.Permit_End_Time,

                               Yönetici_Onay = ap.Approval_Department_Manager_Situation,
                               Yönetici_Not = ap.Department_Manager_Apporoval_Description,

                               Yönetmen_Onay = ap.Approval_Department_Responsible_Situation,
                               Yönetmen_Not = ap.Department_Responsible_Approval_Description,

                               IK_Onay = ap.Paraph_Human_Resource_Situation,
                               IK_Not = ap.Human_Resource_Approval_Description,

                               //Kullanılmış_İzin_Gün_Adedi = ap.Permitted_Use_Knowledge_Data,
                               //Bakiye = ap.Accumulated_Permit_count_Knowledge_Data
                           };
                Annual_Approval_GridControl.DataSource = list;
            }

            /* 
             * Eğer personeller IK veya Genel Müdür ise herkesi görsünler..
             * Buğra Sükan, Armağan, Celal, Fatma Dayı, Tuğba, Çağatay  
             */
            if (Login_Form.Login_User_Obj_Id == 3 || Login_Form.Login_User_Obj_Id == 9 || Login_Form.Login_User_Obj_Id == 13 || Login_Form.Login_User_Obj_Id == 16 || Login_Form.Login_User_Obj_Id == 17 || Login_Form.Login_User_Obj_Id == 8)
            {
                var list = from ap in sql_Server_Db_From_DentasPro_Data_Context.Annual_Permits

                           join u in sql_Server_Db_From_DentasPro_Data_Context.Users on ap.User_Obj_Id equals u.Obj_Id
                           join d in sql_Server_Db_From_DentasPro_Data_Context.Departments on ap.Department_Obj_Id equals d.Obj_Id
                           /*join pr in sql_Server_Db_From_Follow_Up_Data_Context.Permit_Reasons on ap.Permit_Reason_Obj_Id equals pr.Obj_Id*/

                           orderby ap.Permit_Start_Time descending

                           select new
                           {
                               Sıra = ap.Obj_Id,
                               Ad_Soyad = u.Full_Name,
                               Sicil_Numarası = u.Registration_Number,
                               /*u.Department_Obj_Id.Value,*/
                               Departman_Adı = d.Name,
                               İzin_Başlangıç_Tarihi = ap.Permit_Start_Time,
                               İzin_Bitiş_Tarihi = ap.Permit_End_Time,

                               Yönetici_Onay = ap.Approval_Department_Manager_Situation,
                               Yönetici_Not = ap.Department_Manager_Apporoval_Description,

                               Yönetmen_Onay = ap.Approval_Department_Responsible_Situation,
                               Yönetmen_Not = ap.Department_Responsible_Approval_Description,

                               IK_Onay = ap.Paraph_Human_Resource_Situation,
                               IK_Not = ap.Human_Resource_Approval_Description,//Bu_yıl_Hak_Edilen_İzin = u.This_Year_Permit_Count,

                               //Kullanılmış_İzin_Gün_Adedi = ap.Permitted_Use_Knowledge_Data,
                               //Bakiye = ap.Accumulated_Permit_count_Knowledge_Data
                           };
                Annual_Approval_GridControl.DataSource = list;
            }
        }

        /// <summary>
        /// "İlk önce : Kullanılan izin gün sayısı"  - "Toplam izin adedinden" düşüyoruz..
        /// </summary>
        public int Update_Used_Annuel_Permit_Day_Count(int Selected_User_Obj_Id)
        {
            DateTime start = DateTime.Parse(Permit_Start_Date_TextEdit.Text);
            DateTime end = DateTime.Parse(Permit_End_Date_TextEdit.Text);

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

        public int Is_PermitDay_Holiday()
        {
            DateTime start = DateTime.Parse(Permit_Start_Date_TextEdit.Text);
            DateTime end = DateTime.Parse(Permit_End_Date_TextEdit.Text);

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

        public int Update_The_Permitted_Use(int Selected_User_Obj_Id)
        {
            DateTime start = DateTime.Parse(Permit_Start_Date_TextEdit.Text);
            DateTime end = DateTime.Parse(Permit_End_Date_TextEdit.Text);

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

        public int Update_Permitted_Use_With_Zero(int Selected_User_Obj_Id)
        {
            DateTime start = DateTime.Parse(Permit_Start_Date_TextEdit.Text);
            DateTime end = DateTime.Parse(Permit_End_Date_TextEdit.Text);

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

        private void Annual_Approval_GridControl_DoubleClick(object sender, EventArgs e)
        {
            Choice_The_Record(Choose_Obj_Id);
        }

        private void Save_SimpleButton_Click(object sender, EventArgs e)
        {
            Update_From_UI();
        }

        private void Registration_Code_TextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
