using System.ComponentModel.DataAnnotations.Schema;

namespace EmpresaAPI.Models
{
    
    public abstract class AuditoriaBase
    {
        public DateTime Fecha_Creacion { get; set; } = DateTime.Now;
        public DateTime? Fecha_Modificacion { get; set; }

        public int? Usuario_Creacion_Id { get; set; }
        public int? Usuario_Modificacion_Id { get; set; }

        public Usuario? Usuario_Creacion { get; set; } = null!;
        public Usuario? Usuario_Modificacion { get; set; }

    }
}
