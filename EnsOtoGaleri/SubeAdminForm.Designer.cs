namespace EnsOtoGaleri
{
    partial class SubeAdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubeAdminForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.BtnArbKyt = new DevExpress.XtraBars.BarButtonItem();
            this.BtnArbSts = new DevExpress.XtraBars.BarButtonItem();
            this.BtnArbSig = new DevExpress.XtraBars.BarButtonItem();
            this.BtnSubeler = new DevExpress.XtraBars.BarButtonItem();
            this.BtnRapor = new DevExpress.XtraBars.BarButtonItem();
            this.BtnLog = new DevExpress.XtraBars.BarButtonItem();
            this.BtnGeri = new DevExpress.XtraBars.BarButtonItem();
            this.BtnIst = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.LcKullanici = new DevExpress.XtraEditors.LabelControl();
            this.LcID = new DevExpress.XtraEditors.LabelControl();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup10 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.BtnSgrTkp = new DevExpress.XtraBars.BarButtonItem();
            this.BtnCikis = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.BtnArbKyt,
            this.BtnArbSts,
            this.BtnArbSig,
            this.BtnSubeler,
            this.BtnRapor,
            this.BtnLog,
            this.BtnGeri,
            this.BtnIst,
            this.BtnSgrTkp,
            this.BtnCikis});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 13;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbon.Size = new System.Drawing.Size(1104, 194);
            // 
            // BtnArbKyt
            // 
            this.BtnArbKyt.Caption = "ARABA KAYIT İŞLEMLERİ";
            this.BtnArbKyt.Id = 1;
            this.BtnArbKyt.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnArbKyt.ImageOptions.Image")));
            this.BtnArbKyt.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnArbKyt.ImageOptions.LargeImage")));
            this.BtnArbKyt.LargeWidth = 130;
            this.BtnArbKyt.Name = "BtnArbKyt";
            this.BtnArbKyt.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnArbKyt_ItemClick);
            // 
            // BtnArbSts
            // 
            this.BtnArbSts.Caption = "ARABA SATIŞ\r\n   İŞLEMLERİ";
            this.BtnArbSts.Id = 2;
            this.BtnArbSts.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnArbSts.ImageOptions.Image")));
            this.BtnArbSts.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnArbSts.ImageOptions.LargeImage")));
            this.BtnArbSts.LargeWidth = 130;
            this.BtnArbSts.Name = "BtnArbSts";
            this.BtnArbSts.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnArbSts_ItemClick);
            // 
            // BtnArbSig
            // 
            this.BtnArbSig.Caption = "ARABA SİGORTA GİRİŞİ";
            this.BtnArbSig.Id = 3;
            this.BtnArbSig.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnArbSig.ImageOptions.Image")));
            this.BtnArbSig.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnArbSig.ImageOptions.LargeImage")));
            this.BtnArbSig.LargeWidth = 140;
            this.BtnArbSig.Name = "BtnArbSig";
            this.BtnArbSig.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnArbSig_ItemClick);
            // 
            // BtnSubeler
            // 
            this.BtnSubeler.Caption = "TÜM\r\nŞUBELERİMİZ";
            this.BtnSubeler.Id = 4;
            this.BtnSubeler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSubeler.ImageOptions.Image")));
            this.BtnSubeler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnSubeler.ImageOptions.LargeImage")));
            this.BtnSubeler.LargeWidth = 130;
            this.BtnSubeler.Name = "BtnSubeler";
            this.BtnSubeler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnSubeler_ItemClick);
            // 
            // BtnRapor
            // 
            this.BtnRapor.Caption = "RAPORLAR";
            this.BtnRapor.Id = 5;
            this.BtnRapor.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnRapor.ImageOptions.Image")));
            this.BtnRapor.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnRapor.ImageOptions.LargeImage")));
            this.BtnRapor.LargeWidth = 110;
            this.BtnRapor.Name = "BtnRapor";
            this.BtnRapor.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnRapor_ItemClick);
            // 
            // BtnLog
            // 
            this.BtnLog.Caption = "  LOG\r\nKAYITLARI";
            this.BtnLog.Id = 6;
            this.BtnLog.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnLog.ImageOptions.Image")));
            this.BtnLog.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnLog.ImageOptions.LargeImage")));
            this.BtnLog.LargeWidth = 110;
            this.BtnLog.Name = "BtnLog";
            this.BtnLog.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnLog_ItemClick);
            // 
            // BtnGeri
            // 
            this.BtnGeri.Caption = "ARAYÜZE DÖN";
            this.BtnGeri.Id = 7;
            this.BtnGeri.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGeri.ImageOptions.Image")));
            this.BtnGeri.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnGeri.ImageOptions.LargeImage")));
            this.BtnGeri.LargeWidth = 110;
            this.BtnGeri.Name = "BtnGeri";
            this.BtnGeri.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnGeri_ItemClick);
            // 
            // BtnIst
            // 
            this.BtnIst.Caption = "İSTATİSTİKLER";
            this.BtnIst.Id = 8;
            this.BtnIst.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnIst.ImageOptions.Image")));
            this.BtnIst.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnIst.ImageOptions.LargeImage")));
            this.BtnIst.LargeWidth = 130;
            this.BtnIst.Name = "BtnIst";
            this.BtnIst.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnIst_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup6,
            this.ribbonPageGroup4,
            this.ribbonPageGroup8,
            this.ribbonPageGroup5,
            this.ribbonPageGroup7});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Şube Admin Panel";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnArbKyt);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Veriler";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.BtnArbSts);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Ticaret";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.BtnArbSig);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Servis";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.BtnSubeler);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "Bilgi";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.BtnRapor);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Kayıtlar";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.ItemLinks.Add(this.BtnIst);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            this.ribbonPageGroup8.Text = "Bilgiler";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.BtnLog);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Kayıtlar";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.BtnGeri);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.Text = "Eylemler";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(0, 190);
            this.pictureEdit1.MenuManager = this.ribbon;
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(1104, 714);
            this.pictureEdit1.TabIndex = 3;
            // 
            // documentManager1
            // 
            this.documentManager1.MdiParent = this;
            this.documentManager1.MenuManager = this.ribbon;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // LcKullanici
            // 
            this.LcKullanici.Location = new System.Drawing.Point(895, 200);
            this.LcKullanici.Name = "LcKullanici";
            this.LcKullanici.Size = new System.Drawing.Size(85, 23);
            this.LcKullanici.TabIndex = 7;
            this.LcKullanici.Text = "Giriş Yapan";
            // 
            // LcID
            // 
            this.LcID.Location = new System.Drawing.Point(1074, 200);
            this.LcID.Name = "LcID";
            this.LcID.Size = new System.Drawing.Size(18, 23);
            this.LcID.TabIndex = 9;
            this.LcID.Text = "ID";
            this.LcID.Visible = false;
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup9,
            this.ribbonPageGroup10});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Ayarlar";
            // 
            // ribbonPageGroup9
            // 
            this.ribbonPageGroup9.ItemLinks.Add(this.BtnSgrTkp);
            this.ribbonPageGroup9.Name = "ribbonPageGroup9";
            this.ribbonPageGroup9.Text = "Bilgiler";
            // 
            // ribbonPageGroup10
            // 
            this.ribbonPageGroup10.ItemLinks.Add(this.BtnCikis);
            this.ribbonPageGroup10.Name = "ribbonPageGroup10";
            this.ribbonPageGroup10.Text = "Eylemler";
            // 
            // BtnSgrTkp
            // 
            this.BtnSgrTkp.Caption = "Sigorta Tarih Takip Bölümü";
            this.BtnSgrTkp.Id = 11;
            this.BtnSgrTkp.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSgrTkp.ImageOptions.Image")));
            this.BtnSgrTkp.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnSgrTkp.ImageOptions.LargeImage")));
            this.BtnSgrTkp.LargeWidth = 140;
            this.BtnSgrTkp.Name = "BtnSgrTkp";
            this.BtnSgrTkp.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnSgrTkp_ItemClick);
            // 
            // BtnCikis
            // 
            this.BtnCikis.Caption = "ÇIKIŞ";
            this.BtnCikis.Id = 12;
            this.BtnCikis.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnCikis.ImageOptions.Image")));
            this.BtnCikis.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnCikis.ImageOptions.LargeImage")));
            this.BtnCikis.LargeWidth = 140;
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnCikis_ItemClick);
            // 
            // SubeAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 902);
            this.Controls.Add(this.LcID);
            this.Controls.Add(this.LcKullanici);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "SubeAdminForm";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ENS OTOMOTİV";
            this.Load += new System.EventHandler(this.SubeAdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem BtnArbKyt;
        private DevExpress.XtraBars.BarButtonItem BtnArbSts;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem BtnArbSig;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem BtnSubeler;
        private DevExpress.XtraBars.BarButtonItem BtnRapor;
        private DevExpress.XtraBars.BarButtonItem BtnLog;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.BarButtonItem BtnGeri;
        private DevExpress.XtraEditors.LabelControl LcKullanici;
        private DevExpress.XtraBars.BarButtonItem BtnIst;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraEditors.LabelControl LcID;
        private DevExpress.XtraBars.BarButtonItem BtnSgrTkp;
        private DevExpress.XtraBars.BarButtonItem BtnCikis;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup10;
    }
}