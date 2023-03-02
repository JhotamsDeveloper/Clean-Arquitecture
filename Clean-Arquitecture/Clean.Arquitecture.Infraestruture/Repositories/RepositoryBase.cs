using Clean.Arquitectucture.Aplication.Contracts;
using Clean.Arquitecture.Domain.Common;
using Clean.Arquitecture.Infraestruture.Persistence;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Clean.Arquitecture.Infraestruture.Repositories
{
    public class RepositoryBase<T> : IAsyncRepository<T> where T : Audit
    {

        protected readonly CleanArquitectureDbContext _context;

        public RepositoryBase(CleanArquitectureDbContext context)
        {
            _context = context;
        }

        public async Task<IReadOnlyList<T>> ObtenerAsincronico(Expression<Func<T, bool>> predicado)
        {
            return await _context.Set<T>().Where(predicado).ToListAsync();
        }

        public async Task<IReadOnlyList<T>> ObtenerTodosLosDatosAsincronico()
        {
            return await _context.Set<T>().ToListAsync();
        }
    }
}
