using EmpresaAPI.DTOs;
using EmpresaAPI.Models;
using EmpresaAPI.Repositories;

namespace EmpresaAPI.Services
{
    public class EmpleadoService
    {
        private readonly EmpleadoRepository _repo;

        public EmpleadoService(EmpleadoRepository repo)
        {
            _repo = repo;
        }

        public async Task<IEnumerable<EmpleadoDto>> GetAllAsync()
        {
            var empleado = await _repo.GetAllAsync();
            return empleado.Select(em => new EmpleadoDto
            {
                Id = em.Id,
                Nombres = em.Nombres,
                Apellidos = em.Apellidos,
                CUI = em.CUI,
                Fecha_Ingreso = em.Fecha_Ingreso,
                Salario_Actual = em.Salario_Actual,
                Fecha_Ultimo_Aumento = em.Fecha_Ultimo_Aumento,
                Fecha_baja = em.Fecha_baja,
                Puesto = em.Puesto,
                Estado = em.Estado,
                Departamento_Id = em.Departamento_Id,
                Fecha_Creacion = em.Fecha_Creacion,
                Fecha_Modificacion = em.Fecha_Modificacion,
                Usuario_Creacion_Id = em.Usuario_Creacion_Id,
                Usuario_Modificacion_Id = em.Usuario_Modificacion_Id,
            });
        }

        public async Task CreateAsync(EmpleadoInputDto dto)
        {
            var empleado = new Empleado
            {
                Nombres = dto.Nombres,
                Apellidos = dto.Apellidos,
                CUI = dto.CUI,
                Fecha_Ingreso = dto.Fecha_Ingreso,
                Salario_Actual = dto.Salario_Actual,
                Fecha_Ultimo_Aumento = dto.Fecha_Ultimo_Aumento,
                Fecha_baja = dto.Fecha_baja,
                Puesto = dto.Puesto,
                Estado = dto.Estado,
                Departamento_Id = dto.Departamento_Id,
                Fecha_Creacion = DateTime.UtcNow,
                Fecha_Modificacion = DateTime.UtcNow,
                Usuario_Creacion_Id = null,
                Usuario_Modificacion_Id = null,
            };
            await _repo.AddAsync(empleado);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var empleado = await _repo.GetByIdAsync(id);
            if (empleado == null) return false;

            await _repo.DeleteAsync(id);
            return true;
        }
    }
}
