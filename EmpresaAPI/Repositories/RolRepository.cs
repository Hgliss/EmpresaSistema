using EmpresaAPI.Data;
using EmpresaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EmpresaAPI.Repositories
{
    public class RolRepository
    {
        private readonly EmpresaContext _context;

        public RolRepository(EmpresaContext context)
        {
            _context = context;
        }

        //Get All
        public async Task<IEnumerable<Rol>> GetAllAsync()
        {
            return await _context.Rols.ToListAsync();
        }

        //Add
        public async Task AddAsync(Rol rol)
        {
            await _context.Rols.AddAsync(rol);
            await _context.SaveChangesAsync();
        }

        //Get by Id
        public async Task<Rol?> GetByIdAsync(int id)
        {
            return await _context.Rols.FindAsync(id);
        }

        //Update
        public async Task UpdateAsync(Rol rol)
        {
            _context.Rols.Update(rol);
            await _context.SaveChangesAsync();
        }

        //Delete
        public async Task DeleteAsync(int id)
        {
            var rol = await _context.Rols.FindAsync(id);
            if (rol != null)
            {
                _context.Rols.Remove(rol);
                await _context.SaveChangesAsync();
            }

        }
    }
}
