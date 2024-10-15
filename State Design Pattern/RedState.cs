namespace State.NetOptimized;

using static System.Console;

/// <summary>
/// A 'ConcreteState' class
/// <remarks>
/// Red state indicates account is overdrawn 
/// </remarks>
/// </summary>
public class RedState : State
{
    private double serviceFee;

    // Constructor
    public RedState(State state)
    {
        Balance = state.Balance;
        Account = state.Account;
        Initialize();
    }

    private void Initialize()
    {
        // Should come from a datasource
        interest = 0.0;
        lowerLimit = -100.0;
        upperLimit = 0.0;
        serviceFee = 15.00;
    }

    public override void Deposit(double amount)
    {
        Balance += amount;
        StateChangeCheck();
    }

    public override void Withdraw(double amount)
    {
        amount -= serviceFee;
        WriteLine("No funds available for withdrawal!");
    }

    public override void PayInterest()
    {
        // No interest is paid
    }

    private void StateChangeCheck()
    {
        if (Balance > upperLimit)
        {
            Account.State = new SilverState(this);
        }
    }
}
