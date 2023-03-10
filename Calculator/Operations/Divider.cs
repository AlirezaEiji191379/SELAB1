using Calculator.Abstractions;

namespace Calculator.Operations
{
    public class Divider : IDivider
    {
        public double Divide(double first, double second)
        {
            return first / second;
        }
    }
}
