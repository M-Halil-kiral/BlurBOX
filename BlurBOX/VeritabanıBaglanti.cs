using System;
using System.Data.SqlClient;
using System.Configuration;

namespace BlurBOX
{
    public class VeritabaniBaglanti
    {
        private string connectionString;

        public VeritabaniBaglanti()
        {
            // App.config'deki bağlantı dizesini oku
            connectionString = @"Data Source=HALILPC;Initial Catalog=blurBOX;Integrated Security=True;";
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
