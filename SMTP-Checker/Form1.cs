using MaterialSkin.Controls;
using System;
using System.Net.Mail;
using System.Windows.Forms;

namespace SMTP_Checker
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Clicked()
        {
            try
            {
                using (MailMessage NetMail = new MailMessage())
                {
                    using (SmtpClient smtpClient = new SmtpClient())
                    {
                        smtpClient.Port = Convert.ToInt32(txtport.Text);
                        smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                        smtpClient.EnableSsl = chkEnableSsl.Checked;
                        smtpClient.UseDefaultCredentials = chkUseDefaultCredentials.Checked;
                        smtpClient.Credentials = new System.Net.NetworkCredential(txtsenderEmail.Text, txtSenderPassword.Text);
                        smtpClient.Host = txtsmtpAddress.Text;
                        NetMail.From = new MailAddress(txtsenderEmail.Text, "Alert");
                        NetMail.To.Add(new MailAddress(txtreceiverEmail.Text));
                        NetMail.IsBodyHtml = true;
                        NetMail.Subject = "SMTP-Tester";
                        NetMail.Body = "Testing message";
                        smtpClient.Send(NetMail);
                        MessageBox.Show("No Error Found.! Please check indbox", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.StackTrace, "Error Message Detail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            Clicked();
        }
    }
}