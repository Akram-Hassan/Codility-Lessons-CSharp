using System;
using System.Collections.Generic;
using System.Text;

namespace Codility_Lession_CSharp
{
    namespace Lesson3
    {
        public class FrogJmp
        {
            public static int solution(int X, int Y, int D)
            {
                return (int) Math.Ceiling((Y - X) / (double) D);
            }
        }
    }
}
