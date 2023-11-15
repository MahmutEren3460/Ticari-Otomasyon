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
    public partial class FormHareket : Form
    {
        public FormHareket()
        {
            InitializeComponent();
        }

        baglanti bgl = new baglanti();

        void Musterilistele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Exec MusteriHareket",bgl.baglantisi());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void FirmaListele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Exec FirmaHareket", bgl.baglantisi());
            da.Fill(dt);
            gridControl2.DataSource = dt;
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {

        }

        private void FormHareket_Load(object sender, EventArgs e)
        {
            Musterilistele();
            FirmaListele();
        }
    }
}
