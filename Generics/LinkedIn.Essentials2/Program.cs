using System.Diagnostics;

namespace LinkedIn.Essentials2
{
    public static class Program
    {
        public static void Main()
        {
            // To be implemented
        }

        public static void Swap(object first, object second)
        {
            object temp = second;
            second = first;
            first = temp;

            Debug.Assert(first != second);
        }
    }
}