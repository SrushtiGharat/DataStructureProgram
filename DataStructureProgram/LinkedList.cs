using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureProgram
{
    class LinkedList
    {
        internal Node head;
         internal void AddNode(int data)
        {
            Node node = new Node(data);
            if(head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while(temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
        }

        internal void Display()
        {
            if(this.head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            else
            {
                Node temp = head;
                while(temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
            }
        }
    }
}
