using AutoMapper;
using Clean.Arquitectucture.Aplication.Contracts;
using Clean.Arquitecture.Domain;
using MediatR;

namespace Clean.Arquitectucture.Aplication.Features.RegistrarUsuario.Commands
{
    public class RegistrarUsuarioCommandHandler : IRequestHandler<RegistrarUsuarioCommand, bool>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public RegistrarUsuarioCommandHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Handle(RegistrarUsuarioCommand request, CancellationToken cancellationToken)
        {
            var usuario = _mapper.Map<User>(request);

            await _unitOfWork.Repository<User>().InsertarAsync(usuario);

            var result = await _unitOfWork.SalvarCambios();
            if (result <= 0)
            {
                return false;
            }

            return true;
        }
    }
}
