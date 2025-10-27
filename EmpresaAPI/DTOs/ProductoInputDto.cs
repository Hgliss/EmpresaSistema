using System.ComponentModel.DataAnnotations;

namespace EmpresaAPI.DTOs
{
    public class ProductoInputDto
    {
        [Required(ErrorMessage = "La descripción del producto es obligatoria.")]
        [StringLength(255, ErrorMessage = "La descripción no puede tener más de 255 caracteres.")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "La existencia es obligatoria.")]
        [Range(0, int.MaxValue, ErrorMessage = "La existencia no puede ser negativa.")]
        public int Existencia { get; set; }

        [Required(ErrorMessage = "El precio es obligatorio.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "El precio debe ser mayor que cero.")]
        public decimal Precio { get; set; }

        [Required(ErrorMessage = "El costo es obligatorio.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "El costo debe ser mayor que cero.")]
        public decimal Costo { get; set; }

        public bool Estado { get; set; } = true;
    }
}
