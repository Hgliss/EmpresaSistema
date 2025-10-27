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
        //Get All
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

        //Get by Id
        public async Task<RolDto?> GetByIdAsync(int id)
        {
            var rol = await _repo.GetByIdAsync(id);
            if (rol == null) return null;

            return new RolDto
            {
                Id = rol.Id,
                Nombre_Rol = rol.Nombre_Rol,
                Estado = rol.Estado,
                Fecha_Creacion = rol.Fecha_Creacion,
                Fecha_Modificacion = rol.Fecha_Modificacion,
                Usuario_Creacion_Id = rol.Usuario_Creacion_Id,
                Usuario_Modificacion_Id = rol.Usuario_Modificacion_Id
            };
        }

        //Create
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

        //Update
        public async Task<bool> UpdateAsync(int id, RolInputDto dto)
        {
            var rol = await _repo.GetByIdAsync(id);
            if (rol == null)
                return false;

            rol.Nombre_Rol = dto.Nombre_Rol;
            rol.Estado = dto.Estado;
            rol.Fecha_Modificacion = DateTime.UtcNow;
            rol.Usuario_Modificacion = null;

            await _repo.UpdateAsync(rol);
            return true;
        }

        //Delete
        public async Task<bool> DeleteAsync(int id)
        {
            var rol = await _repo.GetByIdAsync(id);
            if (rol == null) return false;

            await _repo.DeleteAsync(id);
            return true;
        }
    }
}
