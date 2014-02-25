using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzzClass
{
    public class FizzBuzz
    {
        public string GetOutput(int dividend)
        {
            if (dividend % 15 == 0)
                return "fizzbuzz";
            if (dividend % 5 == 0)
                return "buzz";
            if (dividend % 3 == 0)
                return "fizz";
            return dividend.ToString();
        }

        public string GetOutputString(int start, int end)
        {
            string output = "";
            for (int i = start; i <= end; i++)
            {
                output += GetOutput(i) + " ";
            }
            return output.Trim();
        }
    }
}
