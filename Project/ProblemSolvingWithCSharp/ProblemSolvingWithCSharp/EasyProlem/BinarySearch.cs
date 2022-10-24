using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingWithCSharp.EasyProlem
{
    class BinarySearchCS
    {
        public static int BinarySearch(int[] array, int target)
        {
            // Write your code here.
            // test
            // sdkhcsd skadjfksladhfß
            return BinarySearch(array, target, 0, array.Length - 1);
        }

        public static int BinarySearch(int[] array, int target, int left, int right)
        {
            if (left > right)
            {
                return -1;
            }
            int middle = (left + right) / 2;
            int potensiatMatch = array[middle];
            if (potensiatMatch == target)
                return middle;
            else if (target < potensiatMatch)
            {
                return BinarySearch(array, target, left, middle - 1);
            }
            else
            {
                return BinarySearch(array, target, middle + 1, right);
            }
        }

        public static int BinarySearch01(int[] array, int target, int left, int right)
        {
            while (left <= right)
            {
                int middle = (left + right) / 2;
                int potentialMatch = array[middle];
                if (potentialMatch == target)
                    return middle;
                else if (target > potentialMatch)
                {

                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }
            }
            return -1;
        }
    }
}
