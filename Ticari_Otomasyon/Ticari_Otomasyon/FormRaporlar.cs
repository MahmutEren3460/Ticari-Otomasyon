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
    public partial class FormRaporlar : Form
    {
        public FormRaporlar()
        {
            InitializeComponent();
        }

        private void FormRaporlar_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'Dbo_Ticari_OtomasyonDataSet5.TBL_PERSONEL' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.TBL_PERSONELTableAdapter.Fill(this.Dbo_Ticari_OtomasyonDataSet5.TBL_PERSONEL);
            // TODO: Bu kod satırı 'Dbo_Ticari_OtomasyonDataSet3.TBL_GIDERLER' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.TBL_GIDERLERTableAdapter.Fill(this.Dbo_Ticari_OtomasyonDataSet3.TBL_GIDERLER);
            // TODO: Bu kod satırı 'Dbo_Ticari_OtomasyonDataSet2.TBL_MUSTERILER' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.TBL_MUSTERILERTableAdapter.Fill(this.Dbo_Ticari_OtomasyonDataSet2.TBL_MUSTERILER);
            // TODO: Bu kod satırı 'Dbo_Ticari_OtomasyonDataSet.TBL_FIRMALAR' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.TBL_FIRMALARTableAdapter.Fill(this.Dbo_Ticari_OtomasyonDataSet.TBL_FIRMALAR);

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer4.RefreshReport();
            this.reportViewer4.RefreshReport();
            this.reportViewer5.RefreshReport();
        }
    }
}
