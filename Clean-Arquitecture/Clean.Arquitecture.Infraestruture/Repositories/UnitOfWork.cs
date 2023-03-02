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

        public async Task<int> GuardarRegistro()
        {
            var result = await _contex.SaveChangesAsync();
            return result;
        }
    }
}
