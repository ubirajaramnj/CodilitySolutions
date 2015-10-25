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
    public class PermutationMissionElementTests
    {
        [TestMethod()]
        public void GetMissingElementExampleTest()
        {
            int[] arrayValues = new int[] { 2, 3, 1, 5 };
            int expected = 4;
            Assert.AreEqual(expected, new PermutationMissingElement().GetMissingElement(arrayValues));
        }
    }
}
