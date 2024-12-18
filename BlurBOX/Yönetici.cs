using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BlurBOX
{
   

    public class Yonetici
    {
        public string YoneticiAdi { get; set; }
        public string YoneticiSifre { get; set; }

        public Yonetici(string yoneticiAdi, string yoneticiSifre)
        {
            YoneticiAdi = yoneticiAdi;
            YoneticiSifre = yoneticiSifre;
        }
        VeritabaniBaglanti veritabani = new VeritabaniBaglanti();
        public bool YoneticiGirisKontrol()
        {
            
            using (SqlConnection conn = veritabani.GetConnection())
            {
                string query = "SELECT * FROM Yoneticiler WHERE yoneticiadi = @yoneticiadi AND yoneticisifre = @yoneticisifre";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@yoneticiadi", YoneticiAdi);
                cmd.Parameters.AddWithValue("@yoneticisifre", YoneticiSifre);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                return reader.HasRows;
            }
        }




    }
}
