namespace Dentas_Pro.UI.Report
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
    using DevExpress.XtraGrid.Views.Grid;
    using DevExpress.XtraGrid.Menu;
    using DevExpress.Utils.Menu;
    using DevExpress.XtraGrid.Views.Grid.ViewInfo;

    using DevExpress.Data;
    using DevExpress.XtraGrid;
    using DevExpress.XtraGrid.Columns;
    using Dentas_Pro.UI.Base;

    public partial class Staff_Rest_Permit_List_Form : Base_Form
    {
        /// <summary>
        /// Departman kalan izin Listesi
        /// </summary>
        public Staff_Rest_Permit_List_Form()
        {
            InitializeComponent();

        }

        DAL_Function.Sql_Server_DB_From_DentasProDataContext sql_Server_Db_From_Follow_Up_Data_Context = new DAL_Function.Sql_Server_DB_From_DentasProDataContext();

        public bool Choose = false;
        public int Choose_Obj_Id = -1;
        GridSummaryItem GridGroupSummaryItem;

        private void Staff_Rest_Permit_List_Form_Load(object sender, EventArgs e)
        {
            List_The_Annual_Permit_For_IT();
            List_The_Annual_Permit_For_Financal();
            List_The_Annual_Permit_For_HR();
            List_The_Annual_Permit_For_Quality();
            List_The_Annual_Permit_For_Manufacture();
            List_The_Annual_Permit_For_Purchasing_Logistics();
            List_The_Annual_Permit_For_Planning();
            List_The_Annual_Permit_For_All_Staff();
        }

        public void List_The_Annual_Permit_For_IT()
        {
            var list = from u in sql_Server_Db_From_Follow_Up_Data_Context.Users

                       join d in sql_Server_Db_From_Follow_Up_Data_Context.Departments on u.Department_Obj_Id equals d.Obj_Id
                       /*join pr in sql_Server_Db_From_Follow_Up_Data_Context.Permit_Reasons on ap.Permit_Reason_Obj_Id equals pr.Obj_Id*/
                       orderby u.Accumulated_Permit_count descending
                       /*Where clause'unda bilgi işlem'i filtreliyoruz*/
                       where u.Department_Obj_Id == 10
                       select new
                       {
                           //Sıra = u.Obj_Id,
                           Ad_Soyad = u.Full_Name,
                           Sicil_Numarası = u.Registration_Number,
                           Departman_Adı = d.Name,
                           Bakiye = u.Accumulated_Permit_count
                       };
            IT_GridControl.DataSource = list;
            

            #region Old_Code
            //var list = from ap in sql_Server_Db_From_Follow_Up_Data_Context.Annual_Permits

            //           join u in sql_Server_Db_From_Follow_Up_Data_Context.Users on ap.User_Obj_Id equals u.Obj_Id
            //           join d in sql_Server_Db_From_Follow_Up_Data_Context.Departments on ap.Department_Obj_Id equals d.Obj_Id

            //           where (ap.Department_Obj_Id == 1)

            //           orderby ap.Permit_Start_Time descending
            //           //group ap by new { ap.User_Obj_Id, u.Full_Name, u.E_Mail, u.Registration_Number, d.Name, ap.Accumulated_Permit_count_Knowledge_Data } into gb

            //           //gb.Max( x => gb.Key.Obj_Id)
            //           //&&  gb.Max().Obj_Id

            //           select new
            //           {
            //               //gb.Key.Obj_Id,
            //               Ad_Soyad = u.Full_Name,
            //               Mail = u.E_Mail,
            //               Sicil_Numarası = u.Registration_Number,
            //               Departman_Adı = d.Name,
            //               //İzin_Başlangıç_Tarihi = ap.Permit_Start_Time,
            //               //İzin_Bitiş_Tarihi = ap.Permit_End_Time,
            //               Bakiye = ap.Accumulated_Permit_count_Knowledge_Data
            //           };

            //IT_GridControl.DataSource = list;
            #endregion
        }

        public void List_The_Annual_Permit_For_Financal()
        {
            var list = from u in sql_Server_Db_From_Follow_Up_Data_Context.Users

                       join d in sql_Server_Db_From_Follow_Up_Data_Context.Departments on u.Department_Obj_Id equals d.Obj_Id
                       /*join pr in sql_Server_Db_From_Follow_Up_Data_Context.Permit_Reasons on ap.Permit_Reason_Obj_Id equals pr.Obj_Id*/
                       orderby u.Accumulated_Permit_count descending
                       /*Where clause'unda bilgi işlem'i filtreliyoruz*/
                       where u.Department_Obj_Id == 20
                       select new
                       {
                           //Sıra = u.Obj_Id,
                           Ad_Soyad = u.Full_Name,
                           Sicil_Numarası = u.Registration_Number,
                           Departman_Adı = d.Name,
                           Bakiye = u.Accumulated_Permit_count
                       };

            Financal_GridControl.DataSource = list;
            gridView1.Columns["Bakiye"].Summary.Add();
        }

        public void List_The_Annual_Permit_For_HR()
        {
            var list = from u in sql_Server_Db_From_Follow_Up_Data_Context.Users

                       join d in sql_Server_Db_From_Follow_Up_Data_Context.Departments on u.Department_Obj_Id equals d.Obj_Id
                       orderby u.Accumulated_Permit_count descending
                       where u.Department_Obj_Id == 17
                       select new
                       {
                           //Sıra = u.Obj_Id,
                           Ad_Soyad = u.Full_Name,
                           Sicil_Numarası = u.Registration_Number,
                           Departman_Adı = d.Name,
                           Bakiye = u.Accumulated_Permit_count
                       };

            HR_GridControl.DataSource = list;
        }

        public void List_The_Annual_Permit_For_Quality()
        {
            var list = from u in sql_Server_Db_From_Follow_Up_Data_Context.Users

                       join d in sql_Server_Db_From_Follow_Up_Data_Context.Departments on u.Department_Obj_Id equals d.Obj_Id
                       orderby u.Accumulated_Permit_count descending
                       where u.Department_Obj_Id == 19
                       select new
                       {
                           //Sıra = u.Obj_Id,
                           Ad_Soyad = u.Full_Name,
                           Sicil_Numarası = u.Registration_Number,
                           Departman_Adı = d.Name,
                           Bakiye = u.Accumulated_Permit_count
                       };
            Quality_GridControl.DataSource = list;
        }

        /// <summary>
        /// Üretim departmanlırın tamamı
        /// </summary>
        public void List_The_Annual_Permit_For_Manufacture()
        {
            var list = from u in sql_Server_Db_From_Follow_Up_Data_Context.Users

                       join d in sql_Server_Db_From_Follow_Up_Data_Context.Departments on u.Department_Obj_Id equals d.Obj_Id
                       orderby u.Accumulated_Permit_count descending
                       where u.Department_Obj_Id == 25 || u.Department_Obj_Id == 22 || u.Department_Obj_Id == 18 || u.Department_Obj_Id == 14 || u.Department_Obj_Id == 13 || u.Department_Obj_Id == 12 || u.Department_Obj_Id == 11 || u.Department_Obj_Id == 9
                       select new
                       {
                           //Sıra = u.Obj_Id,
                           Ad_Soyad = u.Full_Name,
                           Sicil_Numarası = u.Registration_Number,
                           Departman_Adı = d.Name,
                           Bakiye = u.Accumulated_Permit_count
                       };
            Manufacture_GridControl.DataSource = list;
        }

        public void List_The_Annual_Permit_For_Purchasing_Logistics()
        {
            var list = from u in sql_Server_Db_From_Follow_Up_Data_Context.Users

                       join d in sql_Server_Db_From_Follow_Up_Data_Context.Departments on u.Department_Obj_Id equals d.Obj_Id
                       orderby u.Accumulated_Permit_count descending
                       where u.Department_Obj_Id == 23
                       select new
                       {
                           //Sıra = u.Obj_Id,
                           Ad_Soyad = u.Full_Name,
                           Sicil_Numarası = u.Registration_Number,
                           Departman_Adı = d.Name,
                           Bakiye = u.Accumulated_Permit_count
                       };

            Purchasing_Logistic_GridControl.DataSource = list;
        }

        public void List_The_Annual_Permit_For_Planning()
        {
            var list = from u in sql_Server_Db_From_Follow_Up_Data_Context.Users

                       join d in sql_Server_Db_From_Follow_Up_Data_Context.Departments on u.Department_Obj_Id equals d.Obj_Id
                       orderby u.Accumulated_Permit_count descending
                       where u.Department_Obj_Id == 25
                       select new
                       {
                           //Sıra = u.Obj_Id,
                           Ad_Soyad = u.Full_Name,
                           Sicil_Numarası = u.Registration_Number,
                           Departman_Adı = d.Name,
                           Bakiye = u.Accumulated_Permit_count
                       };

            Planning_GridControl.DataSource = list;
        }


        /// <summary>
        /// Personellerin tamamı
        /// </summary>
        public void List_The_Annual_Permit_For_All_Staff()
        {
            var list = from u in sql_Server_Db_From_Follow_Up_Data_Context.Users

                       join d in sql_Server_Db_From_Follow_Up_Data_Context.Departments on u.Department_Obj_Id equals d.Obj_Id
                       orderby u.Accumulated_Permit_count descending
                       //where u.Department_Obj_Id == 25
                       select new
                       {
                           //Sıra = u.Obj_Id,
                           Ad_Soyad = u.Full_Name,
                           Sicil_Numarası = u.Registration_Number,
                           Departman_Adı = d.Name,
                           Bakiye = u.Accumulated_Permit_count
                       };

            All_GridControl.DataSource = list;
        }

        private void gridView1_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {

        }

        #region Best fit for grid colum weight
        private void IT_GridControl_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < gridView1.Columns.Count; i++) gridView1.Columns[i].BestFit();

        }

        private void HR_GridControl_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < gridView2.Columns.Count; i++) gridView1.Columns[i].BestFit();

        }

        private void Manufacture_GridControl_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < gridView3.Columns.Count; i++) gridView1.Columns[i].BestFit();

        }

        private void Financal_GridControl_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < gridView4.Columns.Count; i++) gridView1.Columns[i].BestFit();

        }

        private void Purchasing_Logistic_GridControl_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < gridView5.Columns.Count; i++) gridView1.Columns[i].BestFit();

        }

        private void Quality_GridControl_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < gridView6.Columns.Count; i++) gridView1.Columns[i].BestFit();

        }
        #endregion

    }

}


