using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD01;

namespace MSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
   
        public void TestClear()
        {
            ICalculator c = new CalculatorImpl();
            Assert.AreEqual(0, c.Current);
            c.Add(4);
            c.Clear();
            Assert.AreEqual(0, c.Current);
        }

        [TestMethod]
        public void TestAdd()
        {
            ICalculator c = new CalculatorImpl();
            Assert.AreEqual(0, c.Current);
            c.Add(4);
            Assert.AreEqual(4, c.Current);
        }

    }
}
