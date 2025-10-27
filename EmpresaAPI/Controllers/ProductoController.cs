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

        //GET: api/producto
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var producto = await _service.GetAllAsync();
            return Ok(producto);
        }

        //GET: api/producto/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var producto = await _service.GetByIdAsync(id);
            if (producto == null)
                return NotFound(new { message = "Producto no encontrado" });

            return Ok(producto);
        }


        //POST: api/producto
        [HttpPost]
        public async Task<IActionResult> Create(ProductoInputDto dto)
        {
            await _service.CreateAsync(dto);
            return Ok(new { message = "Producto creado correctamente" });
        }

        //Put: api/producto/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] ProductoInputDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var actualizado = await _service.UpdateAsync(id, dto);
            if (!actualizado)
                return NotFound(new { message = "Producto no encontrado" });

            return Ok(new { message = "Producto actualizado correctamente" });
        }

        //DELETE: api/producto/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var eliminado = await _service.DeleteAsync(id);
            if (!eliminado) return NotFound(new { message = "Producto no encontrado" });
            return Ok(new { message = "Producto eliminado correctamente" });

        }



    }
}
