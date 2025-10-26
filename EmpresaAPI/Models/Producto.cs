using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmpresaAPI.Models
{
    public class Producto : AuditoriaBase
    {
        public int Id { get; set; }
        [MaxLength(255)]
        public string Descripcion {  get; set; }
        public int Existencia { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal Precio { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal Costo { get; set; }

        public ICollection<DetalleVenta> DetallesVentas { get; set; } = new List<DetalleVenta>();

    }
}
