using Macchiato.Application.Abstractions;
using Macchiato.Domain;
using Microsoft.Extensions.Caching.Distributed;
using System.Text.Json;

namespace Macchiato.Infrastructure;

public class ServerRepository : IServerRepository
{
    private const string ServersRootPath = "Servers";
    private readonly IDistributedCache _distributedCache;

    public ServerRepository(IDistributedCache distributedCache)
    {
        _distributedCache = distributedCache;
    }

    public async Task Add(Server server)
    {
        string fileName = server.Name.Replace(" ", "_");
        string filePath = Path.Combine(ServersRootPath, fileName);
        string serverText = JsonSerializer.Serialize(server);

        if (File.Exists(filePath))
        {
            throw new Exception("Server is already exists.");
        }

        _distributedCache.SetString(fileName, serverText);

        await File.WriteAllTextAsync(filePath, serverText);
    }

    public async Task<Server?> Get(string name)
    {
        string fileName = name.Replace(" ", "_");

        string? cachedServer = await _distributedCache.GetStringAsync(fileName);
        if (cachedServer != null)
        {
            return JsonSerializer.Deserialize<Server?>(cachedServer);
        }

        string filePath = Path.Combine(ServersRootPath, fileName);
        if (File.Exists(filePath))
        {
            string serverText = File.ReadAllText(filePath);

            Server? server = JsonSerializer.Deserialize<Server>(serverText);
            
            if (server != null)
            {
                _distributedCache.SetString(fileName, serverText);
            }

            return server;
        }

        return null;
    }

    public async Task<IEnumerable<Server>?> GetList()
    {
        if (internalList != null) 
        {
            return internalList;
        }

        var files = Directory.GetFiles(ServersRootPath);
        internalList = new List<Server>();

        foreach (var file in files)
        {
            var server = JsonSerializer.Deserialize<Server>(File.ReadAllText(file));
            internalList.Add(server);
        }

        return internalList;
    }


    private List<Server> internalList;
}
