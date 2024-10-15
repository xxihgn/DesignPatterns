namespace Strategy.NetOptimized;

using static System.Console;
using System.Collections.Generic;

/// <summary>
/// The 'Context' class
/// </summary>
public class SortedList : List<Student>
{
    // Sets sort strategy
    public ISortStrategy SortStrategy { get; set; } = null!;

    // Perform sort
    public void SortStudents()
    {
        SortStrategy.Sort(this);

        // Display sort results
        foreach (var student in this)
        {
            WriteLine($" {student.Name}");
        }
        WriteLine();
    }
}
