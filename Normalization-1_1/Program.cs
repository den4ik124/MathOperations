using System;
using System.Collections.Generic;
using System.Linq;

namespace Normalization_1_1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IList<double> data = new List<double>() { -4, -1, 2, 7, 11, 17, 25, 98, 99, 100, 111 };
            foreach (var item in data)
                Console.WriteLine(item);
            Console.WriteLine("========");
            Normalization(ref data);

            foreach (var item in data)
                Console.WriteLine(item);
        }

        private static void Normalization(ref IList<double> data)
        {
            double min = data.Min();
            double max = data.Max();
            for (int i = 0; i < data.Count; i++)
                data[i] = -1 + 2 * (data[i] - min) / (max - min);
        }
    }
}