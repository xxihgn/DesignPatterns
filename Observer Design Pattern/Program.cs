namespace Observer.NetOptimized;
using static System.Console;
using System;
/// <summary>
/// Observer Design Pattern
/// </summary>
public class Program
{
    public static void Main()
    {
        // Create IBM stock and attach investors
        var ibm = new IBM(120.00);
        // Attach 'listeners', i.e. Investors
        ibm.Attach(new Investor { Name = "Sorros" });
        ibm.Attach(new Investor { Name = "Berkshire" });
        // Fluctuating prices will notify listening investors
        ibm.Price = 120.10;
        ibm.Price = 121.00;
        ibm.Price = 120.50;
        ibm.Price = 120.75;
        // Wait for user
        ReadKey();
    }
}