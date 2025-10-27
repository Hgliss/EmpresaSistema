using EmpresaAPI.DTOs;
using EmpresaAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace EmpresaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DetalleVentaController : ControllerBase
    {
        private readonly DetalleVentaService _service;

        public DetalleVentaController(DetalleVentaService service)
        {
            _service = service;
        }

        //GET: api/detalleventa
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var detalleventas = await _service.GetAllAsync();
            return Ok(detalleventas);
        }

        //POST: api/detalleventa
        [HttpPost]
        public async Task<IActionResult> Create(DetalleVentaInputDto dto)
        {
            await _service.CreacteAsync(dto);
            return Ok(new { message = "Detalle Venta creado correctamente" });
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var eliminado = await _service.DeleteAsync(id);
            if (!eliminado) return NotFound(new { mesagge = "Detalle Venta no encontrado" });
            return Ok(new { message = "Detalle Venta eliminado correctamente" });

        }


    }
}
