using EmpresaAPI.DTOs;
using EmpresaAPI.Models;
using EmpresaAPI.Repositories;
using Microsoft.Extensions.Hosting;

namespace EmpresaAPI.Services
{
    public class ProductoService
    {
        private readonly ProductoRepository _repo;

        public ProductoService(ProductoRepository repo)
        {
            _repo = repo;
        }

        //Get All
        public async Task<IEnumerable<ProductoDto>> GetAllAsync()
        {
            var producto = await _repo.GetAllAsync();
            return producto.Select(p => new ProductoDto
            {
                Id = p.Id,
                Descripcion = p.Descripcion,
                Existencia = p.Existencia,
                Precio = p.Precio,
                Costo = p.Costo,         
                Estado = p.Estado,
                Fecha_Creacion = p.Fecha_Creacion,
                Fecha_Modificacion = p.Fecha_Modificacion,
                Usuario_Creacion_Id = p.Usuario_Creacion_Id,
                Usuario_Modificacion_Id = p.Usuario_Modificacion_Id
            });
        }

        //Get by Id
        public async Task<ProductoDto?> GetByIdAsync(int id)
        {
            var producto = await _repo.GetByIdAsync(id);
            if (producto == null) return null;

            return new ProductoDto
            {
                Id = producto.Id,
                Descripcion = producto.Descripcion,
                Existencia = producto.Existencia,
                Precio = producto.Precio,
                Costo = producto.Costo,
                Estado = producto.Estado,
                Fecha_Creacion = producto.Fecha_Creacion,
                Fecha_Modificacion = producto.Fecha_Modificacion,
                Usuario_Creacion_Id = producto.Usuario_Creacion_Id,
                Usuario_Modificacion_Id = producto.Usuario_Modificacion_Id
            };
        }

        //Create
        public async Task CreateAsync(ProductoInputDto dto)
        {
            var producto = new Producto
            {
                Descripcion = dto.Descripcion,
                Existencia = dto.Existencia,
                Precio = dto.Precio,
                Costo = dto.Costo,
                Estado = dto.Estado,
                Fecha_Creacion = DateTime.UtcNow,
                Fecha_Modificacion = DateTime.UtcNow,
                Usuario_Creacion_Id = null,
                Usuario_Modificacion_Id = null,
            };
            await _repo.AddAsync(producto);
        }

        //Update
        public async Task<bool> UpdateAsync(int id, ProductoInputDto dto)
        {
            var producto = await _repo.GetByIdAsync(id);
            if (producto == null)
                return false;

            producto.Descripcion = dto.Descripcion;
            producto.Existencia = dto.Existencia;
            producto.Precio = dto.Precio;
            producto.Costo = dto.Costo;
            producto.Estado = dto.Estado;
            producto.Fecha_Modificacion = DateTime.UtcNow;
            producto.Usuario_Modificacion = null;

            await _repo.UpdateAsync(producto);
            return true;
        }

        //Delete
        public async Task<bool> DeleteAsync(int id)
        {
            var producto = await _repo.GetByIdAsync(id);
            if (producto == null) return false;

            await _repo.DeleteAsync(id);
            return true;
        }
    }
}
