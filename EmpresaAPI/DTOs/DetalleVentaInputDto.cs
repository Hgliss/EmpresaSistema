using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmpresaAPI.DTOs
{
    public class DetalleVentaInputDto
    {
        [ForeignKey("Venta")]
        public int Venta_Id { get; set; }

        [ForeignKey("Producto")]
        public int Producto_Id { get; set; }

        [Required(ErrorMessage = "La cantidad es obligatorio.")]
        [Range(1, int.MaxValue, ErrorMessage = "La cantidad debe ser mayor que cero.")]
        public int Cantidad { get; set; }


        [Required(ErrorMessage = "El precio es obligatorio.")]
        [Range(1, int.MaxValue, ErrorMessage = "La cantidad debe ser mayor que cero.")]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Precio { get; set; }

        [Required(ErrorMessage = "El costo es obligatorio.")]
        [Range(1, int.MaxValue, ErrorMessage = "La cantidad debe ser mayor que cero.")]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Costo { get; set; }

        
        [Column(TypeName = "decimal(10,2)")]
        public decimal Subtotal { get; set; }
    }
}
