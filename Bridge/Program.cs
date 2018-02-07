using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            IEngine engine = new StandardEngine(1300);
            StandardControls controls1 = new StandardControls(engine);
            controls1.IgnitionOn();
            controls1.Accelerate();
            controls1.Brake();
            controls1.IgnitionOff();

            SportControls controls2 = new SportControls(engine);
            controls2.IgnitionOn();
            controls2.Accelerate();
            controls2.AcclerateHand();
            controls2.Brake();
            controls2.IgnitionOff();
        }
    }
}
