using Calculator.Abstractions;

namespace Calculator.Operations
{
    public class Subtractor : ISubtractor
    {
        public double Subtract(double first, double second)
        {
            return first - second;
        }
    }
}
