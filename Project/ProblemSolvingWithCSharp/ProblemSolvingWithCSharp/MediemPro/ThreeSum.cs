using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingWithCSharp.MediemPro
{
   public static class ThreeSum
    {
        public static List<int[]> ThreeNumberSum(int[] array, int targetSum)
        {
            // Write your code here.
            Array.Sort(array);
            List<int[]> result = new List<int[]>();
            for (int i = 0; i < array.Length-2; i++)
            {
                int left = i+1;
                int right = array.Length - 1;
                while (left < right)
                {
                    int currentSum = array[i] + array[left] + array[right];
                    if (currentSum == targetSum)
                    {
                        int[] myResult = { array[i], array[left], array[right] };
                        result.Add(myResult);
                        left++;
                        right--;
                    }
                    else if (currentSum < targetSum)
                        left++;
                    else if (currentSum > targetSum)
                        right--;
                }
            }
            
            return new List<int[]>();
        }
    }
}
