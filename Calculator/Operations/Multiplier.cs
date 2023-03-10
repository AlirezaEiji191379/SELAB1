using Calculator.Abstractions;

namespace Calculator.Operations
{
    public class Multiplier : IMultiplier
    {
        public double Multiply(double first, double second)
        {
            return first * second;
        }
    }
}
