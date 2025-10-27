using System.ComponentModel.DataAnnotations;
namespace EmpresaAPI.DTOs
{
    public class UsuarioInputDto
    {
        [Required(ErrorMessage = "El nombre de usuario es obligatorio.")]
        public string Nombre_Usuario { get; set; }

        [Required(ErrorMessage = "La contraseña es obligatoria.")]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "La contraseña debe tener al menos 8 caracteres.")]
        public string Contrasena { get; set; } = null!;
        public bool Estado { get; set; } = true;

        [Required(ErrorMessage = "Debe especificar un empleado asociado.")]
        [Range(1, int.MaxValue, ErrorMessage = "El Id del empleado debe ser válido.")]
        public int Empleado_Id { get; set; }

        [Required(ErrorMessage = "Debe asignar un rol al usuario.")]
        [Range(1, int.MaxValue, ErrorMessage = "El Id del rol debe ser válido.")]
        public int Rol_Id { get; set; }
    }
}
