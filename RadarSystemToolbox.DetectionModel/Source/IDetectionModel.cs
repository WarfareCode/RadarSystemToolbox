using System.Collections.Generic;

namespace RadarSystemToolbox.DetectionModel
{
    public interface IDetectionModel
    {
        RadarRangeEquationInputData InputData { get; set; }

        double TargetStartRange { get; set; }

        double TargetEndRange { get; set; }

        double TargetRangeStep { get; set; }

        List<double> TargetRanges { get; set; }

        List<RadarRangeEquationData> Results { get; set; }

        void Run();
    }
}