namespace Mediator.NetOptimized;

using System.Collections.Generic;

/// <summary>
/// The 'ConcreteMediator' class
/// </summary>
public class Chatroom : IChatroom
{
    private readonly Dictionary<string, Participant> participants = [];

    public void Register(Participant participant)
    {
        participants.TryAdd(participant.Name, participant);
        participant.Chatroom = this;
    }

    public void Send(string from, string to, string message)
    {
        var participant = participants[to];
        if (participant != null)
        {
            participant.Receive(from, message);
        }
    }
}
