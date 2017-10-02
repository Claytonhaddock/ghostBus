using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhostBus
{
    class RegularBus: Bus
    {
        public RegularBus(int TimerTime)
        {
            this.time = TimerTime;
        }
    }
}
