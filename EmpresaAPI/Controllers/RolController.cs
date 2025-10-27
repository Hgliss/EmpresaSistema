using EmpresaAPI.DTOs;
using EmpresaAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace EmpresaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RolController : ControllerBase
    {
        private readonly RolService _service;

        public RolController(RolService service)
        {
            _service = service;
        }

        //GET: api/rol
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var rol = await _service.GetAllAsync();
            return Ok(rol);
        }


        //GET: api/rol/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var rol = await _service.GetByIdAsync(id);
            if (rol == null)
                return NotFound(new { message = "Rol no encontrado" });

            return Ok(rol);
        }

        //POST: api/roles
        [HttpPost]
        public async Task<IActionResult> Create(RolInputDto dto)
        {
            await _service.CreateAsync(dto);
            return Ok(new { message = "Rol creado correctamente" });
        }

        //Put: api/rol/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] RolInputDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var actualizado = await _service.UpdateAsync(id, dto);
            if (!actualizado)
                return NotFound(new { message = "Rol no encontrado" });

            return Ok(new { message = "Rol actualizado correctamente" });
        }

        //DELETE: api/cliente/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var eliminado = await _service.DeleteAsync(id);
            if (!eliminado) return NotFound(new { message = "Rol no encontrado" });
            return Ok(new { message = "Rol eliminado correctamente" });

        }



    }
}
