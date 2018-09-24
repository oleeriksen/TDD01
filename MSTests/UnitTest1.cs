using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD01;

namespace MSTests
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

        [TestMethod]
        public void TestMul()
        {
            ICalculator c = new CalculatorImpl();
            Assert.AreEqual(0, c.Current);
            c.Add(4);
            c.Mul(3);
            Assert.AreEqual(12, c.Current);
        }

        [TestMethod]
        public void TestDiv()
        {
            ICalculator c = new CalculatorImpl();
            Assert.AreEqual(0, c.Current);
            c.Add(6);
            c.Div(3);
            Assert.AreEqual(2, c.Current);
        }

        [TestMethod]
        public void TestDiv2()
        {
            ICalculator c = new CalculatorImpl();
            Assert.AreEqual(0, c.Current);
            c.Add(7);
            c.Div(3);
            Assert.AreEqual(2, c.Current);
        }

        [ExpectedException(typeof(ArgumentException), "Cannot divide by zero")]
        [TestMethod]
        public void TestDivException()
        {
            ICalculator c = new CalculatorImpl();
            c.Add(4);
            c.Div(0);
        }

    }
}
