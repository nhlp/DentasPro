namespace Dentas_Pro.UI.Mail
{
    using System;
    using System.Data.SqlClient;
    using System.Net.Mail;
    using System.Windows.Forms;

    using DevExpress.XtraEditors;

    public partial class Send_An_E_Mail : DevExpress.XtraEditors.XtraForm
    {
        public Send_An_E_Mail()
        {
            InitializeComponent();
            Set_The_AutoSuggestion_Mail(Reciever_Mail_TextEdit);
        }

        private void Send_An_E_Mail_SimpleButton_Click(object sender, EventArgs e)
        {
            Send_An_E_Mail_();
        }


        public void Send_An_E_Mail_()
        {
            try
            {
                SmtpClient smtpClient = new SmtpClient("10.168.0.13", 25);
                //SmtpClient smtpClient = new SmtpClient("mail.gmail.com", 587);

                MailMessage mailMessage = new MailMessage();

                mailMessage.From = new MailAddress(From_Mail_TextEdit.Text);
                mailMessage.To.Add(Reciever_Mail_TextEdit.Text);
                mailMessage.Body = Message_TextEdit.Text;
                mailMessage.Subject = Subject_TextEdit.Text;

                smtpClient.UseDefaultCredentials = false;
                smtpClient.EnableSsl = false;

                if (AttachedTextEdit.Text != "")
                {
                    mailMessage.Attachments.Add(new Attachment(AttachedTextEdit.Text));
                }

                smtpClient.Credentials = new System.Net.NetworkCredential(From_Mail_TextEdit.Text, "irfan216", "Dentas.ads");
                smtpClient.Send(mailMessage);
                mailMessage = null;
                MessageBox.Show("İzin talebiniz alınmış ve ilgili yöneticilere iletilmiştir");
            }
            catch (Exception exception)
            {
                MessageBox.Show("Mail yollanamadı. Problem oluştu...");
            }
        }

        public void Send_An_E_Mail_(int Obj_Id, string From, string Reciever, string Message, string Subject)
        {
            try
            {
                SmtpClient smtpClient = new SmtpClient("10.168.0.13", 25);
                //SmtpClient smtpClient = new SmtpClient("mail.gmail.com", 587);

                MailMessage mailMessage = new MailMessage();

                mailMessage.From = new MailAddress(From);
                mailMessage.To.Add(Reciever);
                mailMessage.Body = Message;
                mailMessage.Subject = Subject;

                //mailMessage.From = new MailAddress(From_Mail_TextEdit.Text);
                //mailMessage.To.Add(Reciever_Mail_TextEdit.Text);
                //mailMessage.Body = Message_TextEdit.Text;
                //mailMessage.Subject = Subject_TextEdit.Text;

                smtpClient.UseDefaultCredentials = false;
                smtpClient.EnableSsl = false;

                if (AttachedTextEdit.Text != "")
                {
                    mailMessage.Attachments.Add(new Attachment(AttachedTextEdit.Text));
                }

                smtpClient.Credentials = new System.Net.NetworkCredential(From, "irfan216", "Dentas.ads");
                smtpClient.Send(mailMessage);
                mailMessage = null;
                MessageBox.Show("İzin talebiniz alınmış ve ilgili yöneticilere iletilmiştir");
            }
            catch (Exception exception)
            {
                MessageBox.Show("Mail yollanamadı. Problem oluştu...");
            }
        }


        public void Send_An_E_Mail_For_Forgetten_Password(string Send_An_E_Mail, string Subject, string Selected_Password,string Message)
        {
            try
            {
                SmtpClient smtpClient = new SmtpClient("10.168.0.13", 25);
                //SmtpClient smtpClient = new SmtpClient("mail.gmail.com", 587);

                MailMessage mailMessage = new MailMessage();

                mailMessage.From = new MailAddress(Send_An_E_Mail);
                mailMessage.To.Add(Send_An_E_Mail);
                mailMessage.Body = Message;
                mailMessage.Subject = Subject;

                //mailMessage.From = new MailAddress(From_Mail_TextEdit.Text);
                //mailMessage.To.Add(Reciever_Mail_TextEdit.Text);
                //mailMessage.Body = Message_TextEdit.Text;
                //mailMessage.Subject = Subject_TextEdit.Text;

                smtpClient.UseDefaultCredentials = false;
                smtpClient.EnableSsl = false;

                if (AttachedTextEdit.Text != "")
                {
                    mailMessage.Attachments.Add(new Attachment(AttachedTextEdit.Text));
                }

                smtpClient.Credentials = new System.Net.NetworkCredential(Send_An_E_Mail, "irfan216", "Dentas.ads");
                smtpClient.Send(mailMessage);
                mailMessage = null;
                MessageBox.Show("Şifreniz mail'inize yollandı!..");
            }
            catch (Exception exception)
            {
                MessageBox.Show("Mail yollanamadı. Problem oluştu...");
            }
        }



        private void Attached_SimpleButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                AttachedTextEdit.Text = openFileDialog1.FileName.ToString();
            }
        }


        /// <summary>
        /// Developed_İrfan_D
        /// 2015_04_10
        /// Mail alıcısını otomatik dolduruyoruz
        /// </summary>
        public void Set_The_AutoSuggestion_Mail(TextEdit textEdit)
        {

            string Login_Name = string.Empty;
            SqlDataReader sql_DataReader;
            SqlCommand sql_Command;

            SqlConnection sqlConnection = new SqlConnection("Server=10.168.0.26;Database=DentasPro;uid=sa;pwd=dentas;");
            sqlConnection.Open();

            try
            {
                sql_Command = new SqlCommand("Select E_Mail From [User]", sqlConnection);
                sql_DataReader = sql_Command.ExecuteReader();

                while (sql_DataReader.Read())
                {
                    Reciever_Mail_TextEdit.MaskBox.AutoCompleteCustomSource.Add(sql_DataReader["E_Mail"].ToString());
                    Reciever_Mail_TextEdit.MaskBox.AutoCompleteMode = AutoCompleteMode.Suggest;
                    Reciever_Mail_TextEdit.MaskBox.AutoCompleteSource = AutoCompleteSource.CustomSource;

                }
                sql_DataReader.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Tavsiye dilecek kayıtlı mail yok");/*=exception.ToString());*/
            }

        }
    }
}