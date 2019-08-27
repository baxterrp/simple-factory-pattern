using System;

namespace MathApplication
{
    public class CalculatorFactory : ICalculatorFactory
    {
        public ICalculator GetCalculator(string operand)
        {
            switch (operand)
            {
                case "+":
                    return new AdditionCalculator();
                case "*":
                    return new MultiplacationCalculator();
                case "-":
                    return new SubtractionCalculator();
                case "/":
                    return new DivisionCalculator();
                default:
                    throw new ArgumentException(nameof(operand));
            }
        }
    }
}
