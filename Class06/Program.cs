using System;

namespace Class06
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter a number pleeeeeease: ");
                    string input = Console.ReadLine();
                    if (input.Equals("N", StringComparison.OrdinalIgnoreCase))
                    {
                        break;
                    }

                    var number = int.Parse(input);
                    DisplayNumber(number);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Format Boom! {ex}");
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine($"The argument was out of range! {ex}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Boom! {ex}");
                }
            }
        }

        public static void DisplayNumber(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(number));
            }

            Console.WriteLine($"Here is your number - {number}");
        }
    }
}
