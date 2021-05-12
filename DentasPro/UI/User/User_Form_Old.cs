/*
 * Kullanıcı kayıt ekranı
 * k_1_2_18_50
 */
namespace Dentas_Pro.UI.User
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Text;
    using System.Windows.Forms;
    using System.Linq;

    using DevExpress.XtraEditors;

    using Dentas_Pro.Framework;
    using Dentas_Pro.UI.Base;

    public partial class User_Form_Old : XtraForm
    {
        DAL_Function.Sql_Server_DB_From_DentasProDataContext sql_Server_Db_From_DentasProDataContext = new DAL_Function.Sql_Server_DB_From_DentasProDataContext();
        DAL_Function.Messages messages = new DAL_Function.Messages();
        Generator.Generate_Id generater_Id = new Generator.Generate_Id();
        /// <summary>
        /// S:Formlar
        /// </summary>
        DAL_Function.Get_The_Form get_The_Form = new DAL_Function.Get_The_Form();
        DAL_Function.Imaging image = new DAL_Function.Imaging();
        #region Description
        /*
         * Resmi pc den seçebilmek için bu nesneyi kullanıyoruz.
         */
        #endregion
        OpenFileDialog Image_Folder = new OpenFileDialog();

        #region Fields

        public bool Choose = false;
        #region Description
        /*
         * Resim
         * Güncelleme yaparken sıkıntı yaşamamak için
         */
        #endregion
        public bool Choose_The_Image = false;
        /// <summary>
        /// 1_1_51
        /// </summary>
        public bool Edit = false;
        public int User_Department_Obj_Id = -1;
        public int User_Title_Obj_Id = -1;
        public int User_Obj_Id = -1;
        public int User_Expense_Group_Obj_Id = -1;
        #endregion

        public User_Form_Old()
        {
            InitializeComponent();
        }

        Dentas_Pro.DTO.Person.User user = new DTO.Person.User();

        /// <summary>
        /// YeniKaydet
        /// 1_2_04_20
        /// </summary>
        public void Get_Data_From_UI()
        {
            try
            {
                DAL_Function.User user = new DAL_Function.User();

                user.Name = Name_TextEdit.Text;
                user.Surname = Surname_TextEdit.Text;
                user.Title_Obj_Id = User_Title_Obj_Id;
                /* 
                * Decimal Convert örnak assig
                * Table.field_Name = decimal.Parse(bla_Bla.Tex)
                */

                //user.Registration_Number = Common_Methods.Convert_String_To_Int(Registration_Number_TextEdit.Text);
                user.Citizen_Number = Citizen_Number_TextEdit.Text;
                if (Birth_Date_TextEdit.Text == null || Birth_Date_TextEdit.Text == "")
                {
                    user.Birth_Date = new DateTime(1900, 01, 01);
                }
                else
                {
                    user.Birth_Date = DateTime.Parse(Birth_Date_TextEdit.Text);
                }

                if (Job_Date_Of_Start_TextEdit.Text == null || Job_Date_Of_Start_TextEdit.Text == "")
                {
                    user.Job_Date_Of_Start = new DateTime(1900,01,01);
                }
                else
                {
                    user.Job_Date_Of_Start = DateTime.Parse(Birth_Date_TextEdit.Text);
                }

                user.Department_Obj_Id = User_Department_Obj_Id;
                user.Birth_Place = Birth_Place_TextEdit.Text;
                user.Phone_Number = (Phone_Number_TextEdit.Text);
                user.Cell_Phone_Number =(Cell_Phone_TextEdit.Text);
                user.Expense_Group_Obj_Id = User_Expense_Group_Obj_Id;
                #region Description
                /*
                * Ekrandaki image'ı böyle alıyoruz.
                * Aşağıdaki kod ile resmimizi binray halinde paketlemiş oluyoruz.
                * ve db'ye binary göndermiş oluyoruz.
                */
                #endregion
                user.User_Photo = new System.Data.Linq.Binary(image.Load_The_Image(User_Photo_PictureBox.Image));
                user.Insert_Time = DateTime.Now;
                user.Insert_User = Login_Form.Login_User_Obj_Id;
                #region Description
                /*Aşağıdaki kod ile user entity mizi insert ediyoruz.*/
                #endregion
                sql_Server_Db_From_DentasProDataContext.Users.InsertOnSubmit(user);
                sql_Server_Db_From_DentasProDataContext.SubmitChanges();
                messages.New_Record("Yeni personel kaydı başarılı ile yapıldı");
                Clean_The_Control();
            }
            catch (Exception exception)
            {
                messages.Error(exception);
            }
        }

        /// <summary>
        /// 1_2_09_08
        /// Guncelle
        /// </summary>
        public void Update_Data_From_Db()
        {
            try
            {
                DAL_Function.User user = sql_Server_Db_From_DentasProDataContext.Users.First(s => s.Obj_Id == User_Obj_Id);

                user.Name = Name_TextEdit.Text;
                user.Surname = Surname_TextEdit.Text;
                user.Title_Obj_Id = User_Title_Obj_Id;
                //user.Registration_Number = short.Parse(Registration_Number_TextEdit.Text);
                user.Citizen_Number = Citizen_Number_TextEdit.Text;
                user.Birth_Date = DateTime.Parse(Birth_Date_TextEdit.Text);
                user.Job_Date_Of_Start = DateTime.Parse(Job_Date_Of_Start_TextEdit.Text);
                user.Department_Obj_Id = User_Department_Obj_Id;
                user.Birth_Place = Birth_Place_TextEdit.Text;
                user.Phone_Number = (Phone_Number_TextEdit.Text);
                user.Cell_Phone_Number = (Cell_Phone_TextEdit.Text);
                user.Expense_Group_Obj_Id = User_Expense_Group_Obj_Id;
                #region Description
                /*
             * Ekrandaki image'ı böyle alıyoruz.
             * Aşağıdaki kod ile resmimizi binray halinde paketlemiş oluyoruz.
             * ve db'ye binary göndermiş oluyoruz.
             */
                #endregion

                #region Description
                /*Eğer resim seçildi ise resmi güncelle seçilmediyse güncelleme*/
                #endregion
                if (Choose_The_Image)
                {
                    user.User_Photo = new System.Data.Linq.Binary(image.Load_The_Image(User_Photo_PictureBox.Image));
                }
                user.Update_Time = DateTime.Now;
                user.Update_User = Login_Form.Login_User_Obj_Id;
                #region Description
                /*Aşağıdaki kod ile user entity mizi insert ediyoruz.*/
                #endregion
                sql_Server_Db_From_DentasProDataContext.SubmitChanges();
                messages.Update(true);
                Clean_The_Control();
            }
            catch (Exception exception)
            {
                messages.Error(exception);
            }
        }

        /// <summary>
        /// 1_2_12_30
        /// 
        ///Kayıt silme işlemi için yazılan metod*/
        /// </summary>
        public void Delete_The_Record()
        {
            try
            {
                sql_Server_Db_From_DentasProDataContext.Users.DeleteOnSubmit(sql_Server_Db_From_DentasProDataContext.Users.First(s => s.Obj_Id == User_Obj_Id));
            }
            catch (Exception exception)
            {
                messages.Error(exception);
            }
        }

        /// <summary>
        /// 1_1:53
        /// </summary>
        private void Clean_The_Control()
        {
            Registration_Number_TextEdit.Text = string.Empty;
            Name_TextEdit.Text = string.Empty;
            Surname_TextEdit.Text = string.Empty;
            Citizen_Number_TextEdit.Text = string.Empty;
            Title_TextEdit.Text = string.Empty;
            Cell_Phone_TextEdit.Text = string.Empty;
            Birth_Date_TextEdit.Text = string.Empty;
            Department_Name_TextEdit.Text = string.Empty;
            E_Mail_TextEdit.Text = string.Empty;
            Phone_Number_Area_Code_TextEdit.Text = string.Empty;
            Cell_Phone_Are_Code_TextEdit.Text = string.Empty;
            //Blood_Type_ComboBoxEdit.SelectedIndex = 0;
            Edit = false;
            Choose_The_Image = false;
            User_Department_Obj_Id = -1;
            User_Photo_PictureBox.Image = null;
            MainMDIForm.Cross = -1;
        }

        /// <summary>
        /// 1_2_00_05
        /// ResimSec
        /// </summary>
        public void Choose_The_Current_Image()
        {
            #region Description
            /*
             * Resmi masaüsütünden seçebilmek için OpenFileDialog kullanıyoruz.
             * OpenFileDialog için filtre uyguladık burda. 
             * OpenFileDialog nesnesi ile Jpg veya Jpeg formatındaki dosyaları filtreleyoruz adeta
             * Yalnızca "jpg" ve "jpeg" formatları kabul ediyoruz*/
            #endregion
            Image_Folder.Filter = "Jpg(*.jpg)|*.jpg|jpeg(*.jpeg|*.jpeg)";
            if (Image_Folder.ShowDialog() == DialogResult.OK)
            {
                #region Description
                /*Ekrandan OpenfileDilaog ile formatını (jpg veya jpeg olarak filtrlediğimizve seciğitimiz) 
                 * image'ı ekradaki Image kontrol'ün "ImageLocation" nına (atıyoruz) set ediyoruz*/
                #endregion
                User_Photo_PictureBox.ImageLocation = Image_Folder.FileName;
                Choose_The_Image = true;
            }
        }

        #region Description
        /*
         * 1_2_15_00
         * GrupAc
         * 2015_01_13_14_19
         * Open_Up = Aç
         */
        #endregion
        public void Open_Up_Department(int Department_Obj_Id)
        {
            User_Department_Obj_Id = Department_Obj_Id;
            /*Ekrandak kpntole'e set ediyoruz*/
            Department_Name_TextEdit.Text = sql_Server_Db_From_DentasProDataContext.Departments.First(s => s.Obj_Id == Department_Obj_Id).Name;
            
            DAL_Function.User user = sql_Server_Db_From_DentasProDataContext.Users.First(s => s.Obj_Id == User_Obj_Id);

        }


        /// <summary>
        /// GrupAc gibi
        /// </summary>
        /// <param name="User_Obj_Id"></param>
        public void Open_Up_User_List(int User_Obj_Id) 
        {
            User_Obj_Id = User_Obj_Id;
            Name_TextEdit.Text = sql_Server_Db_From_DentasProDataContext.Users.First(s=> s.Obj_Id == User_Obj_Id).Name;
            Surname_TextEdit.Text = sql_Server_Db_From_DentasProDataContext.Users.First(s => s.Obj_Id == User_Obj_Id).Surname;
            Registration_Number_TextEdit.Text = sql_Server_Db_From_DentasProDataContext.Users.First(s => s.Obj_Id == User_Obj_Id).Registration_Number.ToString();
            Citizen_Number_TextEdit.Text = sql_Server_Db_From_DentasProDataContext.Users.First(s => s.Obj_Id == User_Obj_Id).Citizen_Number.ToString();
            Birth_Date_TextEdit.Text = sql_Server_Db_From_DentasProDataContext.Users.First(s => s.Obj_Id == User_Obj_Id).Birth_Date.ToString();
            Job_Date_Of_Start_TextEdit.Text = sql_Server_Db_From_DentasProDataContext.Users.First(s => s.Obj_Id == User_Obj_Id).Job_Date_Of_Start.ToString();
            //Blood_Type_ComboBoxEdit.Text = sql_Server_Db_From_DentasProDataContext.Users.First(s => s.Obj_Id == User_Obj_Id).B

        }

        /// <summary>
        /// Her hangi bir Fk. alanı açmak istediğimizde
        /// Ac
        /// 1_2_17_45
        public void Open(int Obj_Id) 
        {
            /* Bu yazmazsak güncelleme işlemini yapamayız*/
            Edit = true;

            User_Department_Obj_Id = Obj_Id;
            DAL_Function.User user = sql_Server_Db_From_DentasProDataContext.Users.First(s => s.Obj_Id == User_Department_Obj_Id);
            /*User içindeki departman'ı açıyoruz.*/
            Open_Up_Department(user.Department_Obj_Id.Value);

            /*Hataya_bakılacak*/
            //User_Photo_PictureBox.Image = image.Get_The_Image(user.User_Photo.ToArray());



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

        private void Close_SimpleButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Delete_SimpleButton_Click(object sender, EventArgs e)
        {
            if (Edit && User_Obj_Id > 0 && messages.Delete() == DialogResult.Yes)
            {
                Delete_The_Record();
            }
        }

        private void User_Form_Load(object sender, EventArgs e)
        {
            #region Description
            /*Örnek sayaç assiged*/
            #endregion
            Citizen_Number_TextEdit.Text = generater_Id.Generate_The_Unique_Id_For_Department_Id();
        }

        private void Choose_The_Image_SimpleButton_Click(object sender, EventArgs e)
        {
            Choose_The_Current_Image();
        }

        private void Title_TextEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int Obj_Id = get_The_Form.Title_Form(true);

            if (Obj_Id > 0)
            {
                Open_Up_Department(Obj_Id);
                #region Description
                /*Aktarma değeri çok önemli. Her kullanımdan sonra default değerini set etmeliyiz.*/
                #endregion
                //MainMDIForm.Cross = -1;
            }
            #region Description
            /*
             * Aktarma değişkenine değer atamayı if bloğunun dışına aldım.
             * Her halükarda yapılması için.
             */
            #endregion
            MainMDIForm.Cross = -1;
        }

        private void Department_TextEdit_DoubleClick(object sender, EventArgs e)
        {
            int Obj_Id = get_The_Form.Department_Form(true);

            if (Obj_Id > 0)
            {
                Open_Up_Department(Obj_Id);
            }
            MainMDIForm.Cross = -1;
        }


        private void Name_TextEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //int Obj_Id = get_The_Form.User_List_Form(true);

            //if (Obj_Id > 0)
            //{
            //    Open(Obj_Id);
            //} 

        }
    }
}
