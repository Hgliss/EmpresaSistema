using EmpresaAPI.DTOs;
using EmpresaAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace EmpresaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly UsuarioService _service;

        public UsuarioController(UsuarioService service)
        {
            _service = service;
        }

        //GET: api/usuarios
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var usuario = await _service.GetAllAsync();
            return Ok(usuario);
        }

        //POST: api/usuarios
        [HttpPost]
        public async Task<IActionResult> Create(UsuarioInputDto dto)
        {
            await _service.CreateAsync(dto);
            return Ok(new { message = "Usuario creado correctamente" });
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var eliminado = await _service.DeleteAsync(id);
            if (!eliminado) return NotFound(new { message = "Usuario no encontrado" });
            return Ok(new { message = "Usuario eliminado correctamente" });

        }



    }
}
