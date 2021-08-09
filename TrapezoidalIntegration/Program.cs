using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrapezoidalIntegration
{
    internal class Program
    {
        private static void Main()
        {
            //var result = FunctionArea(2, 5, 3, (x) => 1.0 / Math.Log(x));
            var result = FunctionArea(0, 5, 500, (x) => 50 - Math.Pow(x, 2));
            Console.WriteLine(result);
            Console.WriteLine();
        }

        private static double FunctionArea(double start, double end, int amount, Func<double, double> functionCalc)
        {
            double step = (end - start) / amount;
            double area = 0;
            double function = 0;
            double[] args = new double[amount + 1];
            for (int i = 0; i < args.Length; i++)
            {
                if (i == 0)
                {
                    args[i] = start;
                    function = functionCalc(args[i]);
                    continue;
                }
                args[i] = args[i - 1] + step;
                area += (function + functionCalc(args[i])) / 2 * step;
                function = functionCalc(args[i]);
            }
            return area;
        }
    }
}