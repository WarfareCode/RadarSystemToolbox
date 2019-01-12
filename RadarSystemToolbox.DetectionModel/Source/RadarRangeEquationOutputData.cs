using RadarSystemToolbox.MathLibrary;

namespace RadarSystemToolbox.DetectionModel
{
    public class RadarRangeEquationOutputData
    {
        public double SignalEnergy { get; set; }

        public double NoiseEnergy { get; set; }

        public double SignalToNoiseRatio { get; set; }

        public double SignalToNoiseRatio_dB => SignalToNoiseRatio.ToDecibels();
    }
}