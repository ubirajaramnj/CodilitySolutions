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
    public class FrogRiverOneTests
    {
        [TestMethod()]
        public void EarliestTimeTest()
        {
            int[] array = new int[] { 1, 3, 1, 4, 2, 3, 5, 4 };
            int expected = 6;
            Assert.AreEqual(expected, new FrogRiverOne().EarliestTime(5, array));
        }

        [TestMethod()]
        public void EarliestTimeSimple_1Test()
        {
            int[] array = new int[] { 2, 2, 2, 2, 2 };
            int expected = -1;
            Assert.AreEqual(expected, new FrogRiverOne().EarliestTime(2, array));
        }

        [TestMethod()]
        public void EarliestTimeSimple_2Test()
        {
            int[] array = new int[] { 1 };
            int expected = 0;
            Assert.AreEqual(expected, new FrogRiverOne().EarliestTime(1, array));
        }

        [TestMethod()]
        public void EarliestTimeSimple_3Test()
        {
            int[] array = new int[] { 1, 1, 1, 1 };
            int expected = -1;
            Assert.AreEqual(expected, new FrogRiverOne().EarliestTime(2, array));
        }

        [TestMethod()]
        public void EarliestTimeSimple_4Test()
        {
            int[] array = new int[] { 1, 2, 3, 5, 3, 1 };
            int expected = -1;
            Assert.AreEqual(expected, new FrogRiverOne().EarliestTime(5, array));
        }

        [TestMethod()]
        public void EarliestTimeSimple_5Test()
        {
            int[] array = new int[] { 1, 3, 1, 3, 2, 1, 3 };
            int expected = 4;
            Assert.AreEqual(expected, new FrogRiverOne().EarliestTime(3, array));
        }
    }
}