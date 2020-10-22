using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureProgram
{
    public class SortedLinkedList
    {
        public Node head;
        public void AddElement(int data)
        {
            Node node = new Node(data);
            if(head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                if(head.data > data)
                {
                    node.next = head;
                    head = node;
                }
                else
                {
                    while(temp.next != null)
                    {
                        if (temp.next.data < data)
                            temp = temp.next;
                        else
                        {
                            node.next = temp.next;
                            temp.next = node;
                            return;
                        }
                    }
                    temp.next = node;
                }
            }
        }
        public void Display()
        {
            if (this.head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            else
            {
                Node temp = head;
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
            }
        }
    }
}
