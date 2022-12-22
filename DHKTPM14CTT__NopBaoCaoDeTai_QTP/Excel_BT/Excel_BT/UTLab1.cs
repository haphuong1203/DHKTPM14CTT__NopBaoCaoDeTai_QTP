using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Excel_BT
{
    [TestClass]
    public class UTLab1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MethodLibrary.MethodLibrary a = new MethodLibrary.MethodLibrary();
            int thu = a.Max(50, 30, 20);
            int kq = 50;
            Assert.AreEqual(kq, thu);
        }
        [TestMethod]
        public void TestMethod2()
        {
            MethodLibrary.MethodLibrary a = new MethodLibrary.MethodLibrary();
            int thu = a.Max(40, 50, 40);
            int kq = 50;
            Assert.AreEqual(kq, thu);
        }
        [TestMethod]
        public void TestMethod3()
        {
            MethodLibrary.MethodLibrary a = new MethodLibrary.MethodLibrary();
            int thu = a.Max(30, 40, 50);
            int kq = 50;
            Assert.AreEqual(kq, thu);
        }
        [TestMethod]
        public void TestMethod4()
        {
            MethodLibrary.MethodLibrary a = new MethodLibrary.MethodLibrary();
            int thu = a.Max(55, 30, 50);
            Exception kq = new IndexOutOfRangeException();
            Assert.IsNotNull(kq);
        }
        [TestMethod]
        public void TestMethod5()
        {
            MethodLibrary.MethodLibrary a = new MethodLibrary.MethodLibrary();
            int thu = a.Max(null, 50, 30);
            Exception kq = new IndexOutOfRangeException();
            Assert.IsNotNull(kq);
        }
        
        [TestMethod]
        public void TestMethod7()
        {
            MethodLibrary.MethodLibrary a = new MethodLibrary.MethodLibrary();
            int thu = a.Max(30, 55, 40);
            Exception kq = new IndexOutOfRangeException();
            Assert.IsNotNull(kq);
        }
        [TestMethod]
        public void TestMethod8()
        {
            MethodLibrary.MethodLibrary a = new MethodLibrary.MethodLibrary();
            int thu = a.Max(40, null, 50);
            Exception kq = new IndexOutOfRangeException();
            Assert.IsNotNull(kq);
        }

        [TestMethod]
        public void TestMethod10()
        {
            MethodLibrary.MethodLibrary a = new MethodLibrary.MethodLibrary();
            int thu = a.Max(40, 30, 55);
            Exception kq = new IndexOutOfRangeException();
            Assert.IsNotNull(kq);
        }
        [TestMethod]
        public void TestMethod11()
        {
            MethodLibrary.MethodLibrary a = new MethodLibrary.MethodLibrary();
            int thu = a.Max(50, 40, null);
            int kq = 50;
            Assert.AreEqual(kq, thu);
        }
        
        [TestMethod]
        public void TestMethod13()
        {
            MethodLibrary.MethodLibrary a = new MethodLibrary.MethodLibrary();
            int thu = a.Max(1, 20, 40);
            int kq = 40;
            Assert.AreEqual(kq, thu);
        }
        [TestMethod]
        public void TestMethod14()
        {
            MethodLibrary.MethodLibrary a = new MethodLibrary.MethodLibrary();
            int thu = a.Max(50, 30, 20);
            int kq = 50;
            Assert.AreEqual(kq, thu);
        }
        [TestMethod]
        public void TestMethod15()
        {
            MethodLibrary.MethodLibrary a = new MethodLibrary.MethodLibrary();
            int thu = a.Max(20, 1, 10);
            int kq = 20;
            Assert.AreEqual(kq, thu);
        }
        [TestMethod]
        public void TestMethod16()
        {
            MethodLibrary.MethodLibrary a = new MethodLibrary.MethodLibrary();
            int thu = a.Max(15, 50, 35);
            int kq = 50;
            Assert.AreEqual(kq, thu);
        }
        [TestMethod]
        public void TestMethod17()
        {
            MethodLibrary.MethodLibrary a = new MethodLibrary.MethodLibrary();
            int thu = a.Max(45, 25, 1);
            int kq = 45;
            Assert.AreEqual(kq, thu);
        }
        [TestMethod]
        public void TestMethod18()
        {
            MethodLibrary.MethodLibrary a = new MethodLibrary.MethodLibrary();
            int thu = a.Max(25, 10, 50);
            int kq = 50;
            Assert.AreEqual(kq, thu);
        }

        [TestMethod]
        public void TestMethod19()
        {
            MethodLibrary.MethodLibrary a = new MethodLibrary.MethodLibrary();
            int thu = a.Max(0, 10, 15);
            Exception kq = new IndexOutOfRangeException();
            Assert.IsNotNull(kq);
        }

        [TestMethod]
        public void TestMethod20()
        {
            MethodLibrary.MethodLibrary a = new MethodLibrary.MethodLibrary();
            int thu = a.Max(51, 20, 35);
            Exception kq = new IndexOutOfRangeException();
            Assert.IsNotNull(kq);
        }
        [TestMethod]
        public void TestMethod21()
        {
            MethodLibrary.MethodLibrary a = new MethodLibrary.MethodLibrary();
            int thu = a.Max(20, 0, 30);
            Exception kq = new IndexOutOfRangeException();
            Assert.IsNotNull(kq);
        }
        [TestMethod]
        public void TestMethod22()
        {
            MethodLibrary.MethodLibrary a = new MethodLibrary.MethodLibrary();
            int thu = a.Max(30, 51, 40);
            Exception kq = new IndexOutOfRangeException();
            Assert.IsNotNull(kq);
        }
        [TestMethod]
        public void TestMethod23()
        {
            MethodLibrary.MethodLibrary a = new MethodLibrary.MethodLibrary();
            int thu = a.Max(25, 30, 0);
            Exception kq = new IndexOutOfRangeException();
            Assert.IsNotNull(kq);
        }
        [TestMethod]
        public void TestMethod24()
        {
            MethodLibrary.MethodLibrary a = new MethodLibrary.MethodLibrary();
            int thu = a.Max(15, 50, 51);
            Exception kq = new IndexOutOfRangeException();
            Assert.IsNotNull(kq);
        }
    }
}
