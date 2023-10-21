using System.Diagnostics;

using Essentials2.Library;

namespace LinkedIn.Essentials2;

public static class Program
{
    public static void Main()
    {
        // Value type variables
        int x = 5, y = 7;

        Console.WriteLine($"Before swapping >>> X: {x} and Y: {y}");

        Swap(x, y);

        Console.WriteLine($"After swapping >>> X: {x} and Y: {y}");

        // Expected output:
        //Before swapping >>> X: 5 and Y: 7
        //After swapping >>> X: 5 and Y: 7

        // Reference type variables
        var p1 = new Person
        {
            FirstName = "matt",
            LastName = "milner",
            Age = 50
        };

        var p2 = new Person
        {
            FirstName = "amanda",
            LastName = "owner",
            Age = 39
        };

        Console.WriteLine($"Before swapping >>> p1: {p1.ToString()} and p2: {p2.ToString()}");

        Swap(p1, p2);

        Console.WriteLine($"After swapping >>> p1: {p1.ToString()} and p2: {p2.ToString()}");
    }

    public static void Swap(object first, object second)
    {
        object temp = second;
        second = first;
        first = temp;

        Debug.Assert(first != second);
    }
}