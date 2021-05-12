/*İzin sebebi kayıt formu*/
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
    using Dentas_Pro.Framework;

    /*İzin türleri kayıt formu*/
    public partial class Permit_Reason_Form : Base_Form
    {
        public Permit_Reason_Form()
        {
            InitializeComponent();
        }

        DAL_Function.Sql_Server_DB_From_DentasProDataContext sql_Server_DB_From_DentasProDataContext = new DAL_Function.Sql_Server_DB_From_DentasProDataContext();
        DAL_Function.Messages messages = new DAL_Function.Messages();
        Generator.Generate_Id generator_Id = new Generator.Generate_Id();


        public bool Choose = false;
        public bool Edit = false;
        public int Choose_Id = -1;


        private void Permit_Type_Form_Load(object sender, EventArgs e)
        {
            Get_The_Permit_Reason_List();
            Permit_Reason_Code_TextEdit.Text = generator_Id.Generate_The_Unique_Id_For_Permit_Reason_Id();
        }


        #region Description
        /*dikkat edersen studio tablo adının sonuna fazladan "s" koydu.*/
        #endregion
        public void Get_The_Permit_Reason_List()
        {
            var Get_The_Permit_Reason = from s in sql_Server_DB_From_DentasProDataContext.Permit_Reasons
                                        select s;

            Permit_Reason_GridControl.DataSource = Get_The_Permit_Reason;
        }

        public void Clean_The_Control()
        {
            Permit_Reason_Code_TextEdit.Text = string.Empty;
            Permit_Reason_Name_TextEdit.Text = string.Empty;
            Permit_Reason_Description_MemoEdit.Text = string.Empty;

            Get_The_Permit_Reason_List();
        }

        public void Get_Data_From_UI()
        {
            try
            {
                DAL_Function.Permit_Reason permit_Reason = new DAL_Function.Permit_Reason();

                permit_Reason.Code = Permit_Reason_Code_TextEdit.Text;
                permit_Reason.Name = Common_Methods.Fitst_Letter_Upper_Case_Other_Lower(Permit_Reason_Name_TextEdit.Text);
                permit_Reason.Description = Common_Methods.Fitst_Letter_Upper_Case_Other_Lower(Permit_Reason_Description_MemoEdit.Text);
                permit_Reason.Insert_User = Login_Form.Login_User_Obj_Id;
                permit_Reason.Insert_Time = DateTime.Now;
                sql_Server_DB_From_DentasProDataContext.Permit_Reasons.InsertOnSubmit(permit_Reason);
                sql_Server_DB_From_DentasProDataContext.SubmitChanges();

                messages.New_Record("Yeni izin türü kaydı yapıldı");
                Clean_The_Control();
            }
            catch (Exception exception)
            {
                messages.Error(exception);
            }
        }

        public void Update_The_Record()
        {
            try
            {
                DAL_Function.Permit_Reason permitReason = sql_Server_DB_From_DentasProDataContext.Permit_Reasons.First(s => s.Obj_Id == Choose_Id);

                permitReason.Code = Permit_Reason_Code_TextEdit.Text;
                permitReason.Name = Common_Methods.Fitst_Letter_Upper_Case_Other_Lower(Permit_Reason_Name_TextEdit.Text);
                permitReason.Description = Common_Methods.Fitst_Letter_Upper_Case_Other_Lower(Permit_Reason_Description_MemoEdit.Text);
                
                permitReason.Update_User = Login_Form.Login_User_Obj_Id;
                permitReason.Update_Time = DateTime.Now;

                sql_Server_DB_From_DentasProDataContext.SubmitChanges();
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

                Choose_Id = int.Parse(gridView1.GetFocusedRowCellValue("Obj_Id").ToString());

                Permit_Reason_Code_TextEdit.Text = gridView1.GetFocusedRowCellValue("Code").ToString();
                Permit_Reason_Name_TextEdit.Text = gridView1.GetFocusedRowCellValue("Name").ToString();
                Permit_Reason_Description_MemoEdit.Text = gridView1.GetFocusedRowCellValue("Description").ToString();

            }
            catch (Exception exception)
            {
                Edit = false;
                Choose_Id = -1;
            }
        }

        public void Delete_The_Record()
        {
            try
            {
                sql_Server_DB_From_DentasProDataContext.Permit_Reasons.DeleteOnSubmit(sql_Server_DB_From_DentasProDataContext.Permit_Reasons.First(s => s.Obj_Id == Choose_Id));
                sql_Server_DB_From_DentasProDataContext.SubmitChanges();
                Clean_The_Control();
            }
            catch (Exception exception)
            {
                messages.Error(exception);
            }

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Choose_The_Record();
            if (Choose && Choose_Id > 0)
            {
                MainMDIForm.Cross = Choose_Id;
                this.Close();
            }
        }

        #region Cruds Actions

        private void Save_SimpleButton_Click(object sender, EventArgs e)
        {
            if (Edit && Choose_Id > 0 && messages.Update() == DialogResult.Yes)
            {
                Update_The_Record();
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
            Delete_The_Record();
        }

        #endregion

        

        
    }
}