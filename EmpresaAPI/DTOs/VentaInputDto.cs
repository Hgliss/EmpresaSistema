using System.ComponentModel.DataAnnotations;

namespace EmpresaAPI.DTOs
{
    public class VentaInputDto
    {
        [Required(ErrorMessage = "La fecha de la venta es obligatoria.")]
        public DateTime Fecha_Venta { get; set; }

        [Required(ErrorMessage = "Debe especificar un cliente asociado.")]
        [Range(1, int.MaxValue, ErrorMessage = "El Id del cliente debe ser válido.")]
        public int Cliente_Id { get; set; }
    }
}
