using System;
using System.Collections.Generic;
using System.Text;

namespace Codility_Lession_CSharp
{
    namespace Lesson3
    {
        public class FrogJmp
        {
            public static int solution(int X, int Y, int D)
            {
                return (int)Math.Ceiling((Y - X) / (double)D);
            }
        }

        public class PermMissingElem
        {
            public static int solution(int[] A)
            {
                HashSet<int> set = new HashSet<int>(A);

                for (int i = 1; i <= A.Length; i++)
                {
                    if (!set.Contains(i))
                        return i;
                }

                return A.Length + 1;
            }
        }

        public class TapeEquilibrium
        {

        }
    }
}
