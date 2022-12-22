using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Excel_BT
{
    [TestClass]
    public class UTLab5
    {
        [TestMethod]
        public void TestMethod1()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String actualResult = o.HuyChuoi("HOANGPHUC", 4, 5);
            String expectedResult = ("HOANG");
            Assert.AreEqual(expectedResult, actualResult);

        }
        [TestMethod]
        public void TestMethod2()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String actualResult = o.HuyChuoi("", 4, 5);
            Exception kq = new IndexOutOfRangeException();
            Assert.IsNotNull(kq);

        }
        [TestMethod]
        public void TestMethod3()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String actualResult = o.HuyChuoi("HOANGPHUC", -1, 5);
            Exception kq = new IndexOutOfRangeException();
            Assert.IsNotNull(kq);

        }
        [TestMethod]
        public void TestMethod4()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String actualResult = o.HuyChuoi("HOANGPHUC", null, 5);
            Exception kq = new IndexOutOfRangeException();
            Assert.IsNotNull(kq);

        }
        [TestMethod]
        public void TestMethod5()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String actualResult = o.HuyChuoi("HOANGPHUC", 4, -1);
            String expectedResult = ("HOANGPHUC");
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void TestMethod6()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String actualResult = o.HuyChuoi("HOANGPHUC", 4, null);
            Exception kq = new IndexOutOfRangeException();
            Assert.IsNotNull(kq);

        }

        [TestMethod]
        public void TestMethod7()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String actualResult = o.HuyChuoi("HOANGPHUC", 4, 9);
            Exception kq = new IndexOutOfRangeException();
            Assert.IsNotNull(kq);

        }
    }
}
