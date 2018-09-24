using System;
using TDD01;
using Xunit;

namespace TDD01Tests
{
    public class CalculatorTest
    {

        [Fact]
        public void TestClear()
        {
            ICalculator c = new CalculatorImpl();
            Assert.Equal(0, c.Current);
            c.Add(4);
            c.Clear();
            Assert.Equal(0, c.Current);
        }

        [Fact]
        public void TestAdd()
        {
			ICalculator c = new CalculatorImpl();
			Assert.Equal(0, c.Current);
			c.Add(4);
			Assert.Equal(4, c.Current);
        }

		[Fact]
		public void TestMul()
		{
			ICalculator c = new CalculatorImpl();
			Assert.Equal(0, c.Current);
			c.Add(4);
            c.Mul(3);
			Assert.Equal(12, c.Current);
		}

		[Fact]
		public void TestDiv()
		{
			ICalculator c = new CalculatorImpl();
			Assert.Equal(0, c.Current);
			c.Add(6);
			c.Div(3);
			Assert.Equal(2, c.Current);
		}

        [Fact]
        public void TestDiv2()
        {
            ICalculator c = new CalculatorImpl();
            Assert.Equal(0, c.Current);
            c.Add(7);
            c.Div(3);
            Assert.Equal(2, c.Current);
        }

        [Fact]
		public void TestDivException()
		{
			ICalculator c = new CalculatorImpl();
			Assert.Equal(0, c.Current);
			c.Add(4);
            Assert.Throws<ArgumentException>(() => c.Div(0) );
		}

        [Theory]
        [InlineData(5, 1, 6)]
        [InlineData(7, 1, 8)]
        [InlineData(5, -11, -6)]
        [InlineData(7, -13, -6)]
        public void AddTest(int x, int y, int res)
        {
            ICalculator c = new CalculatorImpl();
            c.Add(x);
            c.Add(y);
            Assert.Equal(c.Current, res);
        }
    }
}
