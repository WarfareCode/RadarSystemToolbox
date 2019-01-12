using System.Collections.Generic;
using System.Linq;

namespace RadarSystemToolbox.MathLibrary
{
    public static class MathUtilities
    {
        public static IEnumerable<double> LinSpace(double start, double stop, int num, bool endpoint = true)
        {
            var result = new List<double>();
            if (num <= 0)
            {
                return result;
            }

            if (endpoint)
            {
                if (num == 1)
                {
                    return new List<double>() { start };
                }

                var step = (stop - start) / ((double)num - 1.0d);
                result = Enumerable.Range(0, num).Select(v => (v * step) + start).ToList();
            }
            else
            {
                var step = (stop - start) / (double)num;
                result = Enumerable.Range(0, num).Select(v => (v * step) + start).ToList();
            }

            return result;
        }
    }
}