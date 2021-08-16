using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Normalization
{
    public class Normalization01
    {
        public static IList<double> Normalize(IList<double> data)
        {
            double min = data.Min();
            double max = data.Max();
            return data.Select(item => (item - min) / (max - min)).ToList();
        }

        public static IList<double> ReNormalize(IList<double> dataNorm, double min, double max) =>
            dataNorm.Select(item => min + item * (max - min)).ToList();

        public static void SimpleHack()
        {
            qq =)
        }
    }
}