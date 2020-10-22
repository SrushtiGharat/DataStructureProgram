using System;
using System.Collections.Generic;
using DataStructureProgram;
using System.Text;

namespace StackUsingLinkedList
{
    class Stack
    {
        Node top;
        public void Push(int data)
        {
            Node node = new Node(data);
            if (top == null)
            {
                this.top = node;
            }
            else
            {
                Node temp = node;
                temp.next = top;
                top = temp;
            }
        }
        public void Display()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            else
            {
                Node temp = top;
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
            }
        }
    }
}
