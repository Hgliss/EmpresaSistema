namespace EmpresaAPI.DTOs
{
    public class DepartamentoDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Presupuesto { get; set; }
        public bool Estado { get; set; } = true;
        public DateTime Fecha_Creacion { get; set; } = DateTime.Now;
        public DateTime? Fecha_Modificacion { get; set; }
        public int? Usuario_Creacion_Id { get; set; }
        public int? Usuario_Modificacion_Id { get; set; }

    }
}
