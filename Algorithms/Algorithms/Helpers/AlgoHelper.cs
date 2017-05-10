using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Helpers
{
    public static class AlgoHelper
    {
        public static void SwapInt(ref int a, ref int b)
        {
            //may be need to use ref
            //a = a + b;
            //b = a - b;
            //a = a - b;
            int temp = a;
            a = b;
            b = temp;

            //using xorswap
            //if (a != b)
            //{
            //    a ^= b;
            //    b ^= a;
            //    a ^= b;
            //}
        }

        public static void Swap<T>(this List<T> list, int index1, int index2)
        {
            T temp = list[index1];
            list[index1] = list[index2];
            list[index2] = temp;
        }
    }
}
