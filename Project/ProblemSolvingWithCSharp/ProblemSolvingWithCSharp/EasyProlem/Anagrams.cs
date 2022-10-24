using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProblemSolvingWithCSharp.EasyProlem
{
   public static class Anagrams
    {
        // --- Directions
        // Check to see if two provided strings are anagrams of eachother.
        // One string is an anagram of another if it uses the same characters
        // in the same quantity. Only consider characters, not spaces
        // or punctuation.  Consider capital letters to be the same as lower case
        // --- Examples
        //   anagrams('rail safety', 'fairy tales') --> True
        //   anagrams('RAIL! SAFETY!', 'fairy tales') --> True
        //   anagrams('Hi there', 'Bye there') --> False
        public static bool SOL1(string st,string st2)
        {
            string pa = @"[^0-9a-zA-Z:,]";
            var d = st.Replace(pa, string.Empty);
            st = Regex.Replace(st.ToLower(), pa, string.Empty);
            st2 = Regex.Replace(st2.ToLower(), pa, string.Empty);

            return String.Concat(st.OrderBy(c => c)).Equals(String.Concat(st2.OrderBy(x => x)));

          
        }
    }
}
