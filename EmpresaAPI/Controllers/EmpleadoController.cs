using EmpresaAPI.DTOs;
using EmpresaAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace EmpresaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmpleadoController : ControllerBase
    {
        private readonly EmpleadoService _service;

        public EmpleadoController(EmpleadoService service)
        {
            _service = service;
        }

        //GET: api/empleados
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var empleado = await _service.GetAllAsync();
            return Ok(empleado);
        }

        //POST: api/empleados
        [HttpPost]
        public async Task<IActionResult> Create(EmpleadoInputDto dto)
        {
            await _service.CreateAsync(dto);
            return Ok(new { message = "Empleado creado correctamente" });
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var eliminado = await _service.DeleteAsync(id);
            if (!eliminado) return NotFound(new { mesagge = "Empleado no encontrado" });
            return Ok(new { message = "Empleado eliminado correctamente" });

        }
    }
}
