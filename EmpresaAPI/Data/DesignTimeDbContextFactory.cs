using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;
using DotNetEnv;

namespace EmpresaAPI.Data
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<EmpresaContext>
    {
        public EmpresaContext CreateDbContext(string[] args)
        {

            Env.Load();

            //Cadena de conexion
            string server = Environment.GetEnvironmentVariable("DB_SERVER");
            string database = Environment.GetEnvironmentVariable("DB_NAME");
            string user = Environment.GetEnvironmentVariable("DB_USER");
            string password = Environment.GetEnvironmentVariable("DB_PASS");

            string connectionString;

            if (!string.IsNullOrEmpty(user))
            {
                connectionString = $"Server={server};Database={database};User Id={user};Password={password};TrustServerCertificate=True;";
            }
            else
            {
                connectionString = $"Server={server};Database={database};Trusted_Connection=True;TrustServerCertificate=True;";
            }

            var optionsBuilder = new DbContextOptionsBuilder<EmpresaContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new EmpresaContext(optionsBuilder.Options);
        }
    }
}
