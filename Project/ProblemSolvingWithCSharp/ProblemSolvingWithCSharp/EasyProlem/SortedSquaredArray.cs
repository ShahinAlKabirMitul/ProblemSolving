using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingWithCSharp.EasyProlem
{
   public class SortedSquaredArray
    {
        public int[] SortedSquaredArrayS1(int[] array)
        {
            // Write your code here.
            int[] result = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                result[i] = array[i] * array[i];
            }
            Array.Sort(result);
            return result;
        }
    }
}
