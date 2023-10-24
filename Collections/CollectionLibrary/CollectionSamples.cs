using Essentials2.Library;

namespace CollectionLibrary
{
    public static class CollectionSamples
    {
        private static List<Customer> customers;

        static CollectionSamples()
        {
            // initialize new customers and add to list
            customers = new List<Customer>();

            for (int i = 1; i < 11; i++)
            {
                customers.Add(
                new Customer()
                {
                    Id = i,
                    FirstName = i.ToString(),
                    LastName = "Customer",
                    CreateDate = new DateTime(2021, 10, i)
                });
            }
        }

        public static void Indexing()
        {
            // get an item at a specific index
            var customerThree = customers[2];
            Console.WriteLine($"Found customer {customerThree.Id} at index 2");

            // check if a collection containts and item
            string doesContain = customers.Contains(customerThree) ? "does" : "doesn't";
            Console.WriteLine($"Customers {doesContain} contain this customer.");
            // FOLLOW UP: What if you created a new customer object with the same property values?
            // FOLLOW UP: Same as before, but what if customer was a record type or value type instead of a class?

            // use a pricate to find an item in the collection
            var customerSeven = customers.Find(CustomerIsMatch);

            if (customerSeven != null)
            {
                Console.WriteLine($"Found customer {customerSeven.Id}");
            }
            else
            {
                Console.WriteLine("No customer found with that ID.");
            }
        }

        private static bool CustomerIsMatch(Customer customer)
        {
            return customer.Id == 7;
            // FOLLOW UP: What happens if your expression matches more than one item?
        }

        public static void Queue()
        {
            var q = new System.Collections.Generic.Queue<string>();
            q.Enqueue("FirstItem");
            q.Enqueue("SecondItem");

            string? item = null;

            Console.WriteLine("Using a Queue");

            while ((item = q.Dequeue()) != null)
            {
                Console.WriteLine(item);

                if (q.Count <= 0)
                {
                    break;
                }
            }
        }

        public static void Stack()
        {
            var stk = new System.Collections.Generic.Stack<string>();

            stk.Push("FirstItem");
            stk.Push("SecondItem");

            string? stkItem = null;

            Console.WriteLine();
            Console.WriteLine("Using a Stack");

            while ((stkItem = stk.Pop()) != null)
            {
                Console.WriteLine(stkItem);

                if (stk.Count <= 0)
                {
                    break;
                }
            }

        }

    }
}