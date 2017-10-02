using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhostBus
{
    class Level
    {
        Bus[] buses;
        

        public Level(Bus[] BusArray){
            this.buses = BusArray;
            
        }

        


        public int[] RequestArrivals()
        {
            int[] times;
            times = new int[buses.Length];
            for (int i = 0; i < buses.Length; i++)
            {
                times[i] = buses[i].time;
            }
            return times;
        }
    }

        
}
    

