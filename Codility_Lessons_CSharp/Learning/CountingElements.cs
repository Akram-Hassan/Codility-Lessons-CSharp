using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codility_Lessons_CSharp.Learning
{
    public class CountingElements
    {
        static int[] countElements(int[] A, int m = 0)
        {
            //O(n)
            int max = (m == 0) ? A.Max() : m;

            int[] result = new int[max + 1];

            //O(max)
            foreach (var item in A)
                result[item]++;

            return result;
        }


    }
}
