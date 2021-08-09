using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrapezoidalIntegration
{
    internal class Program
    {
        private static void Main()
        {
            //var result = FunctionArea(0, 5, 500, (x) => 50 - Math.Pow(x, 2));
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            var result = FunctionArea(2, 5, 300, (x) => 1.0 / Math.Log(x));
            stopwatch.Stop();
            Console.WriteLine($"Метод трапеции\nЗатрачено: {stopwatch.ElapsedMilliseconds} ms.");
            //var result2 = FunctionAreaSimpson(0, 5, 2, (x) => 50 - Math.Pow(x, 2));
            stopwatch.Start();
            var result2 = FunctionAreaSimpson(2, 5, 10, (x) => 1.0 / Math.Log(x));
            stopwatch.Stop();
            Console.WriteLine($"Метод Симпсона\nЗатрачено: {stopwatch.ElapsedMilliseconds} ms.");
            Console.WriteLine(result);
            Console.WriteLine();
        }

        private static double FunctionAreaSimpson(double start, double end, int amount, Func<double, double> functionCalc)
        {
            double step = (end - start) / amount;
            double area = 0;
            double[] args = new double[amount + 1];
            args[0] = start;
            for (int i = 1; i < args.Length; i++)
            {
                args[i] = args[i - 1] + step;
                double meanValue = (args[i] + args[i - 1]) / 2;
                area += (args[i] - args[i - 1]) / 6 * (functionCalc(args[i - 1]) + 4 * functionCalc(meanValue) + functionCalc(args[i]));
            }
            return area;
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