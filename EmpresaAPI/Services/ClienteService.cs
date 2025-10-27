using EmpresaAPI.DTOs;
using EmpresaAPI.Models;
using EmpresaAPI.Repositories;

namespace EmpresaAPI.Services
{
    public class ClienteService
    {
        private readonly ClienteRepository _repo;

        public ClienteService(ClienteRepository repo)
        {
            _repo = repo;
        }

        public async Task<IEnumerable<ClienteDto>> GetAllAsync()
        {
            var clientes = await _repo.GetAllAsync();
            return clientes.Select(c => new ClienteDto
            {
                Id = c.Id,
                Nit = c.Nit,
                Nombre = c.Nombre,
                Fecha_Creacion = c.Fecha_Creacion,
                Fecha_Modificacion = c.Fecha_Modificacion,
                Usuario_Creacion_Id = c.Usuario_Creacion_Id,
                Usuario_Modificacion_Id = c.Usuario_Modificacion_Id
            });
        }

        public async Task CreateAsync(ClienteInputDto dto)
        {
            var cliente = new Cliente
            {
                Nit = dto.Nit,
                Nombre = dto.Nombre,
                Fecha_Creacion = DateTime.UtcNow,
                Fecha_Modificacion = DateTime.UtcNow,
                Usuario_Creacion_Id = null,
                Usuario_Modificacion_Id = null,
            };
            await _repo.AddAsync(cliente);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var cliente = await _repo.GetByIdAsync(id);
            if (cliente == null) return false;

            await _repo.DeleteAsync(id);
            return true;
        }

    }
}
