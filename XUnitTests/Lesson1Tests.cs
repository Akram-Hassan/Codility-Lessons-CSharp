using Codility_Lession_CSharp;
using System;
using Xunit;

namespace XUnitTests
{
    public class Lesson1Tests
    {
        [Theory]
        [InlineData(0, 4)]
        [InlineData(1, 5)]
        [InlineData(0, 8)]
        [InlineData(2, 9)]
        [InlineData(0, 32)]
        [InlineData(5, 1041)]
        public void MainTest(int result, int N )
        {
            Assert.Equal(result ,Lesson1.Solution(N));
        }
    }
}
