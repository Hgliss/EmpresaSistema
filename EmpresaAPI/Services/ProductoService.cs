using EmpresaAPI.DTOs;
using EmpresaAPI.Models;
using EmpresaAPI.Repositories;

namespace EmpresaAPI.Services
{
    public class ProductoService
    {
        private readonly ProductoRepository _repo;

        public ProductoService(ProductoRepository repo)
        {
            _repo = repo;
        }

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

        public async Task<bool> DeleteAsync(int id)
        {
            var producto = await _repo.GetByIdAsync(id);
            if (producto == null) return false;

            await _repo.DeleteAsync(id);
            return true;
        }
    }
}
