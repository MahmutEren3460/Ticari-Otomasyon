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
    public partial class FormNotlar : Form
    {
        public FormNotlar()
        {
            InitializeComponent();
        }
        baglanti bgl = new baglanti();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_NOT",bgl.baglantisi());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void temizle()
        {
            txtId.Text = "";
            txtBaslık.Text = "";
            txtHitap.Text = "";
            txtOlusturan.Text = "";
            mskTarih.Text = "";
            mskSaat.Text = "";
            rchDetay.Text = "";
        }

        private void FormNotlar_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into TBL_NOT (TARIH,SAAT,BASLIK,DETAY,OLUSTURAN,HITAP) values (@p1,@p2,@p3,@p4,@p5,@p6)",bgl.baglantisi());
            cmd.Parameters.AddWithValue("@p1",mskTarih.Text);
            cmd.Parameters.AddWithValue("@p2",mskSaat.Text);
            cmd.Parameters.AddWithValue("@p3",txtBaslık.Text);
            cmd.Parameters.AddWithValue("@p4", rchDetay.Text);
            cmd.Parameters.AddWithValue("@p5", txtOlusturan.Text);
            cmd.Parameters.AddWithValue("@p6", txtHitap.Text);
            cmd.ExecuteNonQuery();
            bgl.baglantisi().Close();
            MessageBox.Show("Kayıt İşlemi Başarıyla Gerçekleşti");
            listele();
            temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtId.Text = dr["NOTID"].ToString();
            mskTarih.Text = dr["TARIH"].ToString();
            mskSaat.Text = dr["SAAT"].ToString();
            txtBaslık.Text = dr["BASLIK"].ToString();
            rchDetay.Text = dr["DETAY"].ToString();
            txtOlusturan.Text = dr["OLUSTURAN"].ToString();
            txtHitap.Text = dr["HITAP"].ToString();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Not Silinsin mi?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("DELETE From TBL_NOT WHERE NOTID=@p1", bgl.baglantisi());
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
            SqlCommand cmd = new SqlCommand("update TBL_NOT set TARIH=@p1,SAAT=@p2,BASLIK=@p3,DETAY=@p4,OLUSTURAN=@p5,HITAP=@p6 where NOTID=@p7",bgl.baglantisi());
            cmd.Parameters.AddWithValue("@p1", mskTarih.Text);
            cmd.Parameters.AddWithValue("@p2", mskSaat.Text);
            cmd.Parameters.AddWithValue("@p3", txtBaslık.Text);
            cmd.Parameters.AddWithValue("@p4", rchDetay.Text);
            cmd.Parameters.AddWithValue("@p5", txtOlusturan.Text);
            cmd.Parameters.AddWithValue("@p6", txtHitap.Text);
            cmd.Parameters.AddWithValue("@p7", txtId.Text);
            cmd.ExecuteNonQuery();
            bgl.baglantisi().Close();
            MessageBox.Show("Güncelleme İşlemi Başarıyla Gerçekleşti");
            listele();
            temizle();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FormNotDetay fnd = new FormNotDetay();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                fnd.metin = dr[4].ToString();
            }
            fnd.Show();
        }
    }
}
