using Microsoft.Extensions.Configuration;
using System.IO;

namespace BlurBOX
{
    public static class ConfigHelper
    {
        public static string GetConnectionString()
        {
            var builder = new Microsoft.Extensions.Configuration.ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            IConfiguration config = builder.Build();

            return config.GetConnectionString("DefaultConnection");
        }
    }
}