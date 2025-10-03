using AutoMapper;
using Macchiato.Application.Dtos;
using Macchiato.Domain;

namespace Macchiato.Infrastructure;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Server, ServerViewModel>();
        CreateMap<Endpoint, EndpointViewModel>();
        CreateMap<EndpointGroup, EndpointGroupViewModel>();
    }
}
