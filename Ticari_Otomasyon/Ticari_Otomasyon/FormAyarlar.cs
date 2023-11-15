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
    public partial class FormAyarlar : Form
    {
        public FormAyarlar()
        {
            InitializeComponent();
        }
        baglanti bgl = new baglanti();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_ADMIN", bgl.baglantisi());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void temizle()
        {
            txtKullaniciAdi.Text = "";
            txtSifre.Text = "";
        }

        private void FormAyarlar_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
        }

        private void btnIslem_Click(object sender, EventArgs e)
        {
            if (btnIslem.Text == "Kaydet") { 
            SqlCommand cmd = new SqlCommand("insert into TBL_ADMIN values (@p1,@p2)", bgl.baglantisi());
            cmd.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
            cmd.Parameters.AddWithValue("@p2", txtSifre.Text);
            cmd.ExecuteNonQuery();
            bgl.baglantisi().Close();
            MessageBox.Show("Yeni kullanıcı kaydedildi");
            listele();
            temizle();
            }
            if (btnIslem.Text == "Güncelle")
            {
                SqlCommand cmd2 = new SqlCommand("update TBL_ADMIN set KullaniciAdi=@p1,Sifre=@p2 where ID=@p3", bgl.baglantisi());
                cmd2.Parameters.AddWithValue("@p2", txtSifre.Text);
                cmd2.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
                cmd2.Parameters.AddWithValue("@p3",int.Parse(label3.Text));
                cmd2.ExecuteNonQuery();
                bgl.baglantisi().Close();
                MessageBox.Show("Kullanıcı Güncellendi");
                listele();
                temizle();
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtKullaniciAdi.Text = dr["KullaniciAdi"].ToString();
            txtSifre.Text = dr["Sifre"].ToString();
            label3.Text = dr["ID"].ToString();
        }

        private void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text != "")
            {
                btnIslem.Text = "Güncelle";

            }
            else
            {
                btnIslem.Text = "Kaydet";
            }
        }
    }
}
