namespace EnsOtoGaleri
{
    partial class GirisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisForm));
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.BtnMasterAdm = new DevExpress.XtraEditors.SimpleButton();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.BtnSubeAdm = new DevExpress.XtraEditors.SimpleButton();
            this.LblMstAdm = new DevExpress.XtraEditors.LabelControl();
            this.LblSubeAdm = new DevExpress.XtraEditors.LabelControl();
            this.LblKulAdi = new DevExpress.XtraEditors.LabelControl();
            this.LblSif = new DevExpress.XtraEditors.LabelControl();
            this.TeKulAdi = new DevExpress.XtraEditors.TextEdit();
            this.CeBh = new DevExpress.XtraEditors.CheckEdit();
            this.BtnMstAdmGrs = new DevExpress.XtraEditors.SimpleButton();
            this.LblHg = new DevExpress.XtraEditors.LabelControl();
            this.LblSifUnt = new DevExpress.XtraEditors.LabelControl();
            this.BtnGeri = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSbAdmGrs = new DevExpress.XtraEditors.SimpleButton();
            this.TeSifre = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeKulAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CeBh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeSifre.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(-1, -1);
            this.pictureEdit1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(1108, 753);
            this.pictureEdit1.TabIndex = 0;
            // 
            // BtnMasterAdm
            // 
            this.BtnMasterAdm.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.BtnMasterAdm.ImageOptions.ImageIndex = 1;
            this.BtnMasterAdm.ImageOptions.ImageList = this.ımageList1;
            this.BtnMasterAdm.Location = new System.Drawing.Point(662, 233);
            this.BtnMasterAdm.Name = "BtnMasterAdm";
            this.BtnMasterAdm.Size = new System.Drawing.Size(121, 144);
            this.BtnMasterAdm.TabIndex = 1;
            this.BtnMasterAdm.Click += new System.EventHandler(this.BtnMasterAdm_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "subeadmin.png");
            this.ımageList1.Images.SetKeyName(1, "anaadmin.png");
            // 
            // BtnSubeAdm
            // 
            this.BtnSubeAdm.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.BtnSubeAdm.ImageOptions.ImageIndex = 0;
            this.BtnSubeAdm.ImageOptions.ImageList = this.ımageList1;
            this.BtnSubeAdm.Location = new System.Drawing.Point(662, 449);
            this.BtnSubeAdm.Name = "BtnSubeAdm";
            this.BtnSubeAdm.Size = new System.Drawing.Size(121, 144);
            this.BtnSubeAdm.TabIndex = 10;
            this.BtnSubeAdm.Click += new System.EventHandler(this.BtnSubeAdm_Click);
            // 
            // LblMstAdm
            // 
            this.LblMstAdm.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.LblMstAdm.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblMstAdm.Appearance.ForeColor = System.Drawing.Color.Black;
            this.LblMstAdm.Appearance.Options.UseBackColor = true;
            this.LblMstAdm.Appearance.Options.UseFont = true;
            this.LblMstAdm.Appearance.Options.UseForeColor = true;
            this.LblMstAdm.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.LblMstAdm.Location = new System.Drawing.Point(698, 383);
            this.LblMstAdm.Name = "LblMstAdm";
            this.LblMstAdm.Size = new System.Drawing.Size(57, 38);
            this.LblMstAdm.TabIndex = 12;
            this.LblMstAdm.Text = "MASTER\r\n ADMİN";
            // 
            // LblSubeAdm
            // 
            this.LblSubeAdm.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            this.LblSubeAdm.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSubeAdm.Appearance.ForeColor = System.Drawing.Color.Black;
            this.LblSubeAdm.Appearance.Options.UseBackColor = true;
            this.LblSubeAdm.Appearance.Options.UseFont = true;
            this.LblSubeAdm.Appearance.Options.UseForeColor = true;
            this.LblSubeAdm.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.LblSubeAdm.Location = new System.Drawing.Point(698, 611);
            this.LblSubeAdm.Name = "LblSubeAdm";
            this.LblSubeAdm.Size = new System.Drawing.Size(49, 38);
            this.LblSubeAdm.TabIndex = 13;
            this.LblSubeAdm.Text = "  ŞUBE\r\nADMİN";
            // 
            // LblKulAdi
            // 
            this.LblKulAdi.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.LblKulAdi.Appearance.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblKulAdi.Appearance.ForeColor = System.Drawing.Color.Black;
            this.LblKulAdi.Appearance.Options.UseBackColor = true;
            this.LblKulAdi.Appearance.Options.UseFont = true;
            this.LblKulAdi.Appearance.Options.UseForeColor = true;
            this.LblKulAdi.Location = new System.Drawing.Point(591, 342);
            this.LblKulAdi.Name = "LblKulAdi";
            this.LblKulAdi.Size = new System.Drawing.Size(103, 23);
            this.LblKulAdi.TabIndex = 15;
            this.LblKulAdi.Text = "Kullanıcı Adı:";
            this.LblKulAdi.Visible = false;
            // 
            // LblSif
            // 
            this.LblSif.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.LblSif.Appearance.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSif.Appearance.ForeColor = System.Drawing.Color.Black;
            this.LblSif.Appearance.Options.UseBackColor = true;
            this.LblSif.Appearance.Options.UseFont = true;
            this.LblSif.Appearance.Options.UseForeColor = true;
            this.LblSif.Location = new System.Drawing.Point(652, 411);
            this.LblSif.Name = "LblSif";
            this.LblSif.Size = new System.Drawing.Size(42, 23);
            this.LblSif.TabIndex = 16;
            this.LblSif.Text = "Şifre:";
            this.LblSif.Visible = false;
            // 
            // TeKulAdi
            // 
            this.TeKulAdi.Location = new System.Drawing.Point(711, 335);
            this.TeKulAdi.Name = "TeKulAdi";
            this.TeKulAdi.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.TeKulAdi.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TeKulAdi.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.TeKulAdi.Properties.Appearance.Options.UseBackColor = true;
            this.TeKulAdi.Properties.Appearance.Options.UseFont = true;
            this.TeKulAdi.Properties.Appearance.Options.UseForeColor = true;
            this.TeKulAdi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.TeKulAdi.Size = new System.Drawing.Size(147, 30);
            this.TeKulAdi.TabIndex = 17;
            this.TeKulAdi.Visible = false;
            // 
            // CeBh
            // 
            this.CeBh.Location = new System.Drawing.Point(757, 466);
            this.CeBh.Name = "CeBh";
            this.CeBh.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            this.CeBh.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CeBh.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.CeBh.Properties.Appearance.Options.UseBackColor = true;
            this.CeBh.Properties.Appearance.Options.UseFont = true;
            this.CeBh.Properties.Appearance.Options.UseForeColor = true;
            this.CeBh.Properties.Caption = "Beni Hatırla";
            this.CeBh.Size = new System.Drawing.Size(101, 19);
            this.CeBh.TabIndex = 19;
            this.CeBh.Visible = false;
            // 
            // BtnMstAdmGrs
            // 
            this.BtnMstAdmGrs.Appearance.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnMstAdmGrs.Appearance.Options.UseFont = true;
            this.BtnMstAdmGrs.Location = new System.Drawing.Point(687, 541);
            this.BtnMstAdmGrs.Name = "BtnMstAdmGrs";
            this.BtnMstAdmGrs.Size = new System.Drawing.Size(107, 78);
            this.BtnMstAdmGrs.TabIndex = 20;
            this.BtnMstAdmGrs.Text = "GİRİŞ";
            this.BtnMstAdmGrs.Visible = false;
            this.BtnMstAdmGrs.Click += new System.EventHandler(this.BtnMstAdmGrs_Click);
            // 
            // LblHg
            // 
            this.LblHg.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.LblHg.Appearance.Font = new System.Drawing.Font("Buxton Sketch", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHg.Appearance.ForeColor = System.Drawing.Color.Black;
            this.LblHg.Appearance.Options.UseBackColor = true;
            this.LblHg.Appearance.Options.UseFont = true;
            this.LblHg.Appearance.Options.UseForeColor = true;
            this.LblHg.Location = new System.Drawing.Point(648, 233);
            this.LblHg.Name = "LblHg";
            this.LblHg.Size = new System.Drawing.Size(146, 29);
            this.LblHg.TabIndex = 21;
            this.LblHg.Text = "HOŞGELDİNİZ !";
            this.LblHg.Visible = false;
            // 
            // LblSifUnt
            // 
            this.LblSifUnt.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.LblSifUnt.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSifUnt.Appearance.ForeColor = System.Drawing.Color.Black;
            this.LblSifUnt.Appearance.Options.UseBackColor = true;
            this.LblSifUnt.Appearance.Options.UseFont = true;
            this.LblSifUnt.Appearance.Options.UseForeColor = true;
            this.LblSifUnt.Location = new System.Drawing.Point(591, 468);
            this.LblSifUnt.Name = "LblSifUnt";
            this.LblSifUnt.Size = new System.Drawing.Size(103, 18);
            this.LblSifUnt.TabIndex = 22;
            this.LblSifUnt.Text = "Şifremi Unuttum";
            this.LblSifUnt.Visible = false;
            this.LblSifUnt.Click += new System.EventHandler(this.LblSifUnt_Click);
            // 
            // BtnGeri
            // 
            this.BtnGeri.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.BtnGeri.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGeri.ImageOptions.Image")));
            this.BtnGeri.Location = new System.Drawing.Point(562, 203);
            this.BtnGeri.Name = "BtnGeri";
            this.BtnGeri.Size = new System.Drawing.Size(45, 48);
            this.BtnGeri.TabIndex = 23;
            this.BtnGeri.Visible = false;
            this.BtnGeri.Click += new System.EventHandler(this.BtnGeri_Click);
            // 
            // BtnSbAdmGrs
            // 
            this.BtnSbAdmGrs.Appearance.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSbAdmGrs.Appearance.Options.UseFont = true;
            this.BtnSbAdmGrs.Location = new System.Drawing.Point(687, 541);
            this.BtnSbAdmGrs.Name = "BtnSbAdmGrs";
            this.BtnSbAdmGrs.Size = new System.Drawing.Size(107, 78);
            this.BtnSbAdmGrs.TabIndex = 25;
            this.BtnSbAdmGrs.Text = "GİRİŞ";
            this.BtnSbAdmGrs.Visible = false;
            this.BtnSbAdmGrs.Click += new System.EventHandler(this.BtnSbAdmGrs_Click);
            // 
            // TeSifre
            // 
            this.TeSifre.Location = new System.Drawing.Point(711, 404);
            this.TeSifre.Name = "TeSifre";
            this.TeSifre.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.TeSifre.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TeSifre.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.TeSifre.Properties.Appearance.Options.UseBackColor = true;
            this.TeSifre.Properties.Appearance.Options.UseFont = true;
            this.TeSifre.Properties.Appearance.Options.UseForeColor = true;
            this.TeSifre.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.TeSifre.Properties.UseSystemPasswordChar = true;
            this.TeSifre.Size = new System.Drawing.Size(147, 30);
            this.TeSifre.TabIndex = 27;
            this.TeSifre.Visible = false;
            // 
            // GirisForm
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 749);
            this.Controls.Add(this.TeSifre);
            this.Controls.Add(this.BtnSbAdmGrs);
            this.Controls.Add(this.BtnGeri);
            this.Controls.Add(this.LblSifUnt);
            this.Controls.Add(this.LblHg);
            this.Controls.Add(this.BtnMstAdmGrs);
            this.Controls.Add(this.CeBh);
            this.Controls.Add(this.TeKulAdi);
            this.Controls.Add(this.LblSif);
            this.Controls.Add(this.LblKulAdi);
            this.Controls.Add(this.LblSubeAdm);
            this.Controls.Add(this.LblMstAdm);
            this.Controls.Add(this.BtnSubeAdm);
            this.Controls.Add(this.BtnMasterAdm);
            this.Controls.Add(this.pictureEdit1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "GirisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ENS OTOMATİV";
            this.Load += new System.EventHandler(this.GirisForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeKulAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CeBh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeSifre.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.SimpleButton BtnMasterAdm;
        private System.Windows.Forms.ImageList ımageList1;
        private DevExpress.XtraEditors.SimpleButton BtnSubeAdm;
        private DevExpress.XtraEditors.LabelControl LblMstAdm;
        private DevExpress.XtraEditors.LabelControl LblSubeAdm;
        private DevExpress.XtraEditors.LabelControl LblKulAdi;
        private DevExpress.XtraEditors.LabelControl LblSif;
        private DevExpress.XtraEditors.TextEdit TeKulAdi;
        private DevExpress.XtraEditors.CheckEdit CeBh;
        private DevExpress.XtraEditors.SimpleButton BtnMstAdmGrs;
        private DevExpress.XtraEditors.LabelControl LblHg;
        private DevExpress.XtraEditors.LabelControl LblSifUnt;
        private DevExpress.XtraEditors.SimpleButton BtnGeri;
        private DevExpress.XtraEditors.SimpleButton BtnSbAdmGrs;
        private DevExpress.XtraEditors.TextEdit TeSifre;
    }
}