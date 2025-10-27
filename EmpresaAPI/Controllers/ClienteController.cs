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

        //GET: api/clientes
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var cliente = await _service.GetAllAsync();
            return Ok(cliente);
        }

        //POST: api/clientes
        [HttpPost]
        public async Task<IActionResult> Create(ClienteInputDto dto)
        {
            await _service.CreateAsync(dto);
            return Ok(new { message = "Cliente creado correctamente"});
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var eliminado = await _service.DeleteAsync(id);
            if (!eliminado) return NotFound(new { mesagge = "Cliente no encontrado" });
            return Ok(new {message = "Cliente eliminado correctamente"});

        }



    }
}
