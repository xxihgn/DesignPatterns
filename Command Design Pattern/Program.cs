namespace Command.NetOptimized;
using static System.Console;
using System;
using System.Collections.Generic;
/// <summary>
/// Command Design Pattern
/// </summary>
public class Program
{
    public static void Main()
    {
        // Create user and let her compute
        var user = new User();
        // Issue several compute commands
        user.Compute('+', 100);
        user.Compute('-', 50);
        user.Compute('*', 10);
        user.Compute('/', 2);
        // Undo 4 commands
        user.Undo(4);
        // Redo 3 commands
        user.Redo(3);
        // Wait for user
        ReadKey();
    }
}

