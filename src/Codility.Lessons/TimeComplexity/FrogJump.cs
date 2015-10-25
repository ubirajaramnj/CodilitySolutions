using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Lessons.TimeComplexity
{
    public class FrogJump
    {
        public int GetMinimalNumberOfJumps(int X, int Y, int D)
        {
            if (X > Y) return -1;
            return DivideRoundingUp((Y - X), D);
        }

        private static int DivideRoundingUp(int x, int y)
        {
            int remainder;
            int quotient = Math.DivRem(x, y, out remainder);
            return remainder == 0 ? quotient : quotient + 1;
        }
    }
}
