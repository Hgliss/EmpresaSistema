using System.ComponentModel.DataAnnotations.Schema;

namespace EmpresaAPI.Models
{
    public class Venta : AuditoriaBase
    {
        public int Id_Venta { get; set; }
        public DateTime Fecha_Venta { get; set; }
        [Column(TypeName ="decimal(10,2)")]
        public int Total { get; set; }

        public int Cliente_Id { get; set; }
        public Cliente Cliente { get; set; } = null!;

        public ICollection<DetalleVenta> DetallesVentas { get; set; } = new List<DetalleVenta>();
    }
}
