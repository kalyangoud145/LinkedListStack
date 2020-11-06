using System;

namespace LinkedListStackDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListStack linkedListStack = new LinkedListStack();
            linkedListStack.Push(56);
            linkedListStack.Push(30);
            linkedListStack.Push(70);
            Console.WriteLine("*************");
            linkedListStack.Display();
        }
    }
}
