using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace BlurBOX
{
    

    public class MuzikIslemleridal
    {
        private VeritabaniBaglanti veritabani;

        public MuzikIslemleridal()
        {
            veritabani = new VeritabaniBaglanti();
        }

        public DataTable MuzikleriGetir()
        {
            using (SqlConnection conn = veritabani.GetConnection())
            {
                string query = "SELECT * FROM Muzik";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public void MuzikEkle(string baslik, string sanatci, string dosyaYolu)
        {
            using (SqlConnection conn = veritabani.GetConnection())
            {
                string query = "INSERT INTO Muzik (baslik, sanatci, dosya_yolu) VALUES (@baslik, @sanatci, @dosya_yolu)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@baslik", baslik);
                cmd.Parameters.AddWithValue("@sanatci", sanatci);
                cmd.Parameters.AddWithValue("@dosya_yolu", dosyaYolu);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void MuzikSil(int muzikId)
        {
            using (SqlConnection conn = veritabani.GetConnection())
            {
                string query = "DELETE FROM Muzik WHERE id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", muzikId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public DataTable MuzikAra(string aramaKriteri,string aramakriteri2) 
        {
            using (SqlConnection conn = veritabani.GetConnection()) 
            { string query = "SELECT id, baslik, sanatci, dosya_yolu FROM Muzik WHERE baslik LIKE @aramaKriteri or sanatci LIKE @aramakriteri2"; 
                SqlDataAdapter da = new SqlDataAdapter(query, conn); 
                da.SelectCommand.Parameters.AddWithValue("@aramaKriteri", "%" + aramaKriteri + "%");
                da.SelectCommand.Parameters.AddWithValue("@aramakriteri2", "%" + aramakriteri2 + "%");
                DataTable dt = new DataTable(); 
                da.Fill(dt); return dt; 
            } 
        
        }


    }

}
