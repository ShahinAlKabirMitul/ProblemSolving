using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingWithCSharp.EasyProlem
{
   public static class Capitalize
    {

        public static string SOL1(string str)
        {
            StringBuilder result = new StringBuilder();
            var items = str.Split(" ");
            foreach (var item in items)
            {
                if (item != string.Empty)
                {
                    result.Append(CapitalizeFirst(item));

                    result.Append(" ");
                }

            }
            return result.ToString().Trim();
        }
        private static string CapitalizeFirst(string input)
        {
            
            if (input.Length > 2)
                return char.ToUpper(input[0]) + input[1..].ToLower();
            else
                return input.ToLower();
        }
    }
}
