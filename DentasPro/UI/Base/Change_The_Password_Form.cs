namespace Dentas_Pro.UI.Base
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Data.SqlClient;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;

    public partial class Change_The_Password_Form : Base_Form
    {
        public Change_The_Password_Form()
        {
            InitializeComponent();
            First_Password_TextEdit.Focus();
        }

        private void Change_The_Passwod_SimpleButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(First_Password_TextEdit.Text))
            {
                MessageBox.Show("Değişiklik için yeni şifrenizi girinizi", "İlk Şifre eksik", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                First_Password_TextEdit.Focus();
                return;
            }

            if (string.IsNullOrEmpty(Second_Password_TextEdit.Text))
            {
                MessageBox.Show("Değişiklik için şifrenizi tekrar yazınız ", "İlk Şifre eksik", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Second_Password_TextEdit.Focus();
                return;
            }
            if (First_Password_TextEdit.Text == Second_Password_TextEdit.Text)
            {
                int Login_Obj_Id = Login_Form.Login_User_Obj_Id;
                string New_Password = Second_Password_TextEdit.Text;

                SqlConnection sqlConnection = new SqlConnection("Server=10.168.0.26;Database=DentasPro;uid=sa;pwd=dentas;");
                sqlConnection.Open();

                SqlParameter param = new SqlParameter();
                param.ParameterName = "@Login_Obj_Id";
                param.Value = Login_Obj_Id;

                SqlCommand sqlCommand = new SqlCommand("Update [User] Set Password = '" + New_Password + "' where Obj_Id = '" + Login_Obj_Id + "'", sqlConnection);

                sqlCommand.Parameters.Add(param);

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                MessageBox.Show("Şifreniz başarı ile değiştirildi", "Şifre Değiştirildi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Şifreler aynı değil !.. kontrol ediniz", "Şifreler Aynı Değil", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
                this.Close();
            bool res = base.ProcessCmdKey(ref msg, keyData);
            return res;
        }
    }
}
