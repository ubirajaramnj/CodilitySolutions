using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Codility.Lessons.CoutingElements;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Codility.Lessons.CoutingElements.Tests
{
    [TestClass()]
    public class MissingIntegerTests
    {
        [TestMethod()]
        public void SolutionTest()
        {
            int[] array = new int[] { 1, 3, 6, 4, 1, 2 };
            int expected = 5;
            
            Assert.AreEqual(expected, new MissingInteger().Solution(array));
        }

        [TestMethod()]
        public void OneElementTest()
        {
            int[] array = new int[] { 1 };
            int expected = 2;

            Assert.AreEqual(expected, new MissingInteger().Solution(array));
        }

        [TestMethod()]
        public void One_2_ElementTest()
        {
            int[] array = new int[] { 2 };
            int expected = 1;

            Assert.AreEqual(expected, new MissingInteger().Solution(array));
        }

        [TestMethod()]
        public void One_3_ElementTest()
        {
            int[] array = new int[] { 3 };
            int expected = 1;

            Assert.AreEqual(expected, new MissingInteger().Solution(array));
        }

        [TestMethod()]
        public void Extreme_Min_Max_Int_WithMinus_ElementTest()
        {
            int[] array = new int[] { int.MinValue, int.MaxValue };
            int expected = 1;

            Assert.AreEqual(expected, new MissingInteger().Solution(array));
        }

        [TestMethod()]
        public void NegativeOnlyElementTest()
        {
            int[] array = new int[] { int.MinValue, int.MinValue + 1000 };
            int expected = 1;

            Assert.AreEqual(expected, new MissingInteger().Solution(array));
        }
    }
}
