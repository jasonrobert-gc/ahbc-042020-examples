using System;
using System.Collections.Generic;
using System.Text;

namespace Class29
{
    public class FizzBuzzWoof
    {
        public string GetDisplayValue(int value)
        {
            var message = string.Empty;
            
            if (Check(3, value))
            {
                message += "Fizz";
            }
            if (Check(5, value))
            {
                message += "Buzz";
            }
            if (Check(7, value))
            {
                message += "Woof";
            }

            return message;
        }

        private bool Check(int checkValue, int actualValue)
        {
            return actualValue % checkValue == 0 || $"{actualValue}".Contains($"{checkValue}");
        }
    }
}
