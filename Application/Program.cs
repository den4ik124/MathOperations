using System;
using System.Collections.Generic;
using Normalization;

namespace Application
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IList<double> data = new List<double>() { -4, -1, 2, 7, 11, 17, 25, 98, 99, 100, 111 };
            IList<double> normalizedList11 = Normalization11.Normalize(data);
            IList<double> normalizedList01 = Normalization01.Normalize(data);

            IList<double> reNormilizedList11 = Normalization11.ReNormalize(normalizedList11, -4, 111);
            IList<double> reNormilizedList01 = Normalization01.ReNormalize(normalizedList01, -4, 111);

            for (int i = 0; i < data.Count; i++)
                Console.WriteLine($"{data[i]}\t{normalizedList01[i]:0.000}\t{normalizedList11[i]:0.000}\t{reNormilizedList01[i]:0.000}\t{reNormilizedList11[i]:0.000}");
        }
    }
}