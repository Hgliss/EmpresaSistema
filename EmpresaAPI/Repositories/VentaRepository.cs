using EmpresaAPI.Data;
using EmpresaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EmpresaAPI.Repositories
{
    public class VentaRepository
    {
        private readonly EmpresaContext _context;

        public VentaRepository(EmpresaContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Venta>> GetAllAsync()
        {
            return await _context.Ventas.ToListAsync();
        }

        public async Task AddAsync(Venta venta)
        {
            await _context.Ventas.AddAsync(venta);
            await _context.SaveChangesAsync();
        }

        public async Task<Venta?> GetByIdAsync(int id)
        {
            return await _context.Ventas.FindAsync(id);
        }

        public async Task UpdateAsync(Venta venta)
        {
            _context.Ventas.Update(venta);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var venta = await _context.Ventas.FindAsync(id);
            if (venta != null)
            {
                _context.Ventas.Remove(venta);
                await _context.SaveChangesAsync();
            }

        }
    }
}
