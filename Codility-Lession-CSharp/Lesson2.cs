using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codility_Lession_CSharp
{
    namespace Lesson2
    {
        public class CyclicRotation
        {
            public static int[] solution(int[] A, int K)
            {
                int[] result = new int[A.Length];

                for (int i = 0; i < A.Length; i++)
                {
                    int index = CalculateNewIndex(i, K, A.Length);
                    result[index] = A[i];
                }

                return result;
            }

            public static int CalculateNewIndex(int index, int K, int length)
            {
                if (index > (length - 1))
                    throw new ArgumentException("Invalid index value " + index + ", Array length is " + length);
                
                return (index + K) % length;
            }
        }

        public class OddOcurrances
        {
            public static int solution(int[] A)
            {
                HashSet<int> set = new HashSet<int>();

                foreach (var item in A)
                {
                    if (!set.Contains(item))
                        set.Add(item);
                    else
                        set.Remove(item);
                }

                return set.First();
            }
        }
    }
}
