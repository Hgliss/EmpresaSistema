namespace EmpresaAPI.DTOs
{
    public class DepartamentoDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Presupuesto { get; set; }
        public bool Estado { get; set; } = true;

    }
}
