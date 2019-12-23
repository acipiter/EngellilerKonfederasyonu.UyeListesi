namespace EngellilerKonfederasyonu.UyeListesi
{
    partial class frmEngel
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
            this.txtEngel = new System.Windows.Forms.TextBox();
            this.lblEngel = new System.Windows.Forms.Label();
            this.Ekle = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEngel
            // 
            this.txtEngel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtEngel.Location = new System.Drawing.Point(109, 6);
            this.txtEngel.Name = "txtEngel";
            this.txtEngel.Size = new System.Drawing.Size(199, 20);
            this.txtEngel.TabIndex = 0;
            // 
            // lblEngel
            // 
            this.lblEngel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblEngel.AutoSize = true;
            this.lblEngel.Location = new System.Drawing.Point(17, 9);
            this.lblEngel.Name = "lblEngel";
            this.lblEngel.Size = new System.Drawing.Size(86, 13);
            this.lblEngel.TabIndex = 1;
            this.lblEngel.Text = "Engel Tipini Girin";
            // 
            // Ekle
            // 
            this.Ekle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Ekle.Location = new System.Drawing.Point(109, 41);
            this.Ekle.Name = "Ekle";
            this.Ekle.Size = new System.Drawing.Size(112, 23);
            this.Ekle.TabIndex = 2;
            this.Ekle.Text = "Engel Tipi Ekle";
            this.Ekle.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.25605F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.74394F));
            this.tableLayoutPanel1.Controls.Add(this.Ekle, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtEngel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblEngel, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.59459F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.40541F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(311, 74);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // frmEngel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 76);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmEngel";
            this.Text = "Engel Tipi Ekleyin";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtEngel;
        private System.Windows.Forms.Label lblEngel;
        private System.Windows.Forms.Button Ekle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}