using System;
using System.Collections.Generic;
using System.Text;

namespace Codility_Lession_CSharp
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
    }
}
