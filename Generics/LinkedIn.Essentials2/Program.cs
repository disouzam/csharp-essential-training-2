using System;
using System.Diagnostics;
using System.Diagnostics.Metrics;

using Essentials2.Library;

namespace LinkedIn.Essentials2;

public static class Program
{
    public static void Main()
    {
        // Value type variables
        int x = 5, y = 7;

        Console.WriteLine($"Before swapping >>> X: {x} and Y: {y}");

        //Swap(x, y);

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

        // Also don't work as it would be expected

        //Before swapping >>> p1: Id: 0
        //FirstName: matt
        //LastName: milner
        //Age: 50
        // and p2: Id: 0
        //FirstName: amanda
        //LastName: owner
        //Age: 39

        //After swapping >>> p1: Id: 0
        //FirstName: matt
        //LastName: milner
        //Age: 50
        // and p2: Id: 0
        //FirstName: amanda
        //LastName: owner
        //Age: 39
    }

    public static void Swap(Person first, Person second)
    {
        Person temp = second;
        second = first;
        first = temp;

        Debug.Assert(first != second);
    }
}