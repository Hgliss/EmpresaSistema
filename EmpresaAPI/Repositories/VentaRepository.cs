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

        //Get All
        public async Task<IEnumerable<Venta>> GetAllAsync()
        {
            return await _context.Ventas.ToListAsync();
        }

        //Add
        public async Task AddAsync(Venta venta)
        {
            await _context.Ventas.AddAsync(venta);
            await _context.SaveChangesAsync();
        }

        //Get by Id
        public async Task<Venta?> GetByIdAsync(int id)
        {
            return await _context.Ventas.FindAsync(id);
        }

        //Update
        public async Task UpdateAsync(Venta venta)
        {
            _context.Ventas.Update(venta);
            await _context.SaveChangesAsync();
        }

        //Delete
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
