using System;
using System.Collections.Generic;

namespace Class26
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> linkedList = new LinkedList<string>();
            linkedList.AddFirst("World");
            linkedList.AddFirst("Hello");
            
            var first = linkedList.First; // "Hello"
            var second = first.Next; // "World"

            Console.WriteLine("Hello World!");
        }
    }
}
