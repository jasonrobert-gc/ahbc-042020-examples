using System;

namespace Class01
{
    class Program
    {
        public static void Main(string[] args)
        {
            // while loop
            var num = 2;
            while (num < 5)
            {
                Console.WriteLine("Heeeeeeeey yoooooou guuuuuuys!");
                num++;
            }

            return;

            // do loop
            do
            {
                Console.WriteLine("Heeeeeeeey yoooooou guuuuuuys!");
                num++;
            }while(num < 5);

            // switch statement
            switch (num)
            {
                case 1:
                    Console.WriteLine("Yaaaaay its one!");
                    break;
                case 2:
                    Console.WriteLine("It is two :(");
                    num = 5;
                    break;
                default:
                    Console.WriteLine("The number is something else");
                    break;
            }

            // if statement
            if (num == 1)
            {
                Console.WriteLine("Yaaaaay its one!");
            }
            else if (num == 2)
            {
                Console.WriteLine("It is two :(");
                num = 5;
            }
            else
            {
                Console.WriteLine("The number is something else");
            }

            // Relational Operators
            Console.WriteLine(1 == 1); // True
            Console.WriteLine(1 == 0); // False
            Console.WriteLine(1 > 0); // True
            Console.WriteLine(1 < 0); // False
            Console.WriteLine(1 <= 0); // False
            Console.WriteLine(1 != 0); // True

            // Logical Operators
            var jason = 56;
            var mak = 3;
            var kristy = 2;
            var rebecca = 6;

            // C# Short Circuits!
            Console.WriteLine(jason > mak && rebecca > kristy);
            Console.WriteLine(jason > mak || rebecca > kristy);

            // Implicit Cast
            int number = 5;
            long lumber = number;
            Console.WriteLine(number == lumber);

            // Explicit Cast
            long lumber2 = 22000000000;
            int number2 = (int)lumber2;
            Console.WriteLine(number2);

            // Overflow
            //                                 11111111111111111111111111111111
            //                                 00000000000000000000000000000000
            // 1111111111111111111111111111111111111111111111111111111111111111
            // 0000000000010000100000000000000100000000000000000100000100000000

            // Arithmatic 
            int myNumber = 5;
            myNumber = myNumber + 1;
            myNumber++;
            myNumber += 1;
            myNumber = myNumber - 1;
            myNumber--;
            myNumber -= 1;
            Console.WriteLine(myNumber);

            // Prints 1 because 1 is the remainder of 10 / 3
            Console.WriteLine(10 % 3);

            // This won't work because assignments should go right to left
            // 1 + 1 = myNumber;

            // Single line comment

            /*
               Multi 

                line 

                comment
            */

            /*
            Console

                .WriteLine(

                "What is your name?"

                );
            */

            // The above statement is the same as below.
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            Console.WriteLine(name);

            // Variables

            // Variable Declaration
            int myFavoriteNumber;

            // Variable Initialization
            myFavoriteNumber = 3;

            // Joining Declaration and Initialization into one statement
            int myFavoriteNumber2 = 3;

            // Using 'var' is super cool, brah
            var myFavoriteNumber3 = 3;
            myFavoriteNumber3 = 5;

            const int myFavoriteNumber4 = 4;
            // cannot assign to a const like this
            // myFavoriteNumber4 = 6;
        }
    }
}
