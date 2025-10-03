namespace Macchiato.Domain
{
    public class EndpointGroup
    {
        public string RoutePrefix { get; private set; }

        public ICollection<Endpoint> Endpoints { get; set; }
    }
}
