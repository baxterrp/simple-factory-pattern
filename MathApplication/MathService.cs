using System;
using System.Collections.Generic;
using System.Text;

namespace MathApplication
{
    public class MathService
    {
        private readonly ICalculatorFactory _calculatorFactory;

        public MathService(ICalculatorFactory factory)
        {
            _calculatorFactory = factory;
        }

        public void DoMath()
        {
            Console.WriteLine("Input number 1");
            var num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Input number 2");
            var num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Input the operator */+-");
            var operand = Console.ReadLine();

            try
            {
                ICalculator calculator = _calculatorFactory.GetCalculator(operand);
                try
                {
                    Console.WriteLine("The answer is " + calculator.Calculate(num1, num2));
                }
                catch (ArithmeticException)
                {
                    Console.WriteLine("You cannot divide by zero");
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine("You gave " + operand + " which is an invalid operand");
            }

        }
    }
}
