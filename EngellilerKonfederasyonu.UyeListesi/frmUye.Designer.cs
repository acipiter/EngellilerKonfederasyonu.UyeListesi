namespace EngellilerKonfederasyonu.UyeListesi
{
    partial class frmUye
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTcKimlik = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTcKimlik = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblAnne = new System.Windows.Forms.Label();
            this.lblBaba = new System.Windows.Forms.Label();
            this.lblDogum = new System.Windows.Forms.Label();
            this.lblEngel = new System.Windows.Forms.Label();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.lblSehir = new System.Windows.Forms.Label();
            this.lblDernek = new System.Windows.Forms.Label();
            this.lblKarar = new System.Windows.Forms.Label();
            this.dtDogum = new System.Windows.Forms.DateTimePicker();
            this.txtBaba = new System.Windows.Forms.TextBox();
            this.rdKadin = new System.Windows.Forms.RadioButton();
            this.rdErkek = new System.Windows.Forms.RadioButton();
            this.cbSehir = new System.Windows.Forms.ComboBox();
            this.cbDernek = new System.Windows.Forms.ComboBox();
            this.txtAnne = new System.Windows.Forms.TextBox();
            this.txtKarar = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.rtxtEk = new System.Windows.Forms.RichTextBox();
            this.lblEk = new System.Windows.Forms.Label();
            this.cbEngel = new System.Windows.Forms.ComboBox();
            this.txtYuzde = new System.Windows.Forms.TextBox();
            this.lblYuzde = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTcKimlik
            // 
            this.txtTcKimlik.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.SetColumnSpan(this.txtTcKimlik, 2);
            this.txtTcKimlik.Location = new System.Drawing.Point(118, 5);
            this.txtTcKimlik.Name = "txtTcKimlik";
            this.txtTcKimlik.Size = new System.Drawing.Size(149, 20);
            this.txtTcKimlik.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel1.Controls.Add(this.lblTcKimlik, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblAd, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtAd, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblAnne, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblBaba, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblDogum, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblEngel, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblCinsiyet, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.lblSehir, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.lblDernek, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.lblKarar, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.txtTcKimlik, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtDogum, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtBaba, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.rdKadin, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.rdErkek, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.cbSehir, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.cbDernek, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.txtAnne, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtKarar, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.txtSoyad, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblSoyad, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.rtxtEk, 1, 12);
            this.tableLayoutPanel1.Controls.Add(this.lblEk, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.cbEngel, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtYuzde, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblYuzde, 0, 7);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 13;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(275, 415);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblTcKimlik
            // 
            this.lblTcKimlik.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTcKimlik.AutoSize = true;
            this.lblTcKimlik.Location = new System.Drawing.Point(44, 8);
            this.lblTcKimlik.Name = "lblTcKimlik";
            this.lblTcKimlik.Size = new System.Drawing.Size(68, 13);
            this.lblTcKimlik.TabIndex = 1;
            this.lblTcKimlik.Text = "TC Kimlik No";
            // 
            // lblAd
            // 
            this.lblAd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(92, 68);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(20, 13);
            this.lblAd.TabIndex = 1;
            this.lblAd.Text = "Ad";
            // 
            // txtAd
            // 
            this.txtAd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.SetColumnSpan(this.txtAd, 2);
            this.txtAd.Location = new System.Drawing.Point(118, 65);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(149, 20);
            this.txtAd.TabIndex = 2;
            // 
            // lblAnne
            // 
            this.lblAnne.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblAnne.AutoSize = true;
            this.lblAnne.Location = new System.Drawing.Point(62, 158);
            this.lblAnne.Name = "lblAnne";
            this.lblAnne.Size = new System.Drawing.Size(50, 13);
            this.lblAnne.TabIndex = 1;
            this.lblAnne.Text = "Anne Adı";
            // 
            // lblBaba
            // 
            this.lblBaba.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblBaba.AutoSize = true;
            this.lblBaba.Location = new System.Drawing.Point(62, 128);
            this.lblBaba.Name = "lblBaba";
            this.lblBaba.Size = new System.Drawing.Size(50, 13);
            this.lblBaba.TabIndex = 1;
            this.lblBaba.Text = "Baba Adı";
            // 
            // lblDogum
            // 
            this.lblDogum.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDogum.AutoSize = true;
            this.lblDogum.Location = new System.Drawing.Point(42, 98);
            this.lblDogum.Name = "lblDogum";
            this.lblDogum.Size = new System.Drawing.Size(70, 13);
            this.lblDogum.TabIndex = 1;
            this.lblDogum.Text = "Doğum Tarihi";
            // 
            // lblEngel
            // 
            this.lblEngel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblEngel.AutoSize = true;
            this.lblEngel.Location = new System.Drawing.Point(38, 188);
            this.lblEngel.Name = "lblEngel";
            this.lblEngel.Size = new System.Drawing.Size(74, 13);
            this.lblEngel.TabIndex = 1;
            this.lblEngel.Text = "Engel Durumu";
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCinsiyet.AutoSize = true;
            this.lblCinsiyet.Location = new System.Drawing.Point(67, 242);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(45, 13);
            this.lblCinsiyet.TabIndex = 1;
            this.lblCinsiyet.Text = "Cinsiyeti";
            // 
            // lblSehir
            // 
            this.lblSehir.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSehir.AutoSize = true;
            this.lblSehir.Location = new System.Drawing.Point(38, 268);
            this.lblSehir.Name = "lblSehir";
            this.lblSehir.Size = new System.Drawing.Size(74, 13);
            this.lblSehir.TabIndex = 1;
            this.lblSehir.Text = "Yaşadığı Şehir";
            // 
            // lblDernek
            // 
            this.lblDernek.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDernek.AutoSize = true;
            this.lblDernek.Location = new System.Drawing.Point(42, 298);
            this.lblDernek.Name = "lblDernek";
            this.lblDernek.Size = new System.Drawing.Size(70, 13);
            this.lblDernek.TabIndex = 1;
            this.lblDernek.Text = "Bağlı Derneği";
            // 
            // lblKarar
            // 
            this.lblKarar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblKarar.AutoSize = true;
            this.lblKarar.Location = new System.Drawing.Point(63, 328);
            this.lblKarar.Name = "lblKarar";
            this.lblKarar.Size = new System.Drawing.Size(49, 13);
            this.lblKarar.TabIndex = 1;
            this.lblKarar.Text = "Karar No";
            // 
            // dtDogum
            // 
            this.dtDogum.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.SetColumnSpan(this.dtDogum, 2);
            this.dtDogum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDogum.Location = new System.Drawing.Point(118, 95);
            this.dtDogum.Name = "dtDogum";
            this.dtDogum.Size = new System.Drawing.Size(149, 20);
            this.dtDogum.TabIndex = 3;
            // 
            // txtBaba
            // 
            this.txtBaba.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.SetColumnSpan(this.txtBaba, 2);
            this.txtBaba.Location = new System.Drawing.Point(118, 125);
            this.txtBaba.Name = "txtBaba";
            this.txtBaba.Size = new System.Drawing.Size(149, 20);
            this.txtBaba.TabIndex = 4;
            // 
            // rdKadin
            // 
            this.rdKadin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rdKadin.AutoSize = true;
            this.rdKadin.Location = new System.Drawing.Point(118, 240);
            this.rdKadin.Name = "rdKadin";
            this.rdKadin.Size = new System.Drawing.Size(52, 17);
            this.rdKadin.TabIndex = 8;
            this.rdKadin.TabStop = true;
            this.rdKadin.Text = "Kadın";
            this.rdKadin.UseVisualStyleBackColor = true;
            // 
            // rdErkek
            // 
            this.rdErkek.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rdErkek.AutoSize = true;
            this.rdErkek.Location = new System.Drawing.Point(196, 240);
            this.rdErkek.Name = "rdErkek";
            this.rdErkek.Size = new System.Drawing.Size(53, 17);
            this.rdErkek.TabIndex = 9;
            this.rdErkek.TabStop = true;
            this.rdErkek.Text = "Erkek";
            this.rdErkek.UseVisualStyleBackColor = true;
            // 
            // cbSehir
            // 
            this.cbSehir.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.SetColumnSpan(this.cbSehir, 2);
            this.cbSehir.FormattingEnabled = true;
            this.cbSehir.Location = new System.Drawing.Point(118, 264);
            this.cbSehir.Name = "cbSehir";
            this.cbSehir.Size = new System.Drawing.Size(149, 21);
            this.cbSehir.TabIndex = 10;
            // 
            // cbDernek
            // 
            this.cbDernek.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.SetColumnSpan(this.cbDernek, 2);
            this.cbDernek.FormattingEnabled = true;
            this.cbDernek.Location = new System.Drawing.Point(118, 294);
            this.cbDernek.Name = "cbDernek";
            this.cbDernek.Size = new System.Drawing.Size(149, 21);
            this.cbDernek.TabIndex = 11;
            // 
            // txtAnne
            // 
            this.txtAnne.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.SetColumnSpan(this.txtAnne, 2);
            this.txtAnne.Location = new System.Drawing.Point(118, 155);
            this.txtAnne.Name = "txtAnne";
            this.txtAnne.Size = new System.Drawing.Size(149, 20);
            this.txtAnne.TabIndex = 5;
            // 
            // txtKarar
            // 
            this.txtKarar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.SetColumnSpan(this.txtKarar, 2);
            this.txtKarar.Location = new System.Drawing.Point(118, 325);
            this.txtKarar.Name = "txtKarar";
            this.txtKarar.Size = new System.Drawing.Size(149, 20);
            this.txtKarar.TabIndex = 12;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.SetColumnSpan(this.txtSoyad, 2);
            this.txtSoyad.Location = new System.Drawing.Point(118, 35);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(149, 20);
            this.txtSoyad.TabIndex = 1;
            // 
            // lblSoyad
            // 
            this.lblSoyad.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(75, 38);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(37, 13);
            this.lblSoyad.TabIndex = 1;
            this.lblSoyad.Text = "Soyad";
            // 
            // rtxtEk
            // 
            this.rtxtEk.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.SetColumnSpan(this.rtxtEk, 2);
            this.rtxtEk.Location = new System.Drawing.Point(118, 353);
            this.rtxtEk.Name = "rtxtEk";
            this.rtxtEk.Size = new System.Drawing.Size(149, 59);
            this.rtxtEk.TabIndex = 13;
            this.rtxtEk.Text = "";
            // 
            // lblEk
            // 
            this.lblEk.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblEk.AutoSize = true;
            this.lblEk.Location = new System.Drawing.Point(88, 376);
            this.lblEk.Name = "lblEk";
            this.lblEk.Size = new System.Drawing.Size(24, 13);
            this.lblEk.TabIndex = 1;
            this.lblEk.Text = "Not";
            // 
            // cbEngel
            // 
            this.cbEngel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.SetColumnSpan(this.cbEngel, 2);
            this.cbEngel.FormattingEnabled = true;
            this.cbEngel.Location = new System.Drawing.Point(118, 184);
            this.cbEngel.Name = "cbEngel";
            this.cbEngel.Size = new System.Drawing.Size(149, 21);
            this.cbEngel.TabIndex = 6;
            // 
            // txtYuzde
            // 
            this.txtYuzde.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.SetColumnSpan(this.txtYuzde, 2);
            this.txtYuzde.Location = new System.Drawing.Point(118, 213);
            this.txtYuzde.Name = "txtYuzde";
            this.txtYuzde.Size = new System.Drawing.Size(149, 20);
            this.txtYuzde.TabIndex = 7;
            // 
            // lblYuzde
            // 
            this.lblYuzde.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblYuzde.AutoSize = true;
            this.lblYuzde.Location = new System.Drawing.Point(38, 217);
            this.lblYuzde.Name = "lblYuzde";
            this.lblYuzde.Size = new System.Drawing.Size(74, 13);
            this.lblYuzde.TabIndex = 1;
            this.lblYuzde.Text = "Engel Yüzdesi";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(119, 424);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(98, 23);
            this.btnEkle.TabIndex = 14;
            this.btnEkle.Text = "Üye Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            // 
            // frmUye
            // 
            this.AcceptButton = this.btnEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 452);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmUye";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Üye Ekle";
            this.Load += new System.EventHandler(this.frmUye_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtTcKimlik;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DateTimePicker dtDogum;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label lblTcKimlik;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAnne;
        private System.Windows.Forms.Label lblBaba;
        private System.Windows.Forms.Label lblDogum;
        private System.Windows.Forms.Label lblEngel;
        private System.Windows.Forms.Label lblCinsiyet;
        private System.Windows.Forms.Label lblSehir;
        private System.Windows.Forms.Label lblDernek;
        private System.Windows.Forms.Label lblKarar;
        private System.Windows.Forms.TextBox txtBaba;
        private System.Windows.Forms.TextBox txtAnne;
        private System.Windows.Forms.RadioButton rdKadin;
        private System.Windows.Forms.RadioButton rdErkek;
        private System.Windows.Forms.ComboBox cbSehir;
        private System.Windows.Forms.ComboBox cbDernek;
        private System.Windows.Forms.TextBox txtKarar;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label lblEk;
        private System.Windows.Forms.RichTextBox rtxtEk;
        private System.Windows.Forms.ComboBox cbEngel;
        private System.Windows.Forms.TextBox txtYuzde;
        private System.Windows.Forms.Label lblYuzde;
    }
}

