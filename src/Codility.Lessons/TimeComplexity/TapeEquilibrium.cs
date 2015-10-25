using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Lessons.TimeComplexity
{
    public class TapeEquilibrium
    {
        public int GetMinimalDifference(int[] A)
        {
            if (A.Length == 0) return -1;

            int n = A.Length;
            int[] dividedArray = new int[n - 1];

            int sum = A.Sum();
            int cumulative = 0;
            for (int i = 0; i < n - 1; i++)
            {
                cumulative += A[i];
                int diffMinusP = sum - cumulative;
                dividedArray[i] = Math.Abs(diffMinusP - cumulative);
            }

            return dividedArray.Min();
        }
    }
}
