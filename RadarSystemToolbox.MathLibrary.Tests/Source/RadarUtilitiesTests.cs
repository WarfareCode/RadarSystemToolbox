using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RadarSystemToolbox.MathLibrary.Tests
{
    [TestClass]
    public class RadarUtilitiesTests
    {
        [TestMethod]
        public void CalculateTwoWayRangeFromTime_WithValidRange()
        {
            // Arrange:
            var time = 1.0e-6;
            var expectedResult = 150.0;

            // Act:
            var result = RadarUtilities.CalculateTwoWayRangeFromTime(time);

            // Assert:
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void CalculateOneWayRangeFromTime_WithValidRange()
        {
            // Arrange:
            var time = 1.0e-6;
            var expectedResult = 150.0;

            // Act:
            var result = RadarUtilities.CalculateOneWayRangeFromTime(time);

            // Assert:
            Assert.AreEqual(expectedResult, result);
        }
    }
}
