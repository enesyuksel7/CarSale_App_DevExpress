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
    public partial class SubeAdminForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public SubeAdminForm()
        {
            InitializeComponent();
        }

        OtoGaleriDBEntities db = new OtoGaleriDBEntities();
        SubeLog log = new SubeLog();
        public int gsubeid;
        public string gkullanici2;
        public string gsubead;

        public void SubeAdminForm_Load(object sender, EventArgs e)
        {
            LcKullanici.Text = "Hoşgeldiniz: "+gkullanici2;
            LcID.Text = gsubeid.ToString();
        }

        public ArabaKayit argr = null;
        private void BtnArbKyt_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (argr == null || argr.IsDisposed)
            {
                pictureEdit1.Visible = false;
                argr = new ArabaKayit();
                argr.gsubeid = gsubeid;
                argr.MdiParent = this;
                argr.Show();
            }
        }

        public ArabaSatis arst = null;
        private void BtnArbSts_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (arst == null || arst.IsDisposed)
            {
                pictureEdit1.Visible = false;
                arst = new ArabaSatis();
                arst.gsubeid = gsubeid;
                arst.MdiParent = this;
                arst.Show();
            }
        }

        public ArabaSigorta arsg = null;
        private void BtnArbSig_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (arsg == null || arsg.IsDisposed)
            {
                pictureEdit1.Visible = false;
                arsg = new ArabaSigorta();
                arsg.gsubeid = gsubeid;
                arsg.MdiParent = this;
                arsg.Show();
            }
        }

        TumSubelerHarita tsh = null;
        private void BtnSubeler_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (tsh == null || tsh.IsDisposed)
            {
                pictureEdit1.Visible = false;
                tsh = new TumSubelerHarita();
                tsh.MdiParent = this;
                tsh.Show();
            }
        }

        private void BtnRapor_ItemClick(object sender, ItemClickEventArgs e)
        {
            SubeReport rapor = new SubeReport();
            ReportPrintTool rpt = new ReportPrintTool(rapor);
            rpt.ShowRibbonPreview();
            log.KullaniciAdi = gkullanici2;
            log.Tarih = DateTime.Now;
            log.Islem = "Rapor";
            log.Aciklama = "Raporlama yapıldı.";
            db.SubeLog.Add(log);
            db.SaveChanges();
        }

        SubeIstatistik si = null;
        private void BtnIst_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (si == null || si.IsDisposed)
            {
                pictureEdit1.Visible = false;
                si = new SubeIstatistik();
                si.MdiParent = this;
                log.KullaniciAdi = gkullanici2;
                log.Tarih = DateTime.Now;
                log.Islem = "İstatistik";
                log.Aciklama = "İstatistik oluşturuldu.";
                db.SubeLog.Add(log);
                db.SaveChanges();
                si.Show();
            }
        }

        private void BtnLog_ItemClick(object sender, ItemClickEventArgs e)
        {
            SubeLogReport rapor = new SubeLogReport();
            ReportPrintTool rpt = new ReportPrintTool(rapor);
            rpt.ShowRibbonPreview();

            log.KullaniciAdi = gkullanici2;
            log.Tarih = DateTime.Now;
            log.Islem = "Log";
            log.Aciklama = "Log kaydı oluşturuldu.";
            db.SubeLog.Add(log);
            db.SaveChanges();
        }

        private void BtnGeri_ItemClick(object sender, ItemClickEventArgs e)
        {
            GirisForm grf = new GirisForm();
            this.Hide();
            grf.Show();
        }

        SigortaTarih st = null;
        private void BtnSgrTkp_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (st == null || st.IsDisposed)
            {
                pictureEdit1.Visible = false;
                st = new SigortaTarih();
                st.gsubeid = gsubeid;
                st.MdiParent = this;
                st.Show();
            }
        }

        private void BtnCikis_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();
        }
    }
}