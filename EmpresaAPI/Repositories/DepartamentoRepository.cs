using EmpresaAPI.Data;
using EmpresaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EmpresaAPI.Repositories
{
    public class DepartamentoRepository
    {
        private readonly EmpresaContext _context;

        public DepartamentoRepository(EmpresaContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Departamento>> GetAllAsync()
        {
            return await _context.Departamentos.ToListAsync();
        }

        public async Task AddAsync(Departamento departamento)
        {
            await _context.Departamentos.AddAsync(departamento);
            await _context.SaveChangesAsync();
        }

        public async Task<Departamento?> GetByIdAsync(int id)
        {
            return await _context.Departamentos.FindAsync(id);
        }

        public async Task UpdateAsync(Departamento departamento)
        {
            _context.Departamentos.Update(departamento);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var departamento = await _context.Departamentos.FindAsync(id);
            if (departamento != null)
            {
                _context.Departamentos.Remove(departamento);
                await _context.SaveChangesAsync();
            }

        }
    }
}
