using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListStackDemo
{
    /// <summary>
    /// Queue implementation methods
    /// </summary>
    class LinkedListQueue
    {
        Node head = null;
        /// <summary>
        /// Enqueues the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        public void Enqueue(int data)
        {
            Node node = new Node(data);
            if (head == null)
                head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into queue ", node.data);
        }
        /// <summary>
        /// Method for removing elements from beginning
        /// </summary>
        public void DeQueue()
        {
            if (head == null)
            {
                Console.WriteLine("Queue is Empty");
            }
            else
            {
                Console.WriteLine(head.data + " removed from Queue");
                head = head.next;
            }
        }
        /// <summary>
        /// Displays the elements of the queue
        /// </summary>
        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("Queue is Empty");
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    Console.Write(temp.data + "\n");
                    temp = temp.next;
                }
                Console.Write(temp.data + "");
            }
        }
    }
}
