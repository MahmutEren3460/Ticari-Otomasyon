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
    public partial class FormStok : Form
    {
        public FormStok()
        {
            InitializeComponent();
        }
        baglanti bgl = new baglanti();
        private void FormStok_Load(object sender, EventArgs e)
        {          
            SqlDataAdapter da = new SqlDataAdapter("select URUNAD,sum(ADET) As 'Miktar' from TBL_URUN group by URUNAD", bgl.baglantisi());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;

            //charta stok listeleme
            SqlCommand cmd = new SqlCommand("select URUNAD,sum(ADET) As 'Miktar' from TBL_URUN group by URUNAD",bgl.baglantisi());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]),int.Parse( dr[1].ToString()));
            }
            bgl.baglantisi().Close();

            //charta şehir listeleme
            SqlCommand cmd2 = new SqlCommand("select IL,count(*) from TBL_FIRMALAR Group by IL",bgl.baglantisi());
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                chartControl2.Series["Series 1"].Points.AddPoint(Convert.ToString(dr2[0]), int.Parse(dr2[1].ToString()));
            }
            bgl.baglantisi().Close();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FormStokDetay fsd = new FormStokDetay();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (fsd != null)
            {
                fsd.ad = dr["URUNAD"].ToString();
            }
            fsd.Show();
        }
    }
}
