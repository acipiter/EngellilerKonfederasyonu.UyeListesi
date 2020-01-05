using EngellilerKonfederasyonu.UyeListesi.BLL;
using EngellilerKonfederasyonu.UyeListesi.Models;
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
    public partial class frmDernekListele : Form
    {
        //DataTable dt = new DataTable();
        List<Dernek> d = new List<Dernek>();
        public frmDernekListele()
        {
            InitializeComponent();
        }

        private void frmDernekListele_Load(object sender, EventArgs e)
        {
            DernekBL dbl = new DernekBL();
            //dt = dbl.DernekLitele();
            d= dbl.DernekListele()
            lstDernekler.Items = d;
        }
    }
}
