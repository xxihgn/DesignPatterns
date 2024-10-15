namespace Strategy.NetOptimized;

using static System.Console;
using System.Collections.Generic;

/// <summary>
/// A 'ConcreteStrategy' class
/// </summary>
public class MergeSort : ISortStrategy
{
    public void Sort(List<Student> list)
    {
        // MergeSort(); not-implemented
        WriteLine("MergeSorted list ");
    }
}
