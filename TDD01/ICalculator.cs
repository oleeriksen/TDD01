using System;
namespace TDD01
{
    public interface ICalculator
    {
        void Add(int x);
        void Mul(int x);
        void Div(int x);
        void Clear();
        int Current { get;  }
    }
}
