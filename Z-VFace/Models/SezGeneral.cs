using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z_VFace.Models
{
    public class SezGeneral
    {
        public short TempExtruder { get; set; }
        public short TempBed { get; set; }
        public bool EnableRaft { get; set; }
        public bool EnableSupport { get; set; }
        public bool AutofanEnable { get; set; }
        public short AutofanMaxTime { get; set; }
        public short AutofanMinTime { get; set; }
        public bool AutofanFixedEnabled { get; set; }
        public double AutofanFixedSpeed { get; set; }
        public bool VisibleBottomFirst { get; set; }
        public bool EnableFirstLayer { get; set; }
        public bool EnableBridge { get; set; }
    }
}
