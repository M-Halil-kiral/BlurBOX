using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlurBOX
{
    using System.Data.SqlClient;

    public class Kullanici
    {
        public string KullaniciAdi { get; set; }
        public string KullaniciSifre { get; set; }

        public Kullanici(string kullaniciAdi, string kullaniciSifre)
        {
            KullaniciAdi = kullaniciAdi;
            KullaniciSifre = kullaniciSifre;
        }

        public bool KullaniciGirisKontrol()
        {
            VeritabaniBaglanti veritabani = new VeritabaniBaglanti();
            using (SqlConnection conn = veritabani.GetConnection())
            {
                string query = "SELECT * FROM Uyeler WHERE uyekullanciadi = @kullaniciadi AND uyesifre = @sifre";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@kullaniciadi", KullaniciAdi);
                cmd.Parameters.AddWithValue("@sifre", KullaniciSifre);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                return reader.HasRows;
            }
        }
    }



}

