namespace Adapter.NetOptimized;

using Adapter_Design_Pattern;
using static System.Console;

/// <summary>
/// Adapter Design Pattern
/// </summary>
public class Program
{
    public static void Main()
    {
        // Non-adapted chemical compound 
        var unknown = new Compound();
        unknown.Display();

        // Adapted chemical compounds
        var water = new RichCompound(Chemical.Water);
        water.Display();

        var benzene = new RichCompound(Chemical.Benzene);
        benzene.Display();

        var ethanol = new RichCompound(Chemical.Ethanol);
        ethanol.Display();

        // Wait for user
        ReadKey();
    }
}

public enum Chemical
{
    Water,
    Benzene,
    Ethanol
}

public enum State
{
    Boiling,
    Melting
}

