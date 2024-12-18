using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace BlurBOX
{
   

    public class Filmislemleridal
    {
        private VeritabaniBaglanti veritabani;

        public Filmislemleridal()
        {
            veritabani = new VeritabaniBaglanti();
        }

        public DataTable FilmleriGetir()
        {
            using (SqlConnection conn = veritabani.GetConnection())
            {
                string query = "SELECT id, baslik, tur, dosya_yolu FROM Filmler";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public void FilmEkle(string baslik, string tur, string dosyaYolu)
        {
            using (SqlConnection conn = veritabani.GetConnection())
            {
                string query = "INSERT INTO Filmler (baslik, tur, dosya_yolu) VALUES (@baslik, @tur, @dosya_yolu)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@baslik", baslik);
                cmd.Parameters.AddWithValue("@tur", tur);
                cmd.Parameters.AddWithValue("@dosya_yolu", dosyaYolu);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void FilmSil(int filmId)
        {
            using (SqlConnection conn = veritabani.GetConnection())
            {
                string query = "DELETE FROM Filmler WHERE id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", filmId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public DataTable FilmAra(string aramaKriteri, string aramakriteri2)
        {
            using (SqlConnection conn = veritabani.GetConnection())
            {
                string query = "SELECT id, baslik, tur, dosya_yolu FROM Filmler WHERE baslik LIKE @aramaKriteri or tur LIKE @aramakriteri2";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@aramaKriteri", "%" + aramaKriteri + "%");
                da.SelectCommand.Parameters.AddWithValue("@aramakriteri2", "%" + aramakriteri2 + "%");
                DataTable dt = new DataTable();
                da.Fill(dt); return dt;
            }

        }
    }

}
