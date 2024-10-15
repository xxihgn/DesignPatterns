namespace Proxy.NetOptimized;
using static System.Console;
using System.Threading;
/// <summary>
/// Proxy Design Pattern
/// </summary>
public class Program
{
    public static void Main()
    {
        // Create math proxy
        var proxy = new MathProxy();
        // Do the math
        WriteLine($"4 + 2 = {proxy.Add(4, 2)}");
        WriteLine($"4 - 2 = {proxy.Sub(4, 2)}");
        WriteLine($"4 * 2 = {proxy.Mul(4, 2)}");
        WriteLine($"4 / 2 = {proxy.Div(4, 2)}");
        // Wait for user
        ReadKey();
    }
}