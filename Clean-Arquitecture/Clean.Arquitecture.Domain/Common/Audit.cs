namespace Clean.Arquitecture.Domain.Common
{
    public abstract class Audit
    {
        public Guid Id { get; set; }
        public DateTime Create { get; set; }
        public DateTime Update { get; set; }
    }
}
