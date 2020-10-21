using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureProgram
{
    public class LinkedList
    {
       public Node head;
        public void AddNode(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = node;
                temp.next = head;
                head = temp;
            }

        }
        public void AppendNode(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
        }

        public  void InsertAtPosition(int data,int position)
        {
            Node node = new Node(data);
            if(this.head == null)
            {
                Console.WriteLine("List is empty");
            }
            Node temp = head;
            for(int i = 1; i < position-1; i++)
            {
                temp = temp.next;
            }
            node.next = temp.next;
            temp.next = node;
            
        }

        public Node RemoveFirstElement()
        {
            if(this.head == null)
            {
                Console.WriteLine("List is empty");
                return null;
            }
            Node temp = this.head;
            head = head.next;
            temp.next = null;
            return head;
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
