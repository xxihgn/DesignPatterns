namespace Template.NetOptimized;

using static System.Console;

/// <summary>
/// A 'ConcreteClass' class
/// </summary>
public class CategoryAccessor : DataAccessor<Category>
{
    public override void Select()
    {
        Items.Add(new() { CategoryName = "Red" });
        Items.Add(new() { CategoryName = "Green" });
        Items.Add(new() { CategoryName = "Blue" });
        Items.Add(new() { CategoryName = "Yellow" });
        Items.Add(new() { CategoryName = "Purple" }); ;
        Items.Add(new() { CategoryName = "White" });
        Items.Add(new() { CategoryName = "Black" });
    }

    public override void Process(int top)
    {
        WriteLine("Categories ---- ");

        for (int i = 0; i < top; i++)
        {
            WriteLine(Items[i].CategoryName);
        }

        WriteLine();
    }
}
