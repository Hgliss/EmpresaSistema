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

        //Get All
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

        //Get by Id
        public async Task<HistorialSalarialDto?> GetByIdAsync(int id)
        {
            var historialsalarial = await _repo.GetByIdAsync(id);
            if (historialsalarial == null) return null;

            return new HistorialSalarialDto
            {
                Id = historialsalarial.Id,
                Empleado_Id = historialsalarial.Empleado_Id,
                Salario_Anterior = historialsalarial.Salario_Anterior,
                Salario_nuevo = historialsalarial.Salario_nuevo,
                Fecha_Cambio = historialsalarial.Fecha_Cambio,
                Motivo = historialsalarial.Motivo,
                Fecha_Creacion = historialsalarial.Fecha_Creacion,
                Fecha_Modificacion = historialsalarial.Fecha_Modificacion,
                Usuario_Creacion_Id = historialsalarial.Usuario_Creacion_Id,
                Usuario_Modificacion_Id = historialsalarial.Usuario_Modificacion_Id,
            };
        }

        //Create
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

        //Update
        public async Task<bool> UpdateAsync(int id, HistorialSalarialInputDto dto)
        {
            var historialsalarial = await _repo.GetByIdAsync(id);
            if (historialsalarial == null)
                return false;

            historialsalarial.Empleado_Id = dto.Empleado_Id;
            historialsalarial.Salario_Anterior = dto.Salario_Anterior;
            historialsalarial.Salario_nuevo = dto.Salario_nuevo;
            historialsalarial.Fecha_Cambio = dto.Fecha_Cambio;
            historialsalarial.Motivo = dto.Motivo;
            historialsalarial.Fecha_Modificacion = DateTime.UtcNow;
            historialsalarial.Usuario_Modificacion = null;

            await _repo.UpdateAsync(historialsalarial);
            return true;
        }

        //Delete
        public async Task<bool> DeleteAsync(int id)
        {
            var historialsalarial = await _repo.GetByIdAsync(id);
            if (historialsalarial == null) return false;

            await _repo.DeleteAsync(id);
            return true;
        }
    }
}
