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
    public partial class ArabaKayit : DevExpress.XtraEditors.XtraForm
    {
        public ArabaKayit()
        {
            InitializeComponent();
        }

        OtoGaleriDBEntities db = new OtoGaleriDBEntities();
        Arabalar arb = new Arabalar();
        SubeLog log = new SubeLog();
        public string kullanici;
        public int gsubeid;

        public void listele()
        {
           var sorgu = (from x in db.Arabalar.Where(a => a.SubeID == gsubeid) select new { x.ArabaID, x.SubeID, x.Marka, x.Model, x.Yakit, x.Yil, x.Vites, x.MotorGucu, x.MotorHacmi }).ToList();
           gridControl1.DataSource = sorgu;
        }

        private void ArabaKayit_Load(object sender, EventArgs e)
        {
            var sorgu = db.SubeAdmin.Where(x => x.SubeID != 0).FirstOrDefault();
            listele();
            TeArabaID.Enabled = TeSubeID.Enabled = false;
            kullanici = sorgu.KullaniciAdi.ToString();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridView1.RowCount == 0)
            {
                XtraMessageBox.Show("Tabloda kayıtlı veri bulunamadı!", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                TeArabaID.Text = gridView1.GetFocusedRowCellValue("ArabaID").ToString();
                TeSubeID.Text = gridView1.GetFocusedRowCellValue("SubeID").ToString();
                TeMarka.Text = gridView1.GetFocusedRowCellValue("Marka").ToString();
                TeModel.Text = gridView1.GetFocusedRowCellValue("Model").ToString();
                TeYakit.Text = gridView1.GetFocusedRowCellValue("Yakit").ToString();
                TeYil.Text = gridView1.GetFocusedRowCellValue("Yil").ToString();
                TeVites.Text = gridView1.GetFocusedRowCellValue("Vites").ToString();
                TeMtrGucu.Text = gridView1.GetFocusedRowCellValue("MotorGucu").ToString();
                TeMtrHcm.Text = gridView1.GetFocusedRowCellValue("MotorHacmi").ToString();
            }
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            if (TeMarka.Text == "" || TeModel.Text == "" || TeYakit.Text == "" || TeYil.Text == "" || TeVites.Text == "" || TeMtrGucu.Text == "" || TeMtrHcm.Text == "")
            {
                XtraMessageBox.Show("Lütfen boş parametre bırakmayınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                arb.SubeID = gsubeid;
                arb.Marka = TeMarka.Text;
                arb.Model = TeModel.Text;
                arb.Yil = Convert.ToInt32(TeYil.Text);
                arb.Yakit = TeYakit.Text;
                arb.Vites = TeVites.Text;
                arb.MotorGucu = Convert.ToInt32(TeMtrGucu.Text);
                arb.MotorHacmi = Convert.ToInt32(TeMtrHcm.Text);
                db.Arabalar.Add(arb);
                log.KullaniciAdi = kullanici;
                log.Tarih = DateTime.Now;
                log.Islem = "Ekle";
                log.Aciklama = "Araba kaydı eklendi.";
                db.SubeLog.Add(log);
                db.SaveChanges();
                listele();
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int SecilenId = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ArabaID").ToString());
            var a = (from x in db.Arabalar where x.ArabaID == SecilenId select x).FirstOrDefault();
            if (TeSubeID.Text == "" || TeMarka.Text == "" || TeModel.Text == "" || TeYakit.Text == "" || TeYil.Text == "" || TeVites.Text == "" || TeMtrGucu.Text == "" || TeMtrHcm.Text == "")
            {
                XtraMessageBox.Show("Lütfen boş parametre bırakmayınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                a.Marka = TeMarka.Text;
                a.Model = TeModel.Text;
                a.Yakit = TeYakit.Text;
                a.Yil = Convert.ToInt32(TeYil.Text);
                a.Vites = TeVites.Text;
                a.MotorGucu = Convert.ToInt32(TeMtrGucu.Text);
                a.MotorHacmi = Convert.ToInt32(TeMtrHcm.Text);
                db.Entry(a).State = System.Data.Entity.EntityState.Modified;
                log.KullaniciAdi = kullanici;
                log.Tarih = DateTime.Now;
                log.Islem = "Güncelle";
                log.Aciklama = "Araba kaydı güncellendi.";
                db.SubeLog.Add(log);
                db.SaveChanges();
                listele();
            }
            
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int SecilenIndex = gridView1.FocusedRowHandle;
            if (SecilenIndex > -1)
            {
                int SecilenId = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ArabaID").ToString());
                var a = (from x in db.Arabalar where x.ArabaID == SecilenId select x).FirstOrDefault();
                db.Arabalar.Remove(a);
                log.KullaniciAdi = kullanici;
                log.Tarih = DateTime.Now;
                log.Islem = "Sil";
                log.Aciklama = "Araba kaydı silindi.";
                db.SubeLog.Add(log);
                db.SaveChanges();
                listele();
            }
            else
                XtraMessageBox.Show("Lütfen satır seçiniz!", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }
    }
}