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


        Console.WriteLine($"Before swapping >>> p1:{Environment.NewLine}{p1.ToString()} {Environment.NewLine} and {Environment.NewLine}p2:{Environment.NewLine}{p2.ToString()}");

        unsafe
        {
            var addressP1 = &p1;
            var addressP2 = &p2;

            Console.WriteLine($"Variable adresses: p1: {(long)addressP1} - p2: {(long)addressP2}");
        }

        Swap(ref p1, ref p2);

        Console.WriteLine($"After swapping >>> p1:{Environment.NewLine}{p1.ToString()} {Environment.NewLine} and {Environment.NewLine}p2:{Environment.NewLine}{p2.ToString()}");

        unsafe
        {
            var addressP1 = &p1;
            var addressP2 = &p2;

            Console.WriteLine($"Variable adresses: p1: {(long)addressP1} - p2: {(long)addressP2}");
        }

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

    public static void Swap(ref object first, ref object second)
    {
        var firstType = first.GetType();
        var secondType = second.GetType();

        if (firstType == typeof(Person) && secondType == typeof(Person))
        {
            var propFirstName = firstType.GetProperty("FirstName");
            propFirstName?.SetValue(first, "Joao");
            propFirstName?.SetValue(second, "Maria");
        }

        object temp = second;
        second = first;
        first = temp;

        Debug.Assert(first != second);
    }
}