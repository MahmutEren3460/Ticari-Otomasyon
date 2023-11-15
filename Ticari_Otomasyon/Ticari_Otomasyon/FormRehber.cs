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
    public partial class FormRehber : Form
    {
        public FormRehber()
        {
            InitializeComponent();
        }
        baglanti bgl = new baglanti();

        void Musteri()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select AD,SOYAD,TELEFON,TELEFON2,MAIL from TBL_MUSTERILER", bgl.baglantisi());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void Firma()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select AD,YETKILIADSOYAD,TELEFON,TELEFON2,TELEFON3,MAIL,FAX from TBL_FIRMALAR",bgl.baglantisi());
            da.Fill(dt);
            gridControl2.DataSource = dt;
        }

        private void FormRehber_Load(object sender, EventArgs e)
        {
            Musteri();
            Firma();
        }
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FormMail frm = new FormMail();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                frm.mail = dr["MAIL"].ToString();
            }
            frm.Show();
        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            FormMail frm = new FormMail();
            DataRow dr = gridView2.GetDataRow(gridView2.FocusedRowHandle);

            if (dr != null)
            {
                frm.mail = dr["MAIL"].ToString();
            }
            frm.Show();
        }
    }
}
