using System;
using System.Collections.Generic;
using System.Text;
using DataStructureProgram;
namespace QueueUsingLinkedList
{
    class Queue
    {
        Node front;
        public void Enqueue(int data)
        {
            Node node = new Node(data);
            if (front == null)
            {
                this.front = node;
            }
            else
            {
                Node temp = front;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
        }

        public void Display()
        {
            if (this.front == null)
            {
                Console.WriteLine("Queue  is empty");
                return;
            }
            else
            {
                Node temp = front;
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
                Console.WriteLine("\n");
            }
        }
    }
}
