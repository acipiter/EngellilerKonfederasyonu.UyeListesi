using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EngellilerKonfederasyonu.UyeListesi
{
    public partial class frmListe : Form
    {
        public frmListe()
        {
            InitializeComponent();
        }

        private void menuUyeEkle_Click(object sender, EventArgs e)
        {
            frmUye frmUye = new frmUye();
            frmUye.ShowDialog();
        }

        private void menuEngelTipiEkle_Click(object sender, EventArgs e)
        {
            frmEngel frmEngel = new frmEngel();
            frmEngel.ShowDialog();
        }

        private void menuDernekEkle_Click(object sender, EventArgs e)
        {
            frmDernek frmDernek = new frmDernek();
            frmDernek.ShowDialog();
        }

        private void menuCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
