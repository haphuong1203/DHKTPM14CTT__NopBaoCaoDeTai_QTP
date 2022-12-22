using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Excel_BT
{
    [TestClass]
    public class UTLab4
    {
        [TestMethod]
        public void TestMethod1()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            long Result = o.Sum(10, out long s);
            long[] actualResult = { Result, s };
            long[] expectedResult = { 11, 66 };
            CollectionAssert.AreEqual(expectedResult, actualResult);

        }


        [TestMethod]
        public void TestMethod2()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            long Result = o.Sum(-1, out long s);
            long[] actualResult = { Result, s };
            long[] expectedResult = { 1, 1 };
            CollectionAssert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void TestMethod3()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            long Result = o.Sum(null, out long s);
            Exception Result = new IndexOutOfRangeException();
            Assert.IsNotNull(s);

        }
    }
}
