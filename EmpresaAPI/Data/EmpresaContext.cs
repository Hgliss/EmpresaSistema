using Microsoft.EntityFrameworkCore;
using EmpresaAPI.Models;


namespace EmpresaAPI.Data
{
    public class EmpresaContext : DbContext
    {
        public EmpresaContext(DbContextOptions<EmpresaContext> options)
            : base(options) 
        {    
        }

    //tablas
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<DetalleVenta> DetalleVentas { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<HistorialSalarial> HistorialSalarials { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Rol> Rols { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Venta> Ventas { get; set; }


    //Configuraciones Personalizadas
    protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                if (typeof(AuditoriaBase).IsAssignableFrom(entityType.ClrType))
                {
                    //Usuario Creacion
                    modelBuilder.Entity(entityType.ClrType)
                        .HasOne(typeof(Usuario), "Usuario_Creacion")
                        .WithMany()
                        .HasForeignKey("Usuario_Creacion_Id")
                        .OnDelete(DeleteBehavior.Restrict);


                    //Usuario Modificacion
                    modelBuilder.Entity(entityType.ClrType)
                        .HasOne(typeof(Usuario), "Usuario_Modificacion")
                        .WithMany()
                        .HasForeignKey("Usuario_Modificacion_Id")
                        .OnDelete(DeleteBehavior.Restrict);
                }
            }
        }

    }
}
