using System;

namespace DataStructureProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Data Structure Program");
            LinkedList list = new LinkedList();
            list.AddNode(70);
            list.AddNode(56);
            list.InsertAtPosition(30, 2);

            Console.WriteLine("Linked List :");
            list.Display();

        }
    }
}
