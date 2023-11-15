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
    public partial class FormBankalar : Form
    {
        public FormBankalar()
        {
            InitializeComponent();
        }
        baglanti bgl = new baglanti();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("execute BankaBilgiler", bgl.baglantisi());
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

        void firmalistele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select ID,AD from TBL_FIRMALAR",bgl.baglantisi());
            da.Fill(dt);
            lookUpEdit1.Properties.ValueMember = "ID";
            lookUpEdit1.Properties.DisplayMember = "AD";
            lookUpEdit1.Properties.DataSource = dt;
        }

        void temizle()
        {
            txtId.Text = "";
            txtBankaAd.Text = "";
            txtHesapNo.Text = "";
            txtHesapTur.Text = "";
            txtSube.Text = "";
            txtYetkili.Text = "";
            cmbil.Text = "";
            cmbilce.Text = "";
            mskIban.Text = "";
            mskTarih.Text = "";
            mskTel.Text = "";
        }

        private void FormBankalar_Load(object sender, EventArgs e)
        {
            listele();
            sehirlistesi();
            firmalistele();
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

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into TBL_BANKA (BANKAADI,IL,ILCE,SUBE,IBAN,HESAPNO,YETKILI,TELEFON,TARIH,HESAPTURU,FIRMAID) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)",bgl.baglantisi());
            cmd.Parameters.AddWithValue("@p1",txtBankaAd.Text);
            cmd.Parameters.AddWithValue("@p2", cmbil.Text);
            cmd.Parameters.AddWithValue("@p3", cmbilce.Text);
            cmd.Parameters.AddWithValue("@p4", txtSube.Text);
            cmd.Parameters.AddWithValue("@p5", mskIban.Text);
            cmd.Parameters.AddWithValue("@p6", txtHesapNo.Text);
            cmd.Parameters.AddWithValue("@p7", txtYetkili.Text);
            cmd.Parameters.AddWithValue("@p8", mskTel.Text);
            cmd.Parameters.AddWithValue("@p9", mskTarih.Text);
            cmd.Parameters.AddWithValue("@p10", txtHesapTur.Text);
            cmd.Parameters.AddWithValue("@p11", lookUpEdit1.EditValue);
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
            txtBankaAd.Text = dr["BANKAADI"].ToString();
            txtHesapNo.Text = dr["HESAPNO"].ToString();
            txtHesapTur.Text = dr["HESAPTURU"].ToString();
            txtSube.Text = dr["SUBE"].ToString();
            txtYetkili.Text = dr["YETKILI"].ToString();
            mskTel.Text = dr["TELEFON"].ToString();
            cmbil.Text = dr["IL"].ToString();
            cmbilce.Text = dr["ILCE"].ToString();
            mskTarih.Text = dr["TARIH"].ToString();
            mskIban.Text = dr["IBAN"].ToString();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Müşteri Silinsin mi?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("DELETE From TBL_BANKA WHERE ID=@p1", bgl.baglantisi());
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
            SqlCommand cmd = new SqlCommand("update TBL_BANKA set BANKAADI=@p1,IL=@p2,ILCE=@p3,SUBE=@P4,IBAN=@p5,HESAPNO=@p6,YETKILI=@p7,TELEFON=@p8,TARIH=@p9,HESAPTURU=@p10,FIRMAID=@p11 where ID=@p12",bgl.baglantisi());
            cmd.Parameters.AddWithValue("@p1", txtBankaAd.Text);
            cmd.Parameters.AddWithValue("@p2", cmbil.Text);
            cmd.Parameters.AddWithValue("@p3", cmbilce.Text);
            cmd.Parameters.AddWithValue("@p4", txtSube.Text);
            cmd.Parameters.AddWithValue("@p5", mskIban.Text);
            cmd.Parameters.AddWithValue("@p6", txtHesapNo.Text);
            cmd.Parameters.AddWithValue("@p7", txtYetkili.Text);
            cmd.Parameters.AddWithValue("@p8", mskTel.Text);
            cmd.Parameters.AddWithValue("@p9", mskTarih.Text);
            cmd.Parameters.AddWithValue("@p10", txtHesapTur.Text);
            cmd.Parameters.AddWithValue("@p11", lookUpEdit1.EditValue);
            cmd.Parameters.AddWithValue("@p12", txtId.Text);
            cmd.ExecuteNonQuery();
            bgl.baglantisi().Close();
            MessageBox.Show("Güncelleme İşlemi Başarıyla Gerçekleşti");
            listele();
            temizle();
        }
    }
}
