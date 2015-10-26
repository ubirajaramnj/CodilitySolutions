using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Lessons.CoutingElements
{
    public class PermCheck
    {
        public int Solution(int[] A)
        {
            if (A.Length == 0) return 0;
            if (A.Length == 1 && A[0] == 1) return 1;
            if (A.Length == 1 && A[0] != 1) return 0;

            int maxValue = A.ToList().Max();

            //Generate the Steps Needed
            List<int> stepsNeeded = new List<int>();
            for (int i = 1; i <= maxValue; i++)
                stepsNeeded.Add(i);

            if (A.LongCount() < stepsNeeded.LongCount()) return 0;
            
            List<int> AList = A.ToList();
            foreach (var item in stepsNeeded)
                if (AList.Contains(item))
                    AList.Remove(item);

            return (AList.Any()) ? 0 : 1;
        }
    }
}