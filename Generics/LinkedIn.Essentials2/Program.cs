using System.Diagnostics;

using Essentials2.Library;

namespace LinkedIn.Essentials2;

public static class Program
{
    public static void Main()
    {

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