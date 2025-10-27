using EmpresaAPI.DTOs;
using EmpresaAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace EmpresaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductoController : ControllerBase
    {
        private readonly ProductoService _service;

        public ProductoController(ProductoService service)
        {
            _service = service;
        }

        //GET: api/productos
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var producto = await _service.GetAllAsync();
            return Ok(producto);
        }

        //POST: api/productos
        [HttpPost]
        public async Task<IActionResult> Create(ProductoInputDto dto)
        {
            await _service.CreateAsync(dto);
            return Ok(new { message = "Producto creado correctamente" });
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var eliminado = await _service.DeleteAsync(id);
            if (!eliminado) return NotFound(new { message = "Producto no encontrado" });
            return Ok(new { message = "Producto eliminado correctamente" });

        }



    }
}
