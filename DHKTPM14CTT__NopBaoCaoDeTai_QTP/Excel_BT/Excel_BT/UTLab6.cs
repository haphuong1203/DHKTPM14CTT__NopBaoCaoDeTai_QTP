using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Excel_BT
{
    [TestClass]
    public class UTLab6
    {
        [TestMethod]
        public void TestMethod1()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String actualResult = o.ThayThe("haphuong", "ph", "min");
            String expectedResult = ("haminuong");
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void TestMethod2()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String actualResult = o.ThayThe("", "", "");
            String expectedResult = ("");
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod3()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String actualResult = o.ThayThe("haphuong", "621", "min");
            String expectedResult = ("haphuong");
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod4()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String actualResult = o.ThayThe("haphuong", "", "min");
            String expectedResult = ("haphuong");
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod5()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String actualResult = o.ThayThe("haphuong", "ph", "");
            String expectedResult = ("hauong");
            Assert.AreEqual(expectedResult, actualResult);
        }

       
    }
}
