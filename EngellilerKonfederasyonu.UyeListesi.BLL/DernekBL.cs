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
            SqlParameter[] p = { new SqlParameter("@DernekAd", dernek.DernekAd) };
            return hlp.ExecuteNonQuery("spDernekEkle", p, CommandType.StoredProcedure) > 0;
        }

        public bool DernekSil(int id)
        {
            SqlParameter[] p = { new SqlParameter("DernekID", id) };
            return hlp.ExecuteNonQuery("spDernekSil", p, CommandType.StoredProcedure) > 0;
        }

        public List<Dernek> DernekListele()
        {
            SqlDataReader dr = hlp.ExecuteReader("spDernekListe",null, CommandType.StoredProcedure);
            List<Dernek> lst = new List<Dernek>();
            while (dr.Read())
            {
                Dernek d = new Dernek();
                d.DernekID = Convert.ToInt16(dr["DernekID"]);
                d.DernekAd = dr["DernekAd"].ToString();
                lst.Add(d);
            }
            dr.Close();
            return lst;
        }

        //public DataTable DernekLitele() => hlp.MyDataTable("spKitapListe", null, CommandType.StoredProcedure);
    }
}
