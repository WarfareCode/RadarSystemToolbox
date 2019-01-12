using System;
using System.Collections.Generic;
using System.Text;

namespace RadarSystemToolbox.DetectionModel
{
    public class RadarRangeEquationData
    {
        public int BurstId { get; set; }

        public RadarRangeEquationInputData Inputs { get; set; }

        public RadarRangeEquationOutputData Outputs { get; set; }
    }
}
