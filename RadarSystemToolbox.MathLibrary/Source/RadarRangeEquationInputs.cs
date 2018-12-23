namespace RadarSystemToolbox.MathLibrary
{
    public class RadarRangeEquationInputs
    {
        public double TransmitFrequency { get; set; }

        public double TransmitWavelength { get => TransmitFrequency.ToWavelength(); set => TransmitFrequency = value.ToFrequency(); }

        public double TransmitterPeakPower { get; set; }

        public double TransmitPulseDuration { get; set; }

        public double TransmitAntennaGain { get; set; }

        public double TransmitAntennaGain_dB { get => TransmitAntennaGain.ToDecibels(); set => TransmitAntennaGain = value.FromDecibels(); }

        public double ReceiveAntennaGain { get; set; }

        public double ReceiveAntennaGain_dB { get => ReceiveAntennaGain.ToDecibels(); set => ReceiveAntennaGain = value.FromDecibels(); }

        public double SystemLosses { get; set; }

        public double SystemLosses_dB { get => SystemLosses.ToDecibels(); set => SystemLosses = value.FromDecibels(); }

        public double SystemNoiseFactor { get; set; }

        public double SystemNoiseFactor_dB { get => SystemNoiseFactor.ToDecibels(); set => SystemNoiseFactor = value.FromDecibels(); }

        public double NumberOfPulses { get; set; }

        public double TargetRadarCrossSection { get; set; }

        public double TargetRadarCrossSection_dB { get => TargetRadarCrossSection.ToDecibels(); set => TargetRadarCrossSection = value.FromDecibels(); }

        public double TargetRange { get; set; }
    }
}