using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhostBus
{
    class manager
    {
        RegularBus bus1 = new RegularBus(4);
        RegularBus bus2 = new RegularBus(12);
        RegularBus bus3 = new RegularBus(20);
        Ghostbus gb1 = new Ghostbus(2);
        Ghostbus gb2 = new Ghostbus(7);
        Ghostbus gb3 = new Ghostbus(13);

        Bus[] Level1Buses;
        Bus[] Level2Buses;
        Bus[] Level3Buses;

        Level level1; 
        Level level2;
        Level level3;

        Level CurrentLevel;
        public void init()
        {
              Level1Buses = new Bus[] { bus1, gb1, bus2, bus3 };
              Level2Buses = new Bus[] {gb1, bus1, bus2, gb2, bus3};
              Level3Buses = new Bus[] {bus1, gb1, bus2, gb2, gb3, bus3};

              Level level1 = new Level(Level1Buses);
              Level level2 = new Level(Level2Buses);
              Level level3 = new Level(Level3Buses);
              CurrentLevel = level1;
        }

        public int[] RequestArrivals()
        {
            return CurrentLevel.RequestArrivals();
        }
    }
}
