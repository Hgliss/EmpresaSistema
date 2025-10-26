using System.ComponentModel.DataAnnotations.Schema;

namespace EmpresaAPI.Models
{
    public class DetalleVenta : AuditoriaBase
    {
        public int Id { get; set; }
        public int Cantidad { get; set; }
        [Column(TypeName ="decimal(10,2)")]
        public decimal Precio { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal Costo { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal Subtotal { get; set; }

        public int Venta_Id { get; set; }
        public Venta Venta { get; set; } = null!;

        public int Producto_Id { get; set; }
        public Producto Producto { get; set; } = null!;

    }
}
