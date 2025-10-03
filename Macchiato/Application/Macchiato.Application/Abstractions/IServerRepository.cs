using Macchiato.Domain;

namespace Macchiato.Application.Abstractions
{
    public interface IServerRepository
    {
        Task<Server?> Get(string name);

        Task<IEnumerable<Server>?> GetList();

        Task Add(Server server);
    }
}
