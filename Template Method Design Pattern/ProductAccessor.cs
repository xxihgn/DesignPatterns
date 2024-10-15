namespace Template.NetOptimized;

using static System.Console;

/// <summary>
/// A 'ConcreteClass' class
/// </summary>
public class ProductAccessor : DataAccessor<Product>
{
    public override void Select()
    {
        Items.Add(new Product { ProductName = "Car" });
        Items.Add(new Product { ProductName = "Bike" });
        Items.Add(new Product { ProductName = "Boat" });
        Items.Add(new Product { ProductName = "Truck" });
        Items.Add(new Product { ProductName = "Moped" });
        Items.Add(new Product { ProductName = "Rollerskate" });
        Items.Add(new Product { ProductName = "Stroller" });
    }

    public override void Process(int top)
    {
        WriteLine("Products ---- ");

        for (int i = 0; i < top; i++)
        {
            WriteLine(Items[i].ProductName);
        }

        WriteLine();
    }
}
