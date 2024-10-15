namespace Facade.NetOptimized;

using Facade_Design_Pattern;
using static System.Console;
public class Program
{
    static void Main()
    {
        // Facade
        var mortgage = new Mortgage();
        // Evaluate mortgage eligibility for customer
        var customer = new Customer("Ann McKinsey");
        bool eligible = mortgage.IsEligible(customer, 125000);
        string result = eligible ? "Approved" : "Rejected";
        WriteLine($"\n{customer.Name} has been {result}");
        // Wait for user
        ReadKey();
    }
    public record Customer(string Name);
}
