using System;
using System.Collections.Generic;
using System.Text;

namespace RadarSystemToolbox.MathLibrary
{
    public class RadarRangeEquationOutputs
    {
        public double SignalEnergy { get; set; }

        public double NoiseEnergy { get; set; }

        public double SignalToNoiseRatio { get; set; }

        public double SignalToNoiseRatio_dB => SignalToNoiseRatio.ToDecibels();
    }
}
