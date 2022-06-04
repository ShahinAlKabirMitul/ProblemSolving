using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingWithCSharp.EasyProlem
{
    class fibonacci
    {



        public static int GetNthFib1(int n)
        {
            // Write your code here.
            if (n == 1)
                return 0;
            else if (n == 2)
                return 1;
            else
                return GetNthFib1(n - 1) + GetNthFib1(n - 2);
            return -1;
        }

        public static int GetNthFib(int n)
        {
            // Write your code here.
            Dictionary<int, int> stores = new Dictionary<int, int>();
            stores.Add(1, 0);
            stores.Add(2, 1);
            return GetNthFib(n, stores);
        }
        public static int GetNthFib(int n, Dictionary<int, int> stores)
        {
            if (stores.ContainsKey(n))
                return stores[n];
            else
            {
                stores.Add(n, GetNthFib(n - 1, stores) + GetNthFib(n - 2, stores));
                return stores[n];
            }
        }
    }
}
