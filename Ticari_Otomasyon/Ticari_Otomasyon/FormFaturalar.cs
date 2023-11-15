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
    public partial class FormFaturalar : Form
    {
        public FormFaturalar()
        {
            InitializeComponent();
        }
        baglanti bgl = new baglanti();
        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_FATURABILGI", bgl.baglantisi());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void temizle()
        {
            txtId.Text = "";
            txtSeri.Text = "";
            txtSiraNo.Text = "";
            txtVergiD.Text = "";
            mskTarih.Text = "";
            mskSaat.Text = "";
            txtAlıcı.Text = "";
            txtTeslimEden.Text = "";
            txtTeslimAlan.Text = "";
        }

        private void FormFaturalar_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //firma için
            if (txtFaturaId.Text == "" )
            {
                SqlCommand cmd = new SqlCommand("insert into TBL_FATURABILGI (SERI,SIRANO,TARIH,SAAT,VERGIDAIRE,ALICI,TESLIMEDEN,TESLIMALAN) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglantisi());
                cmd.Parameters.AddWithValue("@p1", txtSeri.Text);
                cmd.Parameters.AddWithValue("@p2", txtSiraNo.Text);
                cmd.Parameters.AddWithValue("@p3", mskTarih.Text);
                cmd.Parameters.AddWithValue("@p4", mskSaat.Text);
                cmd.Parameters.AddWithValue("@p5", txtVergiD.Text);
                cmd.Parameters.AddWithValue("@p6", txtAlıcı.Text);
                cmd.Parameters.AddWithValue("@p7", txtTeslimEden.Text);
                cmd.Parameters.AddWithValue("@p8", txtTeslimAlan.Text);
                cmd.ExecuteNonQuery();
                bgl.baglantisi().Close();
                MessageBox.Show("Kayıt İşlemi Başarıyla Gerçekleşti");
                listele();
                temizle();
            }
            if (txtFaturaId.Text != "" && comboBox1.Text == "Firma")
            {
                double miktar, fiyat, tutar;
                fiyat = Convert.ToDouble(txtFiyat.Text);
                miktar = Convert.ToDouble(txtMiktar.Text);
                tutar = fiyat * miktar;
                txtTutar.Text = tutar.ToString();
                SqlCommand cmd = new SqlCommand("insert into TBL_FATURADETAY (URUNAD,MIKTAR,FIYAT,TUTAR,FATURAID) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglantisi());
                cmd.Parameters.AddWithValue("@p1", txtUrunAd.Text);
                cmd.Parameters.AddWithValue("@p2", txtMiktar.Text);
                cmd.Parameters.AddWithValue("@p3",decimal.Parse( txtFiyat.Text));
                cmd.Parameters.AddWithValue("@p4",decimal.Parse( txtTutar.Text));
                cmd.Parameters.AddWithValue("@p5", txtFaturaId.Text);
                cmd.ExecuteNonQuery();
                bgl.baglantisi().Close();

                SqlCommand cmd2 = new SqlCommand("insert into TBL_FIRMAHAREKET (URUNID,ADET,PERSONEL,FIRMA,FIYAT,TOPLAM,FATURAID,TARIH) values (@h1,@h2,@h3,@h4,@h5,@h6,@h7,@h8)", bgl.baglantisi());
                cmd2.Parameters.AddWithValue("@h1", txtUrunId.Text);
                cmd2.Parameters.AddWithValue("@h2", txtMiktar.Text);
                cmd2.Parameters.AddWithValue("@h3", txtpersonel.Text);
                cmd2.Parameters.AddWithValue("@h4", txtFirma.Text);
                cmd2.Parameters.AddWithValue("@h5",decimal.Parse( txtFiyat.Text));
                cmd2.Parameters.AddWithValue("@h6",decimal.Parse( txtTutar.Text));
                cmd2.Parameters.AddWithValue("@h7", txtFaturaId.Text);
                cmd2.Parameters.AddWithValue("@h8", mskTarih.Text);
                cmd2.ExecuteNonQuery();
                bgl.baglantisi().Close();

                SqlCommand cmd3 = new SqlCommand("update TBL_URUN set ADET=ADET-@s1 where ID=@s2", bgl.baglantisi());
                cmd3.Parameters.AddWithValue("@s1", txtMiktar.Text);
                cmd3.Parameters.AddWithValue("@s2", txtUrunId.Text);
                cmd3.ExecuteNonQuery();
                bgl.baglantisi().Close();

                MessageBox.Show("Faturaya Ait Ürün Başarıyla Kaydedildi");
                listele();
                temizle();
            }
            //müşteri
            
            if (txtFaturaId.Text != "" && comboBox1.Text == "Müşteri")
            {
                double miktar, fiyat, tutar;
                fiyat = Convert.ToDouble(txtFiyat.Text);
                miktar = Convert.ToDouble(txtMiktar.Text);
                tutar = fiyat * miktar;
                txtTutar.Text = tutar.ToString();
                SqlCommand cmd = new SqlCommand("insert into TBL_FATURADETAY (URUNAD,MIKTAR,FIYAT,TUTAR,FATURAID) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglantisi());
                cmd.Parameters.AddWithValue("@p1", txtUrunAd.Text);
                cmd.Parameters.AddWithValue("@p2", txtMiktar.Text);
                cmd.Parameters.AddWithValue("@p3",decimal.Parse( txtFiyat.Text));
                cmd.Parameters.AddWithValue("@p4",decimal.Parse( txtTutar.Text));
                cmd.Parameters.AddWithValue("@p5", txtFaturaId.Text);
                cmd.ExecuteNonQuery();
                bgl.baglantisi().Close();

                SqlCommand cmd2 = new SqlCommand("insert into TBL_MUSTERIHAREKET (URUNID,ADET,PERSONEL,MUSTERI,FIYAT,TOPLAM,FATURAID,TARIH) values (@h1,@h2,@h3,@h4,@h5,@h6,@h7,@h8)", bgl.baglantisi());
                cmd2.Parameters.AddWithValue("@h1", txtUrunId.Text);
                cmd2.Parameters.AddWithValue("@h2", txtMiktar.Text);
                cmd2.Parameters.AddWithValue("@h3", txtpersonel.Text);
                cmd2.Parameters.AddWithValue("@h4", txtFirma.Text);
                cmd2.Parameters.AddWithValue("@h5",decimal.Parse( txtFiyat.Text));
                cmd2.Parameters.AddWithValue("@h6",decimal.Parse( txtTutar.Text));
                cmd2.Parameters.AddWithValue("@h7", txtFaturaId.Text);
                cmd2.Parameters.AddWithValue("@h8", mskTarih.Text);
                cmd2.ExecuteNonQuery();
                bgl.baglantisi().Close();

                SqlCommand cmd3 = new SqlCommand("update TBL_URUN set ADET=ADET-@s1 where ID=@s2", bgl.baglantisi());
                cmd3.Parameters.AddWithValue("@s1", txtMiktar.Text);
                cmd3.Parameters.AddWithValue("@s2", txtUrunId.Text);
                cmd3.ExecuteNonQuery();
                bgl.baglantisi().Close();

                MessageBox.Show("Faturaya Ait Ürün Başarıyla Kaydedildi");
                listele();
                temizle();
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtId.Text = dr["FATURABILGIID"].ToString();
            txtAlıcı.Text = dr["ALICI"].ToString();
            txtSeri.Text = dr["SERI"].ToString();
            txtSiraNo.Text = dr["SIRANO"].ToString();
            mskTarih.Text = dr["TARIH"].ToString();
            mskSaat.Text = dr["SAAT"].ToString();
            txtVergiD.Text = dr["VERGIDAIRE"].ToString();
            txtTeslimAlan.Text = dr["TESLIMALAN"].ToString();
            txtTeslimEden.Text = dr["TESLIMEDEN"].ToString();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete from TBL_FATURABILGI where FATURABILGIID=@p1", bgl.baglantisi());
            cmd.Parameters.AddWithValue("@p1", txtId.Text);
            cmd.ExecuteNonQuery();
            bgl.baglantisi().Close();
            MessageBox.Show("Silme İşlemi Başarıyla Gerçekleşti");
            listele();
            temizle();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update TBL_FATURABILGI set SERI=@p1,SIRANO=@p2,TARIH=@p3,SAAT=@p4,VERGIDAIRE=@p5,ALICI=@p6,TESLIMEDEN=@p7,TESLIMALAN=@p8 where FATURABILGIID=@p9", bgl.baglantisi());
            cmd.Parameters.AddWithValue("@p1", txtSeri.Text);
            cmd.Parameters.AddWithValue("@p2", txtSiraNo.Text);
            cmd.Parameters.AddWithValue("@p3", mskTarih.Text);
            cmd.Parameters.AddWithValue("@p4", mskSaat.Text);
            cmd.Parameters.AddWithValue("@p5", txtVergiD.Text);
            cmd.Parameters.AddWithValue("@p6", txtAlıcı.Text);
            cmd.Parameters.AddWithValue("@p7", txtTeslimEden.Text);
            cmd.Parameters.AddWithValue("@p8", txtTeslimAlan.Text);
            cmd.Parameters.AddWithValue("@p9", txtId.Text);
            cmd.ExecuteNonQuery();
            bgl.baglantisi().Close();
            MessageBox.Show("Güncelleme İşlemi Başarıyla Gerçekleşti");
            listele();
            temizle();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FormFaturaUrunler ffu = new FormFaturaUrunler();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (ffu != null)
            {
                ffu.id = dr["FATURABILGIID"].ToString();
            }
            ffu.Show();
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select URUNAD,SATISFIYAT from TBL_URUN where ID=@p1",bgl.baglantisi());
            cmd.Parameters.AddWithValue("@p1", txtUrunId.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtUrunAd.Text = dr[0].ToString();
                txtFiyat.Text = dr[1].ToString();
            }
            bgl.baglantisi().Close();
        }
    }

}
