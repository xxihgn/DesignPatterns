namespace State.NetOptimized;

using static System.Console;

/// <summary>
/// The 'Context' class
/// </summary>
public class Account
{
    private readonly string owner;

    // Constructor
    public Account(string owner)
    {
        // New accounts are 'Silver' by default
        this.owner = owner;
        this.State = new SilverState(0.0, this);
    }

    // Gets the balance
    public double Balance
    {
        get { return State.Balance; }
    }

    // Gets or sets state
    public State State { get; set; }

    public void Deposit(double amount)
    {
        State.Deposit(amount);
        WriteLine($"Owner: {owner}");
        WriteLine("Deposited {0:C} --- ", amount);
        WriteLine(" Balance = {0:C}", this.Balance);
        WriteLine(" Status  = {0}", this.State.GetType().Name);
        WriteLine("");
    }

    public void Withdraw(double amount)
    {
        State.Withdraw(amount);
        WriteLine($"Owner: {owner}");
        WriteLine("Withdrew {0:C} --- ", amount);
        WriteLine(" Balance = {0:C}", this.Balance);
        WriteLine(" Status  = {0}\n", this.State.GetType().Name);
    }

    public void PayInterest()
    {
        State.PayInterest();
        WriteLine("Interest Paid --- ");
        WriteLine(" Balance = {0:C}", this.Balance);
        WriteLine(" Status  = {0}\n", this.State.GetType().Name);
    }
}
