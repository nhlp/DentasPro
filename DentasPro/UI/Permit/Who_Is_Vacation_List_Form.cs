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
    using DevExpress.XtraGrid.Views.Grid;
    using DevExpress.XtraGrid;
    using DevExpress.XtraGrid.Columns;
    using System.Data.SqlClient;

    #region Bu Ekrana kimler girebilir
    /*
     * Sadece yöneticiler girebilir.
     */
    #endregion

    /// <summary>
    /// Yıllık izin formlarının listesi
    /// </summary>
    public partial class Who_Is_Vacation_List_Form : Base_Form
    {
        public Who_Is_Vacation_List_Form()
        {
            InitializeComponent();
            Annual_Date_DateEdit.Text = (DateTime.Now.Date).ToString("dd.MM.yyyy");
            Get_The_Sales_Person_Annual_List_Data();
            Department_Set_Which_Department_Staff_In();
        }

        /// <summary>
        /// Satış - Pazarlama
        /// </summary>
        private void Get_The_Sales_Person_Annual_List_Data()
        {

        }


        DAL_Function.Sql_Server_DB_From_DentasProDataContext sql_Server_Db_From_Follow_Up_Data_Context = new DAL_Function.Sql_Server_DB_From_DentasProDataContext();
        DAL_Function.Get_The_Form get_The_Forms = new DAL_Function.Get_The_Form();


        public bool Choose = false;
        /// <summary>
        /// Seçilen
        /// </summary>
        public int Choose_Obj_Id = -1;
        public int Annual_Permit_Obj_Id = -1;

        /// <summary>
        /// Müdür onayı için filtreleme
        /// </summary>


        /// <summary>
        /// Ekran ilk açılırken Grid'i dolduruyoruz.
        /// İzin türüne göre listeleme yapıyoruz.
        /// </summary>
        public void List_The_Annual_Permit_For_Permit_Type()
        {

            var list = from ap in sql_Server_Db_From_Follow_Up_Data_Context.Annual_Permits

                       join u in sql_Server_Db_From_Follow_Up_Data_Context.Users on ap.User_Obj_Id equals u.Obj_Id
                       join d in sql_Server_Db_From_Follow_Up_Data_Context.Departments on ap.Department_Obj_Id equals d.Obj_Id
                       /*join pr in sql_Server_Db_From_Follow_Up_Data_Context.Permit_Reasons on ap.Permit_Reason_Obj_Id equals pr.Obj_Id*/
                       orderby ap.Permit_Start_Time descending
                       //where d.Name.Contains(Department_Type_ComboBoxEdit.Text)
                       where ap.Permit_Start_Time.Value == DateTime.Parse( (Annual_Date_DateEdit.Text))
                       select new
                       {
                           //Sıra = ap.Obj_Id,
                           Ad_Soyad = u.Full_Name,
                           Sicil_Numarası = u.Registration_Number,
                           Departman_Adı = d.Name,
                           İzin_Başlangıç_Tarihi = ap.Permit_Start_Time,
                           İzin_Bitiş_Tarihi = ap.Permit_End_Time,
                           Cep_Telefonu = u.Cell_Phone_Area_Code + u.Cell_Phone_Number,
                           //Kullanılmış_İzin_Gün_Adedi = ap.Permitted_Use_Knowledge_Data,
                           //Bakiye = ap.Accumulated_Permit_count_Knowledge_Data
                       };
            fuGridControl1.DataSource = list;
        }


        /// <summary>
        /// Ekrandan Filtreleme Query'si 
        /// 2015_03_04:16_15
        /// Departman bilgisini filtreliyoruz
        /// </summary>
        public void List_The_Annual_Permit_Department_Type()
        {
            var list = from ap in sql_Server_Db_From_Follow_Up_Data_Context.Annual_Permits

                       join u in sql_Server_Db_From_Follow_Up_Data_Context.Users on ap.User_Obj_Id equals u.Obj_Id
                       join d in sql_Server_Db_From_Follow_Up_Data_Context.Departments on ap.Department_Obj_Id equals d.Obj_Id
                       /*join pr in sql_Server_Db_From_Follow_Up_Data_Context.Permit_Reasons on ap.Permit_Reason_Obj_Id equals pr.Obj_Id*/
                       orderby ap.Permit_Start_Time descending
                       where d.Name.Contains(Department_Type_ComboBoxEdit.Text)
                       select new
                       {
                           //Sıra = ap.Obj_Id,
                           Ad_Soyad = u.Full_Name,
                           Sicil_Numarası = u.Registration_Number,
                           Departman_Adı = d.Name,
                           İzin_Başlangıç_Tarihi = ap.Permit_Start_Time,
                           İzin_Bitiş_Tarihi = ap.Permit_End_Time,
                           Cep_Telefonu = u.Cell_Phone_Area_Code + u.Cell_Phone_Number,
                           //Kullanılmış_İzin_Gün_Adedi = ap.Permitted_Use_Knowledge_Data,
                           //Bakiye = ap.Accumulated_Permit_count_Knowledge_Data
                       };
            fuGridControl1.DataSource = list;
        }

        public void List_The_Annual_Permit_Permit_Type()
        {
            var list = from ap in sql_Server_Db_From_Follow_Up_Data_Context.Annual_Permits

                       join u in sql_Server_Db_From_Follow_Up_Data_Context.Users on ap.User_Obj_Id equals u.Obj_Id
                       join d in sql_Server_Db_From_Follow_Up_Data_Context.Departments on ap.Department_Obj_Id equals d.Obj_Id
                       /*join pr in sql_Server_Db_From_Follow_Up_Data_Context.Permit_Reasons on ap.Permit_Reason_Obj_Id equals pr.Obj_Id*/
                       orderby ap.Permit_Start_Time descending
                       where ap.Permit_Type.Contains(Permit_Type_ComboBoxEdit.Text)
                       select new
                       {
                           //Sıra = ap.Obj_Id,
                           Ad_Soyad = u.Full_Name,
                           Sicil_Numarası = u.Registration_Number,
                           Departman_Adı = d.Name,
                           İzin_Başlangıç_Tarihi = ap.Permit_Start_Time,
                           İzin_Bitiş_Tarihi = ap.Permit_End_Time,
                           Cep_Telefonu = u.Cell_Phone_Area_Code + u.Cell_Phone_Number,
                           //Kullanılmış_İzin_Gün_Adedi = ap.Permitted_Use_Knowledge_Data,
                           //Bakiye = ap.Accumulated_Permit_count_Knowledge_Data
                       };
            fuGridControl1.DataSource = list;
        }

        public void List_The_Approval_Type()
        {
            var list = from ap in sql_Server_Db_From_Follow_Up_Data_Context.Annual_Permits

                       join u in sql_Server_Db_From_Follow_Up_Data_Context.Users on ap.User_Obj_Id equals u.Obj_Id
                       join d in sql_Server_Db_From_Follow_Up_Data_Context.Departments on ap.Department_Obj_Id equals d.Obj_Id
                       /*join pr in sql_Server_Db_From_Follow_Up_Data_Context.Permit_Reasons on ap.Permit_Reason_Obj_Id equals pr.Obj_Id*/
                       orderby ap.Permit_Start_Time descending
                       //where d.Name.Contains(Permit_Approval_Situation_ComboBoxEdit.Text)
                       where ap.Approval_Department_Manager_Situation.Value == True_False()
                       select new
                       {
                           //Sıra = ap.Obj_Id,
                           Ad_Soyad = u.Full_Name,
                           Sicil_Numarası = u.Registration_Number,
                           Departman_Adı = d.Name,
                           İzin_Başlangıç_Tarihi = ap.Permit_Start_Time,
                           İzin_Bitiş_Tarihi = ap.Permit_End_Time,
                           Cep_Telefonu = u.Cell_Phone_Area_Code + u.Cell_Phone_Number,
                           //Kullanılmış_İzin_Gün_Adedi = ap.Permitted_Use_Knowledge_Data,
                           //Bakiye = ap.Accumulated_Permit_count_Knowledge_Data
                       };
            fuGridControl1.DataSource = list;
        }

        public void List_The_Annual_Date()
        {
            var list = from ap in sql_Server_Db_From_Follow_Up_Data_Context.Annual_Permits

                       join u in sql_Server_Db_From_Follow_Up_Data_Context.Users on ap.User_Obj_Id equals u.Obj_Id
                       join d in sql_Server_Db_From_Follow_Up_Data_Context.Departments on ap.Department_Obj_Id equals d.Obj_Id
                       /*join pr in sql_Server_Db_From_Follow_Up_Data_Context.Permit_Reasons on ap.Permit_Reason_Obj_Id equals pr.Obj_Id*/
                       orderby ap.Permit_Start_Time descending
                       //where d.Name.Contains(Department_Type_ComboBoxEdit.Text)
                       where ap.Permit_Start_Time.Value == DateTime.Parse( (Annual_Date_DateEdit.Text))
                       select new
                       {
                           //Sıra = ap.Obj_Id,
                           Ad_Soyad = u.Full_Name,
                           Sicil_Numarası = u.Registration_Number,
                           Departman_Adı = d.Name,
                           İzin_Başlangıç_Tarihi = ap.Permit_Start_Time,
                           İzin_Bitiş_Tarihi = ap.Permit_End_Time,
                           Cep_Telefonu = u.Cell_Phone_Area_Code + u.Cell_Phone_Number,
                           //Kullanılmış_İzin_Gün_Adedi = ap.Permitted_Use_Knowledge_Data,
                           //Bakiye = ap.Accumulated_Permit_count_Knowledge_Data
                       };
            fuGridControl1.DataSource = list;
        }

        public void List_The_Annual_Permit_Staff_Full_Name()
        {
            var list = from ap in sql_Server_Db_From_Follow_Up_Data_Context.Annual_Permits

                       join u in sql_Server_Db_From_Follow_Up_Data_Context.Users on ap.User_Obj_Id equals u.Obj_Id
                       join d in sql_Server_Db_From_Follow_Up_Data_Context.Departments on ap.Department_Obj_Id equals d.Obj_Id
                       /*join pr in sql_Server_Db_From_Follow_Up_Data_Context.Permit_Reasons on ap.Permit_Reason_Obj_Id equals pr.Obj_Id*/
                       orderby ap.Permit_Start_Time descending
                       where u.Full_Name.StartsWith(Full_Name_TextEdit.Text)
                       select new
                       {
                           //Sıra = ap.Obj_Id,
                           Ad_Soyad = u.Full_Name,
                           Sicil_Numarası = u.Registration_Number,
                           Departman_Adı = d.Name,
                           İzin_Başlangıç_Tarihi = ap.Permit_Start_Time,
                           İzin_Bitiş_Tarihi = ap.Permit_End_Time,
                           Cep_Telefonu = u.Cell_Phone_Area_Code + u.Cell_Phone_Number,
                           //Kullanılmış_İzin_Gün_Adedi = ap.Permitted_Use_Knowledge_Data,
                           //Bakiye = ap.Accumulated_Permit_count_Knowledge_Data
                       };
            fuGridControl1.DataSource = list;
        }


        public bool True_False() 
        {
            bool Value = false;

            if (Permit_Approval_Situation_ComboBoxEdit.Text == "Bekliyor")
            {
                Value = false;
            }
            if (Permit_Approval_Situation_ComboBoxEdit.Text == "Onaylandı")
            {
                Value = true;
            }

            return Value;
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
            List_The_Annual_Permit_For_Permit_Type();
        }

        private void Department_Type_ComboBoxEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            List_The_Annual_Permit_Department_Type();
        }

        /// <summary>
        /// Öz izleme ekanını açıyoruz.
        /// </summary>
        private void Preview_SimpleButton_Click(object sender, EventArgs e)
        {
            //gridView1.ShowPrintPreview();
            fuGridControl1.ShowPrintPreview();
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

        private void Annual_Permit_List_Form_Load(object sender, EventArgs e)
        {
            List_The_Annual_Permit_For_Permit_Type();
        }

        private void fuGridControl1_DoubleClick_1(object sender, EventArgs e)
        {
            Choose_The_Record();

            if (Choose && Choose_Obj_Id > 0)
            {
                MainMDIForm.Cross = Choose_Obj_Id;
                this.Close();
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

        private void Preview_SimpleButton_Click_1(object sender, EventArgs e)
        {
            fuGridControl1.ShowPrintPreview();
        }

        private void Department_Type_ComboBoxEdit_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            List_The_Annual_Permit_Department_Type();
        }

        private void Clean_SimpleButton_Click(object sender, EventArgs e)
        {
            Department_Type_ComboBoxEdit.Text = string.Empty;
            Permit_Type_ComboBoxEdit.Text = string.Empty;
        }

        private void Permit_Type_ComboBoxEdit_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            List_The_Annual_Permit_Permit_Type();
        }

        private void Permit_Approval_Situation_ComboBoxEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            List_The_Approval_Type();
        }

        /// <summary>
        /// Dev_Date:2015_04_28
        /// Grid'in satırlarını renklendiriyoruz...
        /// To_Do: Onaylanmamış izinler farklı renk olsun, onaylanmışlar farklı renk olsun..
        /// </summary>
        private void gridView1_RowStyle(object sender, RowStyleEventArgs e)
        {
            GridView gridView = sender as GridView;
            if (e.RowHandle >= 0)
            {
                string read = gridView.GetRowCellDisplayText(e.RowHandle, gridView.Columns[0]);
                if (read == "Bos")
                {
                    e.Appearance.BackColor = Color.Green;
                }
                else
                {
                    e.Appearance.BackColor = Color.Yellow;
                }
            }
        }

        /// <summary>
        /// Grid kolonlarını auto size yapma
        /// </summary>
        private void fuGridControl1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < gridView1.Columns.Count; i++) gridView1.Columns[i].BestFit();

        }

        /// <summary>
        /// Dev_Date: 2015_05_28
        /// Eğer login olan kişi yönetici değil ise sadece kendinin izinlerini görsün
        /// Genel Müdür, Müdür, Direktör, Yönetmen değil ise ...
        /// </summary>
        //private bool If_Login_User_Doesnt_Manager() 
        //{

        //    int Login_Obj_Id = Login_Form.Login_User_Obj_Id;
        //    bool Title_Situation = false;

        //    SqlConnection sqlConnection = new SqlConnection("Server=10.168.0.26;Database=DentasPro;uid=sa;pwd=dentas;");
        //    sqlConnection.Open();

        //    SqlCommand sqlCommand = new SqlCommand("Select  Case When Title_Obj_Id not in (1,2,3,4,5) Then 'True' Else 'False' End From [User] where Obj_Id = '" + Login_Obj_Id + "'", sqlConnection);

        //    SqlParameter param = new SqlParameter();
        //    param.ParameterName = "@Login_Obj_Id";
        //    param.Value = Login_Obj_Id;

        //    sqlCommand.Parameters.Add(param);

        //    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

        //    if (sqlDataReader.HasRows)
        //    {
        //        while (sqlDataReader.Read())
        //        {
        //            Title_Situation = sqlDataReader.GetBoolean(0);
        //        }
        //    }
        //    return Title_Situation;
        //}


        /// <summary>
        /// Sisteme giriş yapan personel2in departman bilgisi comboya set olsun.
        /// </summary>
        public void Department_Set_Which_Department_Staff_In()
        {
            Department_Type_ComboBoxEdit.Enabled = false;

            Annual_Permit_Form annual_Permit_Form = new Annual_Permit_Form();
            if (annual_Permit_Form.Department_Name_TextEdit.Text.Contains("Bilgi Sistemleri Müdürlüğü"))
            {
                Department_Type_ComboBoxEdit.Text = "Bilgi Sistemleri Müdürlüğü";
            }
            if (annual_Permit_Form.Department_Name_TextEdit.Text.Contains("1.Bölge Satış Müdürlüğü"))
            {
                Department_Type_ComboBoxEdit.Text = "1.Bölge Satış Müdürlüğü";
            }
            if (annual_Permit_Form.Department_Name_TextEdit.Text.Contains("2.Bölge Satış Müdürlüğü"))
            {
                Department_Type_ComboBoxEdit.Text = "2.Bölge Satış Müdürlüğü";
            }
            if (annual_Permit_Form.Department_Name_TextEdit.Text.Contains("3.Bölge Satış Müdürlüğü"))
            {
                Department_Type_ComboBoxEdit.Text = "3.Bölge Satış Müdürlüğü";
            }
            if (annual_Permit_Form.Department_Name_TextEdit.Text.Contains("4.Bölge Satış Müdürlüğü"))
            {
                Department_Type_ComboBoxEdit.Text = "4.Bölge Satış Müdürlüğü";
            }
            if (annual_Permit_Form.Department_Name_TextEdit.Text.Contains("5.Bölge Satış Müdürlüğü"))
            {
                Department_Type_ComboBoxEdit.Text = "5.Bölge Satış Müdürlüğü";
            }
            if (annual_Permit_Form.Department_Name_TextEdit.Text.Contains("6.Bölge Satış Müdürlüğü"))
            {
                Department_Type_ComboBoxEdit.Text = "6.Bölge Satış Müdürlüğü";
            }
            if (annual_Permit_Form.Department_Name_TextEdit.Text.Contains("7.Bölge Satış Müdürlüğü"))
            {
                Department_Type_ComboBoxEdit.Text = "7.Bölge Satış Müdürlüğü";
            }
            if (annual_Permit_Form.Department_Name_TextEdit.Text.Contains("8.Bölge Satış Müdürlüğü"))
            {
                Department_Type_ComboBoxEdit.Text = "8.Bölge Satış Müdürlüğü";
            }
            if (annual_Permit_Form.Department_Name_TextEdit.Text.Contains("Adana Oluklu Üretim Müdürlüğü"))
            {
                Department_Type_ComboBoxEdit.Text = "Adana Oluklu Üretim Müdürlüğü";
            }
            if (annual_Permit_Form.Department_Name_TextEdit.Text.Contains("Çorlu Kağıt Üretim Müdürlüğü"))
            {
                Department_Type_ComboBoxEdit.Text = "Çorlu Kağıt Üretim Müdürlüğü";
            }
            if (annual_Permit_Form.Department_Name_TextEdit.Text.Contains("Çorlu Oluklu Üretim Müdürlüğü"))
            {
                Department_Type_ComboBoxEdit.Text = "Çorlu Oluklu Üretim Müdürlüğü";
            }
            if (annual_Permit_Form.Department_Name_TextEdit.Text.Contains("Denizli Kağıt Üretim Müdürlüğü"))
            {
                Department_Type_ComboBoxEdit.Text = "Denizli Kağıt Üretim Müdürlüğü";
            }
            if (annual_Permit_Form.Department_Name_TextEdit.Text.Contains("Denizli Oluklu Üretim Müdürlüğü"))
            {
                Department_Type_ComboBoxEdit.Text = "Denizli Oluklu Üretim Müdürlüğü";
            }
            if (annual_Permit_Form.Department_Name_TextEdit.Text.Contains("Genel Müdürlük"))
            {
                Department_Type_ComboBoxEdit.Text = "Genel Müdürlük";
            }
            if (annual_Permit_Form.Department_Name_TextEdit.Text.Contains("İç Denetim Müdürlüğü"))
            {
                Department_Type_ComboBoxEdit.Text = "İç Denetim Müdürlüğü";
            }
            if (annual_Permit_Form.Department_Name_TextEdit.Text.Contains("İnsan Kaynakları Müdürlüğü"))
            {
                Department_Type_ComboBoxEdit.Text = "İnsan Kaynakları Müdürlüğü";
            }
            if (annual_Permit_Form.Department_Name_TextEdit.Text.Contains("Kağıt Fabrikaları Üretim Direktörlüğü"))
            {
                Department_Type_ComboBoxEdit.Text = "Kağıt Fabrikaları Üretim Direktörlüğü";
            }
            if (annual_Permit_Form.Department_Name_TextEdit.Text.Contains("Kalite Ve Arge Müdürlüğü"))
            {
                Department_Type_ComboBoxEdit.Text = "Kalite Ve Arge Müdürlüğü";
            }
            if (annual_Permit_Form.Department_Name_TextEdit.Text.Contains("Mali İşler Direktörlüğü"))
            {
                Department_Type_ComboBoxEdit.Text = "Mali İşler Direktörlüğü";
            }
            if (annual_Permit_Form.Department_Name_TextEdit.Text.Contains("Mamul Ambar"))
            {
                Department_Type_ComboBoxEdit.Text = "Mamul Ambar";
            }
            if (annual_Permit_Form.Department_Name_TextEdit.Text.Contains("Oluklu Fabrikaları Üretim Direktörlüğü"))
            {
                Department_Type_ComboBoxEdit.Text = "Oluklu Fabrikaları Üretim Direktörlüğü";
            }
            if (annual_Permit_Form.Department_Name_TextEdit.Text.Contains("Satınalma Ve Lojistik Müdürlüğü"))
            {
                Department_Type_ComboBoxEdit.Text = "Satınalma Ve Lojistik Müdürlüğü";
            }
            if (annual_Permit_Form.Department_Name_TextEdit.Text.Contains("Satış Pazarlama Direktörlüğü"))
            {
                Department_Type_ComboBoxEdit.Text = "Satış Pazarlama Direktörlüğü";
            }
            if (annual_Permit_Form.Department_Name_TextEdit.Text.Contains("Üretim Planlama"))
            {
                Department_Type_ComboBoxEdit.Text = "Üretim Planlama";
            }

        }

        private void Start_Date_DateEdit_EditValueChanged(object sender, EventArgs e)
        {
            List_The_Annual_Date();
        }

        private void Full_Name_TextEdit_EditValueChanged(object sender, EventArgs e)
        {
            List_The_Annual_Permit_Staff_Full_Name();

            if (Full_Name_TextEdit.Text.Length == 0 )
            {

                fuGridControl1.DataSource = null;
            }
        }
    }
}