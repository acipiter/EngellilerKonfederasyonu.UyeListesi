using EngellilerKonfederasyonu.DAL;
using EngellilerKonfederasyonu.UyeListesi.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngellilerKonfederasyonu.UyeListesi.BLL
{
    class DernekBL
    {
        Helper hlp = new Helper();

        public bool DernekEkle(Dernek dernek)
        {
            SqlParameter p = { new SqlParameter("@DernekAd", dernek.) }
        }
    }
}
