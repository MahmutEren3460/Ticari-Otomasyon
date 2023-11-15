namespace Ticari_Otomasyon
{
    partial class FormAna
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAna));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnUrun = new DevExpress.XtraBars.BarButtonItem();
            this.btnStok = new DevExpress.XtraBars.BarButtonItem();
            this.btnMusteri = new DevExpress.XtraBars.BarButtonItem();
            this.btnFirma = new DevExpress.XtraBars.BarButtonItem();
            this.btnAnaSayfa = new DevExpress.XtraBars.BarButtonItem();
            this.btnPersonel = new DevExpress.XtraBars.BarButtonItem();
            this.btnGider = new DevExpress.XtraBars.BarButtonItem();
            this.btnKasa = new DevExpress.XtraBars.BarButtonItem();
            this.btnNot = new DevExpress.XtraBars.BarButtonItem();
            this.btnBanka = new DevExpress.XtraBars.BarButtonItem();
            this.btnRehber = new DevExpress.XtraBars.BarButtonItem();
            this.btnFatura = new DevExpress.XtraBars.BarButtonItem();
            this.btnAyarlar = new DevExpress.XtraBars.BarButtonItem();
            this.btnHareket = new DevExpress.XtraBars.BarButtonItem();
            this.btnRaporlar = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnUrun,
            this.btnStok,
            this.btnMusteri,
            this.btnFirma,
            this.btnAnaSayfa,
            this.btnPersonel,
            this.btnGider,
            this.btnKasa,
            this.btnNot,
            this.btnBanka,
            this.btnRehber,
            this.btnFatura,
            this.btnAyarlar,
            this.btnHareket,
            this.btnRaporlar});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 16;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1924, 177);
            // 
            // btnUrun
            // 
            this.btnUrun.Caption = "ÜRÜNLER";
            this.btnUrun.Id = 1;
            this.btnUrun.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUrun.ImageOptions.Image")));
            this.btnUrun.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUrun.ImageOptions.LargeImage")));
            this.btnUrun.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrun.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnUrun.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrun.ItemAppearance.Normal.Options.UseFont = true;
            this.btnUrun.Name = "btnUrun";
            this.btnUrun.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUrun_ItemClick);
            // 
            // btnStok
            // 
            this.btnStok.Caption = "STOKLAR";
            this.btnStok.Id = 2;
            this.btnStok.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnStok.ImageOptions.Image")));
            this.btnStok.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnStok.ImageOptions.LargeImage")));
            this.btnStok.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStok.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnStok.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStok.ItemAppearance.Normal.Options.UseFont = true;
            this.btnStok.Name = "btnStok";
            this.btnStok.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnStok_ItemClick);
            // 
            // btnMusteri
            // 
            this.btnMusteri.Caption = "MÜŞTERİLER";
            this.btnMusteri.Id = 3;
            this.btnMusteri.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMusteri.ImageOptions.Image")));
            this.btnMusteri.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMusteri.ImageOptions.LargeImage")));
            this.btnMusteri.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteri.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnMusteri.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteri.ItemAppearance.Normal.Options.UseFont = true;
            this.btnMusteri.Name = "btnMusteri";
            this.btnMusteri.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMusteri_ItemClick);
            // 
            // btnFirma
            // 
            this.btnFirma.Caption = "FİRMALAR";
            this.btnFirma.Id = 4;
            this.btnFirma.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFirma.ImageOptions.Image")));
            this.btnFirma.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnFirma.ImageOptions.LargeImage")));
            this.btnFirma.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFirma.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnFirma.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFirma.ItemAppearance.Normal.Options.UseFont = true;
            this.btnFirma.Name = "btnFirma";
            this.btnFirma.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnFirma_ItemClick);
            // 
            // btnAnaSayfa
            // 
            this.btnAnaSayfa.Caption = "ANA SAYFA";
            this.btnAnaSayfa.Id = 5;
            this.btnAnaSayfa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAnaSayfa.ImageOptions.Image")));
            this.btnAnaSayfa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAnaSayfa.ImageOptions.LargeImage")));
            this.btnAnaSayfa.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnaSayfa.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnAnaSayfa.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnaSayfa.ItemAppearance.Normal.Options.UseFont = true;
            this.btnAnaSayfa.Name = "btnAnaSayfa";
            this.btnAnaSayfa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAnaSayfa_ItemClick);
            // 
            // btnPersonel
            // 
            this.btnPersonel.Caption = "PERSONELLER";
            this.btnPersonel.Id = 6;
            this.btnPersonel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPersonel.ImageOptions.Image")));
            this.btnPersonel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPersonel.ImageOptions.LargeImage")));
            this.btnPersonel.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonel.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnPersonel.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonel.ItemAppearance.Normal.Options.UseFont = true;
            this.btnPersonel.Name = "btnPersonel";
            this.btnPersonel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPersonel_ItemClick);
            // 
            // btnGider
            // 
            this.btnGider.Caption = "GİDERLER";
            this.btnGider.Id = 7;
            this.btnGider.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGider.ImageOptions.Image")));
            this.btnGider.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGider.ImageOptions.LargeImage")));
            this.btnGider.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGider.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnGider.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGider.ItemAppearance.Normal.Options.UseFont = true;
            this.btnGider.Name = "btnGider";
            this.btnGider.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGider_ItemClick);
            // 
            // btnKasa
            // 
            this.btnKasa.Caption = "KASA";
            this.btnKasa.Id = 8;
            this.btnKasa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKasa.ImageOptions.Image")));
            this.btnKasa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnKasa.ImageOptions.LargeImage")));
            this.btnKasa.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKasa.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnKasa.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKasa.ItemAppearance.Normal.Options.UseFont = true;
            this.btnKasa.Name = "btnKasa";
            this.btnKasa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKasa_ItemClick);
            // 
            // btnNot
            // 
            this.btnNot.Caption = "NOTLAR";
            this.btnNot.Id = 9;
            this.btnNot.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNot.ImageOptions.Image")));
            this.btnNot.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNot.ImageOptions.LargeImage")));
            this.btnNot.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNot.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnNot.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNot.ItemAppearance.Normal.Options.UseFont = true;
            this.btnNot.Name = "btnNot";
            this.btnNot.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNot_ItemClick);
            // 
            // btnBanka
            // 
            this.btnBanka.Caption = "BANKALAR";
            this.btnBanka.Id = 10;
            this.btnBanka.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBanka.ImageOptions.Image")));
            this.btnBanka.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBanka.ImageOptions.LargeImage")));
            this.btnBanka.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBanka.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnBanka.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBanka.ItemAppearance.Normal.Options.UseFont = true;
            this.btnBanka.Name = "btnBanka";
            this.btnBanka.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBanka_ItemClick);
            // 
            // btnRehber
            // 
            this.btnRehber.Caption = "REHBER";
            this.btnRehber.Id = 11;
            this.btnRehber.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRehber.ImageOptions.Image")));
            this.btnRehber.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRehber.ImageOptions.LargeImage")));
            this.btnRehber.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRehber.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnRehber.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRehber.ItemAppearance.Normal.Options.UseFont = true;
            this.btnRehber.Name = "btnRehber";
            this.btnRehber.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRehber_ItemClick);
            // 
            // btnFatura
            // 
            this.btnFatura.Caption = "FATURALAR";
            this.btnFatura.Id = 12;
            this.btnFatura.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFatura.ImageOptions.Image")));
            this.btnFatura.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnFatura.ImageOptions.LargeImage")));
            this.btnFatura.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFatura.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnFatura.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFatura.ItemAppearance.Normal.Options.UseFont = true;
            this.btnFatura.Name = "btnFatura";
            this.btnFatura.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnFatura_ItemClick);
            // 
            // btnAyarlar
            // 
            this.btnAyarlar.Caption = "AYARLAR";
            this.btnAyarlar.Id = 13;
            this.btnAyarlar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAyarlar.ImageOptions.Image")));
            this.btnAyarlar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAyarlar.ImageOptions.LargeImage")));
            this.btnAyarlar.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAyarlar.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnAyarlar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAyarlar.ItemAppearance.Normal.Options.UseFont = true;
            this.btnAyarlar.Name = "btnAyarlar";
            this.btnAyarlar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAyarlar_ItemClick);
            // 
            // btnHareket
            // 
            this.btnHareket.Caption = "HAREKETLER";
            this.btnHareket.Id = 14;
            this.btnHareket.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHareket.ImageOptions.Image")));
            this.btnHareket.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHareket.ImageOptions.LargeImage")));
            this.btnHareket.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHareket.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnHareket.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHareket.ItemAppearance.Normal.Options.UseFont = true;
            this.btnHareket.Name = "btnHareket";
            this.btnHareket.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHareket_ItemClick);
            // 
            // btnRaporlar
            // 
            this.btnRaporlar.Caption = "RAPORLAR";
            this.btnRaporlar.Id = 15;
            this.btnRaporlar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRaporlar.ImageOptions.Image")));
            this.btnRaporlar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRaporlar.ImageOptions.LargeImage")));
            this.btnRaporlar.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRaporlar.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnRaporlar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRaporlar.ItemAppearance.Normal.Options.UseFont = true;
            this.btnRaporlar.Name = "btnRaporlar";
            this.btnRaporlar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRaporlar_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "TİCARİ OTOMASYON";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnAnaSayfa);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnUrun);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnStok);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnMusteri);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnFirma);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnPersonel);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnNot);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnGider);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnKasa);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnBanka);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnRehber);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnFatura);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnHareket);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnRaporlar);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnAyarlar);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // FormAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "FormAna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnUrun;
        private DevExpress.XtraBars.BarButtonItem btnStok;
        private DevExpress.XtraBars.BarButtonItem btnMusteri;
        private DevExpress.XtraBars.BarButtonItem btnFirma;
        private DevExpress.XtraBars.BarButtonItem btnAnaSayfa;
        private DevExpress.XtraBars.BarButtonItem btnPersonel;
        private DevExpress.XtraBars.BarButtonItem btnGider;
        private DevExpress.XtraBars.BarButtonItem btnKasa;
        private DevExpress.XtraBars.BarButtonItem btnNot;
        private DevExpress.XtraBars.BarButtonItem btnBanka;
        private DevExpress.XtraBars.BarButtonItem btnRehber;
        private DevExpress.XtraBars.BarButtonItem btnFatura;
        private DevExpress.XtraBars.BarButtonItem btnAyarlar;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem btnHareket;
        private DevExpress.XtraBars.BarButtonItem btnRaporlar;
    }
}

