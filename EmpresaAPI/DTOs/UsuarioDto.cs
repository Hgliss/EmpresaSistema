using EmpresaAPI.Models;

namespace EmpresaAPI.DTOs
{
    public class UsuarioDto
    {
        public int Id { get; set; }
        public string Nombre_Usuario { get; set; }
        public string Contrasena { get; set; } = null!;
        public bool Estado { get; set; } = true;
        public int Empleado_Id { get; set; }
        public int Rol_Id { get; set; }
        public DateTime Fecha_Creacion { get; set; } = DateTime.Now;
        public DateTime? Fecha_Modificacion { get; set; }
        public int? Usuario_Creacion_Id { get; set; }
        public int? Usuario_Modificacion_Id { get; set; }
    }
}
