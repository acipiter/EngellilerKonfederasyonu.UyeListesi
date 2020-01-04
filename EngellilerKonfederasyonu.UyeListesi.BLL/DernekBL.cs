using EngellilerKonfederasyonu.DAL;
using EngellilerKonfederasyonu.UyeListesi.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngellilerKonfederasyonu.UyeListesi.BLL
{
    public class DernekBL
    {
        Helper hlp = new Helper();

        public bool DernekEkle(Dernek dernek)
        {
            SqlParameter[] p = { new SqlParameter("@DernekAd", dernek) };
            return hlp.ExecuteNonQuery("spDernekEkle", p, CommandType.StoredProcedure) > 0;
        }
    }
}
