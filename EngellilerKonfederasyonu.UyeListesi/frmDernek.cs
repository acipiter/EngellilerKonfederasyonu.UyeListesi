﻿using EngellilerKonfederasyonu.UyeListesi.BLL;
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
    public partial class frmDernek : Form
    {
        public frmDernek()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            DernekBL dbl = new DernekBL();
            Dernek d = new Dernek();

            d.DernekAd = txtDernek.Text;

            dbl.DernekEkle(d);
        }
    }
}
