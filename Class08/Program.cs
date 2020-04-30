using System;

namespace Class08
{
    class Program
    {
        static void Main(string[] args)
        {
            // Value vs Reference Types, parameters
            int[] footballNumbers = new int[] {56, 57 };
            Reset(footballNumbers);
            Console.WriteLine($"footballNumbers[0]={footballNumbers[0]},footballNumbers[1]={footballNumbers[1]}");

            int jason = 56;
            Reset(jason);
            Console.WriteLine(jason);

            // Value vs Reference Types, assignment
            int[] thisArray;
            thisArray = new int[] { 1, 2, 3 };
            int[] otherArray = thisArray;
            otherArray[0] = 56;
            thisArray = new int[3];
            Console.WriteLine($"thisArray[0]={thisArray[0]}, otherArray[0]={otherArray[0]}");

            int thisOne = 5;
            int otherOne = thisOne;
            otherOne++;
            Console.WriteLine($"number={thisOne}, other={otherOne}");
            
            // looping with a for loop

            //var numbers = new int[] {1, 2, 3 };
            //int[] numbers = { 1, 2, 3 };
            int[] number = new int[3];
            number[0] = 1;
            number[1] = 2;
            number[2] = 3;

            for (int i = 0; i < number.Length; i++)
            {
                // number[0]
                // number[1]
                // number[2]
                Console.WriteLine(number[i]);
            }

            // medium hand
            var nums = new int[] { 56, 57, 58 };
            Console.WriteLine(nums[0]);

            // short hand
            int[] numberz = { 56, 57, 58 };
            Console.WriteLine(numberz[0]);

            // long hand
            int[] numbers = new int[3];
            numbers[0] = 56;
            numbers[1] = 57;
            numbers[2] = 58;
            Console.WriteLine(numbers[0]);
        }

        static void Reset(int[] value)
        {
            for (int i = 0; i < value.Length; i++)
            {
                value[i] = default(int);
            }
        }

        static void Reset(int value)
        {
            value = 0;
            //value = default(int);
            //value = default;
        }
    }
}
