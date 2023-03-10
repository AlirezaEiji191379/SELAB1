using Calculator.Operations.enums;

namespace Calculator.Abstractions
{
    public interface ICalculator
    {
        double Calculate(double x, double y,Operation operation);
    }
}
