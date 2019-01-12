using Microsoft.VisualStudio.TestTools.UnitTesting;
using RadarSystemToolbox.Core;
using RadarSystemToolbox.MathLibrary;

namespace RadarSystemToolbox.DetectionModel.Tests
{
    [TestClass]
    public class DetectionModelTests
    {
        [TestMethod]
        public void Run_WithValidData_ExpectSuccess()
        {
            // Arrange:
            var inputData = new RadarRangeEquationInputData()
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

            var detectionModel = new DetectionModel()
            {
                InputData = inputData,
                TargetStartRange = 1000,
                TargetEndRange = 200000,
                TargetRangeStep = 1000
            };

            // Act:
            detectionModel.Run();

            //detectionModel.Results.WriteToCSVFile(@"c:\temp\DetectionModelResults.csv");

            // Assert:
            Assert.Inconclusive();
        }
    }
}
