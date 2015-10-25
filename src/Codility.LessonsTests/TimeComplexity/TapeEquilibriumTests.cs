using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Codility.Lessons.TimeComplexity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Codility.Lessons.TimeComplexity.Tests
{
    [TestClass()]
    public class TapeEquilibriumTests
    {
        [TestMethod()]
        public void GetMinimalDifferenceTest()
        {
            int[] array = new int[] { 3, 1, 2, 4, 3 };
            int expected = 1;
            Assert.AreEqual(expected, new TapeEquilibrium().GetMinimalDifference(array));
        }
    }
}
