using System;

namespace MathApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string continueFlag;
            var service = new MathService(new CalculatorFactory());
            do
            {
                service.DoMath();
                Console.WriteLine("Would you like to continue? [y/n]");

                continueFlag = Console.ReadLine();
            } while ("y".Equals(continueFlag, StringComparison.OrdinalIgnoreCase));

            Console.ReadKey();
        }
    }
}
