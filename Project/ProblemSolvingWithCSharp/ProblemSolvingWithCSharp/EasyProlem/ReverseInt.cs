using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingWithCSharp.EasyProlem
{
   public static class ReverseInt
    {
        public static int ReverseINT(int input)
        {
            var str = input.ToString();
            string result = string.Empty;
            foreach (var item in str)
            {
               if(item.ToString() != "-")
                {
                    result = item + result;
                }
                
               
            }
            if (input<0)
            {
                return int.Parse(result) * -1;
            }
            return Convert.ToInt32(result);
        }

        public static int ReverseINT2(int input)
        {
            var str = input.ToString();
            if (input < 0)
            {
                str = str.Remove(0,1);
            }
            return  int.Parse(str.Reverse().Aggregate("", (s, c) => s+c));
           
            
        }
    }
}
