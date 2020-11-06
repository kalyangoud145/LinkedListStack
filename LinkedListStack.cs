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
        /// Method for getting the top element 
        /// </summary>
        public void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("stack is empty");
            }
            Console.WriteLine("\n{0} is in the top of the stack", this.top.data);
        }
        /// <summary>
        /// Method gets top most element and removes that.
        /// </summary>
        public void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("stack is empty");
                return;
            }
            Console.WriteLine("\nValue popped is {0} ", this.top.data);
            this.top = this.top.next;
        }
        /// <summary>
        /// Method Performs peek and pop operation till the stack is empty
        /// </summary>
        public  void IsEmpty()
        {
            while (this.top != null)
            {
                Peek();
                Pop();
            }
            Console.WriteLine("Stack is empty now.");
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
