using Codility_Lession_CSharp.Lesson2;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTests
{
    namespace Lesson2Tests
    {
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
