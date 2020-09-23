using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(20, 20);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(80, 80);
        }
    }
}
