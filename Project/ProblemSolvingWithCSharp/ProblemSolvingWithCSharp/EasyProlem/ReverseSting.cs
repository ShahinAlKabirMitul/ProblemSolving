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
        public static string GetReverse2(string str)
        {
            char[] charArray = str.ToCharArray();
            int lastIndex = str.Length - 1;
            var d = str.Length / 2;
            for (int i = 0; i< d ; i++)
            {
                var temp = charArray[i];
                charArray[i] = charArray[lastIndex];
                charArray[lastIndex] = temp;
                lastIndex--;
            }
            return new string(charArray);
        }

        public static string SOL3(string str)
        {
            string reverse = string.Empty;
            foreach (var item in str)
            {
                reverse = item + reverse;
            }
            return reverse;
        }


    }
}
