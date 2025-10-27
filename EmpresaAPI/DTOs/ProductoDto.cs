
namespace EmpresaAPI.DTOs
{
    public class ProductoDto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int Existencia { get; set; }
        public decimal Precio { get; set; }
        public decimal Costo { get; set; }
        public bool Estado { get; set; } = true;
        public DateTime Fecha_Creacion { get; set; } = DateTime.Now;
        public DateTime? Fecha_Modificacion { get; set; }
        public int? Usuario_Creacion_Id { get; set; }
        public int? Usuario_Modificacion_Id { get; set; }
    }
}
