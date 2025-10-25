using Microsoft.EntityFrameworkCore;
using EmpresaAPI.Models;


namespace EmpresaAPI.Data
{
    public class EmpresaContext : DbContext
    {
        public EmpresaContext(DbContextOptions<EmpresaContext> options)
            : base(options) { }
        {
        }

    //tablas



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
