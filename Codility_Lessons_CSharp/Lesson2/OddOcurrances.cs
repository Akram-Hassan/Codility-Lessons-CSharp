using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Codility_Lessons_CSharp
{
    namespace Lesson2
    {
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
        public class OddOccurancesTests
        {
            [Theory]
            [InlineData(5, new int[] { 1, 5, 1 })]
            [InlineData(3, new int[] { 1, 3, 1 })]
            [InlineData(4, new int[] { 10, 5, 5, 10, 4 })]

            public void MainTest(int expected, int[] A)
            {
                Assert.Equal(expected, OddOcurrances.solution(A));
            }
        }
    }
}
