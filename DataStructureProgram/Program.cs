using System;
using System.Drawing;

namespace DataStructureProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Data Structure Program");
            SortedLinkedList sortedLinkedList = new SortedLinkedList();
            sortedLinkedList.AddElement(56);
            sortedLinkedList.AddElement(30);
            sortedLinkedList.AddElement(40);
            sortedLinkedList.AddElement(50);
            sortedLinkedList.AddElement(70);

            sortedLinkedList.Display();

        }
    }
}
