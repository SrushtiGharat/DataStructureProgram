using System;
using System.Drawing;

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

            list.InsertUsingSearch(40,56);
            list.DeleteANode(40);

            int size = list.size();

            Console.WriteLine("Size Of Linked List :" + size);

            Console.WriteLine("Linked List :");
            list.Display();

            Console.WriteLine("\n");
            

        }
    }
}
