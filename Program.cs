using System;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 3, 1, 5, 2, 4 };
        IntArray array = new IntArray(arr);

        Console.WriteLine("Original array:");
        array.Display();

        Console.WriteLine("Sorted in ascending order:");
        array.SortAsc();
        array.Display();

        Console.WriteLine("Sorted in descending order:");
        array.SortDesc();
        array.Display();

        Console.WriteLine("Sorted by parameter (ascending):");
        array.SortByParam(true);
        array.Display();

        Console.WriteLine("Sorted by parameter (descending):");
        array.SortByParam(false);
        array.Display();
    }
}
