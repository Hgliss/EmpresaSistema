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

        //GET: api/detalleventa/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var detalleventa = await _service.GetByIdAsync(id);
            if (detalleventa == null)
                return NotFound(new { message = "Detalle no encontrado" });

            return Ok(detalleventa);
        }

        //POST: api/detalleventa
        [HttpPost]
        public async Task<IActionResult> Create(DetalleVentaInputDto dto)
        {
            await _service.CreacteAsync(dto);
            return Ok(new { message = "Detalle Venta creado correctamente" });
        }

        //Put: api/cliente/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] DetalleVentaInputDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var actualizado = await _service.UpdateAsync(id, dto);
            if (!actualizado)
                return NotFound(new { message = "Detalle no encontrado" });

            return Ok(new { message = "Detalle actualizado correctamente" });
        }


        //DELETE: api/cliente/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var eliminado = await _service.DeleteAsync(id);
            if (!eliminado) return NotFound(new { message = "Detalle Venta no encontrado" });
            return Ok(new { message = "Detalle Venta eliminado correctamente" });

        }


    }
}
