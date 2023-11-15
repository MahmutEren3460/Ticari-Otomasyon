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

namespace Ticari_Otomasyon
{
    public partial class FormMail : Form
    {
        public FormMail()
        {
            InitializeComponent();
        }
        public string mail;
        private void FormMail_Load(object sender, EventArgs e)
        {
            txtMail.Text = mail;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            MailMessage mesajim = new MailMessage();
            SmtpClient istemci = new SmtpClient();
            istemci.Credentials = new System.Net.NetworkCredential("yucemahmuteren@outlook.com","Mahmut12345");
            istemci.Port = 587;
            istemci.Host = "smtp.outlook.com";
            istemci.EnableSsl = true;
            mesajim.To.Add(txtMail.Text);
            mesajim.From = new MailAddress("yucemahmuteren@outlook.com", "Mahmut");
            mesajim.Subject = txtKonu.Text;
            mesajim.Body = rchMesaj.Text;
            mesajim.IsBodyHtml = true;
            istemci.Send(mesajim);
            MessageBox.Show("Mail gönderildi");
            this.Hide();
        }
    }
}
