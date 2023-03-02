using AutoMapper;
using Clean.Arquitectucture.Aplication.Features.RegistrarUsuario.Commands;
using Clean.Arquitecture.Domain;

namespace Clean.Arquitectucture.Aplication.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, RegistrarUsuarioCommand>().ReverseMap();
        }
    }
}
