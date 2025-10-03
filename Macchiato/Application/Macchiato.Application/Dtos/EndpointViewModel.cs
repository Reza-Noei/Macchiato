namespace Macchiato.Application.Dtos
{
    public class EndpointViewModel
    {
        public EndpointGroupViewModel? Group { get; private set; }

        public HttpMethod Method { get; private set; }

        public string? Name { get; private set; }

        public string Url { get; private set; }
    }
}
