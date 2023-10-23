using System.Diagnostics;

using Essentials2.Library;

namespace LinkedIn.Essentials2;

public static class Program
{
    public static void Main()
    {
        var c = new Customer
        {
            Id = 7,
            FirstName = "customer",
            LastName = "first",
            CreateDate = new DateTime(2022, 1, 17)
        };

        var mapper = new CustomerToPersonMapper();
        var p = mapper.Map(c);

        Console.WriteLine(p.FirstName);
    }

    public static void Swap<T>(ref T first, ref T second)
    {
        var firstType = first?.GetType();
        var secondType = second?.GetType();

        if (firstType == typeof(Person) && secondType == typeof(Person))
        {
            var propFirstName = firstType.GetProperty("FirstName");
            propFirstName?.SetValue(first, "Joao");
            propFirstName?.SetValue(second, "Maria");
        }

        T temp = second;
        second = first;
        first = temp;

        Debug.Assert(!first.Equals(second));
    }
}