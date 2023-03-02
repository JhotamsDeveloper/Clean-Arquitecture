using MediatR;

namespace Clean.Arquitectucture.Aplication.Features.RegistrarUsuario.Commands
{
    public class RegistrarUsuarioCommand : IRequest<bool>
    {
        public int DocumentType { get; set; }
        public string DocumentNumber { get; set; } = default!;
        public string Names { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public string SecondLastName { get; set; } = default!;
        public DateTime BirthDate { get; set; }

    }
}
