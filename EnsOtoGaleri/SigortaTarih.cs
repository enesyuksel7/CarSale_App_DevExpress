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
    public partial class SigortaTarih : DevExpress.XtraEditors.XtraForm
    {
        public SigortaTarih()
        {
            InitializeComponent();
        }

        OtoGaleriDBEntities db = new OtoGaleriDBEntities();
        public int gsubeid;
        private void SigortaTarih_Load(object sender, EventArgs e)
        {
            var sorgu = (from x in db.Sigortalar.Where(a => a.SubeID == gsubeid) select new { x.SigortaID, x.BitisT, x.BaslangicT }).ToList();
            gridControl1.DataSource = sorgu;
        }
    }
}