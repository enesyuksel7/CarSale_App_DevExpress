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
    public partial class SubeAbonelikleri : DevExpress.XtraEditors.XtraForm
    {
        public SubeAbonelikleri()
        {
            InitializeComponent();
        }

        OtoGaleriDBEntities db = new OtoGaleriDBEntities();
        SubeAbonelik sb = new SubeAbonelik();
        MasterLog log = new MasterLog();
        public string gkullanici;

        public void listele()
        {
            var sorgu = (from x in db.SubeAbonelik select new { x.SubeID, x.SubeAd, x.SehirAd, x.SemtAd }).ToList();
            gridControl1.DataSource = sorgu;
            TeSubeID.Text = TeSbAdi.Text = TeShrAdi.Text = TeSmtAdi.Text = "";
        }

        private void SubeAbonelikleri_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TeSubeID.Text = gridView1.GetFocusedRowCellValue("SubeID").ToString();
            TeSbAdi.Text = gridView1.GetFocusedRowCellValue("SubeAd").ToString();
            TeShrAdi.Text = gridView1.GetFocusedRowCellValue("SehirAd").ToString();
            TeSmtAdi.Text = gridView1.GetFocusedRowCellValue("SemtAd").ToString();
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            sb.SubeAd = TeSbAdi.Text;
            sb.SehirAd = TeShrAdi.Text;
            sb.SemtAd = TeSmtAdi.Text;
            db.SubeAbonelik.Add(sb);
            log.KullaniciAdi = gkullanici;
            log.Tarih = DateTime.Now;
            log.Islem = "Ekle";
            log.Aciklama = "Şube aboneliği eklendi.";
            db.MasterLog.Add(log);
            db.SaveChanges();
            listele();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int SecilenId = Convert.ToInt32(gridView1.GetFocusedRowCellValue("SubeID").ToString());
            var a = (from x in db.SubeAbonelik where x.SubeID == SecilenId select x).FirstOrDefault();
            a.SubeAd = TeSbAdi.Text;
            a.SehirAd = TeShrAdi.Text;
            a.SemtAd = TeSmtAdi.Text;
            db.Entry(a).State = System.Data.Entity.EntityState.Modified;
            log.KullaniciAdi = gkullanici;
            log.Tarih = DateTime.Now;
            log.Islem = "Güncelle";
            log.Aciklama = "Şube aboneliği güncellendi.";
            db.MasterLog.Add(log);
            db.SaveChanges();
            listele();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int SecilenIndex = gridView1.FocusedRowHandle;
            if (SecilenIndex > -1)
            {
                int SecilenId = Convert.ToInt32(gridView1.GetFocusedRowCellValue("SubeID").ToString());
                var a = (from x in db.SubeAbonelik where x.SubeID == SecilenId select x).FirstOrDefault();
                db.SubeAbonelik.Remove(a);
                log.KullaniciAdi = gkullanici;
                log.Tarih = DateTime.Now;
                log.Islem = "Sil";
                log.Aciklama = "Şube aboneliği silindi.";
                db.MasterLog.Add(log);
                db.SaveChanges();
                listele();
            }
            else
                XtraMessageBox.Show("Lütfen satır seçiniz!", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }
    }
}