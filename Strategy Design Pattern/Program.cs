namespace Strategy.NetOptimized;

using static System.Console;
using System.Collections.Generic;

/// <summary>
/// Strategy Design Pattern
/// </summary>
public class Program
{
    public static void Main()
    {
        // Two contexts following different strategies
        SortedList students =
              [
                new (Name:"Samual", Ssn: "154-33-2009"),
                new (Name:"Jimmy", Ssn: "487-43-1665" ),
                new (Name:"Sandra", Ssn:  "655-00-2944" ),
                new (Name:"Vivek", Ssn:  "133-98-8399" ),
                new (Name:"Anna", Ssn: "760-94-9844" )
              ];

        students.SortStrategy = new QuickSort();
        students.SortStudents();

        students.SortStrategy = new ShellSort();
        students.SortStudents();

        students.SortStrategy = new MergeSort();
        students.SortStudents();

        // Wait for user
        ReadKey();
    }
}

/// <summary>
/// The 'Strategy' interface
/// </summary>
public interface ISortStrategy
{
    void Sort(List<Student> list);
}

/// <summary>
/// Represents a student
/// </summary>
public record Student(string Name, string Ssn);
