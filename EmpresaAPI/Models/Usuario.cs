namespace EmpresaAPI.Models
{
    public class Usuario : AuditoriaBase
    {
        public int Id { get; set; }
        public string Nombre_Usuario { get; set; }
        public string Contrasena { get; set; } = null!;
        public bool Estado { get; set; } = true;

        public int Empleado_Id { get; set;}
        public Empleado Empleado { get; set; }

        public int Rol_Id { get; set; }
        public Rol Rol { get; set; }

    }
}
