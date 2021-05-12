namespace Dentas_Takip.UI.Travel
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
    
    using Dentas_Takip.UI.Base;

    /// <summary>
    /// Harcama formu
    /// </summary>
    public partial class Travel_Expense_Form : Base_Form
    {
        /*Seyehat harcama formu*/
        public Travel_Expense_Form()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 2015_01_29_14_24_00
        /// Obj_Id'yi burdaki açma işlemleri için kullanacağız
        /// </summary>
        public Travel_Expense_Form(bool Edit,int Obj_Id)
        {
            InitializeComponent();
        }

        public bool Choose = false;
        public bool Edit = false;
        public int Choose_Id = -1;
        public int Travel_Expense_Type_Obj_Id = -1;


        DAL_Function.Get_The_Form get_The_Form = new DAL_Function.Get_The_Form();
        DAL_Function.Sql_Server_DB_From_FollowUpDataContext sql_Server_Db_From_Follo_Up_Data_Context = new DAL_Function.Sql_Server_DB_From_FollowUpDataContext();
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

        }

        void Travel_Expense_Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                Travel_Expense_Help_Form travel_Expense_Help_Form = new Travel_Expense_Help_Form();
                travel_Expense_Help_Form.Show();
            }
        }

        public void Getting_For_Travel_Expense_Type_Name_Instead_Obj_Id(int Obj_Id) 
        {
            try
            {
                Travel_Expense_Type_Obj_Id = Obj_Id;
                DAL_Function.Expense_Type expense_Type = sql_Server_Db_From_Follo_Up_Data_Context.Expense_Types.First(s => s.Obj_Id == Travel_Expense_Type_Obj_Id);
                gridView1.SetFocusedRowCellValue("colExpense_Type_Obj_Id", expense_Type.Name);
            }
            catch (Exception exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Harcama türü butonuna basılınca "Harcama Türü" listesi gelecek ve listeden eseçim yapacağız.
        /// Seçilen değer griddeki ilgili kolon'a dolacak.
        /// </summary>
        private void Expense_Type_RepositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int Expense_Type_Obj_Id = get_The_Form.Expense_Type_Form(true);

            if (Expense_Type_Obj_Id > 0)
            {
                DAL_Function.Expense_Type expense_Type = sql_Server_Db_From_Follo_Up_Data_Context.Expense_Types.First(s => s.Obj_Id == Expense_Type_Obj_Id);
                DAL_Function.Travel_Expense travel_Expense = sql_Server_Db_From_Follo_Up_Data_Context.Travel_Expenses.First(s => s.Obj_Id == Travel_Expense_Type_Obj_Id);

                gridView1.AddNewRow();
                gridView1.SetFocusedRowCellValue(colExpense_Type_Obj_Id, expense_Type.Obj_Id);  /*Expense_Type_RepositoryItemButtonEdit*/
                //Getting_For_Travel_Expense_Type_Name_Instead_Obj_Id(Expense_Type_Obj_Id);
                gridView1.SetFocusedRowCellValue(colStarting_Location, travel_Expense.Starting_Location);
                gridView1.SetFocusedRowCellValue(colTransport_Start_Time,travel_Expense.Transport_Start_Time );
                gridView1.SetFocusedRowCellValue(colTarget_Location, travel_Expense.Target_Location);
                gridView1.SetFocusedRowCellValue(colTransport_Destination_Time, travel_Expense.Transport_Destination_Time);
                gridView1.SetFocusedRowCellValue(colTransport_Expense, travel_Expense.Transport_Expense);
                gridView1.SetFocusedRowCellValue(colAccommodation_Expense, travel_Expense.Accommodation_Expense);
                gridView1.SetFocusedRowCellValue(colFood_Expense, travel_Expense.Food_Expense);
                gridView1.SetFocusedRowCellValue(colOther_Expense, travel_Expense.Other_Expense);
                gridView1.SetFocusedRowCellValue(colTotal_Expense, travel_Expense.Total_Expense);
                gridView1.SetFocusedRowCellValue(colDescription, travel_Expense.Description);
            }
        }

        /// <summary>
        /// Help ekranını açıyoruz.
        /// </summary>
        private void Help_SimpleButton_Click(object sender, EventArgs e)
        {
            Travel_Expense_Help_Form travel_Expense_Help_Form = new Travel_Expense_Help_Form();
            travel_Expense_Help_Form.Show();
        }

        //2015_01_29_14_12_22
    }
}