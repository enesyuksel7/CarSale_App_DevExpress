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
    public partial class SubeAdminleri : DevExpress.XtraEditors.XtraForm
    {
        public SubeAdminleri()
        {
            InitializeComponent();
        }

        OtoGaleriDBEntities db = new OtoGaleriDBEntities();
        SubeAdmin sa = new SubeAdmin();
        MasterLog log = new MasterLog();
        public string gkullanici;

        public void listele()
        {
            var sorgu1 = (from x in db.SubeAdmin select new { x.AdminID, x.SubeID, x.KullaniciAdi, x.Sifre }).ToList();
            gridControl1.DataSource = sorgu1;

            var sorgu2 = (from x in db.SubeAbonelik select new { x.SubeID, x.SubeAd, x.SehirAd, x.SemtAd }).ToList();
            gridControl2.DataSource = sorgu2;

            TeAdminID.Text = TeSubeID.Text = TeKulAdi.Text = TeSif.Text = "";
        }

        private void SubeAdminleri_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TeAdminID.Text = gridView1.GetFocusedRowCellValue("AdminID").ToString();
            TeSubeID.Text = gridView1.GetFocusedRowCellValue("SubeID").ToString();
            TeKulAdi.Text = gridView1.GetFocusedRowCellValue("KullaniciAdi").ToString();
            TeSif.Text = gridView1.GetFocusedRowCellValue("Sifre").ToString();
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TeSubeID.Text = gridView2.GetFocusedRowCellValue("SubeID").ToString();
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            sa.SubeID = Convert.ToInt32(TeSubeID.Text);
            sa.KullaniciAdi = TeKulAdi.Text;
            sa.Sifre = TeSif.Text;
            db.SubeAdmin.Add(sa);
            log.KullaniciAdi = gkullanici;
            log.Tarih = DateTime.Now;
            log.Islem = "Ekle";
            log.Aciklama = "Şube admin eklendi.";
            db.MasterLog.Add(log);
            db.SaveChanges();
            listele();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int SecilenId = Convert.ToInt32(gridView1.GetFocusedRowCellValue("AdminID").ToString());
            var a = (from x in db.SubeAdmin where x.AdminID == SecilenId select x).FirstOrDefault();
            a.SubeID = Convert.ToInt32(TeSubeID.Text);
            a.KullaniciAdi = TeKulAdi.Text;
            a.Sifre = TeSif.Text;
            db.Entry(a).State = System.Data.Entity.EntityState.Modified;
            log.KullaniciAdi = gkullanici;
            log.Tarih = DateTime.Now;
            log.Islem = "Güncelle";
            log.Aciklama = "Şube admin güncellendi.";
            db.MasterLog.Add(log);
            db.SaveChanges();
            listele();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int SecilenIndex = gridView1.FocusedRowHandle;
            if (SecilenIndex > -1)
            {
                int SecilenId = Convert.ToInt32(gridView1.GetFocusedRowCellValue("AdminID").ToString());
                var a = (from x in db.SubeAdmin where x.AdminID == SecilenId select x).FirstOrDefault();
                db.SubeAdmin.Remove(a);
                log.KullaniciAdi = gkullanici;
                log.Tarih = DateTime.Now;
                log.Islem = "Sil";
                log.Aciklama = "Şube admin silindi.";
                db.MasterLog.Add(log);
                db.SaveChanges();
                listele();
            }
            else
                    XtraMessageBox.Show("Lütfen satır seçiniz!", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }
    }
}