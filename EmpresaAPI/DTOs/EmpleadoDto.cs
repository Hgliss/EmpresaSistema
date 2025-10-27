using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmpresaAPI.DTOs
{
    public class EmpleadoDto
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string CUI { get; set; }
        public DateTime Fecha_Ingreso { get; set; }
        public decimal Salario_Actual { get; set; }
        public DateTime? Fecha_Ultimo_Aumento { get; set; }
        public DateTime? Fecha_baja { get; set; }
        public string Puesto { get; set; }
        public string Jerarquia { get; set; }
        public bool Estado { get; set; } = true;
        public int Departamento_Id { get; set; }
        public DateTime Fecha_Creacion { get; set; } = DateTime.Now;
        public DateTime? Fecha_Modificacion { get; set; }
        public int? Usuario_Creacion_Id { get; set; }
        public int? Usuario_Modificacion_Id { get; set; }
    }
}
