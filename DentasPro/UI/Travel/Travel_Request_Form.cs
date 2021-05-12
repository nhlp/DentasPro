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
    ///Seyehat talep formu
    //
    /// </summary>
    public partial class Travel_Request_Form : Base_Form
    {
        public Travel_Request_Form()
        {
            InitializeComponent();
        }

        public bool Choose = false;
        public bool Edit = false;
        public int Choose_Id = -1;
        public int Travel_Vehicle_Obj_Id = -1;
        public int User_Obj_Id = -1;
        public int Department_Obj_Id = -1;
        public int Title_Obj_Id = -1;
        public int Expense_Group_Obj_Id = -1;


        DAL_Function.Sql_Server_DB_From_DentasProDataContext sql_Server_Db_From_Follow_Up_Data_context = new DAL_Function.Sql_Server_DB_From_DentasProDataContext();
        DAL_Function.Messages messages = new DAL_Function.Messages();
        DAL_Function.Get_The_Form get_The_Forms = new DAL_Function.Get_The_Form();


        public void Getting_For_Travel_Vehicle(int Obj_Id)
        {
            try
            {
                Travel_Vehicle_Obj_Id = Obj_Id;
                DAL_Function.Travel_Vehicle travel_Vehicle = sql_Server_Db_From_Follow_Up_Data_context.Travel_Vehicles.First(s => s.Obj_Id == Travel_Vehicle_Obj_Id);
                gridView1.AddNewRow();
                gridView1.SetFocusedRowCellValue("Travel_Vehicle", travel_Vehicle.Name);

                //Travel_Vehicle_RepositoryItemButtonEdit. = travel_Vehicle.Name;
            }
            catch (Exception exception)
            {
                throw;
            }
        }

        /// <summary>
        /// 14_*31_00
        /// </summary>
        private void Travel_Vehicle_RepositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int Obj_Id = get_The_Forms.Travel_Vehicle_Form(true);

            if (Obj_Id > 0)
            {
                Getting_For_Travel_Vehicle(Obj_Id);
                MainMDIForm.Cross = -1;
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

        public void Getting_For_Title_Name_Instead_Obj_Id(int Obj_Id)
        {
            try
            {
                Title_Obj_Id = Obj_Id;
                DAL_Function.Title title = sql_Server_Db_From_Follow_Up_Data_context.Titles.First(s => s.Obj_Id == Title_Obj_Id);

                Title_TextEdit.Text = title.Name;
            }
            catch (Exception exception)
            {
                throw;
            }
        }

        public void Getting_For_Expense_Group_Name_Instead_Obj_Id(int Obj_Id)
        {
            try
            {
                Expense_Group_Obj_Id = Obj_Id;
                DAL_Function.Expense_Group expense_Group = sql_Server_Db_From_Follow_Up_Data_context.Expense_Groups.First(s => s.Obj_Id == Expense_Group_Obj_Id);

                Expense_Group_TextEdit.Text = expense_Group.Name;
            }
            catch (Exception exception)
            {
                throw;
            }
        }


        public void Getting_For_Open_Up_User(int Obj_Id)
        {
            try
            {
                Edit = true;
                User_Obj_Id = Obj_Id;
                DAL_Function.User user = sql_Server_Db_From_Follow_Up_Data_context.Users.First(s => s.Obj_Id == User_Obj_Id);

                Name_Surname_TextEdit.Text = user.Full_Name;
                Department_Name_TextEdit.Text = user.Department_Obj_Id.ToString();
                Registration_Number_TextEdit.Text = user.Registration_Number;
                Title_TextEdit.Text = user.Title_Obj_Id.ToString();
                Expense_Group_TextEdit.Text = user.Expense_Group_Obj_Id.ToString();
                Getting_For_Department_Name_Instead_Obj_Id(user.Department_Obj_Id.Value);
                Getting_For_Title_Name_Instead_Obj_Id(user.Title_Obj_Id.Value);
                Getting_For_Expense_Group_Name_Instead_Obj_Id(user.Expense_Group_Obj_Id.Value);

            }
            catch (Exception exception)
            {
                throw;
            }
        }


        private void Name_Surname_TextEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int Obj_Id = get_The_Forms.User_List(true);

            if (Obj_Id > 0)
            {
                Getting_For_Open_Up_User(Obj_Id);
            }
            MainMDIForm.Cross = -1;
        }


        /// <summary>
        /// Grid'in satırını silme denemeleri
        /// </summary>
        /// <param name="view"></param>
        public void Delete_Selection_Row(DevExpress.XtraGrid.Views.Grid.GridView view)
        {
            if (view == null || view.SelectedRowsCount == 0)
            {
                return;
            }

            DataRow[] dataRow = new DataRow[view.SelectedRowsCount];
            for (int i = 0; i < view.SelectedRowsCount; i++)
            {
                dataRow[i] = view.GetDataRow(view.GetSelectedRows()[i]);

                view.BeginSort();

                try
                {
                    foreach (DataRow row in dataRow)
                    {
                        row.Delete();
                    }
                }
                catch (Exception)
                {
                    throw;
                }

                finally
                {
                    view.EndSort();
                }
            }

        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            Delete_Selection_Row(gridView1);
        }

        /*
         *  3_1_39_00
         * 14_13_17_00
         * Grid_start_dev.
         */


        /*
         * Grid'e veri doldururken "DataSet" kullanacağız.
         * 
         */
        //3_23_50

    }
}