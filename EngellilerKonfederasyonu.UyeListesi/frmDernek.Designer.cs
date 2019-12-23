namespace EngellilerKonfederasyonu.UyeListesi
{
    partial class frmDernek
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtDernek = new System.Windows.Forms.TextBox();
            this.lblDernek = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.89518F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.10481F));
            this.tableLayoutPanel1.Controls.Add(this.txtDernek, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDernek, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(353, 50);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtDernek
            // 
            this.txtDernek.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDernek.Location = new System.Drawing.Point(104, 15);
            this.txtDernek.Name = "txtDernek";
            this.txtDernek.Size = new System.Drawing.Size(246, 20);
            this.txtDernek.TabIndex = 1;
            // 
            // lblDernek
            // 
            this.lblDernek.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDernek.AutoSize = true;
            this.lblDernek.Location = new System.Drawing.Point(19, 18);
            this.lblDernek.Name = "lblDernek";
            this.lblDernek.Size = new System.Drawing.Size(79, 13);
            this.lblDernek.TabIndex = 2;
            this.lblDernek.Text = "Dernek Ekleyin";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(104, 56);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(120, 23);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Derneği Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // frmDernek
            // 
            this.AcceptButton = this.btnEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 83);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDernek";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dernek Ekleyin";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtDernek;
        private System.Windows.Forms.Label lblDernek;
        private System.Windows.Forms.Button btnEkle;
    }
}