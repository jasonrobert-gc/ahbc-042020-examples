using System;
using System.Collections;
using System.Collections.Generic;

namespace Class10
{
    class Program
    {
        static void Main(string[] args)
        {
            // NON-Generic, don't use
            // Bad for two reason.  Never use these
            // 1. You don't know what is in there (no type safety)
            // 2. Leads to "boxing" copying value types to/from the heap
            var arraylist = new ArrayList();
            arraylist.Add(132);
            arraylist.Add("asdfasdf");

            // Always use the generic collections!

            // Queue
            var queue1 = new Queue<int>();
            queue1.Enqueue(56);
            queue1.Enqueue(57);
            queue1.Enqueue(58);
            Console.WriteLine(queue1.Dequeue()); // 56
            Console.WriteLine(queue1.Dequeue()); // 57
            Console.WriteLine(queue1.Dequeue()); // 58

            // Stack
            var stack1 = new Stack<int>();
            stack1.Push(56);
            stack1.Push(57);
            stack1.Push(58);
            Console.WriteLine(stack1.Pop()); // 58
            Console.WriteLine(stack1.Pop()); // 57
            Console.WriteLine(stack1.Pop()); // 56

            // Dictionaries - Creating, Adding, Displaying
            var dictionary = new Dictionary<int, string>();
            dictionary.Add(57, "Jason's old football number");
            Console.WriteLine(dictionary[57]);

            //// With an int[] for Patrick
            //var numbers = new Dictionary<string, int[]>();
            //numbers.Add("Football", new int[] { 56, 57 });
            //numbers.Add("Year", new int[] { 2020, 2021, 2022 });
            //for (int i = 0; i < numbers["Year"].Length; i++)
            //{
            //    Console.WriteLine(numbers["Year"][i]);
            //}

            var numbers = new Dictionary<string, List<int>>();
            numbers.Add("Football", new List<int> { 56, 57 });
            numbers.Add("Year", new List<int> { 2020, 2021, 2022 });
            numbers["Year"].Add(2023);
            numbers["Year"].Add(2024);
            for (int i = 0; i < numbers["Year"].Count; i++)
            {
                Console.WriteLine(numbers["Year"][i]);
            }

            //// Dictionaries - Addl functions
            //// numbers.Add("Year", new int[] { 1999, 2000 });
            //numbers.TryAdd("Year", new int[] { 1999, 2000 });

            // Looping through a list with foreach
            var list5 = new List<int> { 1, 2, 4, 8, 16, 32 };
            Console.WriteLine("With a foreach...");
            foreach (var number in list5)
            {
                Console.WriteLine(number);
            }

            // Looping through a list with for
            Console.WriteLine("With a for...");
            for (int i = 0; i < list5.Count; i++)
            {
                var number = list5[i];
                Console.WriteLine(number);
            }
            
            // List methodsssssssssssssssssssssssssssssss
            var list4 = new List<int>();
            list4.Add(57);
            list4.Remove(57); // list4.Clear(); list4.RemoveAt(0);
            Console.WriteLine(list4.Count);

            // Adding to my list
            List<int> list = new List<int>();
            Console.WriteLine($"List length = {list.Count}");
            list.Add(56); // list[0]
            Console.WriteLine($"List length = {list.Count}");
            list.Add(57); // list[1]
            Console.WriteLine($"List length = {list.Count}");
            list.Add(58); // list[2]
            Console.WriteLine($"List length = {list.Count}");

            // Retrieving values from my list
            list[0] = 200;
            Console.WriteLine($"list[0] = {list[0]}");

            // Why var?
            var crazyThing = new List<List<List<int[]>>>();

            // Short-hand
            List<int> list3 = new List<int> { 56, 57, 58 };

            // Medium-hand
            List<int> list2 = new List<int>();
            list2.Add(56);
            list2.Add(57);
            list2.Add(58);

            // Long-hand
            List<int> list1;
            list1 = new List<int>();
            list1.Add(56);
            list1.Add(57);
            list1.Add(58);

            // Declaring an array vs a list
            int[] myArray;
            List<int> myList;

            // Initializing an array vs a list
            myArray = new int[5];
            myList = new List<int>();
        }
    }
}
