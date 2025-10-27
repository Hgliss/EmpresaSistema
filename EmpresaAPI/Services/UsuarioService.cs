using EmpresaAPI.DTOs;
using EmpresaAPI.Models;
using EmpresaAPI.Repositories;

namespace EmpresaAPI.Services
{
    public class UsuarioService
    {
        private readonly UsuarioRepository _repo;

        public UsuarioService(UsuarioRepository repo)
        {
            _repo = repo;
        }
        //Get All
        public async Task<IEnumerable<UsuarioDto>> GetAllAsync()
        {
            var usuarios = await _repo.GetAllAsync();
            return usuarios.Select(u => new UsuarioDto
            {
                Id = u.Id,
                Empleado_Id = u.Empleado_Id,
                Nombre_Usuario = u.Nombre_Usuario,
                Rol_Id = u.Rol_Id,
                Estado = u.Estado,
                Fecha_Creacion = u.Fecha_Creacion,
                Fecha_Modificacion = u.Fecha_Modificacion,
                Usuario_Creacion_Id = u.Usuario_Creacion_Id,
                Usuario_Modificacion_Id = u.Usuario_Modificacion_Id
            });
        }

        //Get by Id
        public async Task<UsuarioDto?> GetByIdAsync(int id)
        {
            var usuario = await _repo.GetByIdAsync(id);
            if (usuario == null) return null;

            return new UsuarioDto
            {
                Empleado_Id = usuario.Empleado_Id,
                Nombre_Usuario = usuario.Nombre_Usuario,
                Rol_Id = usuario.Rol_Id,
                Estado = usuario.Estado,
                Fecha_Creacion = usuario.Fecha_Creacion,
                Fecha_Modificacion = usuario.Fecha_Modificacion,
                Usuario_Creacion_Id = usuario.Usuario_Creacion_Id,
                Usuario_Modificacion_Id = usuario.Usuario_Modificacion_Id
            };
        }

        //Create
        public async Task CreateAsync(UsuarioInputDto dto)
        {
            var usuario = new Usuario
            {
                Empleado_Id = dto.Empleado_Id,
                Nombre_Usuario = dto.Nombre_Usuario,
                Contrasena = dto.Contrasena,
                Rol_Id = dto.Rol_Id,
                Estado = dto.Estado,
                Fecha_Creacion = DateTime.UtcNow,
                Fecha_Modificacion = DateTime.UtcNow,
                Usuario_Creacion_Id = null,
                Usuario_Modificacion_Id = null,
            };
            await _repo.AddAsync(usuario);
        }

        //Update
        public async Task<bool> UpdateAsync(int id, UsuarioInputDto dto)
        {
            var usuario = await _repo.GetByIdAsync(id);
            if (usuario == null)
                return false;

            usuario.Empleado_Id = dto.Empleado_Id;
            usuario.Nombre_Usuario = dto.Nombre_Usuario;
            usuario.Contrasena = dto.Contrasena;
            usuario.Rol_Id = dto.Rol_Id;
            usuario.Estado = dto.Estado;
            usuario.Fecha_Modificacion = DateTime.UtcNow;
            usuario.Usuario_Modificacion = null;

            await _repo.UpdateAsync(usuario);
            return true;
        }

        //Delete
        public async Task<bool> DeleteAsync(int id)
        {
            var usuario = await _repo.GetByIdAsync(id);
            if (usuario == null) return false;

            await _repo.DeleteAsync(id);
            return true;
        }
    }
}
