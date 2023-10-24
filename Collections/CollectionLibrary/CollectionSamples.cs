namespace CollectionLibrary
{
    public class CollectionSamples
    {
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