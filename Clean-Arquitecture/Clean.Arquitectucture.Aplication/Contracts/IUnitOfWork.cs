namespace Clean.Arquitectucture.Aplication.Contracts
{
    public interface IUnitOfWork
    {
        Task<int> GuardarRegistro();
    }
}
