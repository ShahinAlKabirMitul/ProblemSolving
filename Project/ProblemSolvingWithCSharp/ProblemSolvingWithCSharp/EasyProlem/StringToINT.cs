using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProblemSolvingWithCSharp.EasyProlem
{
   public static class StringToINT
    {

        public static int SOL1(string s)
        {
            int myvalue = 0;
            s = s.Replace("^\\s+", "");
            bool isNegative = s.StartsWith("-");
            // Flag to indicate if the number is positive
            bool isPositive = s.StartsWith("+");
            var resultString = Regex.Match(s, @"\d").Value;

            int.TryParse(s, out myvalue);

            return isNegative ? -myvalue : myvalue;


        }
    }
}
