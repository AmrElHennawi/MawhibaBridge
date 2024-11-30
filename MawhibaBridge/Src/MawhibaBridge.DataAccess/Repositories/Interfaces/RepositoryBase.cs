
using System.Linq.Expressions;
using MawhibaBridge.DataAccess.Repositories.Implementations;
using MawhibaBridge.DataContext.Context;
using Microsoft.EntityFrameworkCore;

namespace MawhibaBridge.DataAccess.Repositories.Interfaces
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected readonly DBContext _context;

        public RepositoryBase(DBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate)
        {
            return await _context.Set<T>().Where(predicate).ToListAsync();
        }

        public async Task AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }
    }
}
