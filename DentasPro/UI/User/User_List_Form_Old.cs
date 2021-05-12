/*Kullanıcı Listesi ekranı*/
namespace Dentas_Pro.UI.User
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Data.Linq;
    using System.Data;
    using System.Drawing;
    using System.Text;
    using System.Windows.Forms;
    
    using DevExpress.XtraEditors;
    using Dentas_Pro.UI.Base;


    public partial class User_List_Form_Old : Base_Form
    {
        DAL_Function.Sql_Server_DB_From_DentasProDataContext sql_server_Db_From_DentasProDataContext = new DAL_Function.Sql_Server_DB_From_DentasProDataContext();


        public bool Choose = false;
        public int Choose_Id = -1;

        public User_List_Form_Old()
        {
            InitializeComponent();
        }

        public void Get_The_List() 
        {

            var list = from s in sql_server_Db_From_DentasProDataContext.Users
                       #region Description
                       /*
                        * Text box larda arama yapabilmek için
                        * Contains() sql serverdaki like gibi düşünebilirsin
                        * s.Name.Contains(User_Name_TextEdit.Text)
                        * s.Name'in içindeki ile --> User_Name_TextEdit.Text içindekine like gibi bakıyor.
                        */
                       #endregion
                       where s.Name.Contains(User_Name_TextEdit.Text)    /*&& s.Civilization_Number.GetValueOrDefault(User_Citizen_Id_TextEdit.Text)*/
                       select s;
                

            User_List_GridControl.DataSource = list;
        }

        private void Search_SimpleButton_Click(object sender, EventArgs e)
        {
            Get_The_List();
        }

        private void Clean_SimpleButton_Click(object sender, EventArgs e)
        {
            User_Citizen_Id_TextEdit.Text = string.Empty;
            User_Name_TextEdit.Text = string.Empty;
            Registration_Number_TextEdit.Text = string.Empty;
        }

        #region Description
        /*Grid'in double klik event'inde seçme yapıyoruz.*/
        #endregion
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Chooce_The_Record();
            if (Choose && Choose_Id > 0)
            {
                MainMDIForm.Cross = Choose_Id;
                this.Close();
            }
        }


        #region Description
        /*
         * 1_1:48
         * Bu metod kayıtları seçmek için kullanılıyor
         */

        #endregion
        private void Chooce_The_Record() 
        {
            try
            {
                Choose_Id = int.Parse(gridView1.GetFocusedRowCellValue("Obj_Id").ToString());
            }
            catch (Exception)
            {

                Choose_Id = -1;
            }

        }


        #region Description
        /*Bu form her açıldığında içindeki kod icra olur. Bütün formlar Load metodu aynıdır.*/
        #endregion
        private void User_List_Form_Load(object sender, EventArgs e)
        {
            Get_The_List();
        }

    }
}