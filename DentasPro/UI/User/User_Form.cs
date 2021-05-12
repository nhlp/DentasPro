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
    using Dentas_Pro.Framework;
    using System.Globalization;
    using System.Runtime.InteropServices;


    public partial class User_Form : Base_Form
    {
        public User_Form()
        {
            InitializeComponent();
            Login_Name_TextEdit.Enabled = false;
            /*
             * Bu ekrana görecekleri burda kontrol et.
             * 1. Ya Main MDI'ın ctro'unda bu ekranın visible'ını false yap
             * 2-Y da burda kullanıcıya bu ekranı açmaya yetkiniz yok gibi mesaj vererek engelle.
             */
        }

        public bool Edit = false;
        public int User_Obj_Id = -1;
        public int Department_Responsible_Obj_Id = -1;
        public int Department_Manager_Obj_Id = -1;
        public int Department_Obj_Id = -1;
        public int Expense_Group_Obj_Id = -1;
        public int Title_Obj_Id = -1;

        DAL_Function.Sql_Server_DB_From_DentasProDataContext sql_Server_Db_From_Follow_Up_Data_context = new DAL_Function.Sql_Server_DB_From_DentasProDataContext();
        DAL_Function.Messages messages = new DAL_Function.Messages();
        DAL_Function.Get_The_Form get_The_Forms = new DAL_Function.Get_The_Form();
        Dentas_Pro.UI.Helper.Text_Replacer text_Replacer = new Helper.Text_Replacer();

        Generator.Generate_Id generate_Id = new Generator.Generate_Id();

        private void User_Form_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(User_Form_KeyDown);
            /*
             * Form load olurken Personelin sicil numarasını kendimiz generate ediyoruz.. 
             * Bayram Ç:Sicil numarası IK tarafından maneul girilmeli
             * 2015_03_16_09:30
             */
            //Registration_Number_TextEdit.Text = generate_Id.Generate_The_Unique_Id_For_Registration_Number();


        }

        /// <summary>
        /// Temizle
        /// Kontrollerin text özelliğine empty atayarakta yapabiliriz.
        /// Definition form'larda empty atanan formatı var.
        /// </summary>
        public void Clean_The_Control()
        {
            foreach (Control control in Generale_Knowledge_GroupControl.Controls)
            {
                if (control is DevExpress.XtraEditors.TextEdit || control is DevExpress.XtraEditors.ButtonEdit)
                {
                    control.Text = string.Empty;
                }
            }

            foreach (Control control in Comminication_Knowledge_GroupControl.Controls)
            {
                if (control is DevExpress.XtraEditors.TextEdit || control is DevExpress.XtraEditors.MemoEdit)
                {
                    control.Text = string.Empty;
                }
            }

            foreach (Control control in Manager_GroupControl.Controls)
            {
                if (control is DevExpress.XtraEditors.ButtonEdit)
                {
                    control.Text = string.Empty;
                }
            }

            //Registration_Number_TextEdit.Text = generate_Id.Generate_The_Unique_Id_For_Registration_Number_Id();

            Edit = false;

            User_Obj_Id = -1;
            Department_Obj_Id = -1;
            MainMDIForm.Cross = -1;
        }

        /// <summary>
        /// Dışardan alınan verielrde her zaman
        /// null kontrol'ü yapmak zorundasın.
        /// </summary>
        public void Get_Data_From_UI()
        {

            #region Insert_Rules

            if (Name_TextEdit.Text == "" || Name_TextEdit.Text == null)
            {
                MessageBox.Show("Mutlaka isim girmelisiniz...", "Ad Bilgisi Eksik", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Name_TextEdit.Focus();
                return;

            }
            else if (Surname_TextEdit.Text == "" || Surname_TextEdit.Text == null)
            {
                MessageBox.Show("Mutlaka soyad girmelisiniz...", "Soyad Bilgisi Eksik", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Surname_TextEdit.Focus();
                return;
            }
            else if (Citizen_Number_TextEdit.Text == "" || Citizen_Number_TextEdit.Text == null)
            {
                MessageBox.Show("Mutlaka Tc Kimlik No girmelisiniz...", "Tc Kimlik Bilgisi Eksik", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Citizen_Number_TextEdit.Focus();
                return;
            }
            else if (Birth_Date_TextEdit.Text == "" || Birth_Date_TextEdit.Text == null)
            {
                MessageBox.Show("Doğum tarihi bilgisini girmelisiniz...", "Doğum Tarihi Bilgisi Eksik", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Birth_Date_TextEdit.Focus();
                return;
            }
            else if (Title_ButtonEdit.Text.TrimEnd() == "" || Title_ButtonEdit.Text.TrimEnd() == null)
            {
                MessageBox.Show("Ünvan bilgisi seçmelisiniz...", "Ünvan Bilgisi Eksik", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Title_ButtonEdit.Focus();
                return;
            }

            else if (Password_TextEdit.Text == "" || Password_TextEdit.Text == null)
            {
                MessageBox.Show("Personel'e parola vermelisiniz", "Parola Eksik", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Password_TextEdit.Focus();
                return;
            }
            /*
             * 2015_03_16_09:30
             */
            else if (Registration_Number_TextEdit.Text == "" || Registration_Number_TextEdit.Text == null)
            {
                MessageBox.Show("Personel'i sicil numarasını giriniz", "Sicil Numarası Eksik", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Registration_Number_TextEdit.Focus();
                return;

            }
            else if (Expense_Group_ButtonEdit.Text == "" || Expense_Group_ButtonEdit.Text == null)
            {
                MessageBox.Show("Harcama gurubu seçiniz", "Harcama Gurubu Eksik", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Expense_Group_ButtonEdit.Focus();
                return;
            }
            else if (Cell_Phone_Are_Code_TextEdit.Text == "" || Cell_Phone_Are_Code_TextEdit.Text == null)
            {
                MessageBox.Show("Cep telefonu alan kodunu giriniz", "Cep Telefonu Alan Kodu Eksik", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cell_Phone_Are_Code_TextEdit.Focus();
                return;
            }
            else if (Cell_Phone_Number_TextEdit.Text == "" || Cell_Phone_Number_TextEdit.Text == null)
            {
                MessageBox.Show("Cep telefonunu giriniz", "Cep Telefonu Eksik", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cell_Phone_Number_TextEdit.Focus();
                return;
            }
            else if (E_Mail_TextEdit.Text == "" || E_Mail_TextEdit.Text == null)
            {
                MessageBox.Show("E- mail giriniz", "E-Mail Bilgisi Eksik", MessageBoxButtons.OK, MessageBoxIcon.Information);
                E_Mail_TextEdit.Focus();
                return;
            }

            else if (Department_Manager_ButtonEdit.Text == "" || Department_Manager_ButtonEdit.Text == null)
            {
                MessageBox.Show("Depatman seçiniz", "Departman Bilgisi Eksik", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Department_Manager_ButtonEdit.Focus();
                return;
            }
            #endregion

            try
            {
                DAL_Function.User user = new DAL_Function.User();

                if (sql_Server_Db_From_Follow_Up_Data_context.Users.Where(s => s.Login_Name == Login_Name_TextEdit.Text).Count() > 0)
                {
                    MessageBox.Show("Bu kullanıcı için daha önce kayıt yapmışsınız !!!");
                    return;
                }

                if (sql_Server_Db_From_Follow_Up_Data_context.Users.Where(s => s.Registration_Number == Registration_Number_TextEdit.Text).Count() > 0)
                {
                    MessageBox.Show("Bu sicil numrası ile daha önce kayıt yapmışsınız !!!");
                    return;
                }

                user.Name = Framework.Common_Methods.Fitst_Letter_Upper_Case_Other_Lower(Name_TextEdit.Text);
                user.Surname = Framework.Common_Methods.Fitst_Letter_Upper_Case_Other_Lower(Surname_TextEdit.Text);
                user.Full_Name = Name_TextEdit.Text + " " + Surname_TextEdit.Text;
                user.Login_Name = Login_Name_TextEdit.Text;
                user.Password = Password_TextEdit.Text;
                user.Registration_Number = Registration_Number_TextEdit.Text;
                //user.Citizen_Number = Citizen_Number_TextEdit.Text;
                /*
                 * Gerçek TC Kimlik No kontrol'ü
                 * Şimdilik kapatıyoruz. Talpe olur ise açarız.
                 * Talep oldu :) 2015.05.14 Ik Ekibi
                 */
                if (Common_Methods.Citizen_Id_Check(Citizen_Number_TextEdit.Text))
                {
                    user.Citizen_Number = Citizen_Number_TextEdit.Text;
                }
                else
                {
                    MessageBox.Show("Hatalı Tc No. Lütfen kontrol ediniz..");
                    return;
                }

                if (Birth_Date_TextEdit.Text == null || Birth_Date_TextEdit.Text == "")
                {
                    user.Birth_Date = new DateTime(1900, 01, 01);
                }
                else
                {
                    user.Birth_Date = DateTime.Parse(Birth_Date_TextEdit.Text);
                }

                user.Age = Calculate_The_Age(DateTime.Parse(Birth_Date_TextEdit.Text));
                user.Department_Obj_Id = Department_Obj_Id;

                user.Cell_Phone_Area_Code = Common_Methods.Convert_String_To_Int(Cell_Phone_Are_Code_TextEdit.Text);
                user.Cell_Phone_Number = Cell_Phone_Number_TextEdit.Text;

                user.Phone_Number_Area_Code = Common_Methods.Convert_String_To_Int(Phone_Number_Area_Code_TextEdit.Text);
                user.Title_Obj_Id = Title_Obj_Id;
                user.Department_Responsible_Obj_Id = Department_Responsible_Obj_Id;
                user.Department_Manager_Obj_Id = Department_Manager_Obj_Id;
                user.Phone_Number = (Phone_Number_TextEdit.Text);
                user.Expense_Group_Obj_Id = Expense_Group_Obj_Id;

                if (Job_Date_Of_Start_TextEdit.Text == null || Job_Date_Of_Start_TextEdit.Text == "")
                {
                    user.Job_Date_Of_Start = new DateTime(1900, 01, 01);
                }
                else
                {
                    user.Job_Date_Of_Start = DateTime.Parse(Job_Date_Of_Start_TextEdit.Text);
                }

                user.E_Mail = E_Mail_TextEdit.Text;
                user.Insert_Time = DateTime.Now;
                user.Insert_User = Login_Form.Login_User_Obj_Id;

                sql_Server_Db_From_Follow_Up_Data_context.Users.InsertOnSubmit(user);
                sql_Server_Db_From_Follow_Up_Data_context.SubmitChanges();
                messages.New_Record(Name_TextEdit.Text + Surname_TextEdit.Text + "  için kayıt başarı ile yapıldı");
                Clean_The_Control();
            }
            catch (Exception exception)
            {
                messages.Error(exception);
            }
        }

        /// <Developed Note>
        /// Developed By  : İrfan Dölek
        /// Developed Time: 2015.02.27_09:31
        /// Developed Note: Personelin yaşını hesaplıyoruz.
        /// </summary>
        public static int Calculate_The_Age(DateTime birth_Time)
        {
            int age = DateTime.Now.Year - birth_Time.Year;

            if ((birth_Time.Month > DateTime.Now.Month) || (birth_Time.Month == DateTime.Now.Month && birth_Time.Day > DateTime.Now.Day))
                age--;

            return age;
        }

        public void Update_Data_From_Db()
        {
            try
            {
                DAL_Function.User user = sql_Server_Db_From_Follow_Up_Data_context.Users.First(s => s.Obj_Id == User_Obj_Id);

                user.Name = Framework.Common_Methods.Fitst_Letter_Upper_Case_Other_Lower(Name_TextEdit.Text);
                user.Surname = Framework.Common_Methods.Fitst_Letter_Upper_Case_Other_Lower(Surname_TextEdit.Text);
                user.Full_Name = Name_TextEdit.Text + " " + Surname_TextEdit.Text;
                user.Login_Name = Login_Name_TextEdit.Text;
                user.Password = Password_TextEdit.Text;
                user.Registration_Number = Registration_Number_TextEdit.Text;
                user.Citizen_Number = Citizen_Number_TextEdit.Text;

                if (Birth_Date_TextEdit.Text == null || Birth_Date_TextEdit.Text == "")
                {
                    user.Birth_Date = new DateTime(1900, 01, 01);
                }
                else
                {
                    //DateTime.ParseExact(yourObject.ToString(), "MM/dd/yyyy hh:mm:ss tt", CultureInfo.InvariantCulture);
                    user.Birth_Date = DateTime.Parse(Birth_Date_TextEdit.Text);
                }
                user.Department_Obj_Id = Department_Obj_Id;
                user.Title_Obj_Id = Title_Obj_Id;
                user.Cell_Phone_Area_Code = int.Parse(Cell_Phone_Are_Code_TextEdit.Text);
                user.Cell_Phone_Number = (Phone_Number_TextEdit.Text);
                user.Phone_Number_Area_Code = int.Parse(Phone_Number_Area_Code_TextEdit.Text);
                user.Phone_Number = Phone_Number_TextEdit.Text;
                user.Expense_Group_Obj_Id = Expense_Group_Obj_Id;
                user.Title_Obj_Id = Title_Obj_Id;

                #region Description
                /*
                 * Development_Date: 2015_05_26_10_10
                 * Eğer "Departman Yöneticisi" veya "Müdürü" boş olucak ise boş atama yapılabilsin
                 * Bug giderildi.
                 */
                #endregion
                if (Department_Responsible_ButtonEdit.Text.Length < 1)
                {
                    user.Department_Responsible_Obj_Id = -1;
                }
                else
                {
                    user.Department_Responsible_Obj_Id = Department_Responsible_Obj_Id;
                }

                if (Department_Manager_ButtonEdit.Text.Length < 1)
                {
                    user.Department_Manager_Obj_Id = -1;
                }
                else
                {
                    user.Department_Manager_Obj_Id = Department_Manager_Obj_Id;

                }
                user.Expense_Group_Obj_Id = Expense_Group_Obj_Id;

                if (Job_Date_Of_Start_TextEdit.Text == null || Job_Date_Of_Start_TextEdit.Text == "")
                {
                    user.Job_Date_Of_Start = new DateTime(1900, 01, 01);
                }
                else
                {
                    user.Job_Date_Of_Start = DateTime.Parse(Job_Date_Of_Start_TextEdit.Text);
                }

                user.E_Mail = E_Mail_TextEdit.Text;
                user.Update_Time = DateTime.Now;
                user.Update_User = Login_Form.Login_User_Obj_Id;

                sql_Server_Db_From_Follow_Up_Data_context.SubmitChanges();
                messages.Update(true);
                Clean_The_Control();
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
                sql_Server_Db_From_Follow_Up_Data_context.Users.DeleteOnSubmit(sql_Server_Db_From_Follow_Up_Data_context.Users.First(s => s.Obj_Id == User_Obj_Id));
                sql_Server_Db_From_Follow_Up_Data_context.SubmitChanges();
                Clean_The_Control();
            }
            catch (Exception exception)
            {
                messages.Error(exception);
            }
        }

        #region Cruds Process

        private void Close_SimpleButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Delete_SimpleButton_Click(object sender, EventArgs e)
        {
            if (Edit && User_Obj_Id > 0 && messages.Delete() == DialogResult.Yes)
            {
                Delete_the_Record();
            }
        }

        private void Save_SimpleButton_Click(object sender, EventArgs e)
        {
            if (Edit && User_Obj_Id > 0 && messages.Update() == DialogResult.Yes)
            {
                Update_Data_From_Db();
            }
            else
            {
                Get_Data_From_UI();
            }
        }
        #endregion

        /// <summary>
        /// Ac
        /// 2_1_14_00
        /// Açma işini yapıyoruz.
        /// </summary>
        public void Getting_For_Open_Up_User(int Obj_Id)
        {
            try
            {
                /* Gelen Obj_Id > 0 dan ise bı işleri yap da diyebiliriz.*/
                Edit = true;
                User_Obj_Id = Obj_Id;
                DAL_Function.User user = sql_Server_Db_From_Follow_Up_Data_context.Users.First(s => s.Obj_Id == User_Obj_Id);

                Name_TextEdit.Text = user.Name;
                Surname_TextEdit.Text = user.Surname;
                Login_Name_TextEdit.Text = user.Login_Name;
                Password_TextEdit.Text = user.Password;
                Registration_Number_TextEdit.Text = user.Registration_Number;
                Citizen_Number_TextEdit.Text = user.Citizen_Number.ToString();
                Birth_Date_TextEdit.Text = user.Birth_Date.Value.ToString("dd.MM.yyyy");
                Department_Name_TextEdit.Text = user.Department_Obj_Id.ToString();
                Phone_Number_Area_Code_TextEdit.Text = user.Phone_Number_Area_Code.ToString();
                Phone_Number_TextEdit.Text = user.Phone_Number.ToString();
                Cell_Phone_Are_Code_TextEdit.Text = user.Cell_Phone_Area_Code.ToString();
                Cell_Phone_Number_TextEdit.Text = user.Cell_Phone_Number.ToString();
                Job_Date_Of_Start_TextEdit.Text = user.Job_Date_Of_Start.Value.ToString("dd.MM.yyyy");
                Expense_Group_ButtonEdit.Text = user.Expense_Group_Obj_Id.ToString();

                E_Mail_TextEdit.Text = user.E_Mail;
                #region Description
                /*Departman adını ekrana doldurabilmek için*/
                #endregion

                Getting_For_Department_Name_Instead_Obj_Id(user.Department_Obj_Id.Value);
                Getting_For_Open_Expense_Group_Name_Instead_Obj_Id(user.Expense_Group_Obj_Id.Value);
                Getting_For_Title_Name_Instead_Obj_Id(user.Title_Obj_Id.Value);

                if (Title_ButtonEdit.Text.Contains("Satış Müdür"))
                {
                    Getting_For_Open_Up_Department_Responsible_Name_Surname_Instead_Obj_Id(user.Department_Responsible_Obj_Id.Value);
                    Getting_For_Open_Up_Department_Manager_Name_Surname_Instead_Obj_Id(user.Department_Manager_Obj_Id.Value);
                    Department_Responsible_ButtonEdit.Visible = true;
                    Department_Responsible_LabelControl.Visible = true;
                }
                if (Title_ButtonEdit.Text.Contains("Proje Müdür"))
                {
                    Getting_For_Open_Up_Department_Responsible_Name_Surname_Instead_Obj_Id(user.Department_Responsible_Obj_Id.Value);
                    Getting_For_Open_Up_Department_Manager_Name_Surname_Instead_Obj_Id(user.Department_Manager_Obj_Id.Value);
                    Department_Responsible_ButtonEdit.Visible = true;
                    Department_Responsible_LabelControl.Visible = true;
                }
                if (Title_ButtonEdit.Text.Contains("Üretim Müdür"))
                {
                    Getting_For_Open_Up_Department_Responsible_Name_Surname_Instead_Obj_Id(user.Department_Responsible_Obj_Id.Value);
                    Getting_For_Open_Up_Department_Manager_Name_Surname_Instead_Obj_Id(user.Department_Manager_Obj_Id.Value);
                    Department_Responsible_ButtonEdit.Visible = true;
                    Department_Responsible_LabelControl.Visible = true;
                }

                if (Title_ButtonEdit.Text.Contains("Denetim Müdür"))
                {
                    Getting_For_Open_Up_Department_Manager_Name_Surname_Instead_Obj_Id(user.Department_Manager_Obj_Id.Value);

                    Department_Responsible_ButtonEdit.Visible = false;
                    Department_Responsible_LabelControl.Visible = false;
                }
                if (Title_ButtonEdit.Text.Contains("Direktörü"))
                {
                    Getting_For_Open_Up_Department_Manager_Name_Surname_Instead_Obj_Id(user.Department_Manager_Obj_Id.Value);

                    Department_Responsible_ButtonEdit.Visible = false;
                    Department_Responsible_LabelControl.Visible = false;
                }
                if (Title_ButtonEdit.Text.Contains("Üretim Yönetmen"))
                {
                    Getting_For_Open_Up_Department_Responsible_Name_Surname_Instead_Obj_Id(user.Department_Responsible_Obj_Id.Value);
                    Getting_For_Open_Up_Department_Manager_Name_Surname_Instead_Obj_Id(user.Department_Manager_Obj_Id.Value);

                    Department_Responsible_ButtonEdit.Visible = true;
                    Department_Responsible_LabelControl.Visible = true;
                }
                //if (Title_ButtonEdit.Text.Contains("Yönetmen"))
                //{
                //    Getting_For_Open_Up_Department_Manager_Name_Surname_Instead_Obj_Id(user.Department_Manager_Obj_Id.Value);

                //    Department_Responsible_ButtonEdit.Visible = false;
                //    Department_Responsible_LabelControl.Visible = false;
                //}

                if (Title_ButtonEdit.Text.Contains("Satış Yönetmen"))
                {
                    Getting_For_Open_Up_Department_Manager_Name_Surname_Instead_Obj_Id(user.Department_Manager_Obj_Id.Value);
                    Department_Responsible_ButtonEdit.Visible = true;
                    Department_Responsible_LabelControl.Visible = true;
                }
                if (Title_ButtonEdit.Text.Contains("Bilgi Sistemleri Yönetmeni"))
                {
                    Getting_For_Open_Up_Department_Manager_Name_Surname_Instead_Obj_Id(user.Department_Manager_Obj_Id.Value);
                    Department_Responsible_ButtonEdit.Visible = false;
                    Department_Responsible_LabelControl.Visible = false;
                }

                //Bilgi Sistemleri Yönetmeni
                if (Title_ButtonEdit.Text.Contains("Genel Müdür"))
                {
                    Getting_For_Open_Up_Department_Manager_Name_Surname_Instead_Obj_Id(user.Department_Manager_Obj_Id.Value);

                    Department_Responsible_ButtonEdit.Visible = false;
                    Department_Responsible_LabelControl.Visible = false;
                }
                if (Title_ButtonEdit.Text.Contains("Ceo Management"))
                {
                    Getting_For_Open_Up_Department_Manager_Name_Surname_Instead_Obj_Id(user.Department_Manager_Obj_Id.Value);

                    Department_Responsible_ButtonEdit.Visible = false;
                    Department_Responsible_LabelControl.Visible = false;
                }
                if (user.Department_Responsible_Obj_Id.Value != -1)
                {
                    Getting_For_Open_Up_Department_Responsible_Name_Surname_Instead_Obj_Id(user.Department_Responsible_Obj_Id.Value);
                }
                if (user.Department_Manager_Obj_Id.Value != -1)
                {
                    Getting_For_Open_Up_Department_Manager_Name_Surname_Instead_Obj_Id(user.Department_Manager_Obj_Id.Value);
                }
            }
            catch (Exception exception)
            {
                messages.Error(exception);
            }
        }

        /// <summary>
        /// GrupAc
        /// User tablosunda FK olan Departman ID'sine karşılık gelen "adı" bilgisini açmak için hazırlıyoruz.
        /// 2_1_13_00
        /// </summary>

        public void Getting_For_Open_Expense_Group_Name_Instead_Obj_Id(int Obj_Id)
        {
            try
            {
                Expense_Group_Obj_Id = Obj_Id;
                DAL_Function.Expense_Group expense_Group = sql_Server_Db_From_Follow_Up_Data_context.Expense_Groups.First(s => s.Obj_Id == Expense_Group_Obj_Id);

                Expense_Group_ButtonEdit.Text = expense_Group.Name;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Harcama gurubu atanmamış !..", "Harcama Gurubu Boş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Getting_For_Title_Name_Instead_Obj_Id(int Obj_Id)
        {
            try
            {
                Title_Obj_Id = Obj_Id;
                DAL_Function.Title title = sql_Server_Db_From_Follow_Up_Data_context.Titles.First(s => s.Obj_Id == Title_Obj_Id);

                Title_ButtonEdit.Text = title.Name;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ünvan atanmamış !..", "Ünvan Bilgisi Boş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Departman atanmamış !..", "Departman Bilgisi Boş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Getting_For_Expense_Group_Name_Instead_Obj_Id(int Obj_Id)
        {
            try
            {
                Expense_Group_Obj_Id = Obj_Id;
                DAL_Function.Expense_Group expense_Group = sql_Server_Db_From_Follow_Up_Data_context.Expense_Groups.First(s => s.Obj_Id == Expense_Group_Obj_Id);

                Expense_Group_ButtonEdit.Text = expense_Group.Name;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Harcama gurubu atanmamış !..", "Harcama Gurubu Boş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Getting_For_Open_Up_Department_Responsible_Name_Surname_Instead_Obj_Id(int obj_Id)
        {
            try
            {
                Edit = true;
                Department_Responsible_Obj_Id = obj_Id;
                DAL_Function.User user = sql_Server_Db_From_Follow_Up_Data_context.Users.First(s => s.Obj_Id == Department_Responsible_Obj_Id);

                Department_Responsible_ButtonEdit.Text = user.Full_Name;
            }
            catch (Exception exception)
            {
                /*2015_05_21 Tarihinde commentlendi*/
                //MessageBox.Show("Departman sorumlusu atanmamış !..", "Departman Sorumlusu Boş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Getting_For_Open_Up_Department_Manager_Name_Surname_Instead_Obj_Id(int obj_Id)
        {
            try
            {
                Edit = true;
                Department_Manager_Obj_Id = obj_Id;
                DAL_Function.User user = sql_Server_Db_From_Follow_Up_Data_context.Users.First(s => s.Obj_Id == Department_Manager_Obj_Id);

                Department_Manager_ButtonEdit.Text = user.Full_Name;
            }
            catch (Exception exception)
            {
                /*2015_05_21 Tarihinde commentlendi*/
                //MessageBox.Show("Departman yöneticisi atanmamış!..", "Departman Yöneticisi Boş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #region Events

        private void Name_TextEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int Obj_Id = get_The_Forms.User_List(true);

            if (Obj_Id > 0)
            {
                Getting_For_Open_Up_User(Obj_Id);
            }
            MainMDIForm.Cross = -1;
        }

        private void Title_ButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int Obj_Id = get_The_Forms.Title_Form(true);

            if (Obj_Id > 0)
            {
                Getting_For_Title_Name_Instead_Obj_Id(Obj_Id);
            }
            MainMDIForm.Cross = -1;
        }

        private void Department_Name_TextEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int Obj_Id = get_The_Forms.Department_Form(true);

            if (Obj_Id > 0)
            {
                Getting_For_Department_Name_Instead_Obj_Id(Obj_Id);
                MainMDIForm.Cross = -1;
            }
        }

        private void Expense_Group_ButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {


            int Obj_Id = get_The_Forms.Expense_Group_Form(true);

            if (Obj_Id > 0)
            {
                Getting_For_Open_Expense_Group_Name_Instead_Obj_Id(Obj_Id);



                MainMDIForm.Cross = -1;
            }
        }

        private void Department_Responsible_ButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int Obj_Id = get_The_Forms.User_List_For_Responsible(true);

            if (Obj_Id > 0)
            {
                Getting_For_Open_Up_Department_Responsible_Name_Surname_Instead_Obj_Id(Obj_Id);
            }
            MainMDIForm.Cross = -1;
        }

        private void Department_Manager_ButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int Obj_Id = get_The_Forms.User_List_For_Manager(true);

            if (Obj_Id > 0)
            {
                Getting_For_Open_Up_Department_Manager_Name_Surname_Instead_Obj_Id(Obj_Id);
            }
            MainMDIForm.Cross = -1;
        }
        #endregion

        private void Clean_SimpleButton_Click(object sender, EventArgs e)
        {
            Clean_The_Control();
        }

        private void Name_TextEdit_Leave(object sender, EventArgs e)
        {
            Name_TextEdit.Text = Framework.Common_Methods.Fitst_Letter_Upper_Case_Other_Lower(Name_TextEdit.Text);

        }

        private void Surname_TextEdit_Leave(object sender, EventArgs e)
        {
            Surname_TextEdit.Text = Framework.Common_Methods.Fitst_Letter_Upper_Case_Other_Lower(Surname_TextEdit.Text);
            /*
             * Adının tamamı, soyadının ilk harfinin kullanıc adı olarak atıyoruz.
             */
            Login_Name_TextEdit.Text = text_Replacer.Replace_The_Text(text_Replacer.Replace_The_Text(Name_TextEdit.Text.ToLower().Substring(0, 1)) + Surname_TextEdit.Text.ToLower());



        }

        /// <summary>
        /// Eğer title'ı müdür ise sormlı ve müdür kontrollerini visible'ını false yap
        /// Genel müdür kontrol'ü visible enable yap
        /// Like = Contains
        /// By: İrfan D
        /// 2015_03_15_11:56
        /// </summary>
        private void Title_ButtonEdit_Leave(object sender, EventArgs e)
        {
            if (Title_ButtonEdit.Text.Contains("Satış Müdür"))
            {
                Department_Responsible_ButtonEdit.Visible = true;
                Department_Responsible_LabelControl.Visible = true;
            }
            if (Title_ButtonEdit.Text.Contains("Proje Müdür"))
            {
                Department_Responsible_ButtonEdit.Visible = true;
                Department_Responsible_LabelControl.Visible = true;
            }
            if (Title_ButtonEdit.Text.Contains("Üretim Müdür"))
            {
                Department_Responsible_ButtonEdit.Visible = true;
                Department_Responsible_LabelControl.Visible = true;
            }
            if (Title_ButtonEdit.Text.Contains("Denetim Müdür"))
            {
                Department_Responsible_ButtonEdit.Visible = false;
                Department_Responsible_LabelControl.Visible = false;
            }
            if (Title_ButtonEdit.Text.Contains("Direktörü"))
            {
                Department_Responsible_ButtonEdit.Visible = false;
                Department_Responsible_LabelControl.Visible = false;
            }
            //if (Title_ButtonEdit.Text.Contains("Yönetmen"))
            //{
            //    Department_Responsible_ButtonEdit.Visible = false;
            //    Department_Responsible_LabelControl.Visible = false;
            //}
            if (Title_ButtonEdit.Text.Contains("Satış Yönetmen"))
            {
                Department_Responsible_ButtonEdit.Visible = true;
                Department_Responsible_LabelControl.Visible = true;
            }
            if (Title_ButtonEdit.Text.Contains("Üretim Yönetmen"))
            {
                Department_Responsible_ButtonEdit.Visible = true;
                Department_Responsible_LabelControl.Visible = true;
            }
            if (Title_ButtonEdit.Text.Contains("Bilgi Sistemleri Yönetmeni"))
            {
                Department_Responsible_ButtonEdit.Visible = false;
                Department_Responsible_LabelControl.Visible = false;
            }
            if (Title_ButtonEdit.Text.Contains("Genel Müdür"))
            {
                Department_Responsible_ButtonEdit.Visible = false;
                Department_Responsible_LabelControl.Visible = false;
            }
            if (Title_ButtonEdit.Text.Contains("Ceo Management"))
            {
                Department_Responsible_ButtonEdit.Visible = false;
                Department_Responsible_LabelControl.Visible = false;
            }
        }

        /// <summary>
        /// Shortcut klavye kaydetme tuşu : F2
        /// </summary>
        private void User_Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F2")
            {
                Get_Data_From_UI();
            }
            if (e.KeyCode.ToString() == "Escape")
            {
                this.Close();
            }
        }

        /* ToDo
         * Deparman kaydederken yaptın "Sorumlu" ve "Müdür" name insert'leri devre dışı bırak (2015.02.24_Devre_dışı_bırakıldı)
         * Burdan kişiye bağla sorumlu ve müdürü. Burdan seçildiğinde de yöenticiler departman'a da bağlanmış (departman tablosuna da insert)olsun
         */
    }
}