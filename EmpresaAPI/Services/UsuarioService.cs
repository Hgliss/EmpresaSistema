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

        public async Task<IEnumerable<UsuarioDto>> GetAllAsync()
        {
            var usuarios = await _repo.GetAllAsync();
            return usuarios.Select(u => new UsuarioDto
            {
                Id = u.Id,
                Empleado_Id = u.Empleado_Id,
                Nombre_Usuario = u.Nombre_Usuario,
                Contrasena = u.Contrasena,
                Rol_Id = u.Rol_Id,
                Estado = u.Estado,
                Fecha_Creacion = u.Fecha_Creacion,
                Fecha_Modificacion = u.Fecha_Modificacion,
                Usuario_Creacion_Id = u.Usuario_Creacion_Id,
                Usuario_Modificacion_Id = u.Usuario_Modificacion_Id
            });
        }

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

        public async Task<bool> DeleteAsync(int id)
        {
            var usuario = await _repo.GetByIdAsync(id);
            if (usuario == null) return false;

            await _repo.DeleteAsync(id);
            return true;
        }
    }
}
