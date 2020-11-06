using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListStackDemo
{
    /// <summary>
    /// Stack implementation class
    /// </summary>
    class LinkedListStack
    {
        private Node top;
        public LinkedListStack()
        {
            this.top = null;
        }
        /// <summary>
        /// Adds elements to the stack
        /// </summary>
        /// <param name="data"></param>
        public void Push(int data)
        {
            Node node = new Node(data);

            if (this.top == null)
            {
                this.top = node;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine("{0} pushed to stack ", data);
        }
        /// <summary>
        /// Displays the elements in the stack
        /// </summary>
        public void Display()
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.Write(temp.data + "\n");
                temp = temp.next;
            }
        }
    }
}
