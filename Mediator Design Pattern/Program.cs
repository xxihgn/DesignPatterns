namespace Mediator.NetOptimized;

using static System.Console;

/// <summary>
/// Mediator Design Pattern
/// </summary>
public class Program
{
    public static void Main()
    {
        // Create chatroom participants
        var George = new Beatle { Name = "George" };
        var Paul = new Beatle { Name = "Paul" };
        var Ringo = new Beatle { Name = "Ringo" };
        var John = new Beatle { Name = "John" };
        var Yoko = new NonBeatle { Name = "Yoko" };

        // Create chatroom and register participants
        var chatroom = new Chatroom();
        chatroom.Register(George);
        chatroom.Register(Paul);
        chatroom.Register(Ringo);
        chatroom.Register(John);
        chatroom.Register(Yoko);

        // Chatting participants
        Yoko.Send("John", "Hi John!");
        Paul.Send("Ringo", "All you need is love");
        Ringo.Send("George", "My sweet Lord");
        Paul.Send("John", "Can't buy me love");
        John.Send("Yoko", "My sweet love");

        // Wait for user
        ReadKey();
    }
}

/// <summary>
/// The 'Mediator' interface
/// </summary>
public interface IChatroom
{
    void Register(Participant participant);
    void Send(string from, string to, string message);
}
