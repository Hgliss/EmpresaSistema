using EmpresaAPI.Data;
using EmpresaAPI.Models;
using Microsoft.EntityFrameworkCore;



namespace EmpresaAPI.Repositories
{
    public class ClienteRepository
    {
        private readonly EmpresaContext _context;

        public ClienteRepository(EmpresaContext context)
        {
            _context = context;
        }

        //Get All
        public async Task<IEnumerable<Cliente>> GetAllAsync()
        {
            return await _context.Clientes.ToListAsync();
        }

        //Add
        public async Task AddAsync(Cliente cliente) 
        {
            await _context.Clientes.AddAsync(cliente);
            await _context.SaveChangesAsync();
        }

        //Get by id
        public async Task<Cliente?> GetByIdAsync(int id)
        {
            return await _context.Clientes.FindAsync(id);
        }

        //Update
        public async Task   UpdateAsync(Cliente cliente)
        {
            _context.Clientes.Update(cliente); 
            await _context.SaveChangesAsync();
        }

        //Delete
        public async Task DeleteAsync(int id)
        {
            var cliente = await _context.Clientes.FindAsync(id);
            if (cliente != null)
            {
                _context.Clientes.Remove(cliente);
                await _context.SaveChangesAsync();
            }

        }
    }
}
