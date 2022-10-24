using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingWithCSharp.EasyProlem
{
   public static class Palindrome
    {

        public static bool Ispalindrome(string str)
        {
            string reverse = string.Empty;
            foreach (var item in str)
            {
                reverse = item + reverse;
            }

           return str.Contains(reverse);
            
        }
        public static bool SOL2(string str)
        {
            string reverse = string.Empty;
            char[] array = str.ToCharArray();
            int lastIndex = array.Length;
            for (int i = 0; i < array.Length / 2; i++,lastIndex--)
            {
                char temp = array[i];
                array[i] = array[lastIndex];
                array[lastIndex] = temp;

            }
            reverse = new string(array);
            return str.Contains(reverse);

        }

    }
}
