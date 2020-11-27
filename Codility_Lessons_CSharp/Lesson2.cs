using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Codility_Lessons_CSharp
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

        public class CyclicRotationTests
        {
            [Theory]
            [InlineData(3, 0, 3, 5)]
            [InlineData(4, 1, 3, 5)]
            [InlineData(0, 2, 3, 5)]
            [InlineData(1, 3, 3, 5)]
            [InlineData(2, 4, 3, 5)]

            [InlineData(0, 0, 0, 4)]
            [InlineData(0, 0, 0, 3)]
            [InlineData(0, 0, 0, 30)]

            public void TestCalculateLength(int expected, int index, int K, int Length)
            {
                Assert.Equal(expected, CyclicRotation.CalculateNewIndex(index, K, Length));
            }

            [Fact]
            public void TestCalculateNewIndexException()
            {
                Assert.Throws<ArgumentException>(
                    () => CyclicRotation.CalculateNewIndex(5, 1, 3));
            }

            [Theory]
            [InlineData(
                new int[] { 9, 7, 6, 3, 8 },
                new int[] { 3, 8, 9, 7, 6 },
                3)]
            public void MainTest(int[] expected, int[] A, int k)
            {
                Assert.Equal(expected, CyclicRotation.solution(A, k));
            }
        }

        public class OddOccurancesTests
        {
            [Theory]
            [InlineData(5, new int[] { 1,5,1 })]
            [InlineData(3, new int[] { 1, 3, 1 })]
            [InlineData(4, new int[] { 10, 5, 5 , 10 , 4 })]

            public void MainTest(int expected, int[] A)
            {
                Assert.Equal(expected, OddOcurrances.solution(A));
            }
        }
    }
}
