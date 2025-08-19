namespace Banking.Domain.Aggregates;

public class AccountAggregate
{
    // placeholder properties
    public Guid Id { get; private set; }
    public decimal Balance { get; private set; }

    // placeholder methods
    public void OpenAccount(string owner) { }
    public void Deposit(decimal amount) { }
    public void Withdraw(decimal amount) { }
}
