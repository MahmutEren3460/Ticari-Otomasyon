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
    public partial class FormFaturaUrunDuzenleme : Form
    {
        public FormFaturaUrunDuzenleme()
        {
            InitializeComponent();
        }
        baglanti bgl = new baglanti();
        public string urunid;
        private void FormFaturaUrunDuzenleme_Load(object sender, EventArgs e)
        {
            txtUrunId.Text = urunid;

            SqlCommand cmd = new SqlCommand("select * from TBL_FATURADETAY where FATURAURUNID=@p1",bgl.baglantisi());
            cmd.Parameters.AddWithValue("@p1",urunid);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtUrunAd.Text = dr[1].ToString();
                txtTutar.Text = dr[4].ToString();
                txtMiktar.Text = dr[2].ToString();
                txtFiyat.Text = dr[3].ToString();

                bgl.baglantisi().Close();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            double miktar, fiyat, tutar;
            fiyat = Convert.ToDouble(txtFiyat.Text);
            miktar = Convert.ToDouble(txtMiktar.Text);
            tutar = fiyat * miktar;
            txtTutar.Text = tutar.ToString();
            SqlCommand cmd = new SqlCommand("update TBL_FATURADETAY set URUNAD=@p1,MIKTAR=@p2,FIYAT=@p3,TUTAR=@p4 where FATURAURUNID=@p5",bgl.baglantisi());
            cmd.Parameters.AddWithValue("@p1",txtUrunAd.Text);
            cmd.Parameters.AddWithValue("@p2", txtMiktar.Text);
            cmd.Parameters.AddWithValue("@p3", decimal.Parse( txtFiyat.Text));
            cmd.Parameters.AddWithValue("@p4", decimal.Parse (txtTutar.Text));
            cmd.Parameters.AddWithValue("@p5", txtUrunId.Text);
            cmd.ExecuteNonQuery();
            bgl.baglantisi().Close();
            MessageBox.Show("Güncelleme İşlemi Başarıyla Gerçekleşti");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete from TBL_FATURADETAY where FATURAURUNID=@p1",bgl.baglantisi());
            cmd.Parameters.AddWithValue("@p1", txtUrunId.Text);
            cmd.ExecuteNonQuery();
            bgl.baglantisi().Close();
            MessageBox.Show("Silme İşlemi Başarıyla Gerçekleşti");
        }
    }
}
