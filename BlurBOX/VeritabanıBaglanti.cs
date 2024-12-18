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
            connectionString = ConfigurationManager.ConnectionStrings["BlurBOX.Properties.Settings.blurBOXConnectionString"].ConnectionString;
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
