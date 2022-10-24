using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingWithCSharp.EasyProlem
{
    public static class FizzBuzz
    {
        // --- Directions
        // Write a program that console logs the numbers
        // from 1 to n. But for multiples of three print
        // “fizz” instead of the number and for the multiples
        // of five print “buzz”. For numbers which are multiples
        // of both three and five print “fizzbuzz”.
        // --- Example
        //   fizzBuzz(5);
        //   1
        //   2
        //   fizz
        //   4
        //   buzz
        const string buzz = "buzz";
        const string fizz = "fizz";

        public static string SOL1(int n)
        {
            string result = string.Empty;
            if(n % 3 == 0)
            {
                result = fizz;
            }
            if (n % 5 == 0)
            {
                if (string.IsNullOrEmpty(result))
                {
                    result = buzz;
                }
                else
                {
                    result = fizz + buzz;
                }
            }


            return result;
        }


        public static string SOL2(int n)
        {
            string result = string.Empty;
            for (int i = 1; i < n; i++)
            {
                if(i % 3 == 0 && i % 5 == 0)
                {
                    result += fizz + buzz;
                }
                else if(i % 3 == 0)
                {
                    result += fizz;
                }
                else if (i % 5 == 0)
                {
                    result += buzz;
                }
                
            }

            return result;
        }
    }
}
