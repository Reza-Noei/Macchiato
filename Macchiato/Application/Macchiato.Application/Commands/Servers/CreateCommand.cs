using Mediator.Net.Contracts;

namespace Macchiato.Application.Commands.Servers
{
    public class CreateCommand : ICommand
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string UrlPrefix { get; set; }
    }
}
