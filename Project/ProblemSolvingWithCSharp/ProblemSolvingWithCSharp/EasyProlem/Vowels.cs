using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProblemSolvingWithCSharp.EasyProlem
{

    // --- Directions
    // Write a function that returns the number of vowels
    // used in a string.  Vowels are the characters 'a', 'e'
    // 'i', 'o', and 'u'.
    // --- Examples
    //   vowels('Hi There!') --> 3
    //   vowels('Why do you ask?') --> 4
    //   vowels('Why?') --> 0
    internal static class Vowels
    {

        public static int SOL1(string str)
        {
            char[] vowels = new char[]
            {
               'a','e','i','o','u'
            };
            var count = str.ToLower().Count(x => vowels.Contains(x));

            return count;
        }

        public static int SOL2(string str)
        {
           
            var regex = new Regex(@"[aeiou]",RegexOptions.IgnoreCase).Matches(str);
            return regex.Count;
        }
        public static int SOL3(string[] words,int left,int right)
        {
            
            int count = 0;
            for (int i = left; i <= right; i++)
            {
                var str = words[i];
                int n = str.Length-1;
                if (IsVowel(str[0]) && IsVowel(str[n]))
                {
                    count++;
                }
            }
           
            

            return count;
        }

        private static bool IsVowel(char ch)
        {
            char[] vowels = new char[]
            {
                'a','e','i','o','u'
            };
            return vowels.Contains(ch) ;
        }
    }
}
