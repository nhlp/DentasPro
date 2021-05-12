/*Personel izin hareket formu*/
namespace Dentas_Pro.UI.User
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Data;
    using System.Drawing;
    using System.Text;
    using System.Windows.Forms;

    using DevExpress.XtraEditors;

    public partial class User_Action_Form : DevExpress.XtraEditors.XtraForm
    {
        public bool Chooce = false;
        public int Chooce_Id = -1;

        public User_Action_Form()
        {
            InitializeComponent();
        }


        private void User_Action_Form_Load(object sender, EventArgs e)
        {
            #region Evet Comment
            /*Bu form açılırken, formdaki grid'inde dolması için bu metodu çağırıyoruz*/
            #endregion
            Get_List();
        }

        public void Get_List()
        {
        }
    }
}