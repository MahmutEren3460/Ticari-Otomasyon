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
    public partial class FormFaturaUrunler : Form
    {
        public FormFaturaUrunler()
        {
            InitializeComponent();
        }
        public string id;
        baglanti bgl = new baglanti();

        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_FATURADETAY where FATURAID='" + id+"'",bgl.baglantisi());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void FormFaturaUrunler_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            FormFaturaUrunDuzenleme ffud = new FormFaturaUrunDuzenleme();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (ffud!=null)
            {
                ffud.urunid = dr["FATURAURUNID"].ToString();
            }
            ffud.Show();
        }
    }
}
