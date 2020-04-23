using System;

namespace Class05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(7));

            Log(IsEven(6).ToString());
            Log(IsEven(2, 3).ToString());
            Log("Hello World!");

            int num1 = 5;
            int num2 = 6;

            Console.WriteLine(Add(num1, num2));  // 6
            Console.WriteLine(num1); // 0, 5
            Console.WriteLine(num2); // 6

            bool result = TryAdd(num1, num2, out int sum);
            Console.WriteLine($"Result {result} and Sum {sum}");
        }

        public static bool IsEven(int number)
        {
            bool result = number % 2 == 0;
            return result;
        }

        public static bool IsEven(int number, int number2)
        {
            return IsEven(number) && IsEven(number2);
        }

        public static void Log(string message)
        {
            Console.WriteLine(message);
        }

        public static int Add(int num1, int num2)
        {
            num1 = 0;
            return num1 + num2;
        }

        public static bool TryAdd(int num1, int num2, out int sum)
        {
            sum = 0;

            if (num1 < 0 && num2 < 0)
            {
                return false;
            }

            sum = num1 + num2;
            return true;
        }

        public static int Factorial(int number)
        {
            // Stop condition
            if (number == 1)
            {
                return 1;
            }

            // Recusion
            return number * Factorial(number - 1);
        }

        /*
         * 7 * (Factorial)
         * 
         *      6 * (Factorial)
         *      
         *          5 * (Factorial)
         *          
         *              4 * (Factorial) 
         *              
         *                  3 * (Factorial)
         *                  
         *                      2 * (Factorial)
         *                      
         *                          1
         */
    }
}
