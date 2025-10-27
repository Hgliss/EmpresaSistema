using EmpresaAPI.DTOs;
using EmpresaAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace EmpresaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HistorialSalarialController : ControllerBase
    {
        private readonly HistorialSalarialService _service;

        public HistorialSalarialController(HistorialSalarialService service)
        {
            _service = service;
        }

        //GET: api/historial
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var historialsalarial = await _service.GetAllAsync();
            return Ok(historialsalarial);
        }

        //POST: api/historial
        [HttpPost]
        public async Task<IActionResult> Create(HistorialSalarialInputDto dto)
        {
            await _service.CreateAsync(dto);
            return Ok(new { message = "Historial creado correctamente" });
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var eliminado = await _service.DeleteAsync(id);
            if (!eliminado) return NotFound(new { message = "Historial no encontrado" });
            return Ok(new { message = "Historial eliminado correctamente" });

        }
    }
}
