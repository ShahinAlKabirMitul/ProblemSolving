using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingWithCSharp.MediemPro
{
   public static class ChunkArray
    {
        public static  List<int[]> Sol1(int[]array,int size)
        {
            List<int[]> result = new List<int[]>();
            var t = array;
            int temp = 0;
            int[] kkr = new int[size];
            foreach (var item in array)
            {

                kkr[temp] = item;
                temp++;
                int last = array[array.Length - 1];
                

                if(size> array.Length)
                {
                    result.Add(array);
                    return result;
                }

                if(size == temp)
                {
                    result.Add(kkr);
                    temp = 0;
                    kkr = new int[size];
                }

                if (last == item && size > temp)
                {
                    result.Add(kkr);
                }

            }
            return result;
        }
    }
}
