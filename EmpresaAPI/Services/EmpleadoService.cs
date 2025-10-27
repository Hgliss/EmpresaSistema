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

        //Get All
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

        //Get by Id
        public async Task<EmpleadoDto?> GetByIdAsync(int id)
        {
            var empleado = await _repo.GetByIdAsync(id);
            if (empleado == null) return null;

            return new ClienteDto
            {
                Id = empleado.Id,
                Nombres = empleado.Nombres,
                Apellidos = empleado.Apellidos,
                CUI = empleado.CUI,
                Fecha_Ingreso = empleado.Fecha_Ingreso,
                Salario_Actual = empleado.Salario_Actual,
                Fecha_Ultimo_Aumento = empleado.Fecha_Ultimo_Aumento,
                Fecha_baja = empleado.Fecha_baja,
                Puesto = empleado.Puesto,
                Estado = empleado.Estado,
                Departamento_Id = empleado.Departamento_Id,
                Fecha_Creacion = empleado.Fecha_Creacion,
                Fecha_Modificacion = empleado.Fecha_Modificacion,
                Usuario_Creacion_Id = empleado.Usuario_Creacion_Id,
                Usuario_Modificacion_Id = empleado.Usuario_Modificacion_Id,
            };
        }

        //Create
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

        //Update
        public async Task<bool> UpdateAsync(int id, EmpleadoInputDto dto)
        {
            var empleado = await _repo.GetByIdAsync(id);
            if (empleado == null)
                return false;

            empleado.Nombres = dto.Nombres,
            empleado.Apellidos = dto.Apellidos,
            empleado.CUI = dto.CUI,
            empleado.Fecha_Ingreso = dto.Fecha_Ingreso,
            empleado.Salario_Actual = dto.Salario_Actual,
            empleado.Fecha_Ultimo_Aumento = dto.Fecha_Ultimo_Aumento,
            empleado.Fecha_baja = dto.Fecha_baja,
            empleado.Puesto = dto.Puesto,
            empleado.Estado = dto.Estado,
            empleado.Departamento_Id = dto.Departamento_Id,
            empleado.Fecha_Modificacion = DateTime.UtcNow;
            empleado.Usuario_Modificacion = null;

            await _repo.UpdateAsync(empleado);
            return true;
        }

        //Delete
        public async Task<bool> DeleteAsync(int id)
        {
            var empleado = await _repo.GetByIdAsync(id);
            if (empleado == null) return false;

            await _repo.DeleteAsync(id);
            return true;
        }
    }
}
