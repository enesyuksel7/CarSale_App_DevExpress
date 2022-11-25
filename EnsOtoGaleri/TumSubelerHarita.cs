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
using DevExpress.XtraMap;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace EnsOtoGaleri
{
    public partial class TumSubelerHarita : DevExpress.XtraEditors.XtraForm
    {
        public TumSubelerHarita()
        {
            InitializeComponent();
        }

        public void kordgetir(double x, double y)
        {
            gMapControl1.MapProvider = GoogleMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            gMapControl1.MapProvider = GoogleHybridMapProvider.Instance;
            gMapControl1.Position = new GMap.NET.PointLatLng(x, y);
            gMapControl1.ShowCenter = false;

            GMapOverlay markers = new GMapOverlay("markers");
            GMapMarker marker = new GMarkerGoogle(new PointLatLng(x, y), GMarkerGoogleType.red);
            markers.Markers.Add(marker);
            gMapControl1.MinZoom = 5;
            gMapControl1.MaxZoom = 100;
            gMapControl1.Zoom = 15;
            marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
        }

        private void yazikaldir()
        {
            gMapControl1.Visible = true;
            LcYazi.Visible = false;
        }

        private void TumSubelerHarita_Load(object sender, EventArgs e)
        {
            gMapControl1.Visible = false;
            LcYazi.Visible = true;
        }

        private void BtnAnk_Click(object sender, EventArgs e)
        {
            yazikaldir();
            kordgetir(36.92829165187268, 30.66858237128185);
        }

        private void BtnIst_Click(object sender, EventArgs e)
        {
            yazikaldir();
            kordgetir(41.06701459484822, 28.801731409432122);
        }

        private void BtnIzm_Click(object sender, EventArgs e)
        {
            yazikaldir();
            kordgetir(39.597758054983466, 27.007636943009256);
        }

        private void BtnBur_Click(object sender, EventArgs e)
        {
            yazikaldir();
            kordgetir(40.21669945693774, 28.938195039978073);
        }

        private void BtnAyd_Click(object sender, EventArgs e)
        {
            yazikaldir();
            kordgetir(37.840522343157744, 27.845657088398458);
        }

        private void BtnTra_Click(object sender, EventArgs e)
        {
            yazikaldir();
            kordgetir(40.9924858133947, 39.78388005823982);
        }

        private void BtnSam_Click(object sender, EventArgs e)
        {
            yazikaldir();
            kordgetir(41.340041954800235, 36.26394125208779);
        }
    }
}