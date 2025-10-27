using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmpresaAPI.DTOs
{
    public class HistorialSalarialDto
    {
        public int Id { get; set; }
        public decimal Salario_Anterior { get; set; }
        public decimal Salario_nuevo { get; set; }
        public DateTime Fecha_Cambio { get; set; }
        public string Motivo { get; set; }
        public int Empleado_Id { get; set; }
        public DateTime Fecha_Creacion { get; set; } = DateTime.Now;
        public DateTime? Fecha_Modificacion { get; set; }
        public int? Usuario_Creacion_Id { get; set; }
        public int? Usuario_Modificacion_Id { get; set; }
    }
}
