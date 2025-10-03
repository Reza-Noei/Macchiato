namespace Macchiato.Domain
{
    public class Server
    {
        public Server(string name, string description, string urlPrefix)
        {
            Name = name;
            Description = description;
            UrlPrefix = urlPrefix;

            CreatedAt = DateTime.UtcNow;
        }

        public string Name { get; private set; }

        public string Description { get; private set; }

        public string UrlPrefix { get; private set; }

        public DateTime CreatedAt { get; private set; }

        public bool IsDeleted { get; private set; }

        public ICollection<EndpointGroup> EndpointGroups { get; private set; }
    }
}
