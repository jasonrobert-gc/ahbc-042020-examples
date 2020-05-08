using System;

namespace Exercise42
{
    class Program
    {
        static void Main(string[] args)
        {
            string response;
            do
            {
                var x = GetNumber("Enter an X coordinate: ");
                var y = GetNumber("Enter a Y coordinate: ");

                var point = new Point(x, y);
                Console.WriteLine($"You have created a point object ({point.X}, {point.Y})");

                Console.Write("Would you like to continue? (y/n): ");
                response = Console.ReadLine();
            } while (response.Equals("y", StringComparison.OrdinalIgnoreCase));
        }

        private static int GetNumber(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out var result))
                {
                    return result;
                }
                
                Console.WriteLine("You entered an non-integer! Try again!");
            } 
        }
    }
}
