using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RadarSystemToolbox.MathLibrary.Tests
{
    [TestClass]
    public class RadarRangeEquationUtilitiesTest
    {
        [TestMethod]
        public void CalculateCalculateSignalToNoiseRatio_1()
        {
            // Arrange:
            var transmitFrequency = 10e9;
            var transmitterPeakPower = 8000.0;
            var transmitPulseDuration = 1e-6;
            var transmitAntennaGain = 34.0.FromDecibels();
            var receiveAntennaGain = 34.0.FromDecibels();
            var targetRadarCrossSection = 5.0;
            var targetRange = 100e3;
            var systemLosses = 6.0.FromDecibels();
            var systemNoiseFactor = 3.0.FromDecibels();
            var numberOfPulses = 1024;

            // Act:
            var signalToNoise = RadarRangeEquationUtilities.CalculateSignalToNoiseRatio(transmitFrequency, transmitterPeakPower, transmitPulseDuration, transmitAntennaGain, receiveAntennaGain, targetRadarCrossSection, targetRange, systemLosses, numberOfPulses, systemNoiseFactor);

            // Assert:
            Assert.Inconclusive();
        }

        [TestMethod]
        public void CalculateCalculateSignalToNoiseRatio_2()
        {
            var inputs = new RadarRangeEquationInputs()
            {
                TransmitFrequency = 10e9,
                TransmitterPeakPower = 8000.0,
                TransmitPulseDuration = 1e-6,
                TransmitAntennaGain_dB = 34.0,
                ReceiveAntennaGain_dB = 34.0,
                TargetRadarCrossSection = 5.0,
                TargetRange = 100e3,
                SystemLosses_dB = 6.0,
                SystemNoiseFactor_dB = 3.0,
                NumberOfPulses = 1024,
            };

            // Act:
            var outputs = RadarRangeEquationUtilities.CalculateSignalToNoiseRatio(inputs);

            // Assert:
            Assert.Inconclusive();
        }
    }
}
