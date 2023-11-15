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
    public partial class FormUrun : Form
    {
        public FormUrun()
        {
            InitializeComponent();
        }
        baglanti bgl = new baglanti();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_URUN Order by ID asc",bgl.baglantisi());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void temizle()
        {
            txtId.Text = "";
            txtAd.Text = "";
            txtMarka.Text = "";
            txtModel.Text = "";
            mskYil.Text = "";
            nudAdet.Value = int.Parse("0");
            txtAlisFiyat.Text = "";
            txtSatisFiyat.Text = "";
            rchDetay.Text = "";
            txtAd.Focus();
        }

        private void FormUrun_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into TBL_URUN (URUNAD,MARKA,MODEL,YIL,ADET,ALISFIYAT,SATISFIYAT,DETAY) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)",bgl.baglantisi());
            cmd.Parameters.AddWithValue("@p1",txtAd.Text);
            cmd.Parameters.AddWithValue("@p2", txtMarka.Text);
            cmd.Parameters.AddWithValue("@p3", txtModel.Text);
            cmd.Parameters.AddWithValue("@p4", mskYil.Text);
            cmd.Parameters.AddWithValue("@p5", int.Parse(nudAdet.Value.ToString()));
            cmd.Parameters.AddWithValue("@p6", decimal.Parse(txtAlisFiyat.Text.ToString()));
            cmd.Parameters.AddWithValue("@p7", decimal.Parse(txtSatisFiyat.Text.ToString()));
            cmd.Parameters.AddWithValue("@p8", rchDetay.Text);
            cmd.ExecuteNonQuery();
            bgl.baglantisi().Close();
            MessageBox.Show("Kayıt İşlemi Başarıyla Gerçekleşti");
            listele();
            temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Ürün Silinsin mi?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("DELETE From TBL_URUN WHERE ID=@p1", bgl.baglantisi());
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

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtId.Text = dr["ID"].ToString();
            txtAd.Text = dr["URUNAD"].ToString();
            txtMarka.Text = dr["MARKA"].ToString();
            txtModel.Text = dr["MODEL"].ToString();
            mskYil.Text = dr["YIL"].ToString();
            nudAdet.Value = int.Parse(dr["ADET"].ToString());
            txtAlisFiyat.Text = dr["ALISFIYAT"].ToString();
            txtSatisFiyat.Text = dr["SATISFIYAT"].ToString();
            rchDetay.Text = dr["DETAY"].ToString();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update TBL_URUN set URUNAD=@p1,MARKA=@p2,MODEL=@p3,YIL=@p4,ADET=@p5,ALISFIYAT=@p6,SATISFIYAT=@p7,DETAY=@p8 where ID=@p9",bgl.baglantisi());
            cmd.Parameters.AddWithValue("@p1", txtAd.Text);
            cmd.Parameters.AddWithValue("@p2", txtMarka.Text);
            cmd.Parameters.AddWithValue("@p3", txtModel.Text);
            cmd.Parameters.AddWithValue("@p4", mskYil.Text);
            cmd.Parameters.AddWithValue("@p5", int.Parse(nudAdet.Value.ToString()));
            cmd.Parameters.AddWithValue("@p6", decimal.Parse(txtAlisFiyat.Text.ToString()));
            cmd.Parameters.AddWithValue("@p7", decimal.Parse(txtSatisFiyat.Text.ToString()));
            cmd.Parameters.AddWithValue("@p8", rchDetay.Text);
            cmd.Parameters.AddWithValue("@p9", txtId.Text);
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
