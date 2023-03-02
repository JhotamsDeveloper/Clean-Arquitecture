using Clean.Arquitectucture.Aplication.Contracts;
using Clean.Arquitecture.Infraestruture.Persistence;
using System.Collections;

namespace Clean.Arquitecture.Infraestruture.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private Hashtable _repositories;

        private readonly CleanArquitectureDbContext _contex;

        public UnitOfWork(CleanArquitectureDbContext contex)
        {
            _contex = contex;
        }

        public async Task<int> SalvarCambios()
        {
            var result = await _contex.SaveChangesAsync();
            return result;
        }

        public IAsyncRepository<TEntity> Repository<TEntity>() where TEntity : class
        {
            if (_repositories == null)
            {
                _repositories = new Hashtable();
            }

            var type = typeof(TEntity).Name;

            if (!_repositories.ContainsKey(type))
            {
                var repositoryType = typeof(RepositoryBase<>);
                var repositoryInstance = Activator.CreateInstance(repositoryType
                    .MakeGenericType(typeof(TEntity)), _contex);
                _repositories.Add(type, repositoryInstance);
            }

            return (IAsyncRepository<TEntity>)_repositories[type]!;
        }
    }
}
