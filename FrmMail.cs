using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace TicariOtomasyon
{
    public partial class FrmMail : Form
    {
        public string Mail { get; set; }

        public FrmMail()
        {
            InitializeComponent();
        }

        private void FrmMail_Load(object sender, EventArgs e)
        {
            txtMail.Text = Mail;
        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {
            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("MailAdresi");
            mailMessage.To.Add(txtMail.Text);
            mailMessage.Subject = txtSubject.Text;
            mailMessage.Body = rtxtMessage.Text;
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Credentials = new System.Net.NetworkCredential("MailAdresi", "Sifre");
            smtpClient.Port = 587;
            smtpClient.Host = "smtp.live.com";
            smtpClient.EnableSsl = true;
            
            smtpClient.Send(mailMessage);
        }
    }
}
