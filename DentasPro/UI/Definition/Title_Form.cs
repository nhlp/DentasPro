/*Ünvan kayıt ekranı*/
namespace Dentas_Pro.UI.User
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Text;
    using System.Windows.Forms;
    using System.Linq;

    using DevExpress.XtraEditors;
    using Dentas_Pro.UI.Base;
    using Dentas_Pro.Framework;

    /// <summary>
    /// Ünvan, görevv tanımı
    /// </summary>
    public partial class Title_Form : Base_Form
    {
        public Title_Form()
        {
            InitializeComponent();
        }

        DAL_Function.Sql_Server_DB_From_DentasProDataContext sql_Server_Db_From_Follow_Up_Data_Context = new DAL_Function.Sql_Server_DB_From_DentasProDataContext();
        DAL_Function.Messages messages = new DAL_Function.Messages();
        Generator.Generate_Id generator_Id = new Generator.Generate_Id();



        public bool Choose = false;
        public bool Edit = false;
        public int Choose_Id = -1;
        public int Title_Obj_Id;
        public bool Is_Active = true;


        /// <summary>
        /// Form load olur iken içindeki metod icra oluyor. Yani Grid dolduruluyor.
        /// </summary>
        private void User_Title_Register_Load(object sender, EventArgs e)
        {
            Get_The_List();
            Title_Code_TextEdit.Text = generator_Id.Generate_The_Unique_Id_For_Title_Id();

        }

        public void Get_The_List()
        {
            var Get_The_Title = from s in sql_Server_Db_From_Follow_Up_Data_Context.Titles
                                select s;

            Title_GridControl.DataSource = Get_The_Title;

        }

        public void Clean_The_Control()
        {
            Title_Code_TextEdit.Text = string.Empty;
            Title_Name_TextEdit.Text = string.Empty;
            Title_Description_MemoEdit.Text = string.Empty;
            Edit = false;
            Get_The_List();
        }

        public void Choose_the_Record()
        {
            try
            {
                Edit = true;
                Choose_Id = int.Parse(gridView1.GetFocusedRowCellValue("Obj_Id").ToString());
                Title_Code_TextEdit.Text = gridView1.GetFocusedRowCellValue("Code").ToString();
                Title_Name_TextEdit.Text = gridView1.GetFocusedRowCellValue("Name").ToString();
                Title_Description_MemoEdit.Text = gridView1.GetFocusedRowCellValue("Description").ToString();

            }
            catch (Exception exception)
            {
                Edit = false;
                Choose_Id = -1;
            }
        }

        public void Update_Data_From_Db()
        {
            try
            {
                DAL_Function.Title title = sql_Server_Db_From_Follow_Up_Data_Context.Titles.First(s => s.Obj_Id == Choose_Id);

                title.Code = Title_Code_TextEdit.Text;
                title.Name = Common_Methods.Fitst_Letter_Upper_Case_Other_Lower(Title_Name_TextEdit.Text);
                title.Description = Common_Methods.Fitst_Letter_Upper_Case_Other_Lower(Title_Description_MemoEdit.Text);
                title.Update_User = Login_Form.Login_User_Obj_Id;
                title.Update_Time = DateTime.Now.ToString();

                sql_Server_Db_From_Follow_Up_Data_Context.SubmitChanges();
                messages.Update(true);
                Clean_The_Control();
            }
            catch (Exception exception)
            {
                messages.Error(exception);
            }
        }

        public void Get_Data_From_UI()
        {
            try
            {
                DAL_Function.Title title = new DAL_Function.Title();



                //if (Title_Code_TextEdit.Text == "" && Title_Code_TextEdit.Text == null) ;
                //{
                //    MessageBox.Show("Ünvan kodunu boş geçemezsiniz");
                //    return;
                //}

                //if (string.IsNullOrEmpty(Title_Name_TextEdit.Text)) ;
                //{
                //    MessageBox.Show("Ünvan adını boş geçemezsiniz");
                //    return;
                //}



                title.Code = Title_Code_TextEdit.Text;
                title.Name = Common_Methods.Fitst_Letter_Upper_Case_Other_Lower(Title_Name_TextEdit.Text);
                title.Description = Common_Methods.Fitst_Letter_Upper_Case_Other_Lower(Title_Description_MemoEdit.Text);
                title.Insert_Time = DateTime.Now;
                title.Insert_User = Login_Form.Login_User_Obj_Id;
                title.Is_Active = true;

                sql_Server_Db_From_Follow_Up_Data_Context.Titles.InsertOnSubmit(title);
                sql_Server_Db_From_Follow_Up_Data_Context.SubmitChanges();
                messages.New_Record("Yeni ünvan kaydınız başarı ile yapıldı..");
                Clean_The_Control();

            }
            catch (Exception exception)
            {
                messages.Error(exception);
            }
        }

        private void Save_SimpleButton_Click(object sender, EventArgs e)
        {
            if (Edit && Choose_Id > 0 && messages.Update() == DialogResult.Yes)
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
            if (Edit && Choose_Id > 0 && messages.Delete() == DialogResult.Yes)
            {
                Delete_The_Record();
            }

            #region Description
            // old code --> 2015_01_13_16_31 By: İrfan Dölek-- Kod çalışıyor
            //try
            //{
            //    sql_Server_Db_From_Follow_Up_Data_Context.Titles.DeleteOnSubmit(sql_Server_Db_From_Follow_Up_Data_Context.Titles.First(s => s.Obj_Id == Choose_Id));
            //}
            //catch (Exception exception)
            //{
            //    messages.Error(exception);
            //}
            #endregion
        }

        /// <summary>
        /// Grid'de çift klik yapınca.
        /// </summary>
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Choose_the_Record();
            if (Choose && Choose_Id > 0)
            {
                MainMDIForm.Cross = Choose_Id;
                this.Close();
            }
        }

        public void Delete_The_Record()
        {
            try
            {
                sql_Server_Db_From_Follow_Up_Data_Context.Titles.DeleteOnSubmit(sql_Server_Db_From_Follow_Up_Data_Context.Titles.First(s => s.Obj_Id == Choose_Id));
                sql_Server_Db_From_Follow_Up_Data_Context.SubmitChanges();
                Clean_The_Control();
            }
            catch (Exception exception)
            {
                messages.Error(exception);
            }
        }

    }
}