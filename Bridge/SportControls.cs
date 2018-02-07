using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class SportControls : AbstractDriverControls
    {
        public SportControls(IEngine engine) : base(engine) { }

        public virtual void AcclerateHand() {
            Accelerate();
            Accelerate();
        }
    }
}
