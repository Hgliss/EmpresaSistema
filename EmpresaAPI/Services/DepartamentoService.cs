using EmpresaAPI.DTOs;
using EmpresaAPI.Models;
using EmpresaAPI.Repositories;


namespace EmpresaAPI.Services
{
    public class DepartamentoService
    {
        private readonly DepartamentoRepository _repo;

        public DepartamentoService(DepartamentoRepository repo)
        {
            _repo = repo;
        }

        public async Task<IEnumerable<DepartamentoDto>> GetAllAsync()
        {
            var departamento = await _repo.GetAllAsync();
            return departamento.Select(d => new DepartamentoDto
            {
                Id = d.Id,
                Nombre = d.Nombre,
                Presupuesto = d.Presupuesto,
                Estado = d.Estado,
                Fecha_Creacion = d.Fecha_Creacion,
                Fecha_Modificacion = d.Fecha_Modificacion,
                Usuario_Creacion_Id = d.Usuario_Creacion_Id,
                Usuario_Modificacion_Id = d.Usuario_Modificacion_Id
            });
        }

        public async Task CreacteAsync(DepartamentoInputDto dto)
        {
            var departamento = new Departamento
            {
                Nombre = dto.Nombre,
                Presupuesto = dto.Presupuesto,
                Estado = dto.Estado,
                Fecha_Creacion = DateTime.UtcNow,
                Fecha_Modificacion = DateTime.UtcNow,
                Usuario_Creacion_Id = null,
                Usuario_Modificacion_Id = null,
            };
            await _repo.AddAsync(departamento);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var departamento = await _repo.GetByIdAsync(id);
            if (departamento == null) return false;

            await _repo.DeleteAsync(id);
            return true;
        }
    }
}
