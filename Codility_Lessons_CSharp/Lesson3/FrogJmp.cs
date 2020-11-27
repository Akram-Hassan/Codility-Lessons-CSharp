using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Codility_Lessons_CSharp
{
    namespace Lesson3
    {
        public class FrogJmp
        {
            public static int solution(int X, int Y, int D)
            {
                return (int)Math.Ceiling((Y - X) / (double)D);
            }
        }
        public class FrogJmpTests
        {
            [Theory]
            [InlineData(3, 10, 85, 30)]
            public void MainTest(int expected, int X, int Y, int D)
            {
                Assert.Equal(expected, FrogJmp.solution(X, Y, D));
            }
        }
    }
}
