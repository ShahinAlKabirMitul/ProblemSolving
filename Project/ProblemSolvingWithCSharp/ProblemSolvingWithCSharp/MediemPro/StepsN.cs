using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingWithCSharp.MediemPro
{
    // --- Directions
    // Write a function that accepts a positive number N.
    // The function should console log a step shape
    // with N levels using the # character.  Make sure the
    // step has spaces on the right hand side!
    // --- Examples
    //   steps(2)
    //       '# '
    //       '##'
    //   steps(3)
    //       '#  '
    //       '## '
    //       '###'
    //   steps(4)
    //       '#   '
    //       '##  '
    //       '### '
    //       '####'
    public static  class StepsN
    {
        public static string SOL1(int n)
        {
           
            string result = string.Empty;
            for (int i = 1; i <= n; i++)
            {
                result += GetHash(i)+GetSpace(n-i) + "\n";

            }
            return result;
        }

        public static string SOL2(int n)
        {

            string result = string.Empty;
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if(row >= col)
                    {
                        result += "#";
                    }
                    else
                    {
                        result += "-";
                    }
                  
                }
                result += "\n";

            }
            return result;
        }
        public static void SOL3(int n,int row =0,string result="")
        {
            if (row == n)
            {
                return;
            }
            if(n == result.Length)
            {
                Console.WriteLine(result);
                SOL3(n, row + 1);
                return;
            }
            if (result.Length <= row)
            {
                result += "#";
            }
            else
                result += "*";

            SOL3(n, row,result);
        }


        public static string GetHash(int n)
        {
            string str = string.Empty;
            for (int i = 0; i < n; i++)
            {
                str += "#";

            }
            return str;
        }
        public static string GetSpace(int n)
        {
            string str = string.Empty;
            for (int i = 0; i < n; i++)
            {
                str += "-";

            }
            return str;
        }
    }
}
