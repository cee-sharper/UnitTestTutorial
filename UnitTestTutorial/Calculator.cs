using System;

namespace UnitTestTutorial
{
    class Calculator
    {
        public static decimal Add(decimal a, decimal b)
        {
            return a + b;
        }

        internal static decimal Substract(decimal a, decimal b)
        {
            return a - b;
        }

        internal static decimal Multiply(decimal a, decimal b)
        {
            return a * b;
        }

        internal static decimal Divide(decimal a, decimal b)
        {
            if (b == 0)
            {
                throw new Exception("No se puede dividir entre cero.");
            }
            return a / b;
        }
    }
}
