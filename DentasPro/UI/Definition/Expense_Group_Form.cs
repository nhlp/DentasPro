namespace Dentas_Pro.UI.Definition
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
    using Dentas_Pro.UI.DAL_Function;
    using Dentas_Pro.Framework;

    /// <summary>
    /// Harcama gurubu tanımı
    /// </summary>
    public partial class Expense_Group_Form : Base_Form
    {
        public Expense_Group_Form()
        {
            InitializeComponent();
            Visible_False_Delete_Button();
        }


        #region Description
        /* 
         * His : DatabaseDataContext
         * Mine: Sql_Server_DBDataContext 
         */
        #endregion
        //DAL_Function.Sql_Server_DBDataContext sqlServer_Db_context = new Sql_Server_DBDataContext();

        DAL_Function.Sql_Server_DB_From_DentasProDataContext sql_Server_Db_From_DentasPro_Data_Context = new Sql_Server_DB_From_DentasProDataContext();
        DAL_Function.Messages messages = new Messages();
        Generator.Generate_Id generator_Id = new Generator.Generate_Id();




        #region Field Comment
        /*Bu ekranı seçim içinde açabilmek için*/
        #endregion
        public bool Choose = false;
        public bool Edit = false;
        #region Description
        /*Db'den kayıt seçtiğimizde seçimimizi bunda tutalım*/
        #endregion
        public int Choose_Obj_Id = -1;

        private void Expense_Group_Form_Load(object sender, EventArgs e)
        {
            Get_The_Expense_Group_List();
            Expense_Code_TextEdit.Text = generator_Id.Generate_The_Unique_Id_For_Expense_Group_Id();
        }


        #region Description
        /*dikkat edersen studio tablo adının sonuna fazladan "s" koydu.*/
        #endregion
        public void Get_The_Expense_Group_List()
        {
            var Get_The_Expense_Group = from s in sql_Server_Db_From_DentasPro_Data_Context.Expense_Groups
                                        select s;

            Expense_GridControl.DataSource = Get_The_Expense_Group;
        }

        #region Description
        /*
         * 2015.01.07_ King was here!. :)
         * Bu metod kontroller'e boşluk atıyor. Adeta kontrollerde olan datayı siliyoruz.
         */
        #endregion
        private void Clean_The_Control()
        {
            Expense_Code_TextEdit.Text = string.Empty;
            Expense_Name_TextEdit.Text = string.Empty;
            Expense_Description_MemoEdit.Text = string.Empty;
            Edit = false;
            Get_The_Expense_Group_List();
        }

        #region Cruds proccess

        #region Description
        /*
         * 2015.01.07_09_59 King was here.
         * Yeni kayıt yapmak için bu metodu kullanıyoruz.
         */
        #endregion
        void Get_Data_From_UI()
        {
            try
            {
                #region Description
                /*
             * 2015.01.07
             * Linq bağlantısını yaparken "sa" kullandığın için burda tabloyu göremedin. windows Autentecion kullan
             */
                #endregion
                DAL_Function.Expense_Group expense_Group = new Expense_Group();

                expense_Group.Code = Expense_Code_TextEdit.Text;
                expense_Group.Name = Common_Methods.Fitst_Letter_Upper_Case_Other_Lower(Expense_Name_TextEdit.Text);
                expense_Group.Description = Common_Methods.Fitst_Letter_Upper_Case_Other_Lower(Expense_Description_MemoEdit.Text);
                expense_Group.Insert_Time = DateTime.Now;
                expense_Group.Insert_User = Login_Form.Login_User_Obj_Id;

                sql_Server_Db_From_DentasPro_Data_Context.Expense_Groups.InsertOnSubmit(expense_Group);
                sql_Server_Db_From_DentasPro_Data_Context.SubmitChanges();
                #region Description
                /*
                 * Eğer buraya kadarki adımlara hatasız tamamlanmış ise bir alt satırdaki kodu icare edecek
                 */
                #endregion
                messages.New_Record("Yeni harcma gurubu kaydı yapıldı");
                #region Description
                /*Kayıtta yapıldıktan sonra kerandaki kontrolleri temizleyelim*/
                #endregion
                Clean_The_Control();
            }
            catch (Exception exception)
            {

                messages.Error(exception);
            }
        }

        #region Description
        /*
         * 2015_01_26_İrfan_Dölek
         * Kayıt güncellemek için bu metodu kullanıyoruz
         */
        #endregion
        void Update_Data_From_Db()
        {
            try
            {
                #region Description
                /*
             * Kayıt güncelleme işleminde Chooce_Id'den faydalancağız.
             * 1.Atamamızı yaptık gurubumuz geldi.
             */
                #endregion
                DAL_Function.Expense_Group expense_Group = sql_Server_Db_From_DentasPro_Data_Context.Expense_Groups.First(s => s.Obj_Id == Choose_Obj_Id);/*1*/

                expense_Group.Code = Expense_Code_TextEdit.Text;
                expense_Group.Name = Common_Methods.Fitst_Letter_Upper_Case_Other_Lower(Expense_Name_TextEdit.Text);
                expense_Group.Description = Common_Methods.Fitst_Letter_Upper_Case_Other_Lower(Expense_Description_MemoEdit.Text);
                expense_Group.Update_User = Login_Form.Login_User_Obj_Id;
                expense_Group.Update_Time = DateTime.Now;
                #region Description
                /*aşağıdaki metod ile de "Eklendiğinde, güncelleştirildiğinde veya silindiğinde için değiştirilen nesne kümesini hesaplar ve veritabanında yapılan değişiklikleri uygulamak için uygun komutları yürütür."*/
                #endregion
                sql_Server_Db_From_DentasPro_Data_Context.SubmitChanges();
                messages.Update(true);
                Clean_The_Control();
            }
            catch (Exception exception)
            {

                messages.Error(exception);
            }
        }

        #region Description
        /*Kayıt silmek için bu metodu kullanıyoruz*/
        #endregion
        void Delete_The_Record()
        {
            try
            {
                #region Description
                /*Aynı Id den başka kayıt olmadığı için first'i kullanıyoruz*/
                #endregion
                sql_Server_Db_From_DentasPro_Data_Context.Expense_Groups.DeleteOnSubmit(sql_Server_Db_From_DentasPro_Data_Context.Expense_Groups.First(s => s.Obj_Id == Choose_Obj_Id));
                sql_Server_Db_From_DentasPro_Data_Context.SubmitChanges();
                Clean_The_Control();
            }
            catch (Exception exception)
            {
                messages.Error(exception);
            }
        }
        #endregion

        #region Description
        /*
         * Kayıt seçmek için bu metodu kullanacağız.
         * Textbox'larda da görünecek data.
         */
        #endregion
        void Chooce_The_Record()
        {
            #region Description
            /*Try bloğu icra olur ise Catc'e girmez.*/
            #endregion
            try
            {
                Edit = true;
                #region Description
                /*int.Parse'ı --> int'e cast edebilmek için kullandık*/
                #endregion
                Choose_Obj_Id = int.Parse(gridView1.GetFocusedRowCellValue("Obj_Id").ToString());
                #region Description
                /*Deparman Adı & Kodunu: Text boxlara dolduruyoruz. ekranda görünmesi için.*/
                #endregion
                Expense_Name_TextEdit.Text = gridView1.GetFocusedRowCellValue("Name").ToString();
                Expense_Code_TextEdit.Text = gridView1.GetFocusedRowCellValue("Code").ToString();
                Expense_Description_MemoEdit.Text = gridView1.GetFocusedRowCellValue("Description").ToString();
            }
            /*Hata olması durumunda catch bloğu icra olur.*/
            catch (Exception exception)
            {
                #region Description
                /*
                 * Aşağıdaki 2 satrılık kod yerine kontrolleri temizleyen 
                 * "Clean_The_Control()"
                 * metodunu da çağırsak olur idi..
                 */
                #endregion
                Edit = false;
                Choose_Obj_Id = -1;
            }
        }

        private void Save_SimpleButton_Click_1(object sender, EventArgs e)
        {
            if (Edit && Choose_Obj_Id > 0 && messages.Update() == DialogResult.Yes)
            {
                Update_Data_From_Db();
            }
            else
            {
                Get_Data_From_UI();
            }
        }

        private void Close_SimpleButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Delete_SimpleButton_Click_1(object sender, EventArgs e)
        {
            if (Edit && Choose_Obj_Id > 0 && messages.Delete() == DialogResult.Yes)
            {
                Delete_The_Record();
            }
        }

        private void gridView1_DoubleClick_1(object sender, EventArgs e)
        {
            #region Description
            /*
             * Eğer seçim için açıldı ise ve Choose_Id > 0 dan
             * if bloğundaki kod icra olacak. Choose_Id deki Id yi Main_MDI_Form'a atama işlemini yapacak.
             * Eğer değil ise yalnızca
             * Chooce_The_Record(); metodu icra olacaktır.
             */
            #endregion
            Chooce_The_Record();
            if (Choose && Choose_Obj_Id > 0)
            {
                MainMDIForm.Cross = Choose_Obj_Id;
                this.Close();
            }
        }

        public void Visible_False_Delete_Button()
        {
            /*
             * İ_Dölek hariç herkese kapalı olsun bu kontrol
             * Bu kontroller IK'ya açılacak (Sor)
             */
            if (Login_Form.Login_User_Obj_Id != 1 )
            {
                Delete_SimpleButton.Visible = false;
                Save_SimpleButton.Visible = false;
            }
        }
    }
}