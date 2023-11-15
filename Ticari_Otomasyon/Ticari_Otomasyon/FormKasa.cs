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
using DevExpress.Charts;

namespace Ticari_Otomasyon
{
    public partial class FormKasa : Form
    {
        public FormKasa()
        {
            InitializeComponent();
        }
        baglanti bgl = new baglanti();

        void musterihareket()
        { 
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("execute MusteriHareket", bgl.baglantisi());
            da.Fill(dt);
            gridControl3.DataSource = dt;
        }
        void firmahareket()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("execute FirmaHareket", bgl.baglantisi());
            da.Fill(dt);
            gridControl4.DataSource = dt;
        }
        void ToplamTutar()
        {
            SqlCommand cmd = new SqlCommand("select sum(TUTAR) from TBL_FATURADETAY", bgl.baglantisi());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lblToplamTutar.Text = dr[0].ToString() + " ₺";
            }
            bgl.baglantisi().Close();
        }
        void Odemeler()
        {
            SqlCommand cmd = new SqlCommand("select (ELEKTRIK+SU+DOGALGAZ+INTERNET+EKSTRA) from TBL_GIDERLER order by ID asc", bgl.baglantisi());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lblÖdemeler.Text = dr[0].ToString() + " ₺";
            }
            bgl.baglantisi().Close();
        }
        void PerMaas()
        {

            SqlCommand cmd = new SqlCommand("select MAASLAR from TBL_GIDERLER order by ID asc", bgl.baglantisi());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lblPersonelMaas.Text = dr[0].ToString() + " ₺";
            }
            bgl.baglantisi().Close();
        }
        void Musteri()
        {
            SqlCommand cmd = new SqlCommand("select Count(*) from TBL_MUSTERILER", bgl.baglantisi());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lblMusteri.Text = dr[0].ToString();
            }
            bgl.baglantisi().Close();
        }
        void Fırma()
        {
            SqlCommand cmd = new SqlCommand("select Count(*) from TBL_FIRMALAR", bgl.baglantisi());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lblFirma.Text = dr[0].ToString();
            }
            bgl.baglantisi().Close();
        }
        void FirmaSehir()
        {
            SqlCommand cmd = new SqlCommand("select Count(Distinct(IL)) from TBL_FIRMALAR", bgl.baglantisi());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lblSehir.Text = dr[0].ToString();
            }
            bgl.baglantisi().Close();
        }
        void MusteriSehir()
        {
            SqlCommand cmd = new SqlCommand("select Count(Distinct(IL)) from TBL_MUSTERILER", bgl.baglantisi());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lblSehir2.Text = dr[0].ToString();
            }
            bgl.baglantisi().Close();
        }
        void Personel()
        {
            SqlCommand cmd = new SqlCommand("select Count(*) from TBL_PERSONEL", bgl.baglantisi());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lblPersonelSayısı.Text = dr[0].ToString();
            }
            bgl.baglantisi().Close();
        }
        void Stok()
        {
            SqlCommand cmd = new SqlCommand("select sum(ADET) from TBL_URUN", bgl.baglantisi());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lblStok.Text = dr[0].ToString();
            }
            bgl.baglantisi().Close();
        }
        void Gider()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_GIDERLER", bgl.baglantisi());
            da.Fill(dt);
            gridControl2.DataSource = dt;
        }

        public string ad;
        private void FormKasa_Load(object sender, EventArgs e)
        {
            lblAktif.Text = ad;
            musterihareket();
            firmahareket();
            ToplamTutar();
            Odemeler();
            PerMaas();
            Musteri();
            Fırma();
            FirmaSehir();
            MusteriSehir();
            Personel();
            Stok();
            Gider();
            
        }
        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            if(sayac>0 && sayac < 5)
            {
                groupControl10.Text = "Elektrik";
                chartControl1.Series["Aylar"].Points.Clear();
                SqlCommand cmd = new SqlCommand("select top 4 AY,ELEKTRIK from TBL_GIDERLER order by ID Desc", bgl.baglantisi());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr[0], dr[1]));
                }
                bgl.baglantisi().Close();
            }
            if(sayac > 5 && sayac <= 10)
            {
                groupControl10.Text = "Su";
                chartControl1.Series["Aylar"].Points.Clear();
                SqlCommand cmd = new SqlCommand("select top 4 AY,SU from TBL_GIDERLER order by ID Desc", bgl.baglantisi());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr[0], dr[1]));
                }
                bgl.baglantisi().Close();
            }
            if (sayac > 10 && sayac <= 15)
            {
                groupControl10.Text = "Doğalgaz";
                chartControl1.Series["Aylar"].Points.Clear();
                SqlCommand cmd = new SqlCommand("select top 4 AY,DOGALGAZ from TBL_GIDERLER order by ID Desc", bgl.baglantisi());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr[0], dr[1]));
                }
                bgl.baglantisi().Close();
            }
            if (sayac > 15 && sayac <= 20)
            {
                groupControl10.Text = "İnternet";
                chartControl1.Series["Aylar"].Points.Clear();
                SqlCommand cmd = new SqlCommand("select top 4 AY,INTERNET from TBL_GIDERLER order by ID Desc", bgl.baglantisi());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr[0], dr[1]));
                }
                bgl.baglantisi().Close();
            }
            if (sayac > 20 && sayac <= 25)
            {
                groupControl10.Text = "Ekstra";
                chartControl1.Series["Aylar"].Points.Clear();
                SqlCommand cmd = new SqlCommand("select top 4 AY,EKSTRA from TBL_GIDERLER order by ID Desc", bgl.baglantisi());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr[0], dr[1]));
                }
                bgl.baglantisi().Close();
            }
            if (sayac == 26)
            {
                sayac = 0;
            }
        }
        int sayac2 = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            sayac2++;
            if (sayac2> 0 && sayac2< 5)
            {
                groupControl11.Text = "Elektrik";
                chartControl2.Series["Aylar"].Points.Clear();
                SqlCommand cmd = new SqlCommand("select top 4 AY,ELEKTRIK from TBL_GIDERLER order by ID Desc", bgl.baglantisi());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr[0], dr[1]));
                }
                bgl.baglantisi().Close();
            }
            if (sayac2 > 5 && sayac2 <= 10)
            {
                groupControl11.Text = "Su";
                chartControl2.Series["Aylar"].Points.Clear();
                SqlCommand cmd = new SqlCommand("select top 4 AY,SU from TBL_GIDERLER order by ID Desc", bgl.baglantisi());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr[0], dr[1]));
                }
                bgl.baglantisi().Close();
            }
            if (sayac2 > 10 && sayac2 <= 15)
            {
                groupControl11.Text = "Doğalgaz";
                chartControl2.Series["Aylar"].Points.Clear();
                SqlCommand cmd = new SqlCommand("select top 4 AY,DOGALGAZ from TBL_GIDERLER order by ID Desc", bgl.baglantisi());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr[0], dr[1]));
                }
                bgl.baglantisi().Close();
            }
            if (sayac2 > 15 && sayac2 <= 20)
            {
                groupControl11.Text = "İnternet";
                chartControl2.Series["Aylar"].Points.Clear();
                SqlCommand cmd = new SqlCommand("select top 4 AY,INTERNET from TBL_GIDERLER order by ID Desc", bgl.baglantisi());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr[0], dr[1]));
                }
                bgl.baglantisi().Close();
            }
            if (sayac2 > 20 && sayac2 <= 25)
            {
                groupControl11.Text = "Ekstra";
                chartControl2.Series["Aylar"].Points.Clear();
                SqlCommand cmd = new SqlCommand("select top 4 AY,EKSTRA from TBL_GIDERLER order by ID Desc", bgl.baglantisi());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr[0], dr[1]));
                }
                bgl.baglantisi().Close();
            }
            if (sayac2 == 26)
            {
                sayac2 = 0;
            }
        }
    }
}
