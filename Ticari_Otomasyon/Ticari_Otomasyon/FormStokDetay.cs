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
    public partial class FormStokDetay : Form
    {
        public FormStokDetay()
        {
            InitializeComponent();
        }
        public string ad;
        baglanti bgl = new baglanti();
        private void FormStokDetay_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_URUN where URUNAD='" + ad + "'", bgl.baglantisi());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
    }
}
