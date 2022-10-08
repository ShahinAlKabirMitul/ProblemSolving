using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingWithCSharp.EasyProlem
{
   public static class ReverseSting
    {
        public static string GetReverse(string str)
        {
            char[] charArray = str.ToCharArray();
            for (int i = 0, j = str.Length - 1; i < j; i++,j--)
            {
                charArray[i]= str[j];
                charArray[j] = str[i];
            }
            return new string(charArray);
        }
    }
}
