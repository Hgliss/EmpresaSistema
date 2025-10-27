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

        //Get All
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

        //Get by Id
        public async Task<VentaDto?> GetByIdAsync(int id)
        {
            var venta = await _repo.GetByIdAsync(id);
            if (venta == null) return null;

            return new VentaDto
            {
                Id = venta.Id,
                Cliente_Id = venta.Cliente_Id,
                Fecha_Venta = venta.Fecha_Venta,
                Total = venta.Total,
                Fecha_Creacion = venta.Fecha_Creacion,
                Fecha_Modificacion = venta.Fecha_Modificacion,
                Usuario_Creacion_Id = venta.Usuario_Creacion_Id,
                Usuario_Modificacion_Id = venta.Usuario_Modificacion_Id
            };
        }

        //Create
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

        //Update
        public async Task<bool> UpdateAsync(int id, VentaInputDto dto)
        {
            var venta = await _repo.GetByIdAsync(id);
            if (venta == null)
                return false;

            venta.Cliente_Id = dto.Cliente_Id;
            venta.Fecha_Venta = dto.Fecha_Venta;
            venta.Fecha_Modificacion = DateTime.UtcNow;
            venta.Usuario_Modificacion = null;

            await _repo.UpdateAsync(venta);
            return true;
        }

        //Update Total
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


        //delete
        public async Task<bool> DeleteAsync(int id)
        {
            var venta = await _repo.GetByIdAsync(id);
            if (venta == null) return false;

            await _repo.DeleteAsync(id);
            return true;
        }
    }
}
