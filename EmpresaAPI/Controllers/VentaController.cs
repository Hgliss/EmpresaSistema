using EmpresaAPI.DTOs;
using EmpresaAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace EmpresaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VentaController : ControllerBase
    {
        private readonly VentaService _service;

        public VentaController(VentaService service)
        {
            _service = service;
        }

        //GET: api/venta
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var venta = await _service.GetAllAsync();
            return Ok(venta);
        }

        //POST: api/venta
        [HttpPost]
        public async Task<IActionResult> Create(VentaInputDto dto)
        {
            await _service.CreateAsync(dto);
            return Ok(new { message = "Venta creada correctamente" });
        }

        //DELETE: api/venta/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var eliminado = await _service.DeleteAsync(id);
            if (!eliminado) return NotFound(new { message = "Venta no encontrada" });
            return Ok(new { message = "Venta eliminada correctamente" });

        }

        [HttpPut("{ventaId}/actualizar-total")]
        public async Task<IActionResult> ActualizarTotal(int ventaId)
        {
            await _service.UpdateTotalAsync(ventaId);
            return Ok(new { mensaje = "Total actualizado correctamente" });
        }


    }
}
