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
            public static int solution2(int X, int[] A)
            {
                int count = 0;
                int[] counter = new int[X+1];

                for (int i = 0; i < A.Length; i++)
                {
                    int item = A[i];
                    if (item <= X && counter[item] == 0)
                    {
                        counter[item]++;
                        count++;
                        if (count == X)
                            return i;
                    }
                }

                return -1;
            }
        }
    }
}
