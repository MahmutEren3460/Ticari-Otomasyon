using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticari_Otomasyon
{
    public partial class FormAna : Form
    {
        public FormAna()
        {
            InitializeComponent();
        }
        public string kullanici;
        private void Form1_Load(object sender, EventArgs e)
        {
            fas = new FormAnaSayfa();
            fas.MdiParent = this;
            fas.Show();
        }
        FormUrun fru;
        private void btnUrun_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           // if (fru==null)
            {
                fru = new FormUrun();
                fru.MdiParent = this;
                fru.Show();
            }
        }
        FormMusteri frm;
        private void btnMusteri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm = new FormMusteri();
            frm.MdiParent = this;
            frm.Show();
        }
        FormFirmalar frf;
        private void btnFirma_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frf = new FormFirmalar();
            frf.MdiParent = this;
            frf.Show();
        }
        FormPersonel frp;
        private void btnPersonel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frp = new FormPersonel();
            frp.MdiParent = this;
            frp.Show();
        }
        FormRehber frr;
        private void btnRehber_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frr = new FormRehber();
            frr.MdiParent = this;
            frr.Show();
        }
        FormGiderler frg;
        private void btnGider_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frg = new FormGiderler();
            frg.MdiParent = this;
            frg.Show();
        }
        FormBankalar frb;
        private void btnBanka_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frb = new FormBankalar();
            frb.MdiParent = this;
            frb.Show();
        }
        FormFaturalar frf2;
        private void btnFatura_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frf2 = new FormFaturalar();
            frf2.MdiParent = this;
            frf2.Show();
        }
        FormNotlar frn;
        private void btnNot_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frn = new FormNotlar();
            frn.MdiParent = this;
            frn.Show();
        }
        FormHareket frh;
        private void btnHareket_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frh = new FormHareket();
            frh.MdiParent = this;
            frh.Show();
        }
        FormRaporlar frr2;
        private void btnRaporlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frr2 = new FormRaporlar();
            frr2.MdiParent = this;
            frr2.Show();
        }
        FormStok frs;
        private void btnStok_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frs = new FormStok();
            frs.MdiParent = this;
            frs.Show();
        }
        FormAyarlar fra;
        private void btnAyarlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fra = new FormAyarlar();
            fra.Show();
        }
        FormKasa fsk;
        private void btnKasa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fsk = new FormKasa();
            fsk.ad = kullanici;
            fsk.MdiParent = this;
            fsk.Show();
        }
        FormAnaSayfa fas;
        private void btnAnaSayfa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fas = new FormAnaSayfa();
            fas.MdiParent = this;
            fas.Show();
        }
    }
}
