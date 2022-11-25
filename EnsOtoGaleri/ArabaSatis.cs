using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace EnsOtoGaleri
{
    public partial class ArabaSatis : DevExpress.XtraEditors.XtraForm
    {
        public ArabaSatis()
        {
            InitializeComponent();
        }

        OtoGaleriDBEntities db = new OtoGaleriDBEntities();
        Satislar sts = new Satislar();
        SubeLog log = new SubeLog();
        public string kullanici;
        public int gsubeid;
        public void listele()
        {
            var sorgu1 = (from x in db.Arabalar.Where(a => a.SubeID == gsubeid) select new { x.ArabaID, x.SubeID, x.Marka, x.Model }).ToList();
            gridControl1.DataSource = sorgu1;

            var sorgu2 = (from x in db.Satislar.Where(a => a.SubeID == gsubeid) select new { x.SatisID, x.ArabaID, x.SubeID, x.Marka, x.Model, x.AdSoyad, x.Ucret, x.Tarih, x.TelNo }).ToList();
            gridControl2.DataSource = sorgu2;
        }

        private void ArabaSatis_Load(object sender, EventArgs e)
        {
            var sorgu = db.SubeAdmin.Where(x => x.SubeID == gsubeid).FirstOrDefault();
            listele();
            kullanici = sorgu.KullaniciAdi.ToString();
            TeSatisID.Enabled = TeArabaID.Enabled = TeMarka.Enabled = TeModel.Enabled = false;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TeArabaID.Text = gridView1.GetFocusedRowCellValue("ArabaID").ToString();
            TeSubeID.Text = gridView1.GetFocusedRowCellValue("SubeID").ToString();
            TeMarka.Text = gridView1.GetFocusedRowCellValue("Marka").ToString();
            TeModel.Text = gridView1.GetFocusedRowCellValue("Model").ToString();
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridView2.RowCount == 0)
            {
                XtraMessageBox.Show("Tabloda kayıtlı veri bulunamadı!", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                TeSatisID.Text = gridView2.GetFocusedRowCellValue("SatisID").ToString();
                TeArabaID.Text = gridView2.GetFocusedRowCellValue("ArabaID").ToString();
                TeSubeID.Text = gridView2.GetFocusedRowCellValue("SubeID").ToString();
                TeMarka.Text = gridView2.GetFocusedRowCellValue("Marka").ToString();
                TeModel.Text = gridView2.GetFocusedRowCellValue("Model").ToString();
                TeAdSoyad.Text = gridView2.GetFocusedRowCellValue("AdSoyad").ToString();
                TeUcret.Text = gridView2.GetFocusedRowCellValue("Ucret").ToString();
                dateEdit1.Text = gridView2.GetFocusedRowCellValue("Tarih").ToString();
                TeTelNo.Text = gridView2.GetFocusedRowCellValue("TelNo").ToString();
            }
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            sts.ArabaID = Convert.ToInt32(TeArabaID.Text);
            sts.SubeID = Convert.ToInt32(TeSubeID.Text);
            sts.Marka = TeMarka.Text;
            sts.Model = TeModel.Text;
            sts.AdSoyad = TeAdSoyad.Text;
            sts.Ucret = Convert.ToInt32(TeUcret.Text);
            sts.Tarih = dateEdit1.DateTime;
            sts.TelNo = Convert.ToInt32(TeTelNo.Text);
            db.Satislar.Add(sts);
            log.KullaniciAdi = kullanici;
            log.Tarih = DateTime.Now;
            log.Islem = "Ekle";
            log.Aciklama = "Araba satış kaydı eklendi.";
            db.SubeLog.Add(log);
            db.SaveChanges();
            listele();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int SecilenId = Convert.ToInt32(gridView2.GetFocusedRowCellValue("SatisID").ToString());
            var a = (from x in db.Satislar where x.SatisID == SecilenId select x).FirstOrDefault();
            a.ArabaID = Convert.ToInt32(TeArabaID.Text);
            a.Marka = TeMarka.Text;
            a.Model = TeModel.Text;
            a.AdSoyad = TeAdSoyad.Text;
            a.Ucret = Convert.ToInt32(TeUcret.Text);
            a.Tarih = dateEdit1.DateTime;
            a.TelNo = Convert.ToInt32(TeTelNo.Text);
            //db.Entry(sts).State = System.Data.Entity.EntityState.Modified;
            log.KullaniciAdi = kullanici;
            log.Tarih = DateTime.Now;
            log.Islem = "Güncelle";
            log.Aciklama = "Araba satış kaydı güncellendi.";
            db.SubeLog.Add(log);
            db.SaveChanges();
            listele();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int SecilenIndex = gridView1.FocusedRowHandle;
            if (SecilenIndex > -1)
            {
                int SecilenId = Convert.ToInt32(gridView2.GetFocusedRowCellValue("SatisID").ToString());
                var a = (from x in db.Satislar where x.SatisID == SecilenId select x).FirstOrDefault();
                db.Satislar.Remove(a);
                log.KullaniciAdi = kullanici;
                log.Tarih = DateTime.Now;
                log.Islem = "Sil";
                log.Aciklama = "Araba satış kaydı silindi.";
                db.SubeLog.Add(log);
                db.SaveChanges();
                listele();
            }
            else
                XtraMessageBox.Show("Lütfen satır seçiniz!", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }
    }
}