using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Codility_Lessons_CSharp
{
    namespace Lesson3
    {
        public class TapeEquilibrium
        {
            public static int solution(int[] A)
            {
                int sum = A.Sum();
                int partialSum = 0;
                int min = int.MaxValue;
                int diff;

                for (int i = 0; i < A.Length - 1; i++)
                {
                    int element = A[i];
                    partialSum += element;
                    diff = Math.Abs(partialSum - (sum - partialSum));
                    min = min < diff ? min : diff;
                }

                return min;
            }
        }
        public class TapeEquilibriumTests
        {
            [Theory]
            [InlineData(1, new int[] { 3, 1, 2, 4, 3 })]
            [InlineData(4, new int[] { 1, 5 })]
            [InlineData(4, new int[] { 5, 1 })]
            [InlineData(1, new int[] { 1, 1, 1 })]
            [InlineData(1, new int[] { 1, 0 })]
            [InlineData(0, new int[] { 1, 1 })]
            [InlineData(0, new int[] { 1, 2, 3 })]
            [InlineData(20, new int[] { 10, 30, 20 })]
            [InlineData(1000, new int[] { 1000, 2000 })]
            [InlineData(10, new int[] { -5, 5 })]
            [InlineData(3, new int[] { -5, 3, 1 })]

            public void MainTests(int expected, int[] A)
            {
                Assert.Equal(expected, TapeEquilibrium.solution(A));
            }
        }
    }
}
