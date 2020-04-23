using System;
using System.Linq;

namespace Class05.JrExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new[] {1, 2, 3, 4, 5 };
            int number;
            do
            {
                Console.Write("Enter a number:");
            } while (!int.TryParse(Console.ReadLine(), out number));

            Console.WriteLine(BinarySearch(array, number));
        }

        private static bool BinarySearch(int[] array, int number)
        {
            var middle = array.Length / 2;
            if (array[middle] == number)
            {
                return true;
            }
            else if (array[middle] > number)
            {
                return BinarySearch(Left(array), number);
            }
            else 
            {
                return BinarySearch(Right(array), number);
            }
        }

        private static int[] Left(int[] array)
        {
            return array.Take(array.Length / 2).ToArray();
        }

        private static int[] Right(int[] array)
        {
            return array.Skip(array.Length / 2).ToArray();
        }

    }
}
