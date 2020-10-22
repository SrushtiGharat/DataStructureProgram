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

            Console.WriteLine("\n");
            Console.WriteLine("Enter the element to be searched");
            int data = Convert.ToInt32(Console.ReadLine());

            int position = list.SearchList(data);
            if(position == 0)
            {
                Console.WriteLine("No such element found");
            }
            else
            {
                Console.WriteLine("Element found at position " + position);
            }

        }
    }
}
