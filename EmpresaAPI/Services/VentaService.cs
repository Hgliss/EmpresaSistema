using EmpresaAPI.DTOs;
using EmpresaAPI.Models;
using EmpresaAPI.Repositories;

namespace EmpresaAPI.Services
{
    public class VentaService
    {
        private readonly VentaRepository _repo;
        private readonly DetalleVentaRepository _detalleRepo;

        public VentaService(VentaRepository repo, DetalleVentaRepository detalleRepo)
        {
            _repo = repo;
            _detalleRepo = detalleRepo;
        }

        public async Task<IEnumerable<VentaDto>> GetAllAsync()
        {
            var ventas = await _repo.GetAllAsync();
            return ventas.Select(v => new VentaDto
            {
                Id = v.Id,
                Cliente_Id = v.Cliente_Id,
                Fecha_Venta = v.Fecha_Venta,
                Total = v.Total,
                Fecha_Creacion = v.Fecha_Creacion,
                Fecha_Modificacion = v.Fecha_Modificacion,
                Usuario_Creacion_Id = v.Usuario_Creacion_Id,
                Usuario_Modificacion_Id = v.Usuario_Modificacion_Id
            });
        }

        public async Task CreateAsync(VentaInputDto dto)
        {
            var venta = new Venta
            {
                Cliente_Id = dto.Cliente_Id,
                Fecha_Venta = dto.Fecha_Venta,
                Fecha_Creacion = DateTime.UtcNow,
                Fecha_Modificacion = DateTime.UtcNow,
                Usuario_Creacion_Id = null,
                Usuario_Modificacion_Id = null,
            };
            await _repo.AddAsync(venta);

            //total
            var detalles = await _detalleRepo.GetByVentaIdAsync(dto.Cliente_Id);
            decimal total = detalles.Sum(d => d.Subtotal);
            venta.Total = total;
            await _repo.UpdateAsync(venta);
        }

        public async Task UpdateTotalAsync(int venta_id)
        {
            var detalles = await _detalleRepo.GetByVentaIdAsync(venta_id);
            var total = detalles.Sum(d => d.Subtotal);

            var venta = await _repo.GetByIdAsync(venta_id);
            if (venta != null)
            {
                venta.Total = total;
                venta.Fecha_Modificacion = DateTime.UtcNow;
                await _repo.UpdateAsync(venta);
            }
        }


        public async Task<bool> DeleteAsync(int id)
        {
            var venta = await _repo.GetByIdAsync(id);
            if (venta == null) return false;

            await _repo.DeleteAsync(id);
            return true;
        }
    }
}
