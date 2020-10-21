using System;

namespace DataStructureProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Data Structure Program");
            LinkedList list = new LinkedList();
            list.AddNode(56);
            list.AddNode(30);
            list.AddNode(70);

            Console.WriteLine("Linked List :");
            list.Display();

        }
    }
}
