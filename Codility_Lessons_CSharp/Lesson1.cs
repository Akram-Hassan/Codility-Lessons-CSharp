using System;
using Xunit;

namespace Codility_Lessons_CSharp
{
    public class Lesson1
    {
        public static int Solution(int N)
        {
            int count = 0;
            int q, r;
            int max = 0;
            bool counting = false;

            do
            {
                q = N / 2;
                r = N % 2;

                if (r == 1)
                {
                    counting = true;
                    max = (count > max) ? count : max;
                    count = 0;
                }

                if (counting && r == 0)
                    count++;

                N = q;

            } while (N > 0);

            return max;
        }


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
