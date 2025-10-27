using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using EmpresaAPI.Helpers;

namespace EmpresaAPI.Data
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<EmpresaContext>
    {
        public EmpresaContext CreateDbContext(string[] args)
        {

            string connectionString = ConnectionHelper.GetConnectionString();

            var optionsBuilder = new DbContextOptionsBuilder<EmpresaContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new EmpresaContext(optionsBuilder.Options);
        }
    }
}
