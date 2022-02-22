// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var randomNumbers = new int[] { 5, 4, 5, 7, 6, 9, 4, 1, 1, 3, 4, 50, 56, 41 };

        var sortedNumbers = MergeSort(randomNumbers.AsEnumerable());
        Console.WriteLine("Merge Sort:");
        PrintList(sortedNumbers);
        Console.ReadKey();
        // Console.Clear();
    }
}

