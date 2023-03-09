using System.Linq.Expressions;

namespace Clean.Arquitectucture.Aplication.Contracts
{
    public interface IAsyncRepository<T> where T : class
    {
        Task<IReadOnlyList<T>> ObtenerTodosLosDatosAsincronico();
        Task<T> ObtenerPorIdAsincronico(Guid id);
        Task<IReadOnlyList<T>> ObtenerAsincronico(Expression<Func<T,bool>> predicado);

        Task<T> InsertarAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<T> DeleteAsync(T entity);
    }
}
