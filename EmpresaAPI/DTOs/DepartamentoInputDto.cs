using System.ComponentModel.DataAnnotations;

namespace EmpresaAPI.DTOs

{
    public class DepartamentoInputDto
    {
        [Required(ErrorMessage = "El nombre es Obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El presupuesto es Obligatorio")]
        public decimal Presupuesto { get; set; }

        [Required(ErrorMessage = "El estado es Obligatorio")]
        public bool Estado { get; set; } = true;


    }
}
