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
    public partial class FormMusteri : Form
    {
        public FormMusteri()
        {
            InitializeComponent();
        }
        baglanti bgl = new baglanti();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_MUSTERILER", bgl.baglantisi());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void sehirlistesi()
        {
            SqlCommand cmd = new SqlCommand("select SEHIR from TBL_ILLER", bgl.baglantisi());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbil.Properties.Items.Add(dr[0]);
            }
            bgl.baglantisi().Close();
        }

        void temizle()
        {
            txtId.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            mskTel1.Text = "";
            mskTel2.Text = "";
            mskTC.Text = "";
            txtMail.Text = "";
            cmbil.Text = "";
            cmbilce.Text = "";
            txtVergiD.Text = "";
            rchAdres.Text = "";
            txtAd.Focus();
        }

        private void FormMusteri_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
            sehirlistesi();
        }

        private void cmbil_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbilce.Properties.Items.Clear();
            SqlCommand cmd = new SqlCommand("select ILCE from TBL_ILCELER where SEHIR=@p1", bgl.baglantisi());
            cmd.Parameters.AddWithValue("@p1", cmbil.SelectedIndex + 1);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbilce.Properties.Items.Add(dr[0]);
            }
            bgl.baglantisi().Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into TBL_MUSTERILER (AD,SOYAD,TELEFON,TELEFON2,TC,MAIL,Il,ILCE,ADRES,VERGIDAIRE) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", bgl.baglantisi());
            cmd.Parameters.AddWithValue("@p1", txtAd.Text);
            cmd.Parameters.AddWithValue("@p2", txtSoyad.Text);
            cmd.Parameters.AddWithValue("@p3", mskTel1.Text);
            cmd.Parameters.AddWithValue("@p4", mskTel2.Text);
            cmd.Parameters.AddWithValue("@p5", mskTC.Text);
            cmd.Parameters.AddWithValue("@p6", txtMail.Text);
            cmd.Parameters.AddWithValue("@p7", cmbil.Text);
            cmd.Parameters.AddWithValue("@p8", cmbilce.Text);
            cmd.Parameters.AddWithValue("@p9", rchAdres.Text);
            cmd.Parameters.AddWithValue("@p10", txtVergiD.Text);
            cmd.ExecuteNonQuery();
            bgl.baglantisi().Close();
            MessageBox.Show("Kayıt İşlemi Başarıyla Gerçekleşti");
            listele();
            temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtId.Text = dr["ID"].ToString();
            txtAd.Text = dr["AD"].ToString();
            txtSoyad.Text = dr["SOYAD"].ToString();
            mskTel1.Text = dr["TELEFON"].ToString();
            mskTel2.Text = dr["TELEFON2"].ToString();
            mskTC.Text = dr["TC"].ToString();
            txtMail.Text = dr["MAIL"].ToString();
            cmbil.Text = dr["IL"].ToString();
            cmbilce.Text = dr["ILCE"].ToString();
            rchAdres.Text = dr["ADRES"].ToString();
            txtVergiD.Text = dr["VERGIDAIRE"].ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Müşteri Silinsin mi?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("DELETE From TBL_MUSTERILER WHERE ID=@p1", bgl.baglantisi());
                komut.Parameters.AddWithValue("@p1", txtId.Text);
                komut.ExecuteNonQuery();
                bgl.baglantisi().Close();
                listele();
            }
            else if (d == DialogResult.No)
            {
                //Hiç Bişey yapma
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update TBL_MUSTERILER set AD=@p1,SOYAD=@p2,TELEFON=@p3,TELEFON2=@p4,TC=@p5,MAIL=@p6,IL=@p7,ILCE=@p8,ADRES=@p9,VERGIDAIRE=@p10 where ID=@p11",bgl.baglantisi());
            cmd.Parameters.AddWithValue("@p1", txtAd.Text);
            cmd.Parameters.AddWithValue("@p2", txtSoyad.Text);
            cmd.Parameters.AddWithValue("@p3", mskTel1.Text);
            cmd.Parameters.AddWithValue("@p4", mskTel2.Text);
            cmd.Parameters.AddWithValue("@p5", mskTC.Text);
            cmd.Parameters.AddWithValue("@p6", txtMail.Text);
            cmd.Parameters.AddWithValue("@p7", cmbil.Text);
            cmd.Parameters.AddWithValue("@p8", cmbilce.Text);
            cmd.Parameters.AddWithValue("@p9", rchAdres.Text);
            cmd.Parameters.AddWithValue("@p10", txtVergiD.Text);
            cmd.Parameters.AddWithValue("@p11", txtId.Text);
            cmd.ExecuteNonQuery();
            bgl.baglantisi().Close();
            MessageBox.Show("Güncelleme İşlemi Başarıyla Gerçekleşti");
            listele();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        
    }
}
    
