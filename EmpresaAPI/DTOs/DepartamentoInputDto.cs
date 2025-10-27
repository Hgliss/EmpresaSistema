using System.ComponentModel.DataAnnotations;

namespace EmpresaAPI.DTOs

{
    public class DepartamentoInputDto
    {
        [Required(ErrorMessage = "El nombre es Obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El presupuesto es Obligatorio")]
        [Range(0.01, 999999.99, ErrorMessage = "El presupuesto debe ser mayor a 0.")]
        public decimal Presupuesto { get; set; }

        [Required(ErrorMessage = "El estado es Obligatorio")]
        public bool Estado { get; set; } = true;


    }
}
