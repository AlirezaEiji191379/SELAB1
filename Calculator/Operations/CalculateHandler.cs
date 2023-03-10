using Calculator.Abstractions;
using Calculator.Operations.enums;

namespace Calculator.Operations
{
    public class CalculateHandler : ICalculator
    {

        private readonly IAdder _adder;
        private readonly ISubtractor _subtractor;
        private readonly IMultiplier _multiplier;
        private readonly IDivider _divider;
        public CalculateHandler()
        {
            _adder = new Adder();
            _subtractor = new Subtractor();
            _multiplier = new Multiplier();
            _divider = new Divider();

        }

        public double Calculate(double x, double y,Operation operation)
        {
            if(operation == Operation.Add)
            {
                return _adder.Add(x, y);
            }
            else if(operation == Operation.Subtract)
            {
                return _subtractor.Subtract(x, y);
            }
            else if(operation == Operation.Multiply)
            {
                return _multiplier.Multiply(x,y);
            }
            else if(operation == Operation.Divide)
            {
                return _divider.Divide(x,y);
            }
            throw new NotSupportedException();
        }
    }
}
