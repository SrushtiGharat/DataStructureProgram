using System;

namespace QueueUsingLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Queue Program");
            Queue queue = new Queue();
            queue.Enqueue(53);
            queue.Enqueue(30);
            queue.Enqueue(70);

            Console.WriteLine("Queue :");
            queue.Display();
            queue.size();

            queue.Dequeue();
            Console.WriteLine("Queue after dequeue:");
            queue.Display();
            queue.size();
        }
    }
}
