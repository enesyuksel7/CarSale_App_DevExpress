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
    public partial class ArabaSigorta : DevExpress.XtraEditors.XtraForm
    {
        public ArabaSigorta()
        {
            InitializeComponent();
        }

        OtoGaleriDBEntities db = new OtoGaleriDBEntities();
        Sigortalar sgt = new Sigortalar();
        SubeLog log = new SubeLog();
        public string kullanici;
        public int gsubeid;

        public void listele()
        {
            var sorgu1 = (from x in db.Satislar.Where(a => a.SubeID == gsubeid) select new { x.SatisID, x.ArabaID, x.SubeID, x.Marka, x.Model }).ToList();
            gridControl1.DataSource = sorgu1;

            var sorgu2 = (from x in db.Sigortalar.Where(a => a.SubeID == gsubeid) select new { x.SigortaID, x.SatisID, x.SubeID, x.Marka, x.Model, x.BaslangicT, x.BitisT, x.Ucret }).ToList();
            gridControl2.DataSource = sorgu2;
        }

        private void ArabaSigorta_Load(object sender, EventArgs e)
        {
            var sorgu = db.SubeAdmin.Where(x => x.SubeID == gsubeid).FirstOrDefault();
            listele();
            kullanici = sorgu.KullaniciAdi.ToString();
            TeSigortaID.Enabled = TeSatisID.Enabled = TeMarka.Enabled = TeModel.Enabled = false;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TeSatisID.Text = gridView1.GetFocusedRowCellValue("SatisID").ToString();
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
                TeSigortaID.Text = gridView2.GetFocusedRowCellValue("SigortaID").ToString();
                TeSatisID.Text = gridView2.GetFocusedRowCellValue("SatisID").ToString();
                TeSubeID.Text = gridView2.GetFocusedRowCellValue("SubeID").ToString();
                TeMarka.Text = gridView2.GetFocusedRowCellValue("Marka").ToString();
                TeModel.Text = gridView2.GetFocusedRowCellValue("Model").ToString();
                dateEdit1.Text = gridView2.GetFocusedRowCellValue("BaslangicT").ToString();
                dateEdit2.Text = gridView2.GetFocusedRowCellValue("BitisT").ToString();
                TeUcret.Text = gridView2.GetFocusedRowCellValue("Ucret").ToString();
            }
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            sgt.SatisID = Convert.ToInt32(TeSatisID.Text);
            sgt.SubeID = Convert.ToInt32(TeSubeID.Text);
            sgt.Marka = TeMarka.Text;
            sgt.Model = TeModel.Text;
            sgt.BaslangicT = dateEdit1.DateTime;
            sgt.BitisT = dateEdit2.DateTime;
            sgt.Ucret = Convert.ToInt32(TeUcret.Text);
            db.Sigortalar.Add(sgt);
            log.KullaniciAdi = kullanici;
            log.Tarih = DateTime.Now;
            log.Islem = "Ekle";
            log.Aciklama = "Araba sigorta kaydı eklendi.";
            db.SubeLog.Add(log);
            db.SaveChanges();
            listele();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int SecilenId = Convert.ToInt32(gridView2.GetFocusedRowCellValue("SigortaID").ToString());
            var a = (from x in db.Sigortalar where x.SigortaID == SecilenId select x).FirstOrDefault();
            a.Marka = TeMarka.Text;
            a.Model = TeModel.Text;
            a.BaslangicT = dateEdit1.DateTime;
            a.BitisT = dateEdit2.DateTime;
            a.Ucret = Convert.ToInt32(TeUcret.Text);
            //db.Entry(sts).State = System.Data.Entity.EntityState.Modified;
            log.KullaniciAdi = kullanici;
            log.Tarih = DateTime.Now;
            log.Islem = "Güncelle";
            log.Aciklama = "Araba sigorta kaydı güncellendi.";
            db.SubeLog.Add(log);
            db.SaveChanges();
            listele();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int SecilenIndex = gridView2.FocusedRowHandle;
            if (SecilenIndex > -1)
            {
                int SecilenId = Convert.ToInt32(gridView2.GetFocusedRowCellValue("SigortaID").ToString());
                var a = (from x in db.Sigortalar where x.SigortaID == SecilenId select x).FirstOrDefault();
                db.Sigortalar.Remove(a);
                log.KullaniciAdi = kullanici;
                log.Tarih = DateTime.Now;
                log.Islem = "Sil";
                log.Aciklama = "Araba sigorta kaydı silindi.";
                db.SubeLog.Add(log);
                db.SaveChanges();
                listele();
            }
            else
                XtraMessageBox.Show("Lütfen satır seçiniz!", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }
    }
}