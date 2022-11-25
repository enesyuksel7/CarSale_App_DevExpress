namespace EnsOtoGaleri
{
    partial class ArabaKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArabaKayit));
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnListele = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TeMarka = new DevExpress.XtraEditors.TextEdit();
            this.TeSubeID = new DevExpress.XtraEditors.TextEdit();
            this.TeArabaID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.TeYakit = new DevExpress.XtraEditors.TextEdit();
            this.TeYil = new DevExpress.XtraEditors.TextEdit();
            this.TeModel = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.TeMtrGucu = new DevExpress.XtraEditors.TextEdit();
            this.TeVites = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.TeMtrHcm = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeMarka.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeSubeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeArabaID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeYakit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeYil.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeModel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeMtrGucu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeVites.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeMtrHcm.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(-2, 0);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(1108, 713);
            this.pictureEdit1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1106, 281);
            this.gridControl1.TabIndex = 27;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // BtnSil
            // 
            this.BtnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSil.ImageOptions.Image")));
            this.BtnSil.Location = new System.Drawing.Point(583, 566);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(118, 48);
            this.BtnSil.TabIndex = 37;
            this.BtnSil.Text = "Sil";
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuncelle.ImageOptions.Image")));
            this.BtnGuncelle.Location = new System.Drawing.Point(583, 497);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(118, 48);
            this.BtnGuncelle.TabIndex = 36;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnEkle
            // 
            this.BtnEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnEkle.ImageOptions.Image")));
            this.BtnEkle.Location = new System.Drawing.Point(583, 432);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(118, 48);
            this.BtnEkle.TabIndex = 35;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // BtnListele
            // 
            this.BtnListele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnListele.ImageOptions.Image")));
            this.BtnListele.Location = new System.Drawing.Point(583, 368);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(118, 48);
            this.BtnListele.TabIndex = 34;
            this.BtnListele.Text = "Listele";
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.BackColor = System.Drawing.Color.White;
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelControl3.Appearance.Options.UseBackColor = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(23, 490);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(55, 23);
            this.labelControl3.TabIndex = 33;
            this.labelControl3.Text = "Marka:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.BackColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelControl2.Appearance.Options.UseBackColor = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(13, 431);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(65, 23);
            this.labelControl2.TabIndex = 32;
            this.labelControl2.Text = "Şube ID:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelControl1.Appearance.Options.UseBackColor = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(5, 371);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(73, 23);
            this.labelControl1.TabIndex = 31;
            this.labelControl1.Text = "Araba ID:";
            // 
            // TeMarka
            // 
            this.TeMarka.Location = new System.Drawing.Point(96, 483);
            this.TeMarka.Name = "TeMarka";
            this.TeMarka.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.TeMarka.Properties.Appearance.Options.UseForeColor = true;
            this.TeMarka.Size = new System.Drawing.Size(167, 30);
            this.TeMarka.TabIndex = 30;
            // 
            // TeSubeID
            // 
            this.TeSubeID.Enabled = false;
            this.TeSubeID.Location = new System.Drawing.Point(96, 424);
            this.TeSubeID.Name = "TeSubeID";
            this.TeSubeID.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.TeSubeID.Properties.Appearance.Options.UseForeColor = true;
            this.TeSubeID.Size = new System.Drawing.Size(167, 30);
            this.TeSubeID.TabIndex = 29;
            // 
            // TeArabaID
            // 
            this.TeArabaID.Enabled = false;
            this.TeArabaID.Location = new System.Drawing.Point(96, 368);
            this.TeArabaID.Name = "TeArabaID";
            this.TeArabaID.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.TeArabaID.Properties.Appearance.Options.UseForeColor = true;
            this.TeArabaID.Size = new System.Drawing.Size(167, 30);
            this.TeArabaID.TabIndex = 28;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.BackColor = System.Drawing.Color.White;
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelControl4.Appearance.Options.UseBackColor = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(332, 393);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(42, 23);
            this.labelControl4.TabIndex = 43;
            this.labelControl4.Text = "Yakıt:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.BackColor = System.Drawing.Color.White;
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelControl5.Appearance.Options.UseBackColor = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(56, 595);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(22, 23);
            this.labelControl5.TabIndex = 42;
            this.labelControl5.Text = "Yıl:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.BackColor = System.Drawing.Color.White;
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelControl6.Appearance.Options.UseBackColor = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(24, 542);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(54, 23);
            this.labelControl6.TabIndex = 41;
            this.labelControl6.Text = "Model:";
            // 
            // TeYakit
            // 
            this.TeYakit.Location = new System.Drawing.Point(392, 390);
            this.TeYakit.Name = "TeYakit";
            this.TeYakit.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.TeYakit.Properties.Appearance.Options.UseForeColor = true;
            this.TeYakit.Size = new System.Drawing.Size(167, 30);
            this.TeYakit.TabIndex = 40;
            // 
            // TeYil
            // 
            this.TeYil.Location = new System.Drawing.Point(96, 588);
            this.TeYil.Name = "TeYil";
            this.TeYil.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.TeYil.Properties.Appearance.Options.UseForeColor = true;
            this.TeYil.Size = new System.Drawing.Size(167, 30);
            this.TeYil.TabIndex = 39;
            // 
            // TeModel
            // 
            this.TeModel.Location = new System.Drawing.Point(96, 535);
            this.TeModel.Name = "TeModel";
            this.TeModel.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.TeModel.Properties.Appearance.Options.UseForeColor = true;
            this.TeModel.Size = new System.Drawing.Size(167, 30);
            this.TeModel.TabIndex = 38;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.BackColor = System.Drawing.Color.White;
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelControl8.Appearance.Options.UseBackColor = true;
            this.labelControl8.Appearance.Options.UseForeColor = true;
            this.labelControl8.Location = new System.Drawing.Point(277, 513);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(98, 23);
            this.labelControl8.TabIndex = 48;
            this.labelControl8.Text = "Motor Gücü:";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.BackColor = System.Drawing.Color.White;
            this.labelControl9.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelControl9.Appearance.Options.UseBackColor = true;
            this.labelControl9.Appearance.Options.UseForeColor = true;
            this.labelControl9.Location = new System.Drawing.Point(332, 453);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(43, 23);
            this.labelControl9.TabIndex = 47;
            this.labelControl9.Text = "Vites:";
            // 
            // TeMtrGucu
            // 
            this.TeMtrGucu.Location = new System.Drawing.Point(392, 506);
            this.TeMtrGucu.Name = "TeMtrGucu";
            this.TeMtrGucu.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.TeMtrGucu.Properties.Appearance.Options.UseForeColor = true;
            this.TeMtrGucu.Size = new System.Drawing.Size(167, 30);
            this.TeMtrGucu.TabIndex = 45;
            // 
            // TeVites
            // 
            this.TeVites.Location = new System.Drawing.Point(392, 446);
            this.TeVites.Name = "TeVites";
            this.TeVites.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.TeVites.Properties.Appearance.Options.UseForeColor = true;
            this.TeVites.Size = new System.Drawing.Size(167, 30);
            this.TeVites.TabIndex = 44;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.BackColor = System.Drawing.Color.White;
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelControl7.Appearance.Options.UseBackColor = true;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.Location = new System.Drawing.Point(273, 572);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(102, 23);
            this.labelControl7.TabIndex = 49;
            this.labelControl7.Text = "MotorHacmi:";
            // 
            // TeMtrHcm
            // 
            this.TeMtrHcm.Location = new System.Drawing.Point(392, 565);
            this.TeMtrHcm.Name = "TeMtrHcm";
            this.TeMtrHcm.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.TeMtrHcm.Properties.Appearance.Options.UseForeColor = true;
            this.TeMtrHcm.Size = new System.Drawing.Size(167, 30);
            this.TeMtrHcm.TabIndex = 46;
            // 
            // ArabaKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 709);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.TeMtrHcm);
            this.Controls.Add(this.TeMtrGucu);
            this.Controls.Add(this.TeVites);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.TeYakit);
            this.Controls.Add(this.TeYil);
            this.Controls.Add(this.TeModel);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.BtnListele);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.TeMarka);
            this.Controls.Add(this.TeSubeID);
            this.Controls.Add(this.TeArabaID);
            this.Controls.Add(this.pictureEdit1);
            this.Name = "ArabaKayit";
            this.Text = "ArabaKayit";
            this.Load += new System.EventHandler(this.ArabaKayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeMarka.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeSubeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeArabaID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeYakit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeYil.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeModel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeMtrGucu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeVites.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeMtrHcm.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton BtnEkle;
        private DevExpress.XtraEditors.SimpleButton BtnListele;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit TeMarka;
        private DevExpress.XtraEditors.TextEdit TeSubeID;
        private DevExpress.XtraEditors.TextEdit TeArabaID;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit TeYakit;
        private DevExpress.XtraEditors.TextEdit TeYil;
        private DevExpress.XtraEditors.TextEdit TeModel;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit TeMtrGucu;
        private DevExpress.XtraEditors.TextEdit TeVites;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit TeMtrHcm;
    }
}