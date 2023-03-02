using System.Linq.Expressions;

namespace Clean.Arquitectucture.Aplication.Contracts
{
    public interface IAsyncRepository<T> where T : class
    {
        Task<IReadOnlyList<T>> ObtenerTodosLosDatosAsincronico();
        Task<IReadOnlyList<T>> ObtenerAsincronico(Expression<Func<T,bool>> predicado);
    }
}
