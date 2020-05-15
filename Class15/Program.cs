using System;
using System.IO;

namespace Class15
{
    class Program
    {
        static void Main(string[] args)
        {
            // Things that are external to .NET typically will implement IDisposable.  This give 
            // the object the Dispose() method to clean up memory and other object.
            var reader = new StreamReader("user.config");
            var line = reader.ReadLine();
            if (line != null)
            {
                if (Enum.TryParse<Day>(line, out var lastDay))
                {
                    Console.WriteLine($"Last time you selected a {lastDay}! What will you select this time?");
                }
            }
            reader.Close();
            reader.Dispose();

            Day day;
            do
            {
                Console.Write("Enter a day: ");
            } while (!Enum.TryParse<Day>(Console.ReadLine(), out day));

            Console.WriteLine($"Is {day} a weekend? {IsWeekend(day)}");

            // The using statment tells .NET to make sure the object is DISPOSED.
            // Otherwise you have to call Dispose on your own!
            // Using is always preferred.
            using(var writer = new StreamWriter("user.config"))
            {
                writer.Write((int)day);
                writer.Flush();
                writer.Close();
            }

            // Using a stream is the most effecient (especially with large files) but we can also use the static File methods.
            File.WriteAllText("Somedata.txt", "asdfasdfasdfasdfasdfasdfasdfasdf");
            Console.WriteLine(File.ReadAllText("Somedata.txt"));

            // I can also manipulate files with other static File methods.
            File.Delete("Somedata.txt");
        }

        static bool IsWeekend(Day day)
        {
            if (day == Day.Saturday || day == Day.Sunday)
            {
                return true;
            }

            return false;
        }
    }
}
