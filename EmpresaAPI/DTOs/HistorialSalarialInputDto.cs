using System.ComponentModel.DataAnnotations;

namespace EmpresaAPI.DTOs
{
    public class HistorialSalarialInputDto
    {
        [Required(ErrorMessage = "El salario anterior es obligatorio.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "El salario anterior debe ser mayor que cero.")]
        public decimal Salario_Anterior { get; set; }

        [Required(ErrorMessage = "El salario nuevo es obligatorio.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "El salario nuevo debe ser mayor que cero.")]
        public decimal Salario_nuevo { get; set; }

        [Required(ErrorMessage = "La fecha del cambio es obligatoria.")]
        [DataType(DataType.Date)]
        public DateTime Fecha_Cambio { get; set; }

        [Required(ErrorMessage = "El motivo del cambio es obligatorio.")]
        [StringLength(400, ErrorMessage = "El motivo no puede tener más de 400 caracteres.")]
        public string Motivo { get; set; }

        [Required(ErrorMessage = "El empleado asociado es obligatorio.")]
        
        
        public int Empleado_Id { get; set; }
    }
}
