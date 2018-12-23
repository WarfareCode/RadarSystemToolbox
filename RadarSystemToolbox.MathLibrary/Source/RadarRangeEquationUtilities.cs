using static System.Math;

namespace RadarSystemToolbox.MathLibrary
{
    public static class RadarRangeEquationUtilities
    {
        public static double CalculateSignalEnergy(double transmitFrequency, double transmitterPeakPower, double transmitPulseDuration, double transmitAntennaGain, double receiveAntennaGain, double targetRadarCrossSection, double targetRange, double systemLosses, double numberOfPulses)
        {
            var transmitWavelength = transmitFrequency.ToWavelength();

            var numerator = transmitterPeakPower * transmitPulseDuration * transmitAntennaGain * receiveAntennaGain * Pow(transmitWavelength, 2.0) * numberOfPulses * targetRadarCrossSection;
            var denominator = Pow((4 * PI), 3) * Pow(targetRange, 4.0) * systemLosses;

            var signalEnergy = numerator / denominator;

            return signalEnergy;
        }

        public static double CalculateNoiseEnergy(double noiseFactor)
        {
            var noiseTemperature = CalculateNoiseTemperature(noiseFactor);

            var noiseEnergy = PhysicalConstants.BoltzmannConstant * noiseTemperature;

            return noiseEnergy;
        }

        public static double CalculateNoiseTemperature(double systemNoiseFactor, double systemReferenceTemperature = PhysicalConstants.SystemReferenceTemperature)
        {
            var noiseTemperature = systemReferenceTemperature * systemNoiseFactor;

            return noiseTemperature;
        }

        public static double CalculateSignalToNoiseRatio(double transmitFrequency, double transmitterPeakPower, double transmitPulseDuration, double transmitAntennaGain, double receiveAntennaGain, double targetRadarCrossSection, double targetRange, double systemLosses, double numberOfPulses, double systemNoiseFactor)
        {
            var signalEnergy = CalculateSignalEnergy(transmitFrequency, transmitterPeakPower, transmitPulseDuration, transmitAntennaGain, receiveAntennaGain, targetRadarCrossSection, targetRange, systemLosses, numberOfPulses);
            var noiseEnergy = CalculateNoiseEnergy(systemNoiseFactor);

            var signalToNoiseRatio = signalEnergy / noiseEnergy;

            return signalToNoiseRatio;
        }

        public static RadarRangeEquationOutputs CalculateSignalToNoiseRatio(RadarRangeEquationInputs inputs)
        {
            var signalEnergy = CalculateSignalEnergy(
               inputs.TransmitFrequency,
               inputs.TransmitterPeakPower,
                inputs.TransmitPulseDuration,
                inputs.TransmitAntennaGain,
                inputs.ReceiveAntennaGain,
                inputs.TargetRadarCrossSection,
                inputs.TargetRange,
                inputs.SystemLosses,
                inputs.NumberOfPulses);

            var noiseEnergy = CalculateNoiseEnergy(inputs.SystemNoiseFactor);

            var signalToNoiseRatio = signalEnergy / noiseEnergy;

            var outputs = new RadarRangeEquationOutputs()
            {
                SignalEnergy = signalEnergy,
                NoiseEnergy = noiseEnergy,
                SignalToNoiseRatio = signalToNoiseRatio
            };

            return outputs;
        }
    }
}