namespace MathApplication
{
    public interface ICalculatorFactory
    {
        ICalculator GetCalculator(string operand);
    }
}