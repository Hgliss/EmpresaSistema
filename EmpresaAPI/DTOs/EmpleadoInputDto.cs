using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmpresaAPI.DTOs
{
    public class EmpleadoInputDto
    {
        [Required(ErrorMessage = "Los nombres son obligatorios.")]
        public string Nombres { get; set; }

        [Required(ErrorMessage = "Los apellidos son obligatorios.")]
        public string Apellidos { get; set; }

        [Required(ErrorMessage = "El CUI es obligatorio.")]
        [StringLength(13, MinimumLength = 13, ErrorMessage = "El CUI debe tener 13 dígitos.")]
        [RegularExpression(@"^\d{13}$", ErrorMessage = "El CUI debe contener únicamente números.")]
        public string CUI { get; set; }

        [Required(ErrorMessage = "La fecha de ingreso es obligatoria.")]
        [DataType(DataType.Date)]
        public DateTime Fecha_Ingreso { get; set; }

        [Required(ErrorMessage = "El salario actual es obligatorio.")]
        [Range(0.01, 999999.99, ErrorMessage = "El salario debe ser mayor a 0.")]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Salario_Actual { get; set; }

        [DataType(DataType.Date)]
        public DateTime? Fecha_Ultimo_Aumento { get; set; }

        [DataType(DataType.Date)]
        public DateTime? Fecha_baja { get; set; }

        [Required(ErrorMessage = "El puesto es obligatorio.")]
        public string Puesto { get; set; }

        [Required(ErrorMessage = "La Jerarquia es obligatoria.")]
        public string Jerarquia { get; set; }

        [Required(ErrorMessage = "El Estado es obligatoria.")]
        public bool Estado { get; set; } = true;

        [ForeignKey("Departamento")]
        public int Departamento_Id { get; set; }
        
    }
}
