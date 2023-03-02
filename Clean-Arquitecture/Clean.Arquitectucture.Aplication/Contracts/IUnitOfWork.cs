namespace Clean.Arquitectucture.Aplication.Contracts
{
    public interface IUnitOfWork
    {
        IAsyncRepository<TEntity> Repository<TEntity>() where TEntity : class;
        Task<int> SalvarCambios();
    }
}
