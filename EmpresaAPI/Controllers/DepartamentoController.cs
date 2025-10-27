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

        //GET: api/departamento
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var departamentos = await _service.GetAllAsync();
            return Ok(departamentos);
        }

        //GET: api/departamento/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var departamento = await _service.GetByIdAsync(id);
            if (departamento == null)
                return NotFound(new { message = "Departamento no encontrado" });

            return Ok(departamento);
        }

        //POST: api/departamentos
        [HttpPost]
        public async Task<IActionResult> Create(DepartamentoInputDto dto)
        {
            await _service.CreacteAsync(dto);
            return Ok(new { message = "Departamento creado correctamente" });
        }

        //Put: api/departamento/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] DepartamentoInputDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var actualizado = await _service.UpdateAsync(id, dto);
            if (!actualizado)
                return NotFound(new { message = "Departamento no encontrado" });

            return Ok(new { message = "Departamento actualizado correctamente" });
        }

        //Delete: api/departamento/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var eliminado = await _service.DeleteAsync(id);
            if (!eliminado) return NotFound(new { message = "Departamento no encontrado" });
            return Ok(new { message = "Departamento eliminado correctamente" });

        }


    }
}
