using System;
using System.Collections.Generic;
using System.Text;

namespace MathApplication
{
    public class SubtractionCalculator : ICalculator
    {
        public double Calculate(double x, double y)
        {
            return x - y;
        }
    }
}
