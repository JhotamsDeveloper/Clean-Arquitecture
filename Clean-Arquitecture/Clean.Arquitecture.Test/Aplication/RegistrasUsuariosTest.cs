using AutoMapper;
using Clean.Arquitectucture.Aplication.Contracts;
using Clean.Arquitectucture.Aplication.Features.RegistrarUsuario.Commands;
using Clean.Arquitecture.Domain;
using Moq;

namespace Clean.Arquitecture.Test.Aplication
{
    public class RegistrasUsuariosTest
    {
        private readonly RegistrarUsuarioCommandHandler _handler;
        private readonly Mock<IMapper> _mapperMock;
        private readonly Mock<IUnitOfWork> _unitOfWorkMock;

        public RegistrasUsuariosTest()
        {
            _mapperMock = new Mock<IMapper>();
            _unitOfWorkMock = new Mock<IUnitOfWork>();
            _handler = new RegistrarUsuarioCommandHandler(_mapperMock.Object, _unitOfWorkMock.Object);
        }

        [Fact]
        public async Task Deberia_de_registrar_un_usuario_exitosamente()
        {
            // Arrange
            var command = new RegistrarUsuarioCommand();
            var usuario = new User();
            _mapperMock.Setup(m => m.Map<User>(command)).Returns(usuario);
            _unitOfWorkMock.Setup(u => u.Repository<User>().InsertarAsync(usuario));
            _unitOfWorkMock.Setup(u => u.SalvarCambios()).ReturnsAsync(1);

            // Act
            var result = await _handler.Handle(command, CancellationToken.None);

            // Assert
            Assert.True(result);
        }

    }
}
