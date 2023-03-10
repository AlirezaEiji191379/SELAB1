// See https://aka.ms/new-console-template for more information
using Calculator.Operations;
using Calculator.Operations.enums;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Sample Calculator");

        var calculator = new CalculateHandler();
        Console.WriteLine(calculator.Calculate(1,2,Operation.Add));
    }
}