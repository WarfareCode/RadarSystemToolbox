namespace RadarSystemToolbox.MathLibrary
{
    public static class RadarUtilities
    {
        public static double CalculateOneWayRangeFromTime(double time)
        {
            var range = PhysicalConstants.SpeedOfLight * time;

            return range;
        }

        public static double CalculateTwoWayRangeFromTime(double time)
        {
            var range = PhysicalConstants.SpeedOfLight * time / 2;

            return range;
        }

        public static double CalculateOneWayTimeFromRange(double range)
        {
            var time = range / PhysicalConstants.SpeedOfLight;

            return range;
        }

        public static double CalculateTwoWayTimeFromRange(double range)
        {
            var time = 2 * range / PhysicalConstants.SpeedOfLight;

            return range;
        }
    }
}