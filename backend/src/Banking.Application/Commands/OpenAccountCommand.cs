using MediatR;

namespace Banking.Application.Commands;

public class OpenAccountCommand : IRequest<Guid> // returns the new account ID
{
    public string OwnerName { get; set; } = string.Empty;
}
