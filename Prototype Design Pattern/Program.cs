namespace Prototype.NetOptimized;

using static System.Console;
using System.Text.Json;
using System.Collections.Generic;
using Prototype_Design_Pattern;

/// <summary>
/// Prototype Design Pattern
/// </summary>
public class Program
{
    public static void Main()
    {
        var manager = new ColorManager();

        // Initialize with standard colors
        manager[ColorType.Red] = new Color { Red = 255, Blue = 0, Green = 0 };
        manager[ColorType.Green] = new Color { Red = 0, Blue = 255, Green = 0 };
        manager[ColorType.Blue] = new Color { Red = 0, Blue = 0, Green = 255 };

        // User adds personalized colors
        manager[ColorType.Angry] = new Color { Red = 255, Blue = 54, Green = 0 };
        manager[ColorType.Peace] = new Color { Red = 128, Blue = 211, Green = 128 };
        manager[ColorType.Flame] = new Color { Red = 211, Blue = 34, Green = 20 };

        // User uses selected colors
        _ = manager[ColorType.Red].Clone();
        _ = manager[ColorType.Peace].Clone();
        _ = manager[ColorType.Flame].Clone(false); // Deep Copy

        // Wait for user
        ReadKey();
    }
}

public enum ColorType
{
    Red,
    Green,
    Blue,

    Angry,
    Peace,
    Flame
}
