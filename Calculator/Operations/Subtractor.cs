using Calculator.Abstractions;

namespace Calculator.Operations
{
    public class Subtractor : ISubtractor
    {
        public int Subtract(int first, int second)
        {
            return first - second;
        }
    }
}
