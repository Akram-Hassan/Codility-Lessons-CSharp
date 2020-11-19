using Codility_Lession_CSharp.Lesson3;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTests
{
    namespace Lesson3Tests
    {
        public class FrogJmpTests
        {
            [Theory]
            [InlineData(3, 10, 85, 30)]
            public void MainTest(int expected, int X, int Y, int D)
            {
                Assert.Equal(expected, FrogJmp.solution(X, Y, D));
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

        public class TapeEquilibriumTests
        {

        }
    }
}
