namespace Abstract.NetOptimized;

using Abstract_Factory;
using static System.Console;

/// <summary>
/// Abstract Factory Design Pattern.
/// </summary>
public class Program
{
    public static void Main()
    {
        // Create and run the African animal world
        var africa = new AnimalWorld<Africa>();
        africa.RunFoodChain();

        // Create and run the American animal world
        var america = new AnimalWorld<America>();
        america.RunFoodChain();

        // Wait for user input
        ReadKey();
    }

}




