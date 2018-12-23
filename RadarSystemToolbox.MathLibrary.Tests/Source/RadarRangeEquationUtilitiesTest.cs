using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RadarSystemToolbox.MathLibrary.Tests
{
    [TestClass]
    public class RadarRangeEquationUtilitiesTest
    {
        [TestMethod]
        public void CalculateCalculateSignalToNoise()
        {
            // Arrange:
            var transmitterPeakPower = 8000.0;
            var transmitPulseDuration = 1e-6;
            var transmitAntennaGain = 34.0.FromDecibels();
            var receiveAntennaGain = 34.0.FromDecibels();
            var transmitFrequency = 10e9;
            var radarCrossSection = 5.0;
            var numberOfPulses = 1024;
            var targetRange = 100e3;
            var signalLosses = 6.0.FromDecibels();
            var noiseFactor = 3.0.FromDecibels();

            // Act:
            var signalToNoise = RadarRangeEquationUtilities.CalculateSignalToNoise(transmitterPeakPower, transmitPulseDuration, transmitAntennaGain, receiveAntennaGain, transmitFrequency, radarCrossSection, numberOfPulses, targetRange, signalLosses, noiseFactor);

            // Assert:
            Assert.Inconclusive();
        }
    }
}
