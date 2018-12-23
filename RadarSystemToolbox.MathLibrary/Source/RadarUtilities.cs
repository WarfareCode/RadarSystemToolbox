namespace RadarSystemToolbox.MathLibrary
{
    public static class RadarUtilities
    {
        public static double CalculateOneWayRangeFromTime(double time)
        {
            double range = PhysicalConstants.SpeedOfLight * time;

            return range;
        }

        public static double CalculateTwoWayRangeFromTime(double time)
        {
            double range = PhysicalConstants.SpeedOfLight * time / 2;

            return range;
        }

        public static double CalculateOneWayTimeFromRange(double range)
        {
            double time = range / PhysicalConstants.SpeedOfLight;

            return range;
        }

        public static double CalculateTwoWayTimeFromRange(double range)
        {
            double time = 2 * range / PhysicalConstants.SpeedOfLight;

            return range;
        }
    }
}