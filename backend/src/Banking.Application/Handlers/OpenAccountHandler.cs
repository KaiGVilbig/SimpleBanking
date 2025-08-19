using Banking.Application.Commands;
using Banking.Domain.Aggregates;
using Banking.Domain.Events;
using MediatR;

namespace Banking.Application.Handlers;

public class OpenAccountHandler : IRequestHandler<OpenAccountCommand, Guid>
{
    // In-memory for now
    private static readonly List<AccountAggregate> _accounts = new();

    public Task<Guid> Handle(OpenAccountCommand request, CancellationToken cancellationToken)
    {
        var account = new AccountAggregate();
        account.OpenAccount(request.OwnerName);
        _accounts.Add(account);

        return Task.FromResult(account.Id);
    }
}
