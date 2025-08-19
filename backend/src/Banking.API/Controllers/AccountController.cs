using Banking.Application.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Banking.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AccountsController : ControllerBase
{
    private readonly IMediator _mediator;

    public AccountsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost("open")]
    public async Task<IActionResult> OpenAccount([FromBody] OpenAccountCommand command)
    {
        var accountId = await _mediator.Send(command);
        return Ok(new { AccountId = accountId });
    }
}
