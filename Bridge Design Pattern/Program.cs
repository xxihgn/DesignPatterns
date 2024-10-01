namespace Bridge.NetOptimized;

using Bridge_Design_Pattern;
using static System.Console;

/// <summary>
/// Bridge Design Pattern
/// </summary>
public class Program
{
    public static void Main()
    {
        // Create RefinedAbstraction and
        // set ConcreteImplementor
        var customers = new Customers(
            new CustomersData("Chicago"));

        // Exercise the bridge
        customers.Show();
        customers.Next();
        customers.Show();
        customers.Next();
        customers.Show();

        customers.Add("Henry Velasquez");
        customers.ShowAll();

        // Wait for user
        ReadKey();
    }
}



