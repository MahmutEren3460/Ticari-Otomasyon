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
using System.Xml;

namespace Ticari_Otomasyon
{
    public partial class FormAnaSayfa : Form
    {
        public FormAnaSayfa()
        {
            InitializeComponent();
        }
        baglanti bgl = new baglanti();
        void Stok()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select URUNAD,sum(ADET) as 'Adet' from TBL_URUN group by URUNAD having sum(ADET)<20 order by sum(ADET)", bgl.baglantisi());
            da.Fill(dt);
            gridControl2.DataSource = dt;
        }
        void Ajanda()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select top 5 TARIH,SAAT,BASLIK from TBL_NOT order by NOTID desc", bgl.baglantisi());
            da.Fill(dt);
            gridControl3.DataSource = dt;
        }
        void FirmaListele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Exec FirmaHareket2", bgl.baglantisi());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void Fihrist()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select AD,TELEFON from TBL_FIRMALAR", bgl.baglantisi());
            da.Fill(dt);
            gridControl4.DataSource = dt;
        }
        /*void haberler()
        {
            XmlTextReader xmloku = new XmlTextReader("https://www.hurriyet.com.tr/rss/anasayfa");
            while (xmloku.Read())
            {
                if (xmloku.Name == "title")
                {
                    listBox1.Items.Add(xmloku.ReadString());
                }
            }
        }*/
        private void FormAnaSayfa_Load(object sender, EventArgs e)
        {
            Stok();
            Ajanda();
            FirmaListele();
            Fihrist();
            webBrowser1.Navigate("https://www.tcmb.gov.tr/wps/wcm/connect/tr/tcmb+tr/main+page+site+area/bugun");
            //haberler();
            webBrowser2.Navigate("https://www.hurriyet.com.tr/");
        }
    }
}
