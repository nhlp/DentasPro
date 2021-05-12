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

    /// <summary>
    /// Kullanıcı - Personel kayıt formu
    /// </summary>
    public partial class User_List_Form : Base_Form
    {
        public User_List_Form()
        {
            InitializeComponent();

        }

        DAL_Function.Sql_Server_DB_From_DentasProDataContext sql_Server_Db_From_Follow_Up_Data_Context = new DAL_Function.Sql_Server_DB_From_DentasProDataContext();


        public bool Choose = false;
        public int Choose_Obj_Id = -1;

        /// <summary>
        /// Listele
        /// 2_1_25_00
        /// </summary>
        public void List_the_User() 
        {
            var list = from u in sql_Server_Db_From_Follow_Up_Data_Context.Users

                       join d in sql_Server_Db_From_Follow_Up_Data_Context.Departments on u.Department_Obj_Id equals d.Obj_Id
                       join t in sql_Server_Db_From_Follow_Up_Data_Context.Titles on u.Title_Obj_Id equals t.Obj_Id

                       orderby u.Obj_Id

                       select new
                       {
                                       u.Obj_Id,
                           Ad_Soyad  = u.Full_Name,
                           Sicil     = u.Registration_Number,
                           Ünvan     = t.Name,
                           Departman = d.Name,
                           E_Mail    = u.E_Mail
                       };

            User_List_GridControl.DataSource = list;

            //var User_List = from s in sql_Server_Db_From_Follow_Up_Data_Context.Users
            //                /*where s.Name.Contains(User_Name_TextEdit.Text) && s.Registration_Number.Contains(Registration_Number_TextEdit.Text)*/
            //                select new
            //                {
            //                    s.Full_Name,
            //                    s.Registration_Number,
            //                    s.Phone_Number_Area_Code,
            //                    s.Phone_Number
            //                };

            //User_List_GridControl.DataSource = User_List;
        }

        /// <summary>
        /// Sec
        /// 2_1_26_30
        /// </summary>
        public void Choose_The_Record() 
        {
            try
            {
                Choose_Obj_Id = int.Parse(gridView1.GetFocusedRowCellValue("Obj_Id").ToString());
            }
            catch (Exception exception)
            {
                Choose_Obj_Id = -1;
            } 
        }

        private void User_List_Form_Load(object sender, EventArgs e)
        {
            List_the_User();
        }


        /// <summary>
        /// 2_1_27_20
        /// </summary>
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Choose_The_Record();

            if (Choose && Choose_Obj_Id > 0)
            {
                MainMDIForm.Cross = Choose_Obj_Id;
                this.Close();
            }

        }

        private void User_List_GridControl_DoubleClick(object sender, EventArgs e)
        {
            
            Choose_The_Record();

            if (Choose && Choose_Obj_Id > 0)
            {
                MainMDIForm.Cross = Choose_Obj_Id;
                this.Close();
            }
        }

        private void User_List_GridControl_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < gridView1.Columns.Count; i++) gridView1.Columns[i].BestFit();
        }

    }
}