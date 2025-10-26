namespace EmpresaAPI.Models
{
    public class Cliente : AuditoriaBase
    {
        public int Id { get; set; }
        public string Nit { get; set; }
        public string Nombre { get; set; }

        public ICollection<Venta> Ventas { get; set; } = new List<Venta>();


    }
}
