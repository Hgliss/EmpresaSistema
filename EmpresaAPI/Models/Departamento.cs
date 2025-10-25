namespace EmpresaAPI.Models
{
    public class Departamento : AuditoriaBase
    {
        public int Id_Departamento { get; set; }
        public string Nombre { get; set; }
        public decimal Presupuesto { get; set; }
        public bool Estado { get; set; } = true;

        public ICollection<Empleado> Empleados { get; set; } = new List<Empleado>();
    }
}
