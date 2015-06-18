using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars.SumofNth.Test
{
    [TestClass]
    public class UnitTest1
    {
 
        [TestMethod]
            public void TestZero_ExpectZero() {
            Assert.AreEqual("0.00", NthSeries.seriesSum(0));
        }

        [TestMethod]
        public void Test1_Expect1()
        {
            Assert.AreEqual("1.00", NthSeries.seriesSum(1));
        }

        [TestMethod]
        public void Test2_Expect()
        {
            Assert.AreEqual("1.25", NthSeries.seriesSum(2));
        }

        [TestMethod]
        public void Test3_Expect()
        {
            Assert.AreEqual("1.39", NthSeries.seriesSum(3));
        }

        [TestMethod]
        public void Test5_Expect()
        {
            Assert.AreEqual("1.57", NthSeries.seriesSum(5));
        }

        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual("1.77", NthSeries.seriesSum(9));
        }
  

    }
}
