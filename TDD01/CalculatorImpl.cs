using System;
using System.Diagnostics;

namespace TDD01
{
    public class CalculatorImpl : ICalculator
    {
        int m_x;

        public CalculatorImpl()
        {
        }

        public int Current { get { return m_x;  }}

        public void Add(int x)
        {
            m_x += x;
        }

        public void Clear()
        { m_x = 0; }

        public void Div(int x)
        {
            if (x == 0)
                throw new ArgumentException("Cannot divide by zero");
            m_x /= x;
        }

        public void Mul(int x)
        {
            m_x *= x;
        }

  
    }
}
