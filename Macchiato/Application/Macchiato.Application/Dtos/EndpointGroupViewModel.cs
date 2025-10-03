namespace Macchiato.Application.Dtos
{
    public class EndpointGroupViewModel
    {
        public string RoutePrefix { get; set; }

        public ICollection<EndpointViewModel> Endpoints { get; set; }
    }
}
