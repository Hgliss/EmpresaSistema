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
        //Get All
        public async Task<IEnumerable<ClienteDto>> GetAllAsync()
        {
            var clientes = await _repo.GetAllAsync();
            return clientes.Select(c => new ClienteDto
            {
                Id = c.Id,
                Nit = c.Nit,
                Nombre = c.Nombre,
                Estado = c.Estado,
                Fecha_Creacion = c.Fecha_Creacion,
                Fecha_Modificacion = c.Fecha_Modificacion,
                Usuario_Creacion_Id = c.Usuario_Creacion_Id,
                Usuario_Modificacion_Id = c.Usuario_Modificacion_Id
            });
        }

        //Get by Id
        public async Task<ClienteDto?> GetByIdAsync(int id)
        {
            var cliente = await _repo.GetByIdAsync(id);
            if (cliente == null) return null;

            return new ClienteDto
            {
                Id = cliente.Id,
                Nit = cliente.Nit,
                Nombre = cliente.Nombre,
                Estado = cliente.Estado
            };
        }

        //Create
        public async Task CreateAsync(ClienteInputDto dto)
        {
            var cliente = new Cliente
            {
                Nit = dto.Nit,
                Nombre = dto.Nombre,
                Estado = dto.Estado,
                Fecha_Creacion = DateTime.UtcNow,
                Fecha_Modificacion = DateTime.UtcNow,
                Usuario_Creacion_Id = null,
                Usuario_Modificacion_Id = null,
            };
            await _repo.AddAsync(cliente);
        }

        //Update
        public async Task<bool> UpdateAsync(int id, ClienteInputDto dto)
        {
            var cliente = await _repo.GetByIdAsync(id);
            if (cliente == null)
                return false;

            cliente.Nit = dto.Nit;
            cliente.Nombre = dto.Nombre;
            cliente.Estado = dto.Estado;
            cliente.Fecha_Modificacion = DateTime.UtcNow;
            cliente.Usuario_Modificacion = null;

            await _repo.UpdateAsync(cliente);
            return true;
        }

        //Delete
        public async Task<bool> DeleteAsync(int id)
        {
            var cliente = await _repo.GetByIdAsync(id);
            if (cliente == null) return false;

            await _repo.DeleteAsync(id);
            return true;
        }

    }
}
