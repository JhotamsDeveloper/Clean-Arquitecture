using Clean.Arquitectucture.Aplication.Contracts;
using Clean.Arquitecture.Domain;
using MediatR;

namespace Clean.Arquitectucture.Aplication.Features.ObtenerUsuarioPorId.Queries
{
    public class ObtenerUsuarioPorIdQueryHandler : IRequestHandler<ObtenerUsuarioPorIdQuery, object>
    {
        private readonly IUnitOfWork _unitOfWork;

        public ObtenerUsuarioPorIdQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<object> Handle(ObtenerUsuarioPorIdQuery request, CancellationToken cancellationToken)
        {
            var user = await _unitOfWork
                .Repository<User>()
                .ObtenerPorIdAsincronico(request.IdUser);

            return user;
        }
    }
}
