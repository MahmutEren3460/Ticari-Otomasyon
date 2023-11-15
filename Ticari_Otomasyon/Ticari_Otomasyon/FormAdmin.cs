using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ticari_Otomasyon
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        baglanti bgl = new baglanti();

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from TBL_ADMIN where KullaniciAdi=@p1 and Sifre=@p2",bgl.baglantisi());
            cmd.Parameters.AddWithValue("@p1", txtkullaniciAdi.Text);
            cmd.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                FormAna fra = new FormAna();
                fra.kullanici = txtkullaniciAdi.Text;
                fra.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya Şifre yanlış");
            }
        }
    }
}
