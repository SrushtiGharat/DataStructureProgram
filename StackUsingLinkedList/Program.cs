using System;
using DataStructureProgram;
namespace StackUsingLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Stack Program");
            Stack stack = new Stack();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);

            Console.WriteLine("Stack :");
            stack.Display();

            stack.Pop();
            Console.WriteLine("\n");
            Console.WriteLine("Stack :");
            stack.Display();

            Console.WriteLine("\n");
            stack.Peep();
            


        }
    }
}
