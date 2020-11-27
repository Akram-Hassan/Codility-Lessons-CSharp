using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Codility_Lessons_CSharp
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
                int[] counter = new int[X + 1];

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
        public class FrogRiverOneTests
        {
            #region Solution 1
            [Theory]
            [InlineData(6, 5, new int[] { 1, 3, 1, 4, 2, 3, 5, 4 })]
            [InlineData(4, 4, new int[] { 1, 3, 1, 4, 2, 3, 5, 4 })]
            [InlineData(4, 3, new int[] { 1, 3, 1, 4, 2, 3, 5, 4 })]
            [InlineData(2, 3, new int[] { 1, 3, 2 })]
            [InlineData(3, 4, new int[] { 4, 1, 3, 2 })]
            [InlineData(-1, 5, new int[] { 1, 3, 2 })]
            [InlineData(2, 2, new int[] { 1, 3, 2 })]
            [InlineData(8, 2, new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 2 })]
            [InlineData(0, 1, new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 2 })]
            public void TestSolution1(int expected, int X, int[] A)
            {
                Assert.Equal(expected, FrogRiverOne.solution1(X, A));
            }
            #endregion

            #region Solution 2
            [Theory]
            [InlineData(6, 5, new int[] { 1, 3, 1, 4, 2, 3, 5, 4 })]
            [InlineData(4, 4, new int[] { 1, 3, 1, 4, 2, 3, 5, 4 })]
            [InlineData(4, 3, new int[] { 1, 3, 1, 4, 2, 3, 5, 4 })]
            [InlineData(2, 3, new int[] { 1, 3, 2 })]
            [InlineData(3, 4, new int[] { 4, 1, 3, 2 })]
            [InlineData(-1, 5, new int[] { 1, 3, 2 })]
            [InlineData(2, 2, new int[] { 1, 3, 2 })]
            [InlineData(8, 2, new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 2 })]
            [InlineData(0, 1, new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 2 })]
            public void TestSolution2(int expected, int X, int[] A)
            {
                Assert.Equal(expected, FrogRiverOne.solution2(X, A));
            }
            #endregion
        }
    }
}
