using static System.Math;

namespace RadarSystemToolbox.MathLibrary
{
    public static class RadarRangeEquationUtilities
    {
        public static double CalculateSignalEnergy(double transmitterPeakPower, double transmitPulseDuration, double transmitAntennaGain, double receiveAntennaGain, double transmitFrequency, double radarCrossSection, double numberOfPulses, double targetRange, double signalLosses)
        {
            var transmitWavelength = transmitFrequency.ToWavelength();

            var numerator = transmitterPeakPower * transmitPulseDuration * transmitAntennaGain * receiveAntennaGain * Pow(transmitWavelength, 2.0) * radarCrossSection * numberOfPulses;
            var denominator = Pow((4 * PI), 3) * Pow(targetRange, 4.0) * signalLosses;

            var signalEnergy = numerator / denominator;

            return signalEnergy;
        }

        public static double CalculateNoiseEnergy(double noiseFactor)
        {
            var noiseTemperature = CalculateNoiseTemperature(noiseFactor);

            var noiseEnergy = PhysicalConstants.BoltzmannConstant * noiseTemperature;

            return noiseEnergy;
        }

        public static double CalculateNoiseTemperature(double noiseFactor, double systemReferenceTemperature = PhysicalConstants.SystemReferenceTemperature)
        {
            var noiseTemperature = systemReferenceTemperature * noiseFactor;

            return noiseTemperature;
        }

        public static double CalculateSignalToNoise(double transmitterPeakPower, double transmitPulseDuration, double transmitAntennaGain, double receiveAntennaGain, double transmitFrequency, double radarCrossSection, double numberOfPulses, double targetRange, double signalLosses, double noiseFactor)
        {
            var signalEnergy = CalculateSignalEnergy(transmitterPeakPower, transmitPulseDuration, transmitAntennaGain, receiveAntennaGain, transmitFrequency, radarCrossSection, numberOfPulses, targetRange, signalLosses);
            var noiseEnergy = CalculateNoiseEnergy(noiseFactor);

            var signalToNoise = signalEnergy / noiseEnergy;

            return signalToNoise;
        }
    }
}