using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Excel_BT
{
    [TestClass]
    public class UTLab2
    {
        [TestMethod]
        public void TestMethod1()
        {
            Exception e = null;
            try
            {
                MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
                float x1 = float.Parse("NaN");
                float x2 = float.Parse("NaN");
                String KQTT = obj.SolveQuadratic(0,10,0,out x1, out x2);
            }
            catch(Exception ex)
            {
                e = ex;
                String KQMD = "x1=x2=M=NaN";
                Assert.AreEqual(KQMD,KQMD);
            }
            
        }

        [TestMethod]
        public void TestMethod2()
        {
            Exception e = null;
            try
            {
                MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
                float x1 = 2;
                float x2 = float.Parse("");
                String KQTT = obj.SolveQuadratic(0, 5, -10, out x1, out x2);
            }
            catch (Exception ex)
            {
                e = ex;
                String KQMD = "Có 1 nghiệm";
                Assert.AreEqual(KQMD, KQMD);
            }
        }

        [TestMethod]
        public void TestMethod3()
        {
            Exception e = null;
            try
            {
                MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
                float x1 = -1;
                float x2 = -2;
                String KQTT = obj.SolveQuadratic(2, 6, 4, out x1, out x2);
            }
            catch (Exception ex)
            {
                e = ex;
                String KQMD = "Có 2 nghiệm phân biệt";
                Assert.AreEqual(KQMD, KQMD);
            }
        }

        [TestMethod]
        public void TestMethod4()
        {
            Exception e = null;
            try
            {
                MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
                float x1 = -1;
                float x2 = -1;
                String KQTT = obj.SolveQuadratic(3, 6, 3, out x1, out x2);
            }
            catch (Exception ex)
            {
                e = ex;
                String KQMD = "Có nghiệm kép theo a";
                Assert.AreEqual(KQMD, KQMD);
            }
        }
        [TestMethod]
        public void TestMethod5()
        {
            Exception e = null;
            try
            {
                MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
                float x1 = float.Parse("NaN");
                float x2 = float.Parse("NaN");
                String KQTT = obj.SolveQuadratic(6, 3, 3, out x1, out x2);
            }
            catch (Exception ex)
            {
                e = ex;
                String KQMD = "x1=x2=NaN";
                Assert.AreEqual(KQMD, KQMD);
            }
        }

    }
}
