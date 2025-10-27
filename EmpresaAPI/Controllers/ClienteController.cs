using EmpresaAPI.DTOs;
using EmpresaAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace EmpresaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly ClienteService _service;

        public ClienteController(ClienteService service) 
        { 
            _service = service;
        }

        //GET: api/cliente
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var cliente = await _service.GetAllAsync();
            return Ok(cliente);
        }

        //GET: api/cliente/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var cliente = await _service.GetByIdAsync(id);
            if (cliente == null)
                return NotFound(new { message = "Cliente no encontrado" });

            return Ok(cliente);
        }

        //POST: api/cliente
        [HttpPost]
        public async Task<IActionResult> Create(ClienteInputDto dto)
        {
            await _service.CreateAsync(dto);
            return Ok(new { message = "Cliente creado correctamente"});
        }

        //Put: api/cliente/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] ClienteInputDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var actualizado = await _service.UpdateAsync(id, dto);
            if (!actualizado)
                return NotFound(new { message = "Cliente no encontrado" });

            return Ok(new { message = "Cliente actualizado correctamente" });
        }

        //DELETE: api/cliente/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var eliminado = await _service.DeleteAsync(id);
            if (!eliminado) return NotFound(new { message = "Cliente no encontrado" });
            return Ok(new {message = "Cliente eliminado correctamente"});

        }



    }
}
