using System;
using System.IO;

namespace Class15b
{
    class Program
    {
        static void Main(string[] args)
        {
            var lastName = File.ReadAllText("response.txt");
            //var reader = new StreamReader("response.txt");
            //var lastName = reader.ReadLine();
            //reader.Close();
            //reader.Dispose()

            Console.WriteLine($"Last time you were {lastName}...");
            Console.WriteLine("Tell me your name...");
            var response = Console.ReadLine();

            File.WriteAllText("response.txt", response);
            //using (var writer = new StreamWriter("response.txt"))
            //{
            //    writer.Write(response);
            //    writer.Flush();
            //    writer.Close();
            //}
        }
    }
}
