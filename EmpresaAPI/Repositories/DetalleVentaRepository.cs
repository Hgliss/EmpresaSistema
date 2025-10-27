using EmpresaAPI.Data;
using EmpresaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EmpresaAPI.Repositories
{
    public class DetalleVentaRepository
    {
        private readonly EmpresaContext _context;

        public DetalleVentaRepository(EmpresaContext context)
        {
            _context = context;
        }

        public async Task<List<DetalleVenta>> GetByVentaIdAsync(int ventaId)
        {
            return await _context.DetalleVentas
                                 .Where(d => d.Venta_Id == ventaId)
                                 .ToListAsync();
        }

        public async Task<IEnumerable<DetalleVenta>> GetAllAsync()
        {
            return await _context.DetalleVentas.ToListAsync();
        }

        public async Task AddAsync(DetalleVenta detalleventa)
        {
            await _context.DetalleVentas.AddAsync(detalleventa);
            await _context.SaveChangesAsync();
        }

        public async Task<DetalleVenta?> GetByIdAsync(int id)
        {
            return await _context.DetalleVentas.FindAsync(id);
        }

        public async Task UpdateAsync(DetalleVenta detalleventa)
        {
            _context.DetalleVentas.Update(detalleventa);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var detalleventa = await _context.DetalleVentas.FindAsync(id);
            if (detalleventa != null)
            {
                _context.DetalleVentas.Remove(detalleventa);
                await _context.SaveChangesAsync();
            }

        }
    }
}
