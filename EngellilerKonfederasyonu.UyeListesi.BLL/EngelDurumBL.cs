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
    public class EngelDurumBL
    {
        Helper hlp = new Helper();
        
        public bool EngelDurumEkle(EngelDurum engelDurum)
        {
            SqlParameter[] p = { new SqlParameter("@EngelDurum", engelDurum.EngelDurum) };

            return hlp.ExecuteNonQuery("spEngelDurumEkle", p) > 0;
        }
    }
}
