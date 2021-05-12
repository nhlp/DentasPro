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
    using Dentas_Pro.Framework;

    /// <summary>
    /// 2015.01.25_İrfan_dölek
    /// Lokasyon kayıt formu(İş yeri de bunun içine giriyor)
    /// Denizli, Adana, İzmit Satış
    /// </summary>
    public partial class Location_Form : Base_Form
    {
        public Location_Form()
        {
            InitializeComponent();
        }

        DAL_Function.Sql_Server_DB_From_DentasProDataContext sql_Server_Db_From_Follow_Up_Data_context = new DAL_Function.Sql_Server_DB_From_DentasProDataContext();
        DAL_Function.Messages messages = new DAL_Function.Messages();
        Generator.Generate_Id generator_Id = new Generator.Generate_Id();

        public bool Choose = false;
        public bool Edit = false;
        public int Choose_Obj_Id = -1;

        private void Location_Form_Load(object sender, EventArgs e)
        {
            Get_The_Location_List();
            Location_Code_TextEdit.Text = generator_Id.Generate_The_Unique_Id_For_Location_Id();
        }

        public void Get_The_Location_List()
        {
            var Get_The_User_Location = from s in sql_Server_Db_From_Follow_Up_Data_context.Locations
                                        select s;

            Location_GridControl.DataSource = Get_The_User_Location;
        }

        public void Clean_The_Control()
        {
            Location_Code_TextEdit.Text = string.Empty;
            Location_Name_TextEdit.Text = string.Empty;
            Location_Description_MemoEdit.Text = string.Empty;

            Get_The_Location_List();
        }

        public void Get_Data_From_UI()
        {
            try
            {
                DAL_Function.Location location = new DAL_Function.Location();

                location.Code = Location_Code_TextEdit.Text;
                location.Name = Common_Methods.Fitst_Letter_Upper_Case_Other_Lower(Location_Name_TextEdit.Text);
                location.Description = Common_Methods.Fitst_Letter_Upper_Case_Other_Lower(Location_Description_MemoEdit.Text);
                location.Insert_Time = DateTime.Now;
                location.Insert_User = Login_Form.Login_User_Obj_Id;

                sql_Server_Db_From_Follow_Up_Data_context.Locations.InsertOnSubmit(location);
                sql_Server_Db_From_Follow_Up_Data_context.SubmitChanges();

                messages.New_Record("Yeni lokasyon kaydı başarı ile yapıldı");

                Clean_The_Control();
            }
            catch (Exception exception)
            {
                messages.Error(exception);
            }
        }

        public void Update_Data_From_Db()
        {
            try
            {
                DAL_Function.Location location = sql_Server_Db_From_Follow_Up_Data_context.Locations.First(s => s.Obj_Id == Choose_Obj_Id);

                location.Code = Location_Code_TextEdit.Text;
                location.Name = Common_Methods.Fitst_Letter_Upper_Case_Other_Lower(Location_Name_TextEdit.Text);
                location.Description = Common_Methods.Fitst_Letter_Upper_Case_Other_Lower(Location_Description_MemoEdit.Text);

                location.Update_User = Login_Form.Login_User_Obj_Id;
                location.Update_Time = DateTime.Now;

                sql_Server_Db_From_Follow_Up_Data_context.SubmitChanges();
                messages.Update(true);
                Clean_The_Control();
            }
            catch (Exception exception)
            {
                messages.Error(exception);
            }

        }

        public void Choose_The_Record()
        {
            try
            {
                Edit = true;

                Choose_Obj_Id = int.Parse(gridView1.GetFocusedRowCellValue("Obj_Id").ToString());

                Location_Code_TextEdit.Text = gridView1.GetFocusedRowCellValue("Code").ToString();
                Location_Name_TextEdit.Text = gridView1.GetFocusedRowCellValue("Name").ToString();
                Location_Description_MemoEdit.Text = gridView1.GetFocusedRowCellValue("Description").ToString();

            }
            catch (Exception exception)
            {
                Edit = false;
                Choose_Obj_Id = -1;
            }
        }

        public void Delete_The_Record()
        {
            try
            {

                sql_Server_Db_From_Follow_Up_Data_context.Locations.DeleteOnSubmit(sql_Server_Db_From_Follow_Up_Data_context.Locations.First(s => s.Obj_Id == Choose_Obj_Id));
                sql_Server_Db_From_Follow_Up_Data_context.SubmitChanges();
                Clean_The_Control();

            }
            catch (Exception exception)
            {
                messages.Error(exception);
            }
        }

        
       

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
            if (Edit && Choose_Obj_Id > 0 && messages.Delete() == DialogResult.Yes)
            {
                Delete_The_Record();
            }
        }

        private void gridView1_DoubleClick_1(object sender, EventArgs e)
        {
            Choose_The_Record();
            if (Choose && Choose_Obj_Id > 0)
            {
                MainMDIForm.Cross = Choose_Obj_Id;
                this.Close();
            }
        }








    }
}