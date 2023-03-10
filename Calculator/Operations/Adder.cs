using Calculator.Abstractions;

namespace Calculator.Operations
{
    public class Adder : IAdder
    {
        public double Add(double first, double second)
        {
            return first + second;
        }
    }
}
