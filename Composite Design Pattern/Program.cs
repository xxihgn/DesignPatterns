namespace Composite.NetOptimized;

using static System.Console;

using System;
using System.Collections.Generic;
using Composite_Design_Pattern;

public class Program
{
    public static void Main()
    {
        // Build a tree of shapes
        var root = new TreeNode<Shape> { Node = new("Picture") };

        root.Add(new("Red Line"));
        root.Add(new("Blue Circle"));
        root.Add(new("Green Box"));

        var branch = root.Add(new Shape("Two Circles"));
        branch.Add(new("Black Circle"));
        branch.Add(new("White Circle"));

        // Add, remove, and add a shape
        var shape = new Shape("Yellow Line");
        root.Add(shape);
        root.Remove(shape);
        root.Add(shape);

        // Display tree using static method
        TreeNode<Shape>.Display(root, 1);

        ReadKey();
    }
}





