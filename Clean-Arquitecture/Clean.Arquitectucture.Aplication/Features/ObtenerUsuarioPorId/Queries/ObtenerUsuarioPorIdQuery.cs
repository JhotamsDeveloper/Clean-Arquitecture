using MediatR;

namespace Clean.Arquitectucture.Aplication.Features.ObtenerUsuarioPorId.Queries
{
    public class ObtenerUsuarioPorIdQuery : IRequest<Object>
    {
        public Guid IdUser { get; set; }

        public ObtenerUsuarioPorIdQuery(Guid idUser)
        {
            IdUser = idUser;
        }
    }
}
