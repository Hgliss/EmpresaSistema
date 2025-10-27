using System.ComponentModel.DataAnnotations.Schema;
using EmpresaAPI.Models;

namespace EmpresaAPI.DTOs
{
    public class VentaDto
    {
        public int Id { get; set; }
        public DateTime Fecha_Venta { get; set; }
        public decimal Total { get; set; }
        public int Cliente_Id { get; set; }
        public DateTime Fecha_Creacion { get; set; } = DateTime.Now;
        public DateTime? Fecha_Modificacion { get; set; }
        public int? Usuario_Creacion_Id { get; set; }
        public int? Usuario_Modificacion_Id { get; set; }
    }
}
