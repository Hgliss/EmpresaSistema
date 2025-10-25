using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmpresaAPI.Models
{
    public class Empleado : AuditoriaBase
    {
        public int Id_Empleado { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }

        [Required]
        [MaxLength(13)]
        public string CUI { get; set; }
        public DateTime Fecha_Ingreso { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Salario_Actual { get; set; }
        public DateTime? Fecha_Ultimo_Aumento { get; set; }
        public DateTime? Fecha_baja {  get; set; }
        public string Puesto { get; set; }
        public string Jerarquia { get; set; }
        public bool Estado { get; set; } = true;


        public int Departamento_Id { get; set; }

        public Departamento Departamento { get; set; }

        public ICollection<HistorialSalarial> HistorialesSalariales { get; set; } = new List<HistorialSalarial>();

    }
}
