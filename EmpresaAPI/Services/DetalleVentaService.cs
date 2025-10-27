using EmpresaAPI.DTOs;
using EmpresaAPI.Models;
using EmpresaAPI.Repositories;

namespace EmpresaAPI.Services
{
    public class DetalleVentaService
    {
        private readonly DetalleVentaRepository _repo;

        public DetalleVentaService(DetalleVentaRepository repo)
        {
            _repo = repo;
        }

        public async Task<IEnumerable<DetalleVentaDto>> GetAllAsync()
        {
            var detalleventas = await _repo.GetAllAsync();
            return detalleventas.Select(dv => new DetalleVentaDto
            {
                Id = dv.Id,
                Venta_Id = dv.Venta_Id,
                Producto_Id = dv.Producto_Id,
                Cantidad = dv.Cantidad,
                Precio = dv.Precio,
                Costo = dv.Costo,
                Subtotal = dv.Subtotal,
                Fecha_Creacion = dv.Fecha_Creacion,
                Fecha_Modificacion = dv.Fecha_Modificacion,
                Usuario_Creacion_Id = dv.Usuario_Creacion_Id,
                Usuario_Modificacion_Id = dv.Usuario_Modificacion_Id
            });
        }

        public async Task CreacteAsync(DetalleVentaInputDto dto)
        {
            var detalleventa = new DetalleVenta
            {
                Venta_Id = dto.Venta_Id,
                Producto_Id = dto.Producto_Id,
                Cantidad = dto.Cantidad,
                Precio = dto.Precio,
                Costo = dto.Costo,
                Subtotal = dto.Cantidad * dto.Precio,
                Fecha_Creacion = DateTime.UtcNow,
                Fecha_Modificacion = DateTime.UtcNow,
                Usuario_Creacion_Id = null,
                Usuario_Modificacion_Id = null,
            };
            await _repo.AddAsync(detalleventa);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var detalleventa = await _repo.GetByIdAsync(id);
            if (detalleventa == null) return false;

            await _repo.DeleteAsync(id);
            return true;
        }
    }
}
