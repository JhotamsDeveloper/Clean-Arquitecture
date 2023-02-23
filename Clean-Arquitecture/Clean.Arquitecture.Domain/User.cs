using Clean.Arquitecture.Domain.Common;

namespace Clean.Arquitecture.Domain
{
    public class User : Audit
    {
        public int DocumentType { get; set; }
        public string DocumentNumber { get; set; } = default!;
        public string Names { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public string SecondLastName { get; set; } = default!;
        public DateTime BirthDate { get; set; }
    }
}
