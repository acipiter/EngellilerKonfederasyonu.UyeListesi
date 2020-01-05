namespace EngellilerKonfederasyonu.UyeListesi
{
    partial class frmMain
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
            this.lstUyeler = new System.Windows.Forms.ListView();
            this.clmTcNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSoyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmAd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmBaba = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmYas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmEngel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmCinsiyet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSehir = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDernek = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuTop = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUyeEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEngelTipiEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDernekEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDernekListele = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEngelTipListele = new System.Windows.Forms.ToolStripMenuItem();
            this.bulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstUyeler
            // 
            this.lstUyeler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmTcNo,
            this.clmSoyad,
            this.clmAd,
            this.clmBaba,
            this.clmYas,
            this.clmEngel,
            this.clmCinsiyet,
            this.clmSehir,
            this.clmDernek});
            this.lstUyeler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstUyeler.HideSelection = false;
            this.lstUyeler.Location = new System.Drawing.Point(0, 24);
            this.lstUyeler.Name = "lstUyeler";
            this.lstUyeler.Size = new System.Drawing.Size(793, 474);
            this.lstUyeler.TabIndex = 0;
            this.lstUyeler.UseCompatibleStateImageBehavior = false;
            this.lstUyeler.View = System.Windows.Forms.View.List;
            // 
            // clmTcNo
            // 
            this.clmTcNo.Text = "T.C. No";
            // 
            // clmSoyad
            // 
            this.clmSoyad.DisplayIndex = 2;
            this.clmSoyad.Text = "Soyad";
            // 
            // clmAd
            // 
            this.clmAd.DisplayIndex = 1;
            this.clmAd.Text = "Adı";
            // 
            // clmBaba
            // 
            this.clmBaba.Text = "Baba Adı";
            // 
            // clmYas
            // 
            this.clmYas.Text = "Yaşı";
            // 
            // clmEngel
            // 
            this.clmEngel.Text = "Engel Yüzdesi";
            // 
            // clmCinsiyet
            // 
            this.clmCinsiyet.Text = "Cinsiyeti";
            // 
            // clmSehir
            // 
            this.clmSehir.Text = "Yaşadığı Şehir";
            // 
            // clmDernek
            // 
            this.clmDernek.Text = "Bağlı Olduğu Dernek";
            // 
            // menuTop
            // 
            this.menuTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.düzenToolStripMenuItem});
            this.menuTop.Location = new System.Drawing.Point(0, 0);
            this.menuTop.Name = "menuTop";
            this.menuTop.Size = new System.Drawing.Size(793, 24);
            this.menuTop.TabIndex = 1;
            this.menuTop.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCikis});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // menuCikis
            // 
            this.menuCikis.Name = "menuCikis";
            this.menuCikis.Size = new System.Drawing.Size(99, 22);
            this.menuCikis.Text = "Çıkış";
            this.menuCikis.Click += new System.EventHandler(this.menuCikis_Click);
            // 
            // düzenToolStripMenuItem
            // 
            this.düzenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem,
            this.düzenleToolStripMenuItem,
            this.bulToolStripMenuItem});
            this.düzenToolStripMenuItem.Name = "düzenToolStripMenuItem";
            this.düzenToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.düzenToolStripMenuItem.Text = "İşlemler";
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUyeEkle,
            this.menuEngelTipiEkle,
            this.menuDernekEkle});
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            this.ekleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ekleToolStripMenuItem.Text = "Ekle";
            // 
            // menuUyeEkle
            // 
            this.menuUyeEkle.Name = "menuUyeEkle";
            this.menuUyeEkle.Size = new System.Drawing.Size(149, 22);
            this.menuUyeEkle.Text = "Üye Ekle";
            this.menuUyeEkle.Click += new System.EventHandler(this.menuUyeEkle_Click);
            // 
            // menuEngelTipiEkle
            // 
            this.menuEngelTipiEkle.Name = "menuEngelTipiEkle";
            this.menuEngelTipiEkle.Size = new System.Drawing.Size(149, 22);
            this.menuEngelTipiEkle.Text = "Engel Tipi Ekle";
            this.menuEngelTipiEkle.Click += new System.EventHandler(this.menuEngelTipiEkle_Click);
            // 
            // menuDernekEkle
            // 
            this.menuDernekEkle.Name = "menuDernekEkle";
            this.menuDernekEkle.Size = new System.Drawing.Size(149, 22);
            this.menuDernekEkle.Text = "Dernek Ekle";
            this.menuDernekEkle.Click += new System.EventHandler(this.menuDernekEkle_Click);
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDernekListele,
            this.btnEngelTipListele});
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.düzenleToolStripMenuItem.Text = "Göster";
            // 
            // btnDernekListele
            // 
            this.btnDernekListele.Name = "btnDernekListele";
            this.btnDernekListele.Size = new System.Drawing.Size(180, 22);
            this.btnDernekListele.Text = "Dernekler";
            this.btnDernekListele.Click += new System.EventHandler(this.btnDernekListele_Click);
            // 
            // btnEngelTipListele
            // 
            this.btnEngelTipListele.Name = "btnEngelTipListele";
            this.btnEngelTipListele.Size = new System.Drawing.Size(180, 22);
            this.btnEngelTipListele.Text = "Engel Tipleri";
            // 
            // bulToolStripMenuItem
            // 
            this.bulToolStripMenuItem.Name = "bulToolStripMenuItem";
            this.bulToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bulToolStripMenuItem.Text = "Bul";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 498);
            this.Controls.Add(this.lstUyeler);
            this.Controls.Add(this.menuTop);
            this.MainMenuStrip = this.menuTop;
            this.Name = "frmMain";
            this.Text = "Engelliler Konfederasyonu Üye Listesi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuTop.ResumeLayout(false);
            this.menuTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstUyeler;
        private System.Windows.Forms.MenuStrip menuTop;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düzenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bulToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuUyeEkle;
        private System.Windows.Forms.ToolStripMenuItem menuEngelTipiEkle;
        private System.Windows.Forms.ToolStripMenuItem menuDernekEkle;
        private System.Windows.Forms.ToolStripMenuItem menuCikis;
        private System.Windows.Forms.ColumnHeader clmTcNo;
        private System.Windows.Forms.ColumnHeader clmAd;
        private System.Windows.Forms.ColumnHeader clmSoyad;
        private System.Windows.Forms.ColumnHeader clmBaba;
        private System.Windows.Forms.ColumnHeader clmYas;
        private System.Windows.Forms.ColumnHeader clmEngel;
        private System.Windows.Forms.ColumnHeader clmCinsiyet;
        private System.Windows.Forms.ColumnHeader clmSehir;
        private System.Windows.Forms.ColumnHeader clmDernek;
        private System.Windows.Forms.ToolStripMenuItem btnDernekListele;
        private System.Windows.Forms.ToolStripMenuItem btnEngelTipListele;
    }
}