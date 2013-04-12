using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pixelsense.Infrared
{
    public class InfraredInputEventArgs:EventArgs
    {
        public InfraredInput Led { get; set; }
        public InfraredInputEventArgs(InfraredInput led)
        {
            Led = led;
        }
    }
}
