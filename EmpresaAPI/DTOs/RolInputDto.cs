using System.ComponentModel.DataAnnotations;

namespace EmpresaAPI.DTOs
{
    public class RolInputDto
    {
        [Required(ErrorMessage = "El nombre del rol es obligatorio.")]
        public string Nombre_Rol { get; set; }
        public bool Estado { get; set; } = true;
    }
}
