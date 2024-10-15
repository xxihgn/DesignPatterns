namespace Template.NetOptimized;

using static System.Console;

/// <summary>
/// Template Design Pattern
/// </summary>
public class Program
{
    public static void Main()
    {
        var categories = new CategoryAccessor();
        categories.Run(5);

        var products = new ProductAccessor();
        products.Run(3);

        // Wait for user
        ReadKey();
    }
}

public record Category
{
    public string CategoryName { get; set; } = null!;
}

public record Product
{
    public string ProductName { get; set; } = null!;
}
