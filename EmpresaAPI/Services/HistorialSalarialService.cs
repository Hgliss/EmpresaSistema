using EmpresaAPI.DTOs;
using EmpresaAPI.Models;
using EmpresaAPI.Repositories;

namespace EmpresaAPI.Services
{
    public class HistorialSalarialService
    {
        private readonly HistorialSalarialRepository _repo;

        public HistorialSalarialService(HistorialSalarialRepository repo)
        {
            _repo = repo;
        }

        public async Task<IEnumerable<HistorialSalarialDto>> GetAllAsync()
        {
            var historialsalarial = await _repo.GetAllAsync();
            return historialsalarial.Select(hs => new HistorialSalarialDto
            {
                Id = hs.Id,
                Empleado_Id = hs.Empleado_Id,
                Salario_Anterior = hs.Salario_Anterior,
                Salario_nuevo = hs.Salario_nuevo,
                Fecha_Cambio = hs.Fecha_Cambio,
                Motivo = hs.Motivo,                
                Fecha_Creacion = hs.Fecha_Creacion,
                Fecha_Modificacion = hs.Fecha_Modificacion,
                Usuario_Creacion_Id = hs.Usuario_Creacion_Id,
                Usuario_Modificacion_Id = hs.Usuario_Modificacion_Id,
            });
        }

        public async Task CreateAsync(HistorialSalarialInputDto dto)
        {
            var historialsalarial = new HistorialSalarial
            {
                Empleado_Id = dto.Empleado_Id,
                Salario_Anterior = dto.Salario_Anterior,
                Salario_nuevo = dto.Salario_nuevo,
                Fecha_Cambio = dto.Fecha_Cambio,
                Motivo = dto.Motivo,
                Fecha_Creacion = DateTime.UtcNow,
                Fecha_Modificacion = DateTime.UtcNow,
                Usuario_Creacion_Id = null,
                Usuario_Modificacion_Id = null,
            };
            await _repo.AddAsync(historialsalarial);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var historialsalarial = await _repo.GetByIdAsync(id);
            if (historialsalarial == null) return false;

            await _repo.DeleteAsync(id);
            return true;
        }
    }
}
