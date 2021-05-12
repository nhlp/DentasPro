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
    /// Seyahat araçalrının tanım formu
    /// </summary>
    public partial class Travel_Vehicle_Form : Base_Form
    {
        public Travel_Vehicle_Form()
        {
            InitializeComponent();
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


        private void Travel_Vehicle_Form_Load(object sender, EventArgs e)
        {
            Get_The_Travel_Vehicle_List();
            Travel_Vehicle_Code_TextEdit.Text = generator_Id.Generate_The_Unique_Id_For_Travel_Vehicle_Id();
        }
       

        #region Description
        /*dikkat edersen studio tablo adının sonuna fazladan "s" koydu.*/
        #endregion
        public void Get_The_Travel_Vehicle_List()
        {
            var Get_The_Travel_Vehicle = from s in sql_Server_Db_From_DentasPro_Data_Context.Travel_Vehicles
                                          select s;

            Travel_Vehicle_GridControl.DataSource = Get_The_Travel_Vehicle;
        }

        #region Description
        /*
         * 2015.01.07_ King was here!. :)
         * Bu metod kontroller'e boşluk atıyor. Adeta kontrollerde olan datayı siliyoruz.
         */
        #endregion
        private void Clean_The_Control()
        {
            Travel_Vehicle_Code_TextEdit.Text = string.Empty;
            Travel_Vehicle_Name_TextEdit.Text = string.Empty;
            Travel_Vehicle_Type_TextEdit.Text = string.Empty;
            Travel_Vehicle_Description_MemoEdit.Text = string.Empty;
            Edit = false;
            Get_The_Travel_Vehicle_List();
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
                DAL_Function.Travel_Vehicle travel_Vehicle = new Travel_Vehicle();

                travel_Vehicle.Code = Travel_Vehicle_Code_TextEdit.Text;
                travel_Vehicle.Name = Common_Methods.Fitst_Letter_Upper_Case_Other_Lower(Travel_Vehicle_Name_TextEdit.Text);
                travel_Vehicle.Vehicle_Type = Common_Methods.Fitst_Letter_Upper_Case_Other_Lower(Travel_Vehicle_Type_TextEdit.Text);
                travel_Vehicle.Description = Common_Methods.Fitst_Letter_Upper_Case_Other_Lower(Travel_Vehicle_Description_MemoEdit.Text);
                travel_Vehicle.Insert_Time = DateTime.Now;
                travel_Vehicle.Insert_User = Login_Form.Login_User_Obj_Id;

                sql_Server_Db_From_DentasPro_Data_Context.Travel_Vehicles.InsertOnSubmit(travel_Vehicle);
                sql_Server_Db_From_DentasPro_Data_Context.SubmitChanges();
                #region Description
                /*
                 * Eğer buraya kadarki adımlara hatasız tamamlanmış ise bir alt satırdaki kodu icare edecek
                 */
                #endregion
                messages.New_Record("Yeni araç kaydı yapıldı");
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
        /*Kayıt güncellemek için bu metodu kullanıyoruz*/
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
                DAL_Function.Travel_Vehicle travel_Vehicle = sql_Server_Db_From_DentasPro_Data_Context.Travel_Vehicles.First(s => s.Obj_Id == Choose_Obj_Id);/*1*/

                travel_Vehicle.Code = Travel_Vehicle_Code_TextEdit.Text;
                travel_Vehicle.Name = Common_Methods.Fitst_Letter_Upper_Case_Other_Lower(Travel_Vehicle_Name_TextEdit.Text);
                travel_Vehicle.Vehicle_Type = Common_Methods.Fitst_Letter_Upper_Case_Other_Lower(Travel_Vehicle_Type_TextEdit.Text);
                travel_Vehicle.Description = Common_Methods.Fitst_Letter_Upper_Case_Other_Lower(Travel_Vehicle_Description_MemoEdit.Text);
                travel_Vehicle.Update_User = Login_Form.Login_User_Obj_Id;
                travel_Vehicle.Update_Time = DateTime.Now;
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
                sql_Server_Db_From_DentasPro_Data_Context.Travel_Vehicles.DeleteOnSubmit(sql_Server_Db_From_DentasPro_Data_Context.Travel_Vehicles.First(s => s.Obj_Id == Choose_Obj_Id));
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
                Travel_Vehicle_Name_TextEdit.Text = gridView1.GetFocusedRowCellValue("Name").ToString();
                Travel_Vehicle_Code_TextEdit.Text = gridView1.GetFocusedRowCellValue("Code").ToString();
                Travel_Vehicle_Type_TextEdit.Text = gridView1.GetFocusedRowCellValue("Vehicle_Type").ToString();
                Travel_Vehicle_Description_MemoEdit.Text = gridView1.GetFocusedRowCellValue("Description").ToString();
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

        //private void gridView1_DoubleClick(object sender, EventArgs e)
        //{
        //    #region Description
        //    /*
        //     * Eğer seçim için açıldı ise ve Choose_Id > 0 dan
        //     * if bloğundaki kod icra olacak. Choose_Id deki Id yi Main_MDI_Form'a atama işlemini yapacak.
        //     * Eğer değil ise yalnızca
        //     * Chooce_The_Record(); metodu icra olacaktır.
        //     */
        //    #endregion
        //    Chooce_The_Record();
        //    if (Choose && Choose_Obj_Id > 0)
        //    {
        //        MainMDIForm.Cross = Choose_Obj_Id;
        //        this.Close();
        //    }
        //}

        #region Events

        //private void Save_SimpleButton_Click(object sender, EventArgs e)
        //{
        //    #region Description
        //    /*
        //     * Eğer If'in ilk adımı doğru ise "Update_The_Record()" u çalıştır
        //     * eğer if'in ilk adımındaki şartlar uygun değil ise
        //     * else
        //     * Get_Data_From_UI() çağır. (Çalıştır.)
        //     */
        //    #endregion
        //    if (Edit && Choose_Obj_Id > 0 && messages.Update() == DialogResult.Yes)
        //    {
        //        Update_Data_From_Db();
        //    }
        //    else
        //    {
        //        Get_Data_From_UI();
        //    }
        //}

        //private void Close_SimpleButton_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        //private void Delete_SimpleButton_Click(object sender, EventArgs e)
        //{
        //    #region Description
        //    /*
        //     * if bloğunun ilk adımı şart "true / doğru" ise icra olacaktır.
        //     * Eğer "Edit" true ise (Editleme işlemi var ise)
        //     * ve (&&)
        //     * Chooce_Id sıfırdan büyük ise.
        //     * ve (&&)
        //     * ekrandan alınan delete mesajında Yes'e kliklendi ise
        //     * Silme metodunu çağırıyoruz.
        //     * Eğer clause'daki şartlar uygun değil ise sil mestodu icra olamayacaktır.
        //     */
        //    #endregion
        //    if (Edit && Choose_Obj_Id > 0 && messages.Delete() == DialogResult.Yes)
        //    {
        //        Delete_The_Record();
        //    }
        //}
        #endregion

      

        private void Save_SimpleButton_Click(object sender, EventArgs e)
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

        private void Close_SimpleButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Delete_SimpleButton_Click(object sender, EventArgs e)
        {
            #region Description
            /*
                 * if bloğunun ilk adımı şart "true / doğru" ise icra olacaktır.
                 * Eğer "Edit" true ise (Editleme işlemi var ise)
                 * ve (&&)
                 * Chooce_Id sıfırdan büyük ise.
                 * ve (&&)
                 * ekrandan alınan delete mesajında Yes'e kliklendi ise
                 * Silme metodunu çağırıyoruz.
                 * Eğer clause'daki şartlar uygun değil ise sil mestodu icra olamayacaktır.
                 */
            #endregion
            if (Edit && Choose_Obj_Id > 0 && messages.Delete() == DialogResult.Yes)
            {
                Delete_The_Record();
            }

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Chooce_The_Record();
            if (Choose && Choose_Obj_Id > 0)
            {
                MainMDIForm.Cross = Choose_Obj_Id;
                this.Close();
            }
        }


    }
}