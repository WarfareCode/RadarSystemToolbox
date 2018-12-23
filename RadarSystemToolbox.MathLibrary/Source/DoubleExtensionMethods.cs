using static RadarSystemToolbox.MathLibrary.PhysicalConstants;
using static System.Math;

namespace RadarSystemToolbox.MathLibrary
{
    public static class DoubleExtensionMethods
    {
        public static double ToWavelength(this double frequency)
        {
            var wavelength = SpeedOfLight / frequency;

            return wavelength;
        }

        public static double ToFrequency(this double wavelength)
        {
            var frequency = SpeedOfLight / wavelength;

            return frequency;
        }

        public static double ToDecibels(this double value)
        {
            var value_dB = 10 * Log10(value);

            return value_dB;
        }

        public static double FromDecibels(this double value_dB)
        {
            var value = Pow(10, (value_dB / 10));

            return value;
        }
    }
}