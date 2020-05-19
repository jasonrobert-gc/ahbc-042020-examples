using System;

namespace Class16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var one = Singleton.Instance();
            var two = Singleton.Instance();
            // var three = new Singleton();
        }
    }
}
