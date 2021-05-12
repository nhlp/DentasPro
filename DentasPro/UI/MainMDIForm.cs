/*Ana açılış ekranı*/
namespace Dentas_Pro.UI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Linq;
    using System.Drawing;
    using System.Text;
    using System.Windows.Forms;

    using DevExpress.XtraBars;

    using Dentas_Pro.UI.DAL_Function;
    using DevExpress.XtraBars.Ribbon;
    using Dentas_Pro.UI.Base;
    using System.Data.SqlClient;
    using System.Diagnostics;
    using Dentas_Pro.UI.User;
    using DevExpress.XtraEditors;

    public partial class MainMDIForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Get_The_Form get_The_Form = new Get_The_Form();

        #region Description
        /*Static değişkenlerimiz*/
        #endregion
        public static int UserId = -1;

        /*
         * Formlar arası geçiş için
         * aktarma
         */
        public static int Cross = -1;

        public static int  Title_Obj_Id;
        public static int  Department_Obj_Id;

        public MainMDIForm()
        {
            InitializeComponent();
            Login_Knowledge();
            Is_Password_Initialize();
            Initialize_Form();
            
        }

        public void Login_Knowledge()
        {
            System_Time_BarStaticItem.Caption = DateTime.Now.ToString();

            int Login_Obj_Id = Login_Form.Login_User_Obj_Id;

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
                    Logined_User_Name_SurName_BarButtonItem.Caption = sqlDataReader.GetString(0);
                }
            }
        }

        /// <summary>
        /// Eğer parola ilk verdiğimiz ise değiştirme zorunlu olsun
        /// </summary>
        public void Is_Password_Initialize()
        {
            System_Time_BarStaticItem.Caption = DateTime.Now.ToString();

            int Login_Obj_Id = Login_Form.Login_User_Obj_Id;


            SqlConnection sqlConnection = new SqlConnection("Server=10.168.0.26;Database=DentasPro;uid=sa;pwd=dentas;");
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand("Select Password From [User] where Obj_Id = '" + Login_Obj_Id + "'", sqlConnection);

            SqlParameter param = new SqlParameter();
            param.ParameterName = "@Login_Obj_Id";
            param.Value = Login_Obj_Id;

            sqlCommand.Parameters.Add(param);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    if (sqlDataReader.GetString(0) == "111")
                    {
                        Change_The_Password_Form change_The_Password_Form = new Change_The_Password_Form();
                        change_The_Password_Form.ShowDialog();

                        if (change_The_Password_Form.Second_Password_TextEdit.Text == "111" || string.IsNullOrEmpty(change_The_Password_Form.Second_Password_TextEdit.Text))
                        {
                            this.Close();
                        }
                    }
                }
            }
        }

        /// <Warning>
        /// Var olan bütün "Png" ve "Ico" ları override ediyor.
        /// </summary>
        public void Get_The_Base_Skin()
        {
            //DevExpress.UserSkins.OfficeSkins.Register();
            //DevExpress.UserSkins.BonusSkins.Register();
            //SkinHelper.InitSkinPopupMenu(Skin_Editor_BarButtonItem.Links);
        }

        private void Users_List_BarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {

            /*
             * Description: Sadece ik giriş yapabilsin bu ekrana:
             * Talebi yapan: Tuba Çulha
             * 16:Fatma Dayı
             * 17: Tuba_ 
             *  9: Armağan_ 
             *  8: Çağatay
             *  1: İrfan
             */
            if (Login_Form.Login_User_Obj_Id != 17 && Login_Form.Login_User_Obj_Id != 9 && Login_Form.Login_User_Obj_Id != 8 && Login_Form.Login_User_Obj_Id != 1 && Login_Form.Login_User_Obj_Id != 16)
            {
                MessageBox.Show("Personel kayıt ekranına girmeye yetkili değilsiniz", "Yetki Kontrol", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                get_The_Form.User_List();

            }
        }

        private void Who_Is_On_Vacation_BarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            get_The_Form.Who_Is_On_Vacation_List();

        }
        private void Daily_Hour_Permit_BarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            get_The_Form.Daily_Hour_Permit_Form();
        }

        private void Annual_Permit_BarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            get_The_Form.Annual_Permit_Form();
        }

        private void Department_BarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Login_Form.Login_User_Obj_Id != 17 && Login_Form.Login_User_Obj_Id != 9 && Login_Form.Login_User_Obj_Id != 8 && Login_Form.Login_User_Obj_Id != 1 && Login_Form.Login_User_Obj_Id != 16)
            {
                MessageBox.Show("Ekrana girmeye yetkili değilsiniz", "Yetki Kontrol", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                get_The_Form.Department_Form();
            }
        }

        private void Permit_Type_BarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Login_Form.Login_User_Obj_Id != 17 && Login_Form.Login_User_Obj_Id != 9 && Login_Form.Login_User_Obj_Id != 8 && Login_Form.Login_User_Obj_Id != 1 && Login_Form.Login_User_Obj_Id != 16)
            {
                MessageBox.Show("Ekrana girmeye yetkili değilsiniz", "Yetki Kontrol", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                get_The_Form.Permit_Reason_Form();
            }
        }

        private void Title_BarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Login_Form.Login_User_Obj_Id != 17 && Login_Form.Login_User_Obj_Id != 9 && Login_Form.Login_User_Obj_Id != 8 && Login_Form.Login_User_Obj_Id != 1 && Login_Form.Login_User_Obj_Id != 16)
            {
                MessageBox.Show("Ekrana girmeye yetkili değilsiniz", "Yetki Kontrol", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                get_The_Form.Title_Form();
            }

        }

        private void User_Form_BarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            /*
             * Description: Sadece ik giriş yapabilsin bu ekrana:
             * Talebi yapan: Tuba Çulha
             * 17: Tuba_ 
             * 9: Armağan_ 
             * 8: Çağatay
             * 1: İrfan
             */
            if (Login_Form.Login_User_Obj_Id != 17 && Login_Form.Login_User_Obj_Id != 9 && Login_Form.Login_User_Obj_Id != 8 && Login_Form.Login_User_Obj_Id != 1 && Login_Form.Login_User_Obj_Id != 16)
            {
                MessageBox.Show("Personel kayıt ekranına girmeye yetkili değilsiniz", "Yetki Kontrol", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                get_The_Form.User_Form();
            }
        }

        private void Location_BarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Login_Form.Login_User_Obj_Id != 17 && Login_Form.Login_User_Obj_Id != 9 && Login_Form.Login_User_Obj_Id != 8 && Login_Form.Login_User_Obj_Id != 1 && Login_Form.Login_User_Obj_Id != 16)
            {
                MessageBox.Show("Ekrana girmeye yetkili değilsiniz", "Yetki Kontrol", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                get_The_Form.Location_Form();
            }
        }

        private void Expense_Form_BarButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Login_Form.Login_User_Obj_Id != 17 && Login_Form.Login_User_Obj_Id != 9 && Login_Form.Login_User_Obj_Id != 8 && Login_Form.Login_User_Obj_Id != 1 && Login_Form.Login_User_Obj_Id != 16)
            {
                MessageBox.Show("Ekrana girmeye yetkili değilsiniz", "Yetki Kontrol", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                get_The_Form.Travel_Expense_Form();
            }

        }

        private void Travel_Request_BarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Login_Form.Login_User_Obj_Id != 17 && Login_Form.Login_User_Obj_Id != 9 && Login_Form.Login_User_Obj_Id != 8 && Login_Form.Login_User_Obj_Id != 1 && Login_Form.Login_User_Obj_Id != 16)
            {
                MessageBox.Show("Ekrana girmeye yetkili değilsiniz", "Yetki Kontrol", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                get_The_Form.Travel_Request_Form();
            }
        }

        private void Expense_Group_BarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Login_Form.Login_User_Obj_Id != 17 && Login_Form.Login_User_Obj_Id != 9 && Login_Form.Login_User_Obj_Id != 8 && Login_Form.Login_User_Obj_Id != 1 && Login_Form.Login_User_Obj_Id != 16)
            {
                MessageBox.Show("Ekrana girmeye yetkili değilsiniz", "Yetki Kontrol", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                get_The_Form.Expense_Group_Form();
            }
        }

        private void Travel_Vehicle_BarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Login_Form.Login_User_Obj_Id != 17 && Login_Form.Login_User_Obj_Id != 9 && Login_Form.Login_User_Obj_Id != 8 && Login_Form.Login_User_Obj_Id != 1 && Login_Form.Login_User_Obj_Id != 16)
            {
                MessageBox.Show("Ekrana girmeye yetkili değilsiniz", "Yetki Kontrol", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                get_The_Form.Travel_Vehicle_Form();
            }
        }

        /// <summary>
        /// Seyehat harcama formu açılıyor
        /// </summary>
        private void Expense_Type_Form_BarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Login_Form.Login_User_Obj_Id != 17 && Login_Form.Login_User_Obj_Id != 9 && Login_Form.Login_User_Obj_Id != 8 && Login_Form.Login_User_Obj_Id != 1 && Login_Form.Login_User_Obj_Id != 16)
            {
                MessageBox.Show("Ekrana girmeye yetkili değilsiniz", "Yetki Kontrol", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                get_The_Form.Travel_Expense_Type_Form();
            }

        }

        private void Skin_Editor_BarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Get_The_Base_Skin();
            //var gallery = new DevExpress.XtraBars.Ribbon.GalleryDropDown();
            //gallery.Manager = Skin_Editor_BarButtonItem.Manager;
            //SkinHelper.InitSkinGalleryDropDown(gallery);
            //gallery.ShowPopup(MousePosition);
        }

        private void Daily_Hour_Permit_List_BarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            get_The_Form.Daily_Permit_List_Form();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            get_The_Form.Annual_Permit_List_Form();
        }

        private void Permit_Knowledge_BarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            get_The_Form.Permit_Knowledge_Form();
        }

        private void Add_Annual_Permit_To_Staff_BarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            #region Whose
            /*
             * Tuba
             * Armağan
             * Çağatay
             * Me
             * Fatma D.
             * Buğra
             */
            #endregion
            if (Login_Form.Login_User_Obj_Id != 17 && Login_Form.Login_User_Obj_Id != 9 && Login_Form.Login_User_Obj_Id != 8 && Login_Form.Login_User_Obj_Id != 1 && Login_Form.Login_User_Obj_Id != 16 && Login_Form.Login_User_Obj_Id != 3)
            {
                MessageBox.Show("Ekranına girmeye yetkili değilsiniz", "Yetki Kontrol", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                get_The_Form.Add_Annual_Permit();

            }


        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            #region Whose
            /*
             * Tuba
             * Armağan
             * Çağatay
             * Me
             * Fatma D.
             * Buğra
             */
            #endregion
            if (Login_Form.Login_User_Obj_Id != 17 && Login_Form.Login_User_Obj_Id != 9 && Login_Form.Login_User_Obj_Id != 8 && Login_Form.Login_User_Obj_Id != 1 && Login_Form.Login_User_Obj_Id != 16 && Login_Form.Login_User_Obj_Id != 3)
            {
                MessageBox.Show("Mail gönderme ekranına girmeye yetkili değilsiniz", "Yetki Kontrol", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                get_The_Form.Send_An_Email_Form();
            }
        }

        private void Recycle_Accounting_BarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            get_The_Form.Recycle_Accounting_Form();
        }

        private void Wating_Approval_List_Form_BarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Login_Form.Login_User_Obj_Id != 17 && Login_Form.Login_User_Obj_Id != 9 && Login_Form.Login_User_Obj_Id != 8 && Login_Form.Login_User_Obj_Id != 1 && Login_Form.Login_User_Obj_Id != 16 && Login_Form.Login_User_Obj_Id != 3)
            {
                MessageBox.Show("Giriş için yetkili değilsiniz", "Yetki Kontrol", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                get_The_Form.Wating_Approval_List_Form(true);
            }

        }
        /// <summary>
        /// Bu ekrana sadece buğra Bey ve IK girebilsin
        /// 15.5.2015_ tarihinde 2.durum değerlendirme toplantısında karar alındı
        /// </summary>
        private void Department_Performance_Report_BarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {

            MessageBox.Show("Rapor yapım aşamasındadır");
            return;
            /*
             * Description: Sadece ik giriş yapabilsin bu ekrana:
             * Talebi yapan: Fatma Dayı
             * Yer: Denizli toplantı Odası
             * Toplantı Adı: 2.Dentaş_Pro durum değerlendirme toplantısı
             * Tarih: 2015_05_15
             * 17: Tuba_ 
             * 9: Armağan_ 
             * 8: Çağatay
             * 1: İrfan
             * 3:Buğra
             */
            //if (Login_Form.Login_User_Obj_Id != 17 && Login_Form.Login_User_Obj_Id != 9 && Login_Form.Login_User_Obj_Id != 8 && Login_Form.Login_User_Obj_Id != 1 && Login_Form.Login_User_Obj_Id != 16 && Login_Form.Login_User_Obj_Id != 3)
            //{
            //    MessageBox.Show("Departman performans raporuna  girmeye yetkili değilsiniz", "Yetki Kontrol", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            //else
            //{
            //    get_The_Form.Staff_Rest_Permit_List_Form_Graphic();
            //}
        }

        private void Staff_Rest_Permit_BarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            /*
             * Description: Sadece ik giriş yapabilsin bu ekrana:
             * Talebi yapan: Fatma Dayı
             * Yer: Denizli toplantı Odası
             * Toplantı Adı: 2.Dentaş_Pro durum değerlendirme toplantısı
             * Tarih: 2015_05_15
             * 17: Tuba_ 
             * 9: Armağan_ 
             * 8: Çağatay
             * 1: İrfan
             * 3:Buğra
             */
            if (Login_Form.Login_User_Obj_Id != 17 && Login_Form.Login_User_Obj_Id != 9 && Login_Form.Login_User_Obj_Id != 8 && Login_Form.Login_User_Obj_Id != 1 && Login_Form.Login_User_Obj_Id != 16 && Login_Form.Login_User_Obj_Id != 3)
            {
                MessageBox.Show("Personel kalan izin ekranına girmeye yetkili değilsiniz", "Yetki Kontrol", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                get_The_Form.Staff_Rest_Permit_List_Form();

            }
        }

        private void Holiday_Set_BarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
         
            /*
             * Description: Sadece ik giriş yapabilsin bu ekrana:
             * Talebi yapan: Fatma Dayı
             * Yer: Denizli toplantı Odası
             * Toplantı Adı: 2.Dentaş_Pro durum değerlendirme toplantısı
             * Tarih: 2015_05_15
             * 17: Tuba_ 
             * 9: Armağan_ 
             * 8: Çağatay
             * 1: İrfan
             * 3:Buğra
             */
            if (Login_Form.Login_User_Obj_Id != 17 && Login_Form.Login_User_Obj_Id != 9 && Login_Form.Login_User_Obj_Id != 8 && Login_Form.Login_User_Obj_Id != 1 && Login_Form.Login_User_Obj_Id != 16 && Login_Form.Login_User_Obj_Id != 3)
            {
                MessageBox.Show("Ekrana girmeye yetkili değilsiniz", "Yetki Kontrol", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                get_The_Form.Holiday_Set_Form();

            }
        }

        private void History_Of_Annual_Permit_Form_BarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            get_The_Form.History_Of_Annual_Premit_Form();
        }

        private void MainMDIForm_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Dev_Date : 2015_05_25
        /// Task Manager'daki Exe kill ediliyor.
        /// Görev yöneticisi exe kapatılıyor.
        /// </summary>
        private void MainMDIForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Process[] process;
            process = Process.GetProcessesByName("Dentas_Pro.UI");
            if (process.Length > 0)
            {
                process[0].Kill();
            }
        }

        /*
         * 3_1_47
         * Dentaş Takip PRO
         */

        public void Initialize_Form()
        {
            Permit_Knowledge_Form permit_Knowledge_Form = new Permit_Knowledge_Form();
            permit_Knowledge_Form.Show();
            permit_Knowledge_Form.Hide();
        }

        private void Choose_The_Annual_Permit_ButtonEdit_Click(object sender, EventArgs e)
        {
            Annual_Permit_Form annual_Permit_Form = new Annual_Permit_Form();
            annual_Permit_Form.Choose_The_annual_Permit_ButtonEdit_Click(sender,e);
        }

      public void CloseAllButThis(Form parentForm)
    {
        foreach (Form frm in MainMDIForm.ActiveForm.MdiChildren)
        {
            if (frm.GetType() != Parent.GetType()
                && frm != Parent)
            {
                frm.Close();
            }
        }
    }

      private void popupMenu1_CloseUp(object sender, EventArgs e)
      {
          MainMDIForm mainMDIForm = new MainMDIForm();

          CloseAllButThis(mainMDIForm);
      }
      
    }
}