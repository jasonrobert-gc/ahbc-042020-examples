using System;
using System.Text.RegularExpressions;

namespace Class04
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isValid;
            int num;
            do
            {
                Console.WriteLine("Enter a number: ");
                isValid = int.TryParse(Console.ReadLine(), out num);
                if (!isValid)
                {
                    Console.WriteLine("Not a number");
                }
            } while (!isValid);
            

            // height
            for (int i = 0; i < num; i++)
            {
                // spaces
                for (int j = 0; j < num - i; j++)
                {
                    Console.Write(" ");
                }

                // width
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                
                Console.WriteLine();
            }

            return;

            // Regular Expressions
            var regex = new Regex(@"^[0-9]{5}(?:-[0-9]{4})?$");
            bool isMatch;
            do
            {
                Console.Write("Enter a zip code: ");
                isMatch = regex.IsMatch(Console.ReadLine());
            } while (!isMatch);

            return;

            var result = Regex.IsMatch("1234", @"^[0-9]{5}(?:-[0-9]{4})?$");
            if (result)
            {
                Console.WriteLine("MATCH!");
            }
            return;

            // Validating numeric strings
            int number;
            bool valid;

            do
            {
                Console.Write("Enter a number: ");
                var response = Console.ReadLine();
                isValid = int.TryParse(response, out num);
            } while(!isValid);

            Console.WriteLine("Your number is " + num); // String concatenation
            Console.WriteLine(string.Format("Your number is {0}", num)); // Not used anymore
            Console.WriteLine($"Your number is {num}"); // String interpolation, preferred
        }
    }
}
