using System;
using System.Drawing;

namespace DataStructureProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Data Structure Program");
            bool flag = true;
            int data;
            int position;
            LinkedList list = new LinkedList();
            while (flag)
            {
                
                Console.WriteLine("\n");
                Console.WriteLine("1.Add  Node\n2.Append Node\n3.Insert in between node\n4.Remove First node\n5.Remove Last node\n6.Search element\n7.Insert after node\n8.Delete an node\n9.Implement Sorted List\n10.Exit");
                Console.WriteLine("Enter Choice");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter elements to add");
                        data = Convert.ToInt32(Console.ReadLine());

                        list.AddNode(data);
                        Console.WriteLine("Linked list :");
                        list.Display();
                        break;

                    case 2:
                        Console.WriteLine("Enter elements to append");
                        data = Convert.ToInt32(Console.ReadLine());

                        list.AppendNode(data);
                        Console.WriteLine("Linked list :");
                        list.Display();
                        break;
                    case 3:
                        Console.WriteLine("Enter elements to insert");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the position");
                        position = Convert.ToInt32(Console.ReadLine());

                        if (position > list.size() || position < 1)
                        {
                            Console.WriteLine("Invalid position.Enter position less than "+list.size());
                            break;
                        }

                        list.InsertAtPosition(data, position);
                        Console.WriteLine("Linked list :");
                        list.Display();
                        
                        break;
                    case 4:
                        list.RemoveFirstElement();
                        Console.WriteLine("Linked list :");
                        list.Display();
                        break;
                    case 5:
                        list.RemoveLastElement();
                        Console.WriteLine("Linked list :");
                        list.Display();
                        break;
                    case 6:
                        Console.WriteLine("Enter Element to be searched");
                        data = Convert.ToInt32(Console.ReadLine());

                        position = list.SearchList(data);
                        if (position == 0)
                        {
                            Console.WriteLine("No element found");
                        }
                        else 
                        {
                            Console.WriteLine("Element found at position " + position);
                        }
                        break;
                    case 7:
                        Console.WriteLine("Enter Element after which node is to be added");
                        int data1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the element to be added");
                        int data2 = Convert.ToInt32(Console.ReadLine());
                        list.InsertUsingSearch(data2, data1);

                        Console.WriteLine("Linked list :");
                        list.Display();
                        break;
                    case 8:
                        Console.WriteLine("Enter the node to be deleted");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.DeleteANode(data);

                        Console.WriteLine("Linked list :");
                        list.Display();
                        break;
                    case 9:
                        SortedLinkedList sortedList = new SortedLinkedList();
                        sortedList.AddElement(56);
                        sortedList.AddElement(30);
                        sortedList.AddElement(70);
                        sortedList.AddElement(50);

                        sortedList.Display();
                        break;
                    case 10:
                        flag = false;
                        Environment.Exit(0);
                        break;


                }
            }
        }
    }
}
