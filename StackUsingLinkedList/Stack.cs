﻿using System;
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
        public void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Node temp = this.top;
            top = top.next;
            
        }
        public void Peep()
        {
            if(top == null)
            {
                Console.WriteLine("Stack is null");
            }
            Console.WriteLine("Peep :" + top.data);
        }
        public void size()
        {
            int count = 0;
            Node temp = top;
            if (temp == null)
            {
                Console.WriteLine("Stack is Empty");
            }
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }
            Console.WriteLine("Size :" + count);
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
                Console.WriteLine("\n");
            }
        }
    }
}
