
namespace EmpresaAPI.DTOs
{
    public class DetalleVentaDto
    {
        public int Id { get; set; }
        public int Venta_Id { get; set; }
        public int Producto_Id { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Costo { get; set; }
        public decimal Subtotal { get; set; }
        public DateTime Fecha_Creacion { get; set; } = DateTime.Now;
        public DateTime? Fecha_Modificacion { get; set; }
        public int? Usuario_Creacion_Id { get; set; }
        public int? Usuario_Modificacion_Id { get; set; }

    }
}
