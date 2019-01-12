using System;
using System.Linq;
using System.Collections.Generic;
using RadarSystemToolbox.Core;
using RadarSystemToolbox.MathLibrary;

namespace RadarSystemToolbox.DetectionModel
{
    public class DetectionModel : IDetectionModel
    {
        public RadarRangeEquationInputData InputData { get; set; }

        public double TargetStartRange { get; set; }

        public double TargetEndRange { get; set; }

        public double TargetRangeStep { get; set; }

        public List<double> TargetRanges { get; set; }

        public List<RadarRangeEquationData> Results { get; set; }

        public void Run()
        {
            Results = new List<RadarRangeEquationData>();

            var numberOfPoints = (int)((TargetEndRange - TargetStartRange) / (TargetRangeStep)) + 1;

            TargetRanges = MathUtilities.LinSpace(TargetStartRange, TargetEndRange, numberOfPoints).ToList();

            var burstId = 0;

            foreach (var range in TargetRanges)
            {
                var inputData = InputData.Copy();

                inputData.TargetRange = range;

                var outputData = RadarRangeEquationUtilities.CalculateSignalToNoiseRatio(inputData);

                burstId++;

                var data = new RadarRangeEquationData()
                {
                    BurstId = burstId,
                    Inputs = inputData,
                    Outputs = outputData
                };

                Results.Add(data);
            }
        }
    }
}