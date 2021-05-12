namespace Dentas_Pro.UI.Permit
{
    using Dentas_Pro.UI.Base;
    using Dentas_Pro.UI.DAL_Function;
    using Dentas_Pro.UI.User;
    using DevExpress.XtraEditors;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;


    /// <summary>
    /// Onay beyleyenler listesi
    /// </summary>
    public partial class Wating_Approval_List_Form_Old : XtraForm
    {
        public Wating_Approval_List_Form_Old()
        {
            InitializeComponent();
            Get_Waiting_Approval_List_();
            Is_Mannager();
            Set_The_GridColumn_Visible();
        }

        public bool Choose = false;
        /// <summary>
        /// Seçilen
        /// </summary>
        public int Choose_Obj_Id = -1;
        public int Annual_Permit_Obj_Id = -1;


        DAL_Function.Sql_Server_DB_From_DentasProDataContext sql_Server_Db_From_DentasPro_Data_Context = new Sql_Server_DB_From_DentasProDataContext();
        DAL_Function.Get_The_Form get_The_Forms = new DAL_Function.Get_The_Form();
        DAL_Function.Messages messages = new Messages();



        public void Get_Waiting_Approval_List_()
        {
            Annual_Permit_Form annual_Permit_Form = new Annual_Permit_Form();

            var list = from ap in sql_Server_Db_From_DentasPro_Data_Context.Annual_Permits

                       join u in sql_Server_Db_From_DentasPro_Data_Context.Users on ap.User_Obj_Id equals u.Obj_Id
                       join d in sql_Server_Db_From_DentasPro_Data_Context.Departments on ap.Department_Obj_Id equals d.Obj_Id
                       /*join pr in sql_Server_Db_From_Follow_Up_Data_Context.Permit_Reasons on ap.Permit_Reason_Obj_Id equals pr.Obj_Id*/
                       orderby ap.Obj_Id descending
                       /*Where clause'unda bilgi işlem'i filtreliyoruz*/
                       where u.Department_Obj_Id == annual_Permit_Form.Department_Obj_Id
                       select new
                       {
                           Sıra = ap.Obj_Id,
                           Ad_Soyad = u.Full_Name,
                           Sicil_Numarası = u.Registration_Number,
                           /*u.Department_Obj_Id.Value,*/
                           Departman_Adı = d.Name,
                           İzin_Başlangıç_Tarihi = ap.Permit_Start_Time,
                           İzin_Bitiş_Tarihi = ap.Permit_End_Time,
                           /*ap.Permit_Type,*/
                           /*İzin_Sebebi = pr.Name,*/
                           //Bu_yıl_Hak_Edilen_İzin = u.This_Year_Permit_Count,
                           Kullanılmış_İzin_Gün_Adedi = ap.Permitted_Use_Knowledge_Data,
                           Bakiye = ap.Accumulated_Permit_count_Knowledge_Data
                       };

            gridControl1.DataSource = list;
        }


        /// <summary>
        /// Hangi yönetici seviyesi giriyorsa ona göre kolonlar açılsın veya edit'i false olsun.
        /// </summary>
        public void Is_Mannager()
        {
            if (UI.Base.Login_Form.Login_User_Obj_Id == 1)
            {
                //Index 3-4 Yönetmen Onay - Not 
                //Index 5-6 Müdür Onay - Not 
                //Index 7-8 IK Onay - Not 

                gridView1.Columns[5].Visible = false;
                gridView1.Columns[6].Visible = false;
                gridView1.Columns[7].Visible = false;
                gridView1.Columns[8].Visible = false;
            }
        }

        public void Set_The_GridColumn_Visible()
        {

            /*Çağatay, Armağan, Celal, Fatma, Tuğba, */
            if (Login_Form.Login_User_Obj_Id == 8 || Login_Form.Login_User_Obj_Id == 9 || Login_Form.Login_User_Obj_Id == 13 || Login_Form.Login_User_Obj_Id == 16 || Login_Form.Login_User_Obj_Id == 17)
            {
                gridView1.Columns[3].Visible = false;
                gridView1.Columns[4].Visible = false;
                gridView1.Columns[5].Visible = false;
                gridView1.Columns[6].Visible = false;
                gridView1.Columns[7].Visible = true;
                gridView1.Columns[8].Visible = true;
            }
            Login_Form login_form = new Login_Form();

            if (login_form.Get_Title_Id() == 5)
            {
                gridView1.Columns[3].Visible = false;
                gridView1.Columns[4].Visible = false;
                gridView1.Columns[5].Visible = false;
                gridView1.Columns[6].Visible = false;
                gridView1.Columns[7].Visible = true;
                gridView1.Columns[8].Visible = true;
            }


            //Title bilgisi Login formdaki Get_Title_Id dan geliyor. Dolayısıyla Title'a grid'in yönetici kontrollerinin visible'ını false veya trua yap.
            //Login_Form login_form = new Login_Form();

            //var query = from l in Login_Form.Login_User_Obj_Id
            //            join u in sql_Server_Db_From_DentasPro_Data_Context.Users on Login_Form.Login_User_Obj_Id equals u.Obj_Id
            //            select new
            //            {
            //                u.Obj_Id
            //            };

            //if (this.Job_Title_TextEdit.Text.Contains("Direktör") == true)
            //{
            //    gridView1.Columns[3].Visible = false;
            //    gridView1.Columns[4].Visible = false;
            //    gridView1.Columns[5].Visible = false;
            //    gridView1.Columns[6].Visible = false;
            //    gridView1.Columns[7].Visible = true;
            //    gridView1.Columns[8].Visible = true;

            //}

            //if (this.Job_Title_TextEdit.Text.Contains("Müdür") == true)
            //{
            //    gridView1.Columns[3].Visible = false;
            //    gridView1.Columns[4].Visible = false;
            //    gridView1.Columns[5].Visible = false;
            //    gridView1.Columns[6].Visible = false;
            //    gridView1.Columns[7].Visible = true;
            //    gridView1.Columns[8].Visible = true;


            //}

            //if (this.Job_Title_TextEdit.Text.Contains("Yönetmen") == true)
            //{
            //    gridView1.Columns[3].Visible = false;
            //    gridView1.Columns[4].Visible = false;
            //    gridView1.Columns[5].Visible = false;
            //    gridView1.Columns[6].Visible = false;
            //    gridView1.Columns[7].Visible = true;
            //    gridView1.Columns[8].Visible = true;


            //}

            //if (this.Job_Title_TextEdit.Text.Contains("Direktör") == false || this.Job_Title_TextEdit.Text.Contains("Müdür") == false || this.Job_Title_TextEdit.Text.Contains("Yönetmen") == true)
            //{
            //    gridView1.Columns[3].Visible = false;
            //    gridView1.Columns[4].Visible = false;
            //    gridView1.Columns[5].Visible = false;
            //    gridView1.Columns[6].Visible = false;
            //    gridView1.Columns[7].Visible = true;
            //    gridView1.Columns[8].Visible = true;


            //}
        }


    }
}
