using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingWithCSharp.EasyProlem
{
    class ValidateSubsequence
    {

        public static bool IsValidSubsequence(List<int> array, List<int> sequence)
        {
            // Write your code here.
            int arrayLength = 0;
            int seqLength = 0;
            while (arrayLength < array.Count && seqLength < sequence.Count)
            {
                if (array[arrayLength] == sequence[seqLength])
                {
                    seqLength++;
                }
                else
                    arrayLength++;
            }
            return seqLength == sequence.Count;
        }
        void a()
        {

        }
        public static bool IsValidSubsequenceSN2(List<int> array, List<int> sequence)
        {
            // Write your code here.
            bool isMatch = false;
            foreach (var sq in sequence)
            {
                isMatch = array.Contains(sq);
                if (!isMatch)
                {
                    break;
                }
                // if
            }
            return isMatch;
        }
        public static bool IsValidSubsequenceSL3(List<int> array, List<int> sequence)
        {
            // Write your code here.
            int seqIndex = 0;

            foreach (var v in array)
            {
                if (seqIndex == sequence.Count)
                    break;
                if (sequence[seqIndex] == v)
                    seqIndex++;
            }
            return seqIndex == sequence.Count;
        }
    }
}
