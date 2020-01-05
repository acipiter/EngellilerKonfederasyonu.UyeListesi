namespace EngellilerKonfederasyonu.UyeListesi
{
    partial class frmDernekListele
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
            this.lstDernekler = new System.Windows.Forms.ListView();
            this.clmDernekler = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lstDernekler
            // 
            this.lstDernekler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmDernekler});
            this.lstDernekler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstDernekler.HideSelection = false;
            this.lstDernekler.Location = new System.Drawing.Point(0, 0);
            this.lstDernekler.Name = "lstDernekler";
            this.lstDernekler.Size = new System.Drawing.Size(413, 365);
            this.lstDernekler.TabIndex = 0;
            this.lstDernekler.UseCompatibleStateImageBehavior = false;
            // 
            // clmDernekler
            // 
            this.clmDernekler.Text = "Dernekler";
            // 
            // frmDernekListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 365);
            this.Controls.Add(this.lstDernekler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDernekListele";
            this.Text = "Dernekler";
            this.Load += new System.EventHandler(this.frmDernekListele_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstDernekler;
        private System.Windows.Forms.ColumnHeader clmDernekler;
    }
}