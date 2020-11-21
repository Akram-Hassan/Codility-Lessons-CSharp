using System;
using System.Collections.Generic;
using System.Text;

namespace Codility_Lession_CSharp
{
    namespace Lesson4
    {
        public class FrogRiverOne
        {
            public static int solution1(int X, int[] A)
            {
                int total = X * (X + 1) / 2;
                int sum = 0;
                var set = new HashSet<int>();

                for (int i = 0; i < A.Length; i++)
                {
                    int item = A[i];
                    if (!set.Contains(item))
                    {
                        set.Add(item);
                        if (item <= X)
                        {
                            sum += item;
                            if (sum == total)
                                return i;
                        }
                    }
                }

                return -1;
            }
        }
    }
}
