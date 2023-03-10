using Calculator.Abstractions;

namespace Calculator.Operations
{
    public class Adder : IAdder
    {
        public int Add(int first, int second)
        {
            return first + second;
        }
    }
}
