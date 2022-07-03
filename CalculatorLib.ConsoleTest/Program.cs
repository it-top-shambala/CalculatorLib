using CalculatorLib.Lib;

namespace CalculatorLib.ConsoleTest
{
    internal static class Program
    {
        private static void Main()
        {
            var x = 5.0;
            var y = 10.0;
            var zero = 0.0;
            double result;

            result = Calculator.Add(x, y);
            Console.WriteLine($"{x} + {y} = {result}");
            
            result = Calculator.Sub(x, y);
            Console.WriteLine($"{x} - {y} = {result}");
            
            result = Calculator.Mul(x, y);
            Console.WriteLine($"{x} * {y} = {result}");
            
            result = Calculator.Div(x, y);
            Console.WriteLine($"{x} / {y} = {result}");

            try
            {
                result = Calculator.Div(x, zero);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}