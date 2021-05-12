namespace Dentas_Pro.UI.Travel
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

    /// <summary>
    /// Seyahat Harcama formu
    /// </summary>
    public partial class Travel_Expense_Form : Base_Form
    {
        public Travel_Expense_Form()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 2015_01_29_14_24_00
        /// Obj_Id'yi burdaki açma işlemleri için kullanacağız
        /// </summary>
        public Travel_Expense_Form(bool Edit, int Obj_Id)
        {
            InitializeComponent();
        }

        public bool Choose = false;
        public bool Edit = false;
        public int Choose_Id = -1;
        public int Travel_Expense_Type_Obj_Id = -1;
        public int User_Obj_Id = -1;
        public int Department_Obj_Id = -1;
        public int Title_Obj_Id = -1;

        DAL_Function.Get_The_Form get_The_Form = new DAL_Function.Get_The_Form();
        DAL_Function.Sql_Server_DB_From_DentasProDataContext sql_Server_Db_From_Follo_Up_Data_Context = new DAL_Function.Sql_Server_DB_From_DentasProDataContext();
        /// <summary>
        /// Buna bastığımızda Önce liste gelicek ve seçim yapacağız.
        /// 14_31_00
        /// 2015_01_29_14_20_58--> Griddeki kolon'a buton ekliyoruz
        /// </summary>
        private void Travel_Expense_Form_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Travel_Expense_Form_KeyDown);
            Declaration_Date_DateEdit.Text = DateTime.Now.ToString();


            gridView1.SetFocusedRowCellValue("colTransportation_Start_Place", string.Empty);

            /*Manuel tarih seçtirilecek*/
            gridView1.SetFocusedRowCellValue("colTransport_Start_Time", DateTime.MinValue);

            gridView1.SetFocusedRowCellValue("colTransportation_Destination_Place", " ");
            gridView1.SetFocusedRowCellValue("colTransport_End_Time", " ");
            gridView1.SetFocusedRowCellValue("colTransportation_Amount", 0);
            gridView1.SetFocusedRowCellValue("colLayover_Place", " ");
            gridView1.SetFocusedRowCellValue("colLayover_Amount", 0);
            gridView1.SetFocusedRowCellValue("colLayover_Time", " ");
            gridView1.SetFocusedRowCellValue("colFood_Amount", 0);
            gridView1.SetFocusedRowCellValue("colFeeding_Time", " ");
            gridView1.SetFocusedRowCellValue("colOther_Amount", 0);

        }

        #region Help işlemi için

        void Travel_Expense_Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                //Add_Annual_Permit_Help_Form travel_Expense_Help_Form = new Travel_Expense_Help_Form();
                //travel_Expense_Help_Form.Show();
            }
        }

        /// <summary>
        /// Help ekranını açıyoruz.
        /// </summary>
        private void Help_SimpleButton_Click(object sender, EventArgs e)
        {
            //Travel_Expense_Help_Form travel_Expense_Help_Form = new Travel_Expense_Help_Form();
            //travel_Expense_Help_Form.Show();
        }
        #endregion

        /// <summary>
        /// Griddeki harcama türü butonuna basınca
        /// 1.Harcama butonuna basılınca önce "Setahat Harcama Türü" list ekranı gelecek ve listeden seçim yapacağız.
        /// 2.Seçtiğimiz değer grid'deki ilgili kolon'a dolacak. 
        /// 14_22_30
        /// </summary>
        private void Travel_Expense_Type_RepositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            /*1.Adım: Seyehat harcama türü formunu açıyoruz.*/
            int Travel_Expense_Obj_Id = get_The_Form.Travel_Expense_Type_Form(true);

            /*2.Seyahta harcama Obj_ID'ye karşılık gelecek "Setahat_Harcama_Tür_Adı" set ediyoruz.*/
            //Getting_For_Travel_Expense_Name_Instead_Obj_Id(Travel_Expense_Obj_Id);  şimdilik commentelendi

            if (Travel_Expense_Obj_Id > 0)
            {
                DAL_Function.Travel_Expense_Type travel_Expense_Types = sql_Server_Db_From_Follo_Up_Data_Context.Travel_Expense_Types.First(s => s.Obj_Id == Travel_Expense_Obj_Id);
                gridView1.AddNewRow();
                /*
                 * Burda ilk girilecek olan seyahat harcama türü bilgisi
                 * "Travel_Expense_Obj_Id = Seyehat harcama türü bilgisinin grid'deki kolon adı"
                 * Expense_Type_Obj_Id --> Seyahat harcama türü tablosundan seçilip Seyhat Harcama Satırına yazılcak.
                 * Burda Gridde henüz data topluyoruz.
                 * 14_35_15
                 */
                gridView1.SetFocusedRowCellValue(gridView1.Columns["Travel_Expense_Obj_Id"], travel_Expense_Types.Obj_Id);

                /*Bu bilgi elle girilecek*/
                gridView1.SetFocusedRowCellValue("colTransportation_Start_Place", " ");/*Boom*/

                /*Manuel tarih seçtirilecek*/
                gridView1.SetFocusedRowCellValue("colTransport_Start_Time", " ");

                gridView1.SetFocusedRowCellValue("colTransportation_Destination_Place", " ");
                gridView1.SetFocusedRowCellValue("colTransport_End_Time", " ");
                gridView1.SetFocusedRowCellValue("colTransportation_Amount", 0);
                gridView1.SetFocusedRowCellValue("colLayover_Place", " ");
                gridView1.SetFocusedRowCellValue("colLayover_Amount", 0);
                gridView1.SetFocusedRowCellValue("colLayover_Time", " ");
                gridView1.SetFocusedRowCellValue("colFood_Amount", 0);
                gridView1.SetFocusedRowCellValue("colFeeding_Time", " ");
                gridView1.SetFocusedRowCellValue("colOther_Amount", 0);

                gridView1.SetFocusedRowCellValue("colRow_Amount", "colTransportation_Amount + colLayover_Amount + colFood_Amount + colOther_Amount");
            }

        }

        private void Clean_The_Control_Value()
        {
            Registration_Number_TextEdit.Text = string.Empty;
            Traveller_Name_And_Surname_TextEdit.Text = string.Empty;
            Department_TextEdit.Text = string.Empty;
            Title_TextEdit.Text = string.Empty;

        }

        private void Clean_The_Control_Value_SimpleButton_Click(object sender, EventArgs e)
        {
            Clean_The_Control_Value();
        }

        /// <summary>
        /// 14_39_40
        /// </summary>
        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                /*
               * Sütun toplam sütunu değil ise
               * Her sütun değişilkliğinde toplam değişeceği için sonsuz döngü
               * oluşabilir. Önlem alıyoruz.
               */

                decimal Transportation_Amount_In = 0;
                decimal Layover_Amount_In = 0;
                decimal Food_Amount_In = 0;
                decimal Other_Amount_In = 0;
                decimal Row_Amount_In = 0;

                if (e.Column.Name != "colRow_Amount")
                {
                    //if (gridView1.GetFocusedRowCellValue("Transportation_Amount").ToString() != "" || gridView1.GetFocusedRowCellValue("Transportation_Amount").ToString() != null)
                    Transportation_Amount_In = decimal.Parse(gridView1.GetFocusedRowCellValue("Transportation_Amount").ToString());
                    Layover_Amount_In = decimal.Parse(gridView1.GetFocusedRowCellValue("colLayover_Amount").ToString());
                    Food_Amount_In = decimal.Parse(gridView1.GetFocusedRowCellValue("colFood_Am ount").ToString());
                    Other_Amount_In = decimal.Parse(gridView1.GetFocusedRowCellValue("colOther_Amount").ToString());
                    Row_Amount_In = Transportation_Amount_In + Layover_Amount_In + Food_Amount_In + Other_Amount_In;

                    gridView1.SetFocusedRowCellValue("Row_Amount", Row_Amount_In.ToString());
                    Account_The_Rows();
                    //14_44:01_
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        /// <summary>
        /// 14_50_00
        /// </summary>
        public void Account_The_Rows()
        {
            try
            {
                decimal Transportation_Amount = 0;
                decimal Layover_Amount = 0;
                decimal Food_Amount = 0;
                decimal Other_Amount = 0;
                /*Alınan avans*/
                decimal Advances_Receivable = 0;
                decimal Row_Amount = 0;
                decimal Total_Amount = 0;

                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    Transportation_Amount = decimal.Parse(gridView1.GetRowCellValue(i, "Transportation_Amount").ToString());
                    Layover_Amount = decimal.Parse(gridView1.GetRowCellValue(i, "Layover_Amount").ToString());
                    Food_Amount = decimal.Parse(gridView1.GetRowCellValue(i, "Food_Amount").ToString());
                    Other_Amount = decimal.Parse(gridView1.GetRowCellValue(i, "Other_Amount").ToString());
                    Row_Amount = decimal.Parse(gridView1.GetRowCellValue(i, "Row_Amount").ToString());
                    Total_Amount = decimal.Parse(gridView1.GetRowCellValue(i, "Total_Amount").ToString() + Row_Amount);
                    /*Alınan avanstan Genel toplam çıkarılıyor*/
                    //Advances_Receivable = decimal.Parse(gridView1.GetRowCellValue(i, "Advances_Receivable").ToString() - Total_Amount.ToString());
                }
                Total_Amoun_TextEdit.Text = Row_Amount.ToString("0.00");
                Receivable_TextEdit.Text = (Total_Amount - Advances_Receivable).ToString();  /*Advances_Receivable.ToString("0.00");*/


            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void gridView1_RowCountChanged(object sender, EventArgs e)
        {
            Account_The_Rows();
        }

        /// <summary>
        /// Seyahat harcam türünün adını grid'deki kolna'a set ediyoruz
        /// Artık Obj_Id değil .Ad görünecek.ş
        /// </summary>
        private void Getting_For_Travel_Expense_Name_Instead_Obj_Id(int Obj_Id)
        {
            try
            {
                Travel_Expense_Type_Obj_Id = Obj_Id;
                DAL_Function.Travel_Expense_Type travel_Expense_Type = sql_Server_Db_From_Follo_Up_Data_Context.Travel_Expense_Types.First(s => s.Obj_Id == Travel_Expense_Type_Obj_Id);
                //gridView1.GetRowCellValue([0], "Expense_Type_Obj_Id") = travel_Expense_Type.Name;
                gridView1.SetFocusedRowCellValue("Expense_Type_Obj_Id", travel_Expense_Type.Name);
                //.GetFocusedRowCellValue("Transportation_Amount").ToString());
            }
            catch (Exception exception)
            {
                throw;
            }
        }

        #region Grid'in satırını silme (2 Farklı yol ile)
        DAL_Function.Messages message = new DAL_Function.Messages();
        /// <summary>
        /// Grid'in satırını "Griddeki Silme Butonu" ile siliyoruz
        /// </summary>
        private void Button_Delete_RepositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            if (message.Delete() == DialogResult.Yes)
            {
                gridView1.DeleteRow(gridView1.FocusedRowHandle);
            }
        }

        /// <summary>
        /// Bu event ise grid'deki satırıdı "Delete" tuşuna basarak siliyoruz
        /// </summary>
        private void gridControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (message.Delete() == DialogResult.Yes)
                {
                    gridView1.DeleteRow(gridView1.FocusedRowHandle);
                }
            }
        }
        #endregion

        private void Registration_Number_TextEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int Obj_Id = get_The_Form.User_List(true);
            if (Obj_Id > 0)
            {
                Getting_For_Open_Up_User(Obj_Id);
            }
        }


        public void Getting_For_Open_Up_User(int Obj_Id)
        {
            try
            {
                Edit = true;
                User_Obj_Id = Obj_Id;
                DAL_Function.User user = sql_Server_Db_From_Follo_Up_Data_Context.Users.First(s=> s.Obj_Id == User_Obj_Id);

                Registration_Number_TextEdit.Text = user.Registration_Number;
                Traveller_Name_And_Surname_TextEdit.Text = user.Full_Name;
                Department_TextEdit.Text = user.Department_Obj_Id.Value.ToString();
                Title_TextEdit.Text = user.Title_Obj_Id.Value.ToString();

                #region Description
                /*Yukarda Departman ve Title bilgileri Obj_Id olarak alıyoruz. 
                 * Şimdi ise Obj_Id'lere karşılık gelecek Name'leri ekrandaki 
                 * ilgili kontrollere doldurcağız
                 */
                #endregion
                Getting_For_Department_Name_Instead_Obj_Id(user.Department_Obj_Id.Value);
                Getting_For_Title_Name_Instead_Obj_Id(user.Title_Obj_Id.Value);
                
            }
            catch (Exception exception)
            {
                message.Error(exception);
            }
            
        }

        public void Getting_For_Department_Name_Instead_Obj_Id(int Obj_Id)
        {
            try
            {
                Department_Obj_Id = Obj_Id;
                DAL_Function.Department department = sql_Server_Db_From_Follo_Up_Data_Context.Departments.First(s => s.Obj_Id == Department_Obj_Id);

                Department_TextEdit.Text = department.Name;
            }
            catch (Exception exception)
            {
                throw;
            }
        }

        public void Getting_For_Title_Name_Instead_Obj_Id(int Obj_Id)
        {
            try
            {
                Title_Obj_Id = Obj_Id;
                DAL_Function.Title title = sql_Server_Db_From_Follo_Up_Data_Context.Titles.First(s => s.Obj_Id == Title_Obj_Id);

                Title_TextEdit.Text = title.Name;
            }
            catch (Exception exception)
            {
                throw;
            }
        }

    }
}