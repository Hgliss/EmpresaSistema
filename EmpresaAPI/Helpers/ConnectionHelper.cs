using DotNetEnv;
using System;

namespace EmpresaAPI.Helpers
{
    public class ConnectionHelper
    {
        public static string GetConnectionString()
        {
            Env.Load();
            
            string server = Environment.GetEnvironmentVariable("DB_SERVER");
            string database = Environment.GetEnvironmentVariable("DB_NAME");
            string user = Environment.GetEnvironmentVariable("DB_USER");
            string password = Environment.GetEnvironmentVariable("DB_PASS");

            if (!string.IsNullOrEmpty(user))
                return $"Server={server};Database={database};User Id={user};Password={password};TrustServerCertificate=True;";
            else
                return $"Server={server};Database={database};Trusted_Connection=True;TrustServerCertificate=True;";
        }
    }
}

