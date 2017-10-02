using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhostBus
{
    abstract class Bus
    {

        public int time;

        public virtual string ToString(){
            return string.Format("You picked the right bus!");
        }
    }
}
