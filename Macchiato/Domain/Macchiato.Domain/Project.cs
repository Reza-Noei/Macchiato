namespace Macchiato.Domain
{
    public class Project
    {
        public string Name { get; private set; }

        public string Description { get; private set; }

        public string UrlPrefix { get; set; }

        public DateTime CreatedAt { get; private set; }

        public bool IsDeleted { get; private set; }

        public ICollection<Endpoint> Endpoints { get; private set; }
    }
}
