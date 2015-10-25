using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Lessons.CoutingElements
{
    public class FrogRiverOne
    {
        public int EarliestTime(int X, int[] A)
        {
            if (A.Length == 0) return -1;
            if (A.Length == 1 && A[0] == X) return 0;
            if (A.Length == 1 && A[0] != X) return -1;

            var numberOfSameElement = A.Where(a => a == X).Count();
            if (numberOfSameElement == A.Length) return -1;
            
            //Generate the Steps Needed
            List<int> stepsNeeded = new List<int>();
            for (int i = 1; i <= X; i++)
                stepsNeeded.Add(i);

            //Extract SubArray when all Itens are found
            int[] subArray = new int[A.Length + 1];
            for (int i = 0; i < A.Length; i++)
            {
                subArray[i] = A[i];
                if (stepsNeeded.Contains(subArray[i]))
                    stepsNeeded.Remove(subArray[i]);

                if (stepsNeeded.Count == 0) return i;
            }

            return -1;
        }
    }
}