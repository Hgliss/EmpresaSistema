using EmpresaAPI.DTOs;
using EmpresaAPI.Models;
using EmpresaAPI.Repositories;

namespace EmpresaAPI.Services
{
    public class RolService
    {
        private readonly RolRepository _repo;

        public RolService(RolRepository repo)
        {
            _repo = repo;
        }

        public async Task<IEnumerable<RolDto>> GetAllAsync()
        {
            var roles = await _repo.GetAllAsync();
            return roles.Select(r => new RolDto
            {
                Id = r.Id,
                Nombre_Rol = r.Nombre_Rol,
                Estado = r.Estado,
                Fecha_Creacion = r.Fecha_Creacion,
                Fecha_Modificacion = r.Fecha_Modificacion,
                Usuario_Creacion_Id = r.Usuario_Creacion_Id,
                Usuario_Modificacion_Id = r.Usuario_Modificacion_Id
            });
        }

        public async Task CreateAsync(RolInputDto dto)
        {
            var rol = new Rol
            {
                Nombre_Rol = dto.Nombre_Rol,
                Estado = dto.Estado,
                Fecha_Creacion = DateTime.UtcNow,
                Fecha_Modificacion = DateTime.UtcNow,
                Usuario_Creacion_Id = null,
                Usuario_Modificacion_Id = null,
            };
            await _repo.AddAsync(rol);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var rol = await _repo.GetByIdAsync(id);
            if (rol == null) return false;

            await _repo.DeleteAsync(id);
            return true;
        }
    }
}
