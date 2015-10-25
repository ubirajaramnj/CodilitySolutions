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
    public class FrogJumpTests
    {
        [TestMethod()]
        public void GetMinimalNumberOfJumpsTest()
        {
            int expected = 3;
            Assert.AreEqual(expected, new FrogJump().GetMinimalNumberOfJumps(10, 85, 30));
        }
    }
}
