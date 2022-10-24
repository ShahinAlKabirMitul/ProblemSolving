using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingWithCSharp.EasyProlem
{
    public static class TwoNumberSum
    {
        public static int[] TwoNumberSumSOL1(int[] array, int targetSum)
        {
            // Write your code here.


            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if ((array[i] + array[j]) == targetSum)
                        return new int[] { array[i], array[j] };
                }
            }
            return new int[0];
        }
        public static int[] TwoNumberSumSOL2(int[] array, int targetSum)
        {
            // Write your code here.
            HashSet<int> nums = new HashSet<int>();
            foreach (var i in array)
            {
                int value = targetSum - i;
                if (nums.Contains(value))
                {
                    return new int[] { value, i };
                }
                else
                {
                    nums.Add(i);
                }
            }
            return new int[0];
        }

        public static int[] TwoNumberSumSol3(int[] array, int targetSum)
        {
            // Write your code here.

            Array.Sort(array);
            int left = 0;
            int right = array.Length - 1;
            while (left < right)
            {
                int currentSum = array[left] + array[right];
                if (currentSum == targetSum)
                    return new int[] { array[left], array[right] };
                else if (currentSum < targetSum)
                {
                    left++;
                }
                else if (currentSum > targetSum)
                {
                    right--;
                }
            }
            return new int[0];
        }
    }
}
