using System.ComponentModel.DataAnnotations;


namespace EmpresaAPI.DTOs

{
    public class ClienteInputDto
    {
        [Required(ErrorMessage ="El nit es obligatorio")]
        public string Nit {  get; set; }

        [Required(ErrorMessage = "El nombre es Obligatorio")]
        public string Nombre { get; set; }
    }
}
