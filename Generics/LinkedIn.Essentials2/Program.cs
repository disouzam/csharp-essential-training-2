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

        var c2 = new Customer
        {
            Id = 3,
            FirstName = "customer",
            LastName = "second",
            CreateDate = new DateTime(2022, 1, 17)
        };

        var sorter = new Sorter<Customer>();
        var customers = new Customer[] { c, c2 };

        sorter.Sort(customers);

        foreach (var customer in customers)
        {
            Console.WriteLine($"{customer.Id}: {customer.LastName}");
        }


        var mapper = new CustomerToPersonMapper();
        var p = c.Map<Person>(mapper);

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