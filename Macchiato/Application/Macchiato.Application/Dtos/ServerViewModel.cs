namespace Macchiato.Application.Dtos
{
    public class ServerViewModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string UrlPrefix { get; set; }

        public DateTime CreatedAt { get; set; }

        public bool IsDeleted { get; set; }

        public ICollection<EndpointGroupViewModel> EndpointGroups { get; private set; }
    }
}
