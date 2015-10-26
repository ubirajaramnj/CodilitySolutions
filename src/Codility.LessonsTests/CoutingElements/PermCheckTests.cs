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
    public class PermCheckTests
    {
        [TestMethod()]
        public void IsPermutationTest()
        {
            int[] array = new int[] { 4, 1, 3, 2 };
            int expected = 1;
            Assert.AreEqual(expected, new PermCheck().Solution(array));
        }

        [TestMethod()]
        public void IsNotPermutationTest()
        {
            int[] array = new int[] { 4, 1, 3 };
            int expected = 0;
            Assert.AreEqual(expected, new PermCheck().Solution(array));
        }

        [TestMethod()]
        public void IsNotPermutationDueDuplicatedElementTest()
        {
            int[] array = new int[] { 4, 1, 3, 2, 1, 3, 2 };
            int expected = 0;
            Assert.AreEqual(expected, new PermCheck().Solution(array));
        }

        [TestMethod()]
        public void PermutationMinElementTest()
        {
            int[] array = new int[] { 1 };
            int expected = 1;
            Assert.AreEqual(expected, new PermCheck().Solution(array));
        }

        [TestMethod()]
        public void PermutationMin2ElementTest()
        {
            int[] array = new int[] { 2 };
            int expected = 0;
            Assert.AreEqual(expected, new PermCheck().Solution(array));
        }

        [TestMethod()]
        public void NotPermutationTwolementTest()
        {
            int[] array = new int[] { 3, 2 };
            int expected = 0;
            Assert.AreEqual(expected, new PermCheck().Solution(array));
        }
    }
}