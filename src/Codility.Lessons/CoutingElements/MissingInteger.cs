using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Lessons.CoutingElements
{
    public class MissingInteger
    {
        public int Solution(int[] A)
        {
            int[] newArray = new int[A.Length];
            foreach (var item in A)
            {
                if (0 < item && item <= A.Length)
                    newArray[item - 1] = 1;
            }

            for (int i = 0; i < newArray.Length; i++)
            {
                if (newArray[i] == 0)
                    return i + 1;   
            }

            return A.Length + 1;
        }
    }
}