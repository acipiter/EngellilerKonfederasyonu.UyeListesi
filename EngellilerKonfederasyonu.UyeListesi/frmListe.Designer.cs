namespace EngellilerKonfederasyonu.UyeListesi
{
    partial class frmListe
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
            this.menuTop = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUyeEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEngelTipiEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDernekEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TcNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstUyeler
            // 
            this.lstUyeler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TcNo,
            this.Ad});
            this.lstUyeler.HideSelection = false;
            this.lstUyeler.Location = new System.Drawing.Point(1, 27);
            this.lstUyeler.Name = "lstUyeler";
            this.lstUyeler.Size = new System.Drawing.Size(793, 459);
            this.lstUyeler.TabIndex = 0;
            this.lstUyeler.UseCompatibleStateImageBehavior = false;
            this.lstUyeler.View = System.Windows.Forms.View.List;
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
            this.düzenToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.düzenToolStripMenuItem.Text = "Düzen";
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUyeEkle,
            this.menuEngelTipiEkle,
            this.menuDernekEkle});
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            this.ekleToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
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
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            // 
            // bulToolStripMenuItem
            // 
            this.bulToolStripMenuItem.Name = "bulToolStripMenuItem";
            this.bulToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.bulToolStripMenuItem.Text = "Bul";
            // 
            // TcNo
            // 
            this.TcNo.Text = "T.C. No";
            // 
            // Ad
            // 
            this.Ad.Text = "Adı";
            // 
            // frmListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 498);
            this.Controls.Add(this.lstUyeler);
            this.Controls.Add(this.menuTop);
            this.MainMenuStrip = this.menuTop;
            this.Name = "frmListe";
            this.Text = "frmListe";
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
        private System.Windows.Forms.ColumnHeader TcNo;
        private System.Windows.Forms.ColumnHeader Ad;
    }
}