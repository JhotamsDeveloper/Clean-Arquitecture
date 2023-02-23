using Clean.Arquitecture.Domain;

namespace Clean.Arquitecture.Infraestruture.Persistence
{
    public class CleanArquitectureDbContextSeed
    {
        public static IEnumerable<User> GetConfigurationUser()
        {
            return new List<User>
            {
                new User()
                {
                    Id = Guid.NewGuid(),
                    Names = "Jhonatan Alejandro",
                    LastName = "Muñoz",
                    SecondLastName = "Serna",
                    BirthDate = new DateTime(1992,9,10),
                    DocumentType = 1,
                    DocumentNumber = "1022095102"
                }
            };
        }
    }
}
