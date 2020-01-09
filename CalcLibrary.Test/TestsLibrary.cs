using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalcLibrary.Test
{
    [TestClass]
    public class TestsLibrary
    {
        [TestMethod]
        public void Test1()
        {
            double ris = Calc.RadQ(9);
            Assert.AreEqual(3, ris);
        }

        [TestMethod]
        public void Test2()
        {
            double ris = Calc.RadQ(5);
            Assert.AreEqual(2.2360679775, ris );
        }

        [TestMethod]
        public void Test3()
        {
            double ris = Calc.RadQ(-3);
            Assert.AreEqual(double.NaN, ris);
        }
    }
}
