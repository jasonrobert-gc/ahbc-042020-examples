using System;
using System.Runtime.InteropServices;

namespace MockAssessment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Town town = new Town();
            var result = town.SurviveTheWinter();

            Console.WriteLine(result);
        }
    }
}
