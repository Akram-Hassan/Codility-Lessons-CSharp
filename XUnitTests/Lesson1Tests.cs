using Codility_Lession_CSharp;
using System;
using Xunit;

namespace XUnitTests
{
    public class Lesson1Tests
    {
        [Theory]
        [InlineData(0, 4)]
        public void MainTest(int result, int N )
        {
            Assert.Equal(result ,Lesson1.Solution(N));
        }
    }
}
