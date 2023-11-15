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
    public partial class FormGiderler : Form
    {
        public FormGiderler()
        {
            InitializeComponent();
        }

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_GIDERLER",bgl.baglantisi());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void Temizle()
        {
            txtElektrik.Text = "";
            txtId.Text = "";
            txtEkstra.Text = "";
            txtMaas.Text = "";
            txtSu.Text = "";
            txtDoğalgaz.Text = "";
            txtInternet.Text = "";
            cmbAy.Text = "";
            cmbYıl.Text = "";
            rchAcıklama.Text = "";
        }

        baglanti bgl = new baglanti();
        private void FormGiderler_Load(object sender, EventArgs e)
        {
            listele();

            Temizle();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into TBL_GIDERLER (AY,YIL,ELEKTRIK,SU,DOGALGAZ,INTERNET,MAASLAR,EKSTRA,NOTLAR) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)",bgl.baglantisi());
            cmd.Parameters.AddWithValue("@p1",cmbAy.Text);
            cmd.Parameters.AddWithValue("@p2", cmbYıl.Text);
            cmd.Parameters.AddWithValue("@p3",decimal.Parse (txtElektrik.Text));
            cmd.Parameters.AddWithValue("@p4",decimal.Parse( txtSu.Text));
            cmd.Parameters.AddWithValue("@p5", decimal.Parse( txtDoğalgaz.Text));
            cmd.Parameters.AddWithValue("@p6", decimal.Parse( txtInternet.Text));
            cmd.Parameters.AddWithValue("@p7", decimal.Parse( txtMaas.Text));
            cmd.Parameters.AddWithValue("@p8",decimal.Parse (txtEkstra.Text));
            cmd.Parameters.AddWithValue("@p9",rchAcıklama.Text);
            cmd.ExecuteNonQuery();
            bgl.baglantisi().Close();
            MessageBox.Show("Kayıt İşlemi Başarıyla Gerçekleşti");
            listele();
            Temizle();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete from TBL_GIDERLER where ID=@p1",bgl.baglantisi());
            cmd.Parameters.AddWithValue("@p1", txtId.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Silme İşlemi Başarıyla Gerçekleşti");
            listele();
            Temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtId.Text = dr["ID"].ToString();
            cmbAy.Text = dr["AY"].ToString();
            cmbYıl.Text = dr["YIL"].ToString();
            txtElektrik.Text = dr["ELEKTRIK"].ToString();
            txtSu.Text = dr["SU"].ToString();
            txtDoğalgaz.Text = dr["DOGALGAZ"].ToString();
            txtInternet.Text = dr["INTERNET"].ToString();
            txtMaas.Text = dr["MAASLAR"].ToString();
            txtEkstra.Text = dr["EKSTRA"].ToString();
            rchAcıklama.Text = dr["NOTLAR"].ToString();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update TBL_GIDERLER set AY=@p1,YIL=@p2,ELEKTRIK=@p3,SU=@p4,DOGALGAZ=@p5,INTERNET=@p6,MAASLAR=@p7,EKSTRA=@p8,NOTLAR=@p9 where ID=@p10",bgl.baglantisi());
            cmd.Parameters.AddWithValue("@p1", cmbAy.Text);
            cmd.Parameters.AddWithValue("@p2", cmbYıl.Text);
            cmd.Parameters.AddWithValue("@p3", decimal.Parse(txtElektrik.Text));
            cmd.Parameters.AddWithValue("@p4", decimal.Parse(txtSu.Text));
            cmd.Parameters.AddWithValue("@p5", decimal.Parse(txtDoğalgaz.Text));
            cmd.Parameters.AddWithValue("@p6", decimal.Parse(txtInternet.Text));
            cmd.Parameters.AddWithValue("@p7", decimal.Parse(txtMaas.Text));
            cmd.Parameters.AddWithValue("@p8", decimal.Parse(txtEkstra.Text));
            cmd.Parameters.AddWithValue("@p9", rchAcıklama.Text);
            cmd.Parameters.AddWithValue("@p10",txtId.Text);
            cmd.ExecuteNonQuery();
            bgl.baglantisi().Close();
            MessageBox.Show("Güncelleme İşlemi Başarıyla Gerçekleşti");
            listele();
            Temizle();
        }
    }
}
