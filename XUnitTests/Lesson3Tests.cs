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
            [InlineData(3,10,85,30)]
            public void MainTest(int expected, int X, int Y, int D)
            {
                Assert.Equal(expected, FrogJmp.solution(X, Y, D));
            }
        }

        public class PermMissingElemTests
        {

        }
    }
}
