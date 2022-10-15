using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingWithCSharp.EasyProlem
{
   public class MaxChar
    {
        public static string MaxCharSL01(string str)
        {
            char[] array = str.ToCharArray();
            Dictionary<char, int> result = new Dictionary<char, int>();

            foreach (var item in array)
            {
                if (result.ContainsKey(item))
                {
                    result[item] += 1;
                }
                else
                {
                    result.Add(item, 1);
                }

            }

           
           return result.OrderByDescending(x => x.Value).FirstOrDefault().Key.ToString();

           
        }

        public static string SOL2(string str)
        {
            char[] array = str.ToCharArray();
            Dictionary<char, int> result = new Dictionary<char, int>();

            foreach (var item in array)
            {
                if (result.ContainsKey(item))
                {
                    result[item] += 1;
                }
                else
                {
                    result.Add(item, 1);
                }

            }
            int maxValue = 0;
            string ctr = string.Empty;
            foreach (var item in result)
            {
                if (item.Value > maxValue)
                {
                    maxValue = item.Value;
                    ctr = item.Key.ToString();
                }
            }

            return ctr;
        }

       
    }
}
