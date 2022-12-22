using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Excel_BT
{
    [TestClass]
    public class UTLab3
    {
        [TestMethod]
        public void TestMethod1()
        {
            MethodLibrary.MethodLibrary a = new MethodLibrary.MethodLibrary();
            double thu = Math.Round(a.TinhTienDien(1000, 1030));
            double kq = 48972;
            Assert.AreEqual(kq, thu);
        }

        [TestMethod]
        public void TestMethod2()
        {
            MethodLibrary.MethodLibrary a = new MethodLibrary.MethodLibrary();
            double thu = Math.Round(a.TinhTienDien(1000, 1080));
            double kq = 1322209;
            Assert.AreEqual(kq, thu);
        }

        [TestMethod]
        public void TestMethod3()
        {
            MethodLibrary.MethodLibrary a = new MethodLibrary.MethodLibrary();
            double thu = Math.Round(a.TinhTienDien(1000, 1120));
            double kq = 205227;
            Assert.AreEqual(kq, thu);
        }

        [TestMethod]
        public void TestMethod4()
        {
            MethodLibrary.MethodLibrary a = new MethodLibrary.MethodLibrary();
            double thu = Math.Round(a.TinhTienDien(1000, 1220));
            double kq = 661631;
            Assert.AreEqual(kq, thu);
        }

        [TestMethod]
        public void TestMethod5()
        {
            MethodLibrary.MethodLibrary a = new MethodLibrary.MethodLibrary();
            double thu = Math.Round(a.TinhTienDien(1000, 1320));
            double kq = 48972;
            Assert.AreEqual(kq, thu);
        }

        [TestMethod]
        public void TestMethod6()
        {
            MethodLibrary.MethodLibrary a = new MethodLibrary.MethodLibrary();
            double thu = Math.Round(a.TinhTienDien(1000, 1420));
            double kq = 941259;
            Assert.AreEqual(kq, thu);
        }

        [TestMethod]
        public void TestMethod7()
        {
            MethodLibrary.MethodLibrary a = new MethodLibrary.MethodLibrary();
            double thu = Math.Round(a.TinhTienDien(-1000, 1020));
            double kq = -1;
            Assert.AreEqual(kq, thu);
        }

        [TestMethod]
        public void TestMethod8()
        {
            MethodLibrary.MethodLibrary a = new MethodLibrary.MethodLibrary();
            double thu = Math.Round(a.TinhTienDien(1020, 1000));
            double kq = -1;
            Assert.AreEqual(kq, thu);
        }

        [TestMethod]
        public void TestMethod9()
        {
            MethodLibrary.MethodLibrary a = new MethodLibrary.MethodLibrary();
            double thu = Math.Round(a.TinhTienDien(1000, -1020));
            double kq = -1;
            Assert.AreEqual(kq, thu);
        }


        [TestMethod]
        public void TestMethod10()
        {
            MethodLibrary.MethodLibrary a = new MethodLibrary.MethodLibrary();
            double thu = Math.Round(a.TinhTienDien(1000, 1000));
            double kq = 0;
            Assert.AreEqual(kq, thu);
        }
        
    
        [TestMethod]
        public void TestMethod11()
        {
            MethodLibrary.MethodLibrary a = new MethodLibrary.MethodLibrary();
            double thu = Math.Round(a.TinhTienDien(1000, 1050));
            double kq = 81620;
            Assert.AreEqual(kq, thu);
        }


        [TestMethod]
        public void TestMethod12()
        {
            MethodLibrary.MethodLibrary a = new MethodLibrary.MethodLibrary();
            double thu = Math.Round(a.TinhTienDien(1000, 1051));
            double kq = 83306.3;
            Assert.AreEqual(kq, thu);
        }


        [TestMethod]
        public void TestMethod13()
        {
            MethodLibrary.MethodLibrary a = new MethodLibrary.MethodLibrary();
            double thu = Math.Round(a.TinhTienDien(1000, 1100));
            double kq = 165935;
            Assert.AreEqual(kq, thu);
        }


        [TestMethod]
        public void TestMethod14()
        {
            MethodLibrary.MethodLibrary a = new MethodLibrary.MethodLibrary();
            double thu = Math.Round(a.TinhTienDien(1000, 1101));
            double kq = 167899.6;
            Assert.AreEqual(kq, thu);
        }


        [TestMethod]
        public void TestMethod15()
        {
            MethodLibrary.MethodLibrary a = new MethodLibrary.MethodLibrary();
            double thu = Math.Round(a.TinhTienDien(1000, 1200));
            double kq = 362395;
            Assert.AreEqual(kq, thu);
        }

        [TestMethod]
        public void TestMethod16()
        {
            MethodLibrary.MethodLibrary a = new MethodLibrary.MethodLibrary();
            double thu = Math.Round(a.TinhTienDien(1000, 1201));
            double kq = 364861.2;
            Assert.AreEqual(kq, thu);
        }
        [TestMethod]
        public void TestMethod17()
        {
            MethodLibrary.MethodLibrary a = new MethodLibrary.MethodLibrary();
            double thu = Math.Round(a.TinhTienDien(1000, 1300));
            double kq = 609015;
            Assert.AreEqual(kq, thu);
        }
        [TestMethod]
        public void TestMethod18()
        {
            MethodLibrary.MethodLibrary a = new MethodLibrary.MethodLibrary();
            double thu = Math.Round(a.TinhTienDien(1000, 1031));
            double kq = 611768.3;
            Assert.AreEqual(kq, thu);
        }
        [TestMethod]
        public void TestMethod19()
        {
            MethodLibrary.MethodLibrary a = new MethodLibrary.MethodLibrary();
            double thu = Math.Round(a.TinhTienDien(1000, 1400));
            double kq = 884345;
            Assert.AreEqual(kq, thu);
        }

        [TestMethod]
        public void TestMethod20()
        {
            MethodLibrary.MethodLibrary a = new MethodLibrary.MethodLibrary();
            double thu = Math.Round(a.TinhTienDien(1000, 1401));
            double kq = 887190.7;
            Assert.AreEqual(kq, thu);
        }

        [TestMethod]
        public void TestMethod21()
        {
            MethodLibrary.MethodLibrary a = new MethodLibrary.MethodLibrary();
            double thu = Math.Round(a.TinhTienDien(1001, 1000));
            Exception kq = new IndexOutOfRangeException();
            Assert.IsNotNull(kq);
        }
    }
}
