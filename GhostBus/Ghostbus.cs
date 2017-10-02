using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhostBus
{
    class Ghostbus: Bus
    {
       
        public Ghostbus(int TimerTime)
        {
            this.time = TimerTime;
        }
     

        public override string ToString()
        {
            return string.Format("You picked a ghost bus. You lose.");
        }
    }
}
