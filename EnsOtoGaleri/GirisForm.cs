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
    public partial class GirisForm : DevExpress.XtraEditors.XtraForm
    {
        public GirisForm()
        {
            InitializeComponent();
        }

        OtoGaleriDBEntities db = new OtoGaleriDBEntities();
        MasterAdminForm maf = new MasterAdminForm();
        SubeAdminForm saf = new SubeAdminForm();
        MasterLog log = new MasterLog();

        private void GirisForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnMasterAdm_Click(object sender, EventArgs e)
        {
            LblHg.Visible = LblKulAdi.Visible = LblSif.Visible = TeKulAdi.Visible = TeSifre.Visible = LblSifUnt.Visible = CeBh.Visible = BtnMstAdmGrs.Visible = BtnGeri.Visible = true;
            BtnMasterAdm.Visible = BtnSubeAdm.Visible = BtnSbAdmGrs.Enabled = LblMstAdm.Visible = LblSubeAdm.Visible = BtnSbAdmGrs.Visible = false;
        }

        private void BtnSubeAdm_Click(object sender, EventArgs e)
        {
            LblHg.Visible = LblKulAdi.Visible = LblSif.Visible = TeKulAdi.Visible = TeSifre.Visible = LblSifUnt.Visible = CeBh.Visible = BtnSbAdmGrs.Visible = BtnSbAdmGrs.Enabled = BtnGeri.Visible = true;
            BtnMasterAdm.Visible = BtnSubeAdm.Visible = BtnMstAdmGrs.Visible = LblMstAdm.Visible = LblSubeAdm.Visible = BtnMstAdmGrs.Visible = false;
        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            LblHg.Visible = LblKulAdi.Visible = LblSif.Visible = TeKulAdi.Visible = TeSifre.Visible = LblSifUnt.Visible = CeBh.Visible = BtnMstAdmGrs.Visible = BtnSbAdmGrs.Visible = BtnGeri.Visible = false;
            BtnMasterAdm.Visible = BtnSubeAdm.Visible = LblMstAdm.Visible = LblSubeAdm.Visible = true;
        }

        private void LblSifUnt_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("Şifre yenilemek için şirket yöneticisine başvurunuz!","Bilgilendirme", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void BtnMstAdmGrs_Click(object sender, EventArgs e)
        {
            var sorgu = db.MasterAdmin.Where(x=>x.KullaniciAdi == TeKulAdi.Text && x.Sifre == TeSifre.Text).FirstOrDefault();

            if (TeKulAdi.Text == "" || TeSifre.Text == "")
            {
                XtraMessageBox.Show("Kullanıcı adı veya şifre alanı boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(sorgu != null)
            {
                maf.gkullanici = sorgu.KullaniciAdi;
                log.KullaniciAdi = TeKulAdi.Text;
                log.Tarih = DateTime.Now;
                log.Islem = "Başarılı Giriş";
                log.Aciklama = "Sisteme giriş yapıldı.";
                db.MasterLog.Add(log);
                db.SaveChanges();
                maf.Show();
                this.Hide();
            }
            else
            {
                log.KullaniciAdi = TeKulAdi.Text;
                log.Tarih = DateTime.Now;
                log.Islem = "Hatalı Giriş";
                log.Aciklama = "Kullanıcı adı veya şifre yanlış girildi.";
                db.MasterLog.Add(log);
                db.SaveChanges();
                XtraMessageBox.Show("Kullanıcı adı veya şifre yanlış!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnSbAdmGrs_Click(object sender, EventArgs e)
        {
            var sorgu = db.SubeAdmin.Where(x => x.KullaniciAdi == TeKulAdi.Text && x.Sifre == TeSifre.Text).FirstOrDefault();
            if (TeKulAdi.Text == "" || TeSifre.Text == "")
            {
                XtraMessageBox.Show("Kullanıcı adı veya şifre alanı boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(sorgu != null)
            {
                saf.gkullanici2 = sorgu.KullaniciAdi;
                saf.gsubeid = sorgu.SubeID;
                log.KullaniciAdi = TeKulAdi.Text;
                log.Tarih = DateTime.Now;
                log.Islem = "Başarılı Giriş";
                log.Aciklama = "Sisteme giriş yapıldı.";
                db.MasterLog.Add(log);
                db.SaveChanges();
                saf.Show();
                this.Hide();
            }
            else
            {
                log.KullaniciAdi = TeKulAdi.Text;
                log.Tarih = DateTime.Now;
                log.Islem = "Hatalı Giriş";
                log.Aciklama = "Kullanıcı adı veya şifre yanlış girildi.";
                db.MasterLog.Add(log);
                db.SaveChanges();
                XtraMessageBox.Show("Kullanıcı adı veya şifre yanlış!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}