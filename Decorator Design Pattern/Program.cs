namespace Decorator.NetOptimized;

using Decorator_Design_Pattern;
using static System.Console;
public class Program
{
    public static void Main()
    {
        // Create book
        var book = new Book("Worley", "Inside ASP.NET", 10);
        book.Display();
        // Create video
        var video = new Video("Spielberg", "Jaws", 23, 92);
        video.Display();
        // Make video borrowable, then borrow and display
        WriteLine("\nMaking video borrowable:");
        var borrow = new Borrowable<Video>(video);
        borrow.BorrowItem("Customer #1");
        borrow.BorrowItem("Customer #2");
        borrow.Display();
        // Wait for user
        ReadKey();
    }
}