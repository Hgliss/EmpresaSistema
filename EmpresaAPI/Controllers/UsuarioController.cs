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

        //GET: api/usuario
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var usuario = await _service.GetAllAsync();
            return Ok(usuario);
        }

        //GET: api/usuario/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var usuario = await _service.GetByIdAsync(id);
            if (usuario == null)
                return NotFound(new { message = "Usuario no encontrado" });

            return Ok(usuario);
        }

        //POST: api/usuarios
        [HttpPost]
        public async Task<IActionResult> Create(UsuarioInputDto dto)
        {
            await _service.CreateAsync(dto);
            return Ok(new { message = "Usuario creado correctamente" });
        }

        //Put: api/usuario/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] UsuarioInputDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var actualizado = await _service.UpdateAsync(id, dto);
            if (!actualizado)
                return NotFound(new { message = "Usuario no encontrado" });

            return Ok(new { message = "Usuario actualizado correctamente" });
        }

        //DELETE: api/usuario/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var eliminado = await _service.DeleteAsync(id);
            if (!eliminado) return NotFound(new { message = "Usuario no encontrado" });
            return Ok(new { message = "Usuario eliminado correctamente" });

        }



    }
}
