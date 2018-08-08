using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Demo;
namespace UnitTestProject1
{
    [TestClass]
    public class MyTest
    {
        [TestMethod]
        public void A()
        {
            int[] arr = { 20, 11, 16 };
            Sample.CheckArray(arr);
        }

        [TestMethod]
        public void B()
        {
            double ar = Sample.Area(25d, 3d);
            Assert.IsTrue(ar > 0d);
        }
    }
}
