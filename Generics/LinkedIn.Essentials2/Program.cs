using System.Diagnostics;

namespace LinkedIn.Essentials2;

public static class Program
{
    public static void Main()
    {
        int x = 5, y = 7;

        Console.WriteLine($"Before swapping >>> X: {x} and Y: {y}");

        Swap(x, y);

        Console.WriteLine($"After swapping >>> X: {x} and Y: {y}");

        // Expected output:
        //Before swapping >>> X: 5 and Y: 7
        //After swapping >>> X: 5 and Y: 7
    }

    public static void Swap(object first, object second)
    {
        object temp = second;
        second = first;
        first = temp;

        Debug.Assert(first != second);
    }
}