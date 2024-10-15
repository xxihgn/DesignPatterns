namespace Strategy.NetOptimized;

using static System.Console;
using System;
using System.Collections.Generic;

/// <summary>
/// A 'ConcreteStrategy' class
/// </summary>
public class QuickSort : ISortStrategy
{
    public void Sort(List<Student> list)
    {
        // Call overloaded Sort
        Sort(list, 0, list.Count - 1);
        WriteLine("QuickSorted list ");
    }

    // Recursively sort
    private static void Sort(List<Student> list, int left, int right)
    {
        int lhold = left;
        int rhold = right;

        // Use a random pivot
        var random = new Random();
        int pivot = random.Next(left, right);
        Swap(list, pivot, left);
        pivot = left;
        left++;

        while (right >= left)
        {
            int compareleft = list[left].Name.CompareTo(list[pivot].Name);
            int compareright = list[right].Name.CompareTo(list[pivot].Name);

            if ((compareleft >= 0) && (compareright < 0))
            {
                Swap(list, left, right);
            }
            else
            {
                if (compareleft >= 0)
                {
                    right--;
                }
                else
                {
                    if (compareright < 0)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                        left++;
                    }
                }
            }
        }
        Swap(list, pivot, right);
        pivot = right;

        if (pivot > lhold) Sort(list, lhold, pivot);
        if (rhold > pivot + 1) Sort(list, pivot + 1, rhold);
    }

    // Swap helper function
    private static void Swap(List<Student> list, int left, int right)
    {
        // Tuple based swap
        (list[left], list[right]) = (list[right], list[left]);
    }
}
