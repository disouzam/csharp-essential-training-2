namespace CollectionLibrary
{
    public class CollectionSamples
    {
        public static void Queue()
        {
            var q = new System.Collections.Queue();
            q.Enqueue("FirstItem");
            q.Enqueue("SecondItem");

            string? item = null;

            Console.WriteLine("Using a Queue");

            while (( item = (string?)q.Dequeue()) != null ) 
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
            var stk = new System.Collections.Stack();

            stk.Push("FirstItem");
            stk.Push("SecondItem");

            string? stkItem = null;

            Console.WriteLine();
            Console.WriteLine("Using a Stack");

            while((stkItem = (string?)stk.Pop()) != null)
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