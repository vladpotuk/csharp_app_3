using System;

public class IntArray : ISort
{
    private int[] elements;

    public IntArray(int[] arr)
    {
        elements = arr;
    }

    public void SortAsc()
    {
        Array.Sort(elements);
    }

    public void SortDesc()
    {
        Array.Sort(elements);
        Array.Reverse(elements);
    }

    public void SortByParam(bool isAsc)
    {
        if (isAsc)
            SortAsc();
        else
            SortDesc();
    }

    public void Display()
    {
        Console.WriteLine("Елементи масиву:");
        foreach (var element in elements)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}
