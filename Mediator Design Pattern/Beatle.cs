namespace Mediator.NetOptimized;

using static System.Console;

/// <summary>
/// A 'ConcreteColleague' class
/// </summary>
public class Beatle : Participant
{
    public override void Receive(string from, string message)
    {
        Write("To a Beatle: ");
        base.Receive(from, message);
    }
}
