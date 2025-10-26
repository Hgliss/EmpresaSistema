using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmpresaAPI.Models
{
    public class HistorialSalarial : AuditoriaBase
    {
        public int Id { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal Salario_Anterior { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Salario_nuevo { get; set; }
        public DateTime Fecha_Cambio {  get; set; }

        [MaxLength(200)]
        public string Motivo {  get; set; }

        public int Empleado_Id {  get; set; }
        public Empleado Empleado { get; set; } = null!;
    }
}
