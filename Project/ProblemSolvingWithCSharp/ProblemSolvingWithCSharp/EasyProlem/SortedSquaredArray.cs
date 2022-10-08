using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingWithCSharp.EasyProlem
{
   public static class SortedSquaredArray
    {
        public static int[] SortedSquaredArrayS1(int[] array)
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

        public static int[] Sol2(int[] array)
        {

            int [] result = new int[array.Length];
            int i = 0;
            foreach (var item in array)
            {
               
                result[i] = item * item;
                i++;
            }
            Array.Sort(result);
            return result;
        }

        public static int[] Sol3(int[] array)
        {

            int[] result = new int[array.Length];
            int i = array.Length-1;
            while (i >= 0)
            {
                result[i] = array[i] * array[i];
                i--;
            }

            Array.Sort(result);
            return result;
        }
    }
}
