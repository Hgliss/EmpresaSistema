namespace EmpresaAPI.Models
{
    public class Rol : AuditoriaBase
    {
        public int Id { get; set; }
        public string Nombre_Rol { get; set; }
        public bool Estado { get; set; } = true;

        public ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();


    }
}
