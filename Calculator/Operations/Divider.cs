using Calculator.Abstractions;

namespace Calculator.Operations
{
    public class Divider : IDivider
    {
        public double Divide(double first, double second)
        {
            if(second == 0)
            {
                throw new DivideByZeroException();
            }
            return first / second;
        }
    }
}
