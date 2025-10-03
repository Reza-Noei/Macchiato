using Macchiato.Application.Commands.Servers;
using Macchiato.Application.Dtos;
using Macchiato.Application.Queries.Servers;
using Mediator.Net;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Macchiato.Server.Controllers;

[ApiController]
[Route("[controller]")]
public class ServersController : ControllerBase
{
    private readonly IMediator _mediator;
    private readonly ILogger<ServersController> _logger;

    public ServersController(IMediator mediator,
                             ILogger<ServersController> logger)
    {
        this._mediator = mediator;
        _logger = logger;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        Response<IEnumerable<ServerViewModel>> result = await _mediator.RequestAsync<GetListQuery, Response<IEnumerable<ServerViewModel>>>(new GetListQuery());
        return new JsonResult(result);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateCommand command)
    {
        Response<ServerViewModel> result = await _mediator.SendAsync<CreateCommand, Response<ServerViewModel>>(command);
        return new JsonResult(result);
    }
}
