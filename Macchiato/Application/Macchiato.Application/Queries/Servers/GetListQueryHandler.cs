using AutoMapper;
using Macchiato.Application.Abstractions;
using Macchiato.Application.Dtos;
using Mediator.Net.Context;
using Mediator.Net.Contracts;

namespace Macchiato.Application.Queries.Servers;

public class GetListQueryHandler : IRequestHandler<GetListQuery, Response<IEnumerable<ServerViewModel>>>
{
    public GetListQueryHandler(IServerRepository serverRepository,
                               IMapper mapper)
    {
        _serverRepository = serverRepository;
        _mapper = mapper;
    }

    public async Task<Response<IEnumerable<ServerViewModel>>> Handle(IReceiveContext<GetListQuery> context, CancellationToken cancellationToken)
    {
        try
        {
            var servers = await _serverRepository.GetList();

            return new Response<IEnumerable<ServerViewModel>>
            {
                StatusCode = System.Net.HttpStatusCode.OK,
                Data = _mapper.Map<IEnumerable<ServerViewModel>>(servers)
            };
        }
        catch (Exception ex) 
        {
            return new Response<IEnumerable<ServerViewModel>>
            {
                Message = "Internal error.",
                StatusCode = System.Net.HttpStatusCode.InternalServerError
            };
        }
    }


    private readonly IServerRepository _serverRepository;
    private readonly IMapper _mapper;
}
