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
            List<int[]> chunked = new List<int[]>();
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
                    chunked.Add(array);
                    return chunked;
                }

                if(size == temp)
                {
                    chunked.Add(kkr);
                    temp = 0;
                    kkr = new int[size];
                }

                if (last == item && size > temp)
                {
                    chunked.Add(kkr);
                }

            }
            return chunked;
        }

        public static int[] SOl2(int[] array, int size)
        {
            int[] chunked = new int[array.Length]; 
            int index = 0;
            while (index < array.Length)
            {
                Array.Copy(array, chunked, index + size);
                index += size;
            }
            return chunked;
        }



    }
}
