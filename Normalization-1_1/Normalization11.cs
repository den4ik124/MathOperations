using System;
using System.Collections.Generic;
using System.Linq;

namespace Normalization
{
    public class Normalization11
    {
        public static IList<double> Normalize(IList<double> data)
        {
            double min = data.Min();
            double max = data.Max();
            return data.Select(item => -1 + 2 * (item - min) / (max - min)).ToList();
        }

        public static IList<double> ReNormalize(IList<double> dataNorm, double min, double max) =>
            dataNorm.Select(item => min + (item + 1) * (max - min) / 2).ToList();
    }
}