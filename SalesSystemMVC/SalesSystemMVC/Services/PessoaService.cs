using Microsoft.EntityFrameworkCore;
using SalesSystemMVC.Data;
using SalesSystemMVC.Models;
using SalesSystemMVC.Services.Exceptions;
using SalesWebMvc.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SalesSystemMVC.Services
{
    public class PessoaService
    {
        private readonly UsuarioDbContext _context;

        public PessoaService(UsuarioDbContext context)
        {
            _context = context;
        }

        public async Task<List<Pessoa>> FindAllAsync()
        {
            return await _context.Pessoa.ToListAsync();
        }

        public async Task InsertAsync(Pessoa obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task<Pessoa> FindByIdAsync(int id)
        {
            return await _context.Pessoa.Include(obj => obj.Endereco).Include(obj => obj.PessoaTelefone).FirstOrDefaultAsync(obj => obj.Id == id);
        }

        public async Task RemoveAsync(int id)
        {
            try
            {
                var obj = await _context.Pessoa.FindAsync(id);
                _context.Pessoa.Remove(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException e)
            {
                throw new IntegrityException("Can't delete Pessoa because he/she has sales");
            }
        }

        public async Task UpdateAsync(Pessoa obj)
        {
            bool hasAny = await _context.Pessoa.AnyAsync(x => x.Id == obj.Id);
            if (!hasAny)
            {
                throw new NotFoundException("Id not found");
            }
            try
            {
                _context.Update(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }
    }
}
