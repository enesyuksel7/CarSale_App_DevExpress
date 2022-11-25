using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using DevExpress.LookAndFeel;

namespace EnsOtoGaleri
{
    public partial class MasterAdminForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MasterAdminForm()
        {
            InitializeComponent();
        }

        OtoGaleriDBEntities db = new OtoGaleriDBEntities();
        MasterLog log = new MasterLog();
        public string gkullanici;
        public int gsubeid;
        private void MasterAdminForm_Load(object sender, EventArgs e)
        {
            LcKullanici.Text = "Hoşgeldiniz: "+gkullanici;
        }

        MasterAdminler ma = null;
        private void BtnMstAdm_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (ma == null || ma.IsDisposed)
            {
                pictureEdit1.Visible = false;
                ma = new MasterAdminler();
                ma.MdiParent = this;
                ma.Show();
            }
        }

        public SubeAdminleri sad = null;
        private void BtnSbAdm_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (sad == null || sad.IsDisposed)
            {
                pictureEdit1.Visible = false;
                sad = new SubeAdminleri();
                sad.gkullanici = gkullanici;
                sad.MdiParent = this;
                sad.Show();
            }
        }

        public SubeAbonelikleri sab = null;
        private void BtnSbAbn_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (sab == null || sab.IsDisposed)
            {
                pictureEdit1.Visible = false;
                sab = new SubeAbonelikleri();
                sab.gkullanici = gkullanici;
                sab.MdiParent = this;
                sab.Show();
            }
        }

        public Harita hrt = null;
        private void BtnHarita_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (hrt == null || hrt.IsDisposed)
            {
                pictureEdit1.Visible = false;
                hrt = new Harita();
                hrt.MdiParent = this;
                hrt.Show();
            }
        }

        private void BtnRpr_ItemClick(object sender, ItemClickEventArgs e)
        {
            MasterReport rapor = new MasterReport();
            ReportPrintTool rpt = new ReportPrintTool(rapor);
            rpt.ShowRibbonPreview();
            log.KullaniciAdi = gkullanici;
            log.Tarih = DateTime.Now;
            log.Islem = "Rapor";
            log.Aciklama = "Raporlama yapıldı.";
            db.MasterLog.Add(log);
            db.SaveChanges();
        }

        public MasterIstatistik mai = null;
        private void BtnIst_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (mai == null || mai.IsDisposed)
            {
                pictureEdit1.Visible = false;
                mai = new MasterIstatistik();
                mai.MdiParent = this;
                log.KullaniciAdi = gkullanici;
                log.Tarih = DateTime.Now;
                log.Islem = "İstatistik";
                log.Aciklama = "İstatistik oluşturuldu.";
                db.MasterLog.Add(log);
                db.SaveChanges();
                mai.Show();
            }
        }

        private void BtnLog_ItemClick(object sender, ItemClickEventArgs e)
        {
            MasterLogReport rapor = new MasterLogReport();
            ReportPrintTool rpt = new ReportPrintTool(rapor);
            rpt.ShowRibbonPreview();

            log.KullaniciAdi = gkullanici;
            log.Tarih = DateTime.Now;
            log.Islem = "Log";
            log.Aciklama = "Log kaydı oluşturuldu.";
            db.MasterLog.Add(log);
            db.SaveChanges();
        }

        private void BtnGeri_ItemClick(object sender, ItemClickEventArgs e)
        {
            GirisForm gf = new GirisForm();
            this.Hide();
            gf.Show();
        }

        public Hakkimizda hkm = null;
        private void BtnHkmzd_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (hkm == null || hkm.IsDisposed)
            {
                pictureEdit1.Visible = false;
                hkm = new Hakkimizda();
                hkm.MdiParent = this;
                hkm.Show();
            }
        }

        private void BtnCikis_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();
        }
    }
}