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
    public partial class FormFirmalar : Form
    {
        public FormFirmalar()
        {
            InitializeComponent();
        }

        baglanti bgl = new baglanti();

        void firmalistele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_FIRMALAR", bgl.baglantisi());
            DataTable dt = new DataTable();
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
            txtSektor.Text = "";
            txtYetkili.Text = "";
            txtYGorev.Text = "";
            mskTC.Text = "";
            mskTel1.Text = "";
            mskTel2.Text = "";
            mskTel3.Text = "";
            txtMail.Text = "";
            mskTC.Text = "";
            cmbil.Text = "";
            cmbilce.Text = "";
            txtVergiD.Text = "";
            rchAdres.Text = "";
            txtKod1.Text = "";
            txtKod2.Text = "";
            txtKod3.Text = "";
            txtKod1.Text = "";
            txtKod2.Text = "";
            txtKod3.Text = "";
            mskFax.Text = "";
            txtAd.Focus();

        }

        void carikodaciklama()
        {
            SqlCommand cmd = new SqlCommand("select * from TBL_KOD",bgl.baglantisi());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                rchKod1.Text = dr[0].ToString();
                rchKod2.Text = dr[1].ToString();
                rchKod3.Text = dr[2].ToString();
            }
            bgl.baglantisi().Close();
        }

        private void FormFirmalar_Load(object sender, EventArgs e)
        {
            firmalistele();
            temizle();
            sehirlistesi();
            carikodaciklama();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtId.Text = dr["ID"].ToString();
            txtAd.Text = dr["AD"].ToString();
            txtYetkili.Text = dr["YETKILIADSOYAD"].ToString();
            txtYGorev.Text = dr["YETKILISTATU"].ToString();
            mskTC.Text = dr["YETKILITC"].ToString();
            txtSektor.Text = dr["SEKTOR"].ToString();
            mskTel1.Text = dr["TELEFON"].ToString();
            mskTel2.Text = dr["TELEFON2"].ToString();
            mskTel3.Text = dr["TELEFON3"].ToString();
            txtMail.Text = dr["MAIL"].ToString();
            mskFax.Text = dr["FAX"].ToString();
            cmbil.Text = dr["IL"].ToString();
            cmbilce.Text = dr["ILCE"].ToString();
            txtVergiD.Text = dr["VERGIDAIRE"].ToString();
            rchAdres.Text = dr["ADRES"].ToString();
            txtKod1.Text = dr["OZELKOD1"].ToString();
            txtKod2.Text = dr["OZELKOD2"].ToString();
            txtKod3.Text = dr["OZELKOD3"].ToString();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into TBL_FIRMALAR (AD,YETKILIADSOYAD,YETKILISTATU,YETKILITC,SEKTOR,TELEFON,TELEFON2,TELEFON3,MAIL,FAX,IL,ILCE,VERGIDAIRE,ADRES,OZELKOD1,OZELKOD2,OZELKOD3) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16,@p17)",bgl.baglantisi());
            cmd.Parameters.AddWithValue("@p1", txtAd.Text);
            cmd.Parameters.AddWithValue("@p2", txtYetkili.Text);
            cmd.Parameters.AddWithValue("@p3", txtYGorev.Text);
            cmd.Parameters.AddWithValue("@p4", mskTC.Text);
            cmd.Parameters.AddWithValue("@p5", txtSektor.Text);
            cmd.Parameters.AddWithValue("@p6", mskTel1.Text);
            cmd.Parameters.AddWithValue("@p7", mskTel2.Text);
            cmd.Parameters.AddWithValue("@p8", mskTel3.Text);
            cmd.Parameters.AddWithValue("@p9", txtMail.Text);
            cmd.Parameters.AddWithValue("@p10", mskFax.Text);
            cmd.Parameters.AddWithValue("@p11", cmbil.Text);
            cmd.Parameters.AddWithValue("@p12", cmbilce.Text);
            cmd.Parameters.AddWithValue("@p13", txtVergiD.Text);
            cmd.Parameters.AddWithValue("@p14", rchAdres.Text);
            cmd.Parameters.AddWithValue("@p15", txtKod1.Text);
            cmd.Parameters.AddWithValue("@p16", txtKod2.Text);
            cmd.Parameters.AddWithValue("@p17", txtKod3.Text);
            cmd.ExecuteNonQuery();
            bgl.baglantisi().Close();
            MessageBox.Show("Kayıt İşlemi Başarıyla Gerçekleşti");
            firmalistele();
            temizle();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
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

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete from TBL_FIRMALAR where ID=@p1",bgl.baglantisi());
            cmd.Parameters.AddWithValue("@p1",txtId.Text);
            cmd.ExecuteNonQuery();
            bgl.baglantisi().Close();
            MessageBox.Show("Silme İşlemi Başarıyla Gerçekleşti");
            firmalistele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Update TBL_FIRMALAR set AD=@p1,YETKILIADSOYAD=@p2,YETKILISTATU=@p3,YETKILITC=@p4,SEKTOR=@p5,TELEFON=@p6,TELEFON2=@p7,TELEFON3=@p8,MAIL=@p9,FAX=@p10,IL=@p11,ILCE=@p12,VERGIDAIRE=@p13,ADRES=@p14,OZELKOD1=@p15,OZELKOD2=@p16,OZELKOD3=@p17 where ID=@p18", bgl.baglantisi());
            cmd.Parameters.AddWithValue("@p1", txtAd.Text);
            cmd.Parameters.AddWithValue("@p2", txtYetkili.Text);
            cmd.Parameters.AddWithValue("@p3", txtYGorev.Text);
            cmd.Parameters.AddWithValue("@p4", mskTC.Text);
            cmd.Parameters.AddWithValue("@p5", txtSektor.Text);
            cmd.Parameters.AddWithValue("@p6", mskTel1.Text);
            cmd.Parameters.AddWithValue("@p7", mskTel2.Text);
            cmd.Parameters.AddWithValue("@p8", mskTel3.Text);
            cmd.Parameters.AddWithValue("@p9", txtMail.Text);
            cmd.Parameters.AddWithValue("@p10", mskFax.Text);
            cmd.Parameters.AddWithValue("@p11", cmbil.Text);
            cmd.Parameters.AddWithValue("@p12", cmbilce.Text);
            cmd.Parameters.AddWithValue("@p13", txtVergiD.Text);
            cmd.Parameters.AddWithValue("@p14", rchAdres.Text);
            cmd.Parameters.AddWithValue("@p15", txtKod1.Text);
            cmd.Parameters.AddWithValue("@p16", txtKod2.Text);
            cmd.Parameters.AddWithValue("@p17", txtKod3.Text);
            cmd.Parameters.AddWithValue("@p18", txtId.Text);
            cmd.ExecuteNonQuery();
            bgl.baglantisi().Close();
            MessageBox.Show("Güncelleme İşlemi Başarıyla Gerçekleşti");
            firmalistele();
            temizle();

        }
    }
}
