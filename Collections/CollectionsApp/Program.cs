using CollectionLibrary;

namespace CollectionsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CollectionSamples.Queue();
            CollectionSamples.Stack();

            CollectionSamples.Indexing();
            return;

            string[] names = new string[2];

            names[0] = "matt";
            names[1] = "milner";

            Console.WriteLine("Hello {0} {1}", names);

            var al = new System.Collections.ArrayList(2);
            al.Add("First");
            al.AddRange(new string[] { "Second", "Third", "Fourth" });

            Console.WriteLine($"Collection size is {al.Count}");
            Console.WriteLine("Indexed item from collection [2]: {0}", al[2]);
            Console.WriteLine("All items in the list:");

            foreach (var item in al)
            {
                Console.WriteLine(item);
            }            
        }
    }
}