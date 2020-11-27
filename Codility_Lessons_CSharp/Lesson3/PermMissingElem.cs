using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Codility_Lessons_CSharp
{
    namespace Lesson3
    {
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
        public class PermMissingElemTests
        {
            [Theory]
            [InlineData(1, new int[] { 3, 2, 4 })]
            [InlineData(3, new int[] { 1, 2, 4 })]
            [InlineData(4, new int[] { 1, 2, 3 })]
            [InlineData(2, new int[] { 1, 3, 4 })]
            [InlineData(1, new int[] { 2 })]
            [InlineData(5, new int[] { 1, 2, 4, 3, 6 })]

            public void MainTest(int expected, int[] A)
            {
                Assert.Equal(expected, PermMissingElem.solution(A));
            }
        }
    }
}
