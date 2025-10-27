using EmpresaAPI.DTOs;
using EmpresaAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace EmpresaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DepartamentoController : ControllerBase
    {

        private readonly DepartamentoService _service;

        public DepartamentoController(DepartamentoService service)
        {
            _service = service;
        }

        //GET: api/departamentos
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var departamentos = await _service.GetAllAsync();
            return Ok(departamentos);
        }

        //POST: api/departamentos
        [HttpPost]
        public async Task<IActionResult> Create(DepartamentoInputDto dto)
        {
            await _service.CreacteAsync(dto);
            return Ok(new { message = "Departamento creado correctamente" });
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var eliminado = await _service.DeleteAsync(id);
            if (!eliminado) return NotFound(new { mesagge = "Departamento no encontrado" });
            return Ok(new { message = "Departamento eliminado correctamente" });

        }


    }
}
