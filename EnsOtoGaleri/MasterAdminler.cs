using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnsOtoGaleri
{
    public partial class MasterAdminler : DevExpress.XtraEditors.XtraForm
    {
        public MasterAdminler()
        {
            InitializeComponent();
        }

        OtoGaleriDBEntities db = new OtoGaleriDBEntities();
        private void MasterAdminler_Load(object sender, EventArgs e)
        {
            var sorgu = (from x in db.MasterAdmin select new { x.MasterID, x.KullaniciAdi }).ToList();
            gridControl1.DataSource = sorgu;
        }
    }
}