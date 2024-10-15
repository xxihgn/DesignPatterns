namespace Strategy.NetOptimized;

using static System.Console;
using System.Collections.Generic;

/// <summary>
/// A 'ConcreteStrategy' class
/// </summary>
public class ShellSort : ISortStrategy
{
    public void Sort(List<Student> list)
    {
        // ShellSort();  not-implemented
        WriteLine("ShellSorted list ");
    }
}
