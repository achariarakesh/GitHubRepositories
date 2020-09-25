using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestProject
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void NunitTestMethod1()
        {
            Assert.AreEqual(20, 20);
        }

        [Test]
        public void NunitTestMethod2()
        {
            Assert.AreEqual(50, 50);
        }

    }
}
