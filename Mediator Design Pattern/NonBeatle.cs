namespace Mediator.NetOptimized;

using static System.Console;

/// <summary>
/// A 'ConcreteColleague' class
/// </summary>
public class NonBeatle : Participant
{
    public override void Receive(string from, string message)
    {
        Write("To a non-Beatle: ");
        base.Receive(from, message);
    }
}
