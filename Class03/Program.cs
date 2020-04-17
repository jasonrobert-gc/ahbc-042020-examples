using System;

namespace Class03
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = "1234";
            int num = int.Parse(number);

            // StringBuilder
            var sb = new System.Text.StringBuilder();
            sb.Append("1");
            sb.Append(",2");
            sb.Append(",3");
            sb.Append(",4");
            sb.Append(",5");
            Console.WriteLine(sb.ToString());

            // Immunable Strings
            var test = "1";
            test = test + ",2";
            test = test + ",3";
            test = test + ",4";
            test = test + ",5";
            Console.WriteLine(test);
            return;

            // String Functions
            var company = "Tyler Technologies";
            Console.WriteLine(company.IndexOf('z'));
            Console.WriteLine(company.StartsWith("Tyler")); // True
            Console.WriteLine(company.EndsWith("ies"));   // True
            Console.WriteLine(company.Replace("T", "t"));
            Console.WriteLine(company.ToUpper());

            // Comparing String
            var first = "Jason";
            var second = "JASON";

            Console.WriteLine(first == second);
            Console.WriteLine(first.Equals(second));
            Console.WriteLine(first.Equals(second, StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(string.Compare(first, second, true));

            // String declaration
            char firstCharacter = 'j';
            var hello = "Hello";
            var world = "World";

            // Combining String
            var helloworld = hello + world;

            var name = "Jason";
            name += " Robert";
            // name = name + " Robert";

            var ta = "Kristy" + " " + "Currier";
            Console.WriteLine(ta);

            // Continue
            while (true)
            {
                Console.WriteLine("Before continue");
                continue;
                // This will never execute! Or will it????????????????????
                Console.WriteLine("After continue");
            }

            // Break
            while (1 == 1)
            {
                break;
                Console.WriteLine("We are going to see this a lot!");
            }

            // For loop
            for (var i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
