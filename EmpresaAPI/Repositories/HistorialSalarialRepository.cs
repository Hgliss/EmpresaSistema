using EmpresaAPI.Data;
using EmpresaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EmpresaAPI.Repositories
{
    public class HistorialSalarialRepository
    {
        private readonly EmpresaContext _context;

        public HistorialSalarialRepository(EmpresaContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<HistorialSalarial>> GetAllAsync()
        {
            return await _context.HistorialSalarials.ToListAsync();
        }

        public async Task AddAsync(HistorialSalarial historialsalarial)
        {
            await _context.HistorialSalarials.AddAsync(historialsalarial);
            await _context.SaveChangesAsync();
        }

        public async Task<HistorialSalarial?> GetByIdAsync(int id)
        {
            return await _context.HistorialSalarials.FindAsync(id);
        }

        public async Task UpdateAsync(HistorialSalarial historialsalarial)
        {
            _context.HistorialSalarials.Update(historialsalarial);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var historialsalarial = await _context.HistorialSalarials.FindAsync(id);
            if (historialsalarial != null)
            {
                _context.HistorialSalarials.Remove(historialsalarial);
                await _context.SaveChangesAsync();
            }

        }

    }
}
