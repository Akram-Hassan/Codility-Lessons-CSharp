using Codility_Lession_CSharp.Lesson4;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTests
{
    namespace Lesson4Tests
    {
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
