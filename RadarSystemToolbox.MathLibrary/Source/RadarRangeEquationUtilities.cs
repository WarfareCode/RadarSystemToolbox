using static System.Math;

namespace RadarSystemToolbox.MathLibrary
{
    public static class RadarRangeEquationUtilities
    {
        public static double CalculateSignalEnergy(double transmitFrequency, double transmitterPeakPower, double transmitPulseDuration, double transmitAntennaGain, double receiveAntennaGain, double targetRadarCrossSection, double targetRange, double systemLosses, double numberOfPulses)
        {
            double transmitWavelength = transmitFrequency.ToWavelength();

            double numerator = transmitterPeakPower * transmitPulseDuration * transmitAntennaGain * receiveAntennaGain * Pow(transmitWavelength, 2.0) * numberOfPulses * targetRadarCrossSection;
            double denominator = Pow((4 * PI), 3) * Pow(targetRange, 4.0) * systemLosses;

            double signalEnergy = numerator / denominator;

            return signalEnergy;
        }

        public static double CalculateNoiseEnergy(double noiseFactor)
        {
            double noiseTemperature = CalculateNoiseTemperature(noiseFactor);

            double noiseEnergy = PhysicalConstants.BoltzmannConstant * noiseTemperature;

            return noiseEnergy;
        }

        public static double CalculateNoiseTemperature(double systemNoiseFactor, double systemReferenceTemperature = PhysicalConstants.SystemReferenceTemperature)
        {
            double noiseTemperature = systemReferenceTemperature * systemNoiseFactor;

            return noiseTemperature;
        }

        public static double CalculateSignalToNoiseRatio(double transmitFrequency, double transmitterPeakPower, double transmitPulseDuration, double transmitAntennaGain, double receiveAntennaGain, double targetRadarCrossSection, double targetRange, double systemLosses, double numberOfPulses, double systemNoiseFactor)
        {
            double signalEnergy = CalculateSignalEnergy(transmitFrequency, transmitterPeakPower, transmitPulseDuration, transmitAntennaGain, receiveAntennaGain, targetRadarCrossSection, targetRange, systemLosses, numberOfPulses);
            double noiseEnergy = CalculateNoiseEnergy(systemNoiseFactor);

            double signalToNoiseRatio = signalEnergy / noiseEnergy;

            return signalToNoiseRatio;
        }

        public static RadarRangeEquationOutputs CalculateSignalToNoiseRatio(RadarRangeEquationInputs inputs)
        {
            double signalEnergy = CalculateSignalEnergy(
                inputs.TransmitFrequency,
                inputs.TransmitterPeakPower,
                inputs.TransmitPulseDuration,
                inputs.TransmitAntennaGain,
                inputs.ReceiveAntennaGain,
                inputs.TargetRadarCrossSection,
                inputs.TargetRange,
                inputs.SystemLosses,
                inputs.NumberOfPulses);

            double noiseEnergy = CalculateNoiseEnergy(inputs.SystemNoiseFactor);

            double signalToNoiseRatio = signalEnergy / noiseEnergy;

            RadarRangeEquationOutputs outputs = new RadarRangeEquationOutputs()
            {
                SignalEnergy = signalEnergy,
                NoiseEnergy = noiseEnergy,
                SignalToNoiseRatio = signalToNoiseRatio
            };

            return outputs;
        }
    }
}