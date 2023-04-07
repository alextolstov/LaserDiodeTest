using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaserDiodeTest
{
    public class QCWData
    {
        public bool IsQCWTest { get; set; }
        public int Wavelength { get; set;}
        public int Grade { get; set; }
        public double CoeffPower { get; set; }
        public double PulseDuration_ms { get; set; }
        public double DutyCycle { get; set; }
        public double MaximumCurrent_A { get; set; }
        public double OperatingCurrent_A { get; set; }
        public double Step_A { get; set; }
        public double ThresholdPower_W { get; set; }
        public int MeasurementTime_ms { get; set; }
        public double MinThresholdCurrent_A { get; set; }
        public double MaxThresholdCurrent_A { get; set; }
        public double MinSlope_WA { get; set; }
        public double MaxSlope_WA { get; set; }
        public double MinPowAtOp_W { get; set; }
        public double MinPowAtMax_W { get; set; }
    }
}
