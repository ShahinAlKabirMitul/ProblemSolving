using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingWithCSharp.MediemPro
{
  public static  class pyramid
    {

        public static void SOL1(decimal n)
        {
            
            for (int row = 0; row < n; row++)
            {
                string str = string.Empty;
                for (int col = 0; col < 2* n-1; col++)
                {
                    var mid = Math.Floor((2 * n - 1) / 2);
                    if (mid - row <= col && mid + row >= col)
                    {
                        str += "*";
                    }
                    else
                        str += " ";

                }
                Console.WriteLine(str);
            }
        }

        public static void SOL2(decimal n,int row=0,string str="")
        {
            if (row==n)
                return;
            if (str.Length == 2*n-1)
            {
                Console.WriteLine(str);
                SOL2(n, row + 1);
                return;
            }
            string add;
            var mid = Math.Floor((2 * n - 1) / 2);
            
           if(mid-row<= str.Length && mid+row>= str.Length)
            {
                add = "#";
            }
           else
            {
                add = " ";
            }
            SOL2(n, row, str + add);

        }
    }
}
