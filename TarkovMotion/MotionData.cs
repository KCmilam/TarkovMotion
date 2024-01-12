using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarkovMotion
{
    public class MotionData
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        // Yaw, Pitch, Roll
        public double Yaw { get; set; }
        public double Pitch { get; set; }
        public double Roll { get; set; }
    }
}
