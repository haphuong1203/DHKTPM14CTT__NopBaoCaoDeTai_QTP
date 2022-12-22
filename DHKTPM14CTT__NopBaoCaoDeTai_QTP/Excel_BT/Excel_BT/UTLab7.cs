using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Excel_BT
{
    [TestClass]
    public class UTLab7
    {
        [TestMethod]
        public void TestMethod1()
        {
            MethodLibrary.MethodLibrary m = new MethodLibrary.MethodLibrary();
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int thu = m.Largest(a);
            int kq = 10;
            Assert.AreEqual(kq, thu);

        }
        [TestMethod]
        public void TestMethod2()
        {
            MethodLibrary.MethodLibrary m = new MethodLibrary.MethodLibrary();
            int[] a = {};
            int thu = m.Largest(a);
            int kq = 2147483647;
            Assert.AreEqual(kq, thu);

        }
    }
}
