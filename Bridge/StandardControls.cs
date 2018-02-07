using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class StandardControls :AbstractDriverControls
    {
        public StandardControls(IEngine engine) : base(engine) {

        }
    }
}
