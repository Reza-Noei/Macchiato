using Macchiato.Domain.Requests;
using Macchiato.Domain.Responses;

namespace Macchiato.Domain
{
    public class Endpoint
    {
        public EndpointGroup? Group { get; private set; }

        public HttpMethod Method { get; private set; }

        public string? Name { get; private set; }

        public string Url { get; private set; }

        public RequestBody Request { get; private set; }
    
        public HttpResponse Response { get; private set; }
    }
}
