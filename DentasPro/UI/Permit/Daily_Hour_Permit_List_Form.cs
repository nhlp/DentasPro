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
    using Dentas_Pro.UI.User;
    using DevExpress.Xpo.DB;
    using DevExpress.XtraGrid.Views.Grid.ViewInfo;
    using DevExpress.XtraGrid.Views.Grid;
    using DevExpress.XtraGrid;

    using Dentas_Pro.UI.Helper;
    using Dentas_Pro.UI.WinControl;

    public partial class Daily_Hour_Permit_List_Form : Base_Form
    {
        public Daily_Hour_Permit_List_Form()
        {
            InitializeComponent();
        }

        DAL_Function.Sql_Server_DB_From_DentasProDataContext sql_Server_Db_From_Follow_Up_Data_Context = new DAL_Function.Sql_Server_DB_From_DentasProDataContext();
        DAL_Function.Get_The_Form get_The_Forms = new DAL_Function.Get_The_Form();

        public bool Choose = false;
        /// <summary>
        /// Seçilen
        /// </summary>
        public int Choose_Obj_Id = -1;
        public int Daily_Houry_Permit_Obj_Id = -1;


        /// <summary>
        /// Ekran ilk açılırken Grid'i dolduruyoruz.
        /// İzin türüne göre listeleme yapıyoruz.
        /// </summary>
        public void List_The_Daily_Hour_Permit()
        {
            Daily_Hour_Permit_Form daily_Hour_Permit_Form = new Daily_Hour_Permit_Form();


            /* 
             * Eğer personeller IK veya Genel Müdür ise herkesi görsünler..
             * Buğra Sükan, Armağan, Celal, Fatma Dayı, Tuğba, Çağatay  
             */
            if (Login_Form.Login_User_Obj_Id == 3 || Login_Form.Login_User_Obj_Id == 9 || Login_Form.Login_User_Obj_Id == 13 || Login_Form.Login_User_Obj_Id == 16 || Login_Form.Login_User_Obj_Id == 17 || Login_Form.Login_User_Obj_Id == 8)
            {
                var list = from dhp in sql_Server_Db_From_Follow_Up_Data_Context.Daily_Hour_Permits

                           join u in sql_Server_Db_From_Follow_Up_Data_Context.Users on dhp.User_Obj_Id equals u.Obj_Id
                           join d in sql_Server_Db_From_Follow_Up_Data_Context.Departments on dhp.Department_Obj_Id equals d.Obj_Id
                           /*join pr in sql_Server_Db_From_Follow_Up_Data_Context.Permit_Reasons on dhp.Permit_Reason_Obj_Id equals pr.Obj_Id*/

                           orderby dhp.Permit_Start_Time descending

                           select new
                           {
                               Sıra = dhp.Obj_Id,
                               Ad_Soyad = u.Full_Name,
                               Sicil_Numarası = u.Registration_Number,
                               /*u.Department_Obj_Id.Value,*/
                               Departman_Adı = d.Name,
                               İzin_Başlangıç_Tarihi = dhp.Permit_Start_Time,
                               İzin_Bitiş_Tarihi = dhp.Permit_End_Time,
                               /*dhp.Permit_Type,*/
                               /*İzin_Sebebi = pr.Name,*/
                               //Bu_yıl_Hak_Edilen_İzin = u.This_Year_Permit_Count,
                               //Kullanılmış_İzin_Gün_Adedi = dhp.Permitted_Use_Knowledge_Data,
                               //Bakiye = dhp.Accumulated_Permit_count_Knowledge_Data
                           };
                fuGridControl1.DataSource = list;
                return;
            }


            if (daily_Hour_Permit_Form.Job_Title_TextEdit.Text.Contains("Müdür") == true)
            {
                var list = from dhp in sql_Server_Db_From_Follow_Up_Data_Context.Daily_Hour_Permits

                           join u in sql_Server_Db_From_Follow_Up_Data_Context.Users on dhp.User_Obj_Id equals u.Obj_Id
                           join d in sql_Server_Db_From_Follow_Up_Data_Context.Departments on dhp.Department_Obj_Id equals d.Obj_Id
                           /*join pr in sql_Server_Db_From_Follow_Up_Data_Context.Permit_Reasons on dhp.Permit_Reason_Obj_Id equals pr.Obj_Id*/
                           orderby dhp.Obj_Id descending
                           /*Where clause'unda bilgi işlem'i filtreliyoruz*/
                           where u.Department_Obj_Id == daily_Hour_Permit_Form.Department_Obj_Id
                           select new
                           {
                               Sıra = dhp.Obj_Id,
                               Ad_Soyad = u.Full_Name,
                               Sicil_Numarası = u.Registration_Number,
                               /*u.Department_Obj_Id.Value,*/
                               Departman_Adı = d.Name,
                               İzin_Başlangıç_Tarihi = dhp.Permit_Start_Time,
                               İzin_Bitiş_Tarihi = dhp.Permit_End_Time,
                               /*dhp.Permit_Type,*/
                               /*İzin_Sebebi = pr.Name,*/
                               //Bu_yıl_Hak_Edilen_İzin = u.This_Year_Permit_Count,
                               //Kullanılmış_İzin_Gün_Adedi = dhp.Permitted_Use_Knowledge_Data,
                               //Bakiye = dhp.Accumulated_Permit_count_Knowledge_Data
                           };
                fuGridControl1.DataSource = list;
            }
            if (daily_Hour_Permit_Form.Job_Title_TextEdit.Text.Contains("Yönetmen") == true)
            {
                var list = from dhp in sql_Server_Db_From_Follow_Up_Data_Context.Daily_Hour_Permits

                           join u in sql_Server_Db_From_Follow_Up_Data_Context.Users on dhp.User_Obj_Id equals u.Obj_Id
                           join d in sql_Server_Db_From_Follow_Up_Data_Context.Departments on dhp.Department_Obj_Id equals d.Obj_Id
                           /*join pr in sql_Server_Db_From_Follow_Up_Data_Context.Permit_Reasons on dhp.Permit_Reason_Obj_Id equals pr.Obj_Id*/
                           orderby dhp.Obj_Id descending
                           /*Where clause'unda bilgi işlem'i filtreliyoruz*/
                           where u.Department_Obj_Id == daily_Hour_Permit_Form.Department_Obj_Id
                           select new
                           {
                               Sıra = dhp.Obj_Id,
                               Ad_Soyad = u.Full_Name,
                               Sicil_Numarası = u.Registration_Number,
                               /*u.Department_Obj_Id.Value,*/
                               Departman_Adı = d.Name,
                               İzin_Başlangıç_Tarihi = dhp.Permit_Start_Time,
                               İzin_Bitiş_Tarihi = dhp.Permit_End_Time,
                               /*dhp.Permit_Type,*/
                               /*İzin_Sebebi = pr.Name,*/
                               //Bu_yıl_Hak_Edilen_İzin = u.This_Year_Permit_Count,
                               //Kullanılmış_İzin_Gün_Adedi = dhp.Permitted_Use_Knowledge_Data,
                               //Bakiye = dhp.Accumulated_Permit_count_Knowledge_Data
                           };
                fuGridControl1.DataSource = list;
            }

            if (daily_Hour_Permit_Form.Job_Title_TextEdit.Text.Contains("Direktör") == true)
            {
                var list = from dhp in sql_Server_Db_From_Follow_Up_Data_Context.Daily_Hour_Permits

                           join u in sql_Server_Db_From_Follow_Up_Data_Context.Users on dhp.User_Obj_Id equals u.Obj_Id
                           join d in sql_Server_Db_From_Follow_Up_Data_Context.Departments on dhp.Department_Obj_Id equals d.Obj_Id
                           /*join pr in sql_Server_Db_From_Follow_Up_Data_Context.Permit_Reasons on dhp.Permit_Reason_Obj_Id equals pr.Obj_Id*/
                           orderby dhp.Obj_Id descending
                           /*Where clause'unda bilgi işlem'i filtreliyoruz*/
                           where u.Department_Obj_Id == daily_Hour_Permit_Form.Department_Obj_Id
                           select new
                           {
                               Sıra = dhp.Obj_Id,
                               Ad_Soyad = u.Full_Name,
                               Sicil_Numarası = u.Registration_Number,
                               /*u.Department_Obj_Id.Value,*/
                               Departman_Adı = d.Name,
                               İzin_Başlangıç_Tarihi = dhp.Permit_Start_Time,
                               İzin_Bitiş_Tarihi = dhp.Permit_End_Time,
                               /*dhp.Permit_Type,*/
                               /*İzin_Sebebi = pr.Name,*/
                               //Bu_yıl_Hak_Edilen_İzin = u.This_Year_Permit_Count,
                               //Kullanılmış_İzin_Gün_Adedi = dhp.Permitted_Use_Knowledge_Data,
                               //Bakiye = dhp.Accumulated_Permit_count_Knowledge_Data
                           };
                fuGridControl1.DataSource = list;
            }


            /*Düz personel*/
            if (daily_Hour_Permit_Form.Job_Title_TextEdit.Text.Contains("Müdür") == false && daily_Hour_Permit_Form.Job_Title_TextEdit.Text.Contains("Yönetmen") == false && daily_Hour_Permit_Form.Job_Title_TextEdit.Text.Contains("Direktör") == false)
            {
                var list = from dhp in sql_Server_Db_From_Follow_Up_Data_Context.Daily_Hour_Permits

                           join u in sql_Server_Db_From_Follow_Up_Data_Context.Users on dhp.User_Obj_Id equals u.Obj_Id
                           join d in sql_Server_Db_From_Follow_Up_Data_Context.Departments on dhp.Department_Obj_Id equals d.Obj_Id
                           /*join pr in sql_Server_Db_From_Follow_Up_Data_Context.Permit_Reasons on dhp.Permit_Reason_Obj_Id equals pr.Obj_Id*/
                           orderby dhp.Obj_Id descending
                           /*Where clause'unda bilgi işlem'i filtreliyoruz*/
                           where u.Obj_Id == Login_Form.Login_User_Obj_Id
                           select new
                           {
                               Sıra = dhp.Obj_Id,
                               Ad_Soyad = u.Full_Name,
                               Sicil_Numarası = u.Registration_Number,
                               /*u.Department_Obj_Id.Value,*/
                               Departman_Adı = d.Name,
                               İzin_Başlangıç_Tarihi = dhp.Permit_Start_Time,
                               İzin_Bitiş_Tarihi = dhp.Permit_End_Time,
                               /*dhp.Permit_Type,*/
                               /*İzin_Sebebi = pr.Name,*/
                               //Bu_yıl_Hak_Edilen_İzin = u.This_Year_Permit_Count,
                               //Kullanılmış_İzin_Gün_Adedi = dhp.Permitted_Use_Knowledge_Data,
                               //Bakiye = dhp.Accumulated_Permit_count_Knowledge_Data
                           };
                fuGridControl1.DataSource = list;
            }

            

        }

        public void List_The_Daily_Hour_Permit_For_Permit_Type()
        {
            /* 
             * Kullanıcı girişine göre ekrana data dolduyoruz
             * Şimdilik sadece
             * B.Sükan
             * İ.Dölek
             */
            //if (Login_Form.Login_User_Obj_Id == 15 || Login_Form.Login_User_Obj_Id == 28)
            //{
                var list = from dhp in sql_Server_Db_From_Follow_Up_Data_Context.Daily_Hour_Permits

                           join u in sql_Server_Db_From_Follow_Up_Data_Context.Users on dhp.User_Obj_Id equals u.Obj_Id
                           join d in sql_Server_Db_From_Follow_Up_Data_Context.Departments on dhp.Department_Obj_Id equals d.Obj_Id
                           join pr in sql_Server_Db_From_Follow_Up_Data_Context.Permit_Reasons on dhp.Permit_Reason_Obj_Id equals pr.Obj_Id
                           orderby u.Obj_Id
                           where dhp.Permit_Type.Contains(Permit_Type_ComboBoxEdit.Text)
                           select new
                           {
                               Sıra = dhp.Obj_Id,
                               Ad_Soyad = u.Full_Name,
                               Sicil_Numarası = u.Registration_Number,
                               /*u.Department_Obj_Id.Value,*/
                               Departman_Adı = d.Name,
                               İzin_Başlangıç_Tarihi = dhp.Permit_Start_Time,
                               İzin_Bitiş_Tarihi = dhp.Permit_End_Time,
                               /*dhp.Permit_Type,*/
                               İzin_Sebebi = pr.Name
                           };
                fuGridControl1.DataSource = list;
            //}
        }

        /// <summary>
        /// Ekrandan Filtreleme Query'si 
        /// 2015_03_04:16_15
        /// Departman bilgisini filtreliyoruz
        /// </summary>
        public void List_The_Daily_Hour_Permit_Department_Type()
        {
            var list = from dhp in sql_Server_Db_From_Follow_Up_Data_Context.Daily_Hour_Permits

                       join u in sql_Server_Db_From_Follow_Up_Data_Context.Users on dhp.User_Obj_Id equals u.Obj_Id
                       join d in sql_Server_Db_From_Follow_Up_Data_Context.Departments on dhp.Department_Obj_Id equals d.Obj_Id
                       join pr in sql_Server_Db_From_Follow_Up_Data_Context.Permit_Reasons on dhp.Permit_Reason_Obj_Id equals pr.Obj_Id
                       orderby u.Obj_Id
                       where d.Name.Contains(Department_Type_ComboBoxEdit.Text)
                       select new
                       {
                           Sıra = dhp.Obj_Id,
                           Ad_Soyad = u.Full_Name,
                           Sicil_Numarası = u.Registration_Number,
                           /*u.Department_Obj_Id.Value,*/
                           Departman_Adı = d.Name,
                           İzin_Başlangıç_Tarihi = dhp.Permit_Start_Time,
                           İzin_Bitiş_Tarihi = dhp.Permit_End_Time,
                           /*dhp.Permit_Type,*/
                           İzin_Sebebi = pr.Name
                       };
            fuGridControl1.DataSource = list;
        }

        private void Daily_Hour_Permit_List_Form_Load(object sender, EventArgs e)
        {
            List_The_Daily_Hour_Permit();
        }

        /// <summary>
        /// Description: gird'in satırındaki veriyi silmek için
        /// </summary>
        private void gridControl1_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == NavigatorButtonType.Remove)
            {
                if (MessageBox.Show("Satırdaki veriyi sileceksin", "Eminmisin Alloooo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) != DialogResult.Yes) e.Handled = true;
                {
                    /*
                     * Şimdilik ekrandan kayboluyor. Ekran bir daha açıldığında data doluyor.
                     * Eğer datayı db'den de silmek isityorsan buraya yaz ilgili kodu.
                     */
                }
            }
        }

        private void Permit_Type_ComboBoxEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            List_The_Daily_Hour_Permit_For_Permit_Type();
        }

        private void Department_Type_ComboBoxEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            List_The_Daily_Hour_Permit_Department_Type();
        }

        /// <summary>
        /// Öz izleme ekanını açıyoruz.
        /// </summary>
        private void Preview_SimpleButton_Click(object sender, EventArgs e)
        {
            //gridView1.ShowPrintPreview();
            fuGridControl1.ShowPrintPreview();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Choose_The_Record();

            if (Choose && Choose_Obj_Id > 0)
            {
                MainMDIForm.Cross = Choose_Obj_Id;
                this.Close();
            }
        }

        public static DataRow Get_Selected_Data_Row(GridView gridView, GridControl gridControl)
        {
            BindingManagerBase bindingManagerBase = gridControl.BindingContext[gridControl.DataSource, gridControl.DataMember];
            if (gridView.SelectedRowsCount > 0 && bindingManagerBase.Position != -1)
            {
                return ((DataRowView)bindingManagerBase.Current).Row;
            }
            return null;
        }

        public void Choose_The_Record()
        {
            try
            {
                Choose_Obj_Id = int.Parse(gridView1.GetFocusedRowCellValue("Sıra").ToString());
            }
            catch (Exception exception)
            {
                Choose_Obj_Id = -1;
            }
        }

        private void fuGridControl1_DoubleClick(object sender, EventArgs e)
        {
            Choose_The_Record();

            if (Choose && Choose_Obj_Id > 0)
            {
                MainMDIForm.Cross = Choose_Obj_Id;
                this.Close();
            }
        }

        private void Clean_SimpleButton_Click(object sender, EventArgs e)
        {
            Department_Type_ComboBoxEdit.Text = string.Empty;
            Permit_Type_ComboBoxEdit.Text = string.Empty;
        }

        private void fuGridControl1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < gridView1.Columns.Count; i++) gridView1.Columns[i].BestFit();
        }
    }
}