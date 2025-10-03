using AutoMapper;
using Macchiato.Application.Abstractions;
using Macchiato.Application.Dtos;
using Macchiato.Domain;
using Mediator.Net.Context;
using Mediator.Net.Contracts;
using System.Net;

namespace Macchiato.Application.Commands.Servers
{
    public class CreateCommandHandler : ICommandHandler<CreateCommand, Response<ServerViewModel>>
    {
        public CreateCommandHandler(IServerRepository serverRepository,
                                    IMapper mapper)
        {
            _serverRepository = serverRepository;
            _mapper = mapper;
        }

        public async Task<Response<ServerViewModel>> Handle(IReceiveContext<CreateCommand> context, CancellationToken cancellationToken)
        {
            try
            {
                var server = new Server(context.Message.Name, 
                                        context.Message.Description, 
                                        context.Message.UrlPrefix);

                _serverRepository.Add(server);

                return new Response<ServerViewModel>
                {
                    StatusCode = HttpStatusCode.Created,
                    Data = _mapper.Map<ServerViewModel>(server)
                };
            }
            catch (Exception ex)
            {
                return new Response<ServerViewModel>
                {
                    Message = "Internal error.",
                    StatusCode = HttpStatusCode.InternalServerError
                };
            }
        }


        private readonly IServerRepository _serverRepository;
        private readonly IMapper _mapper;
    }
}
