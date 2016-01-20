using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeathStar
{
    class Barracks
    {
        int inactiveStormtroopers;
        int activeStormtroopers;
        int deployedStormtroopers;
        

        public void activateStormtrooper()
        {
            this.activeStormtroopers++;
            this.inactiveStormtroopers--;
        }
        public void deactivateStormtrooper()
        {
            this.activeStormtroopers--;
            this.inactiveStormtroopers++;
        }
        public void deployToArmory()
        {
            if (activeStormtroopers > 0)
            {
                Console.WriteLine("A stormtrooper has been sent to the armory to be deployed");
                this.activeStormtroopers--;
                this.deployedStormtroopers++;
            } else if (activeStormtroopers == 0)
            {
                Console.WriteLine("You currently have 0 active stormtroopers. Please activate a stormtrooper to standby before deploying.");
            }
        }
        public void recallToBarracks()
        {
            if (deployedStormtroopers > 0)
            {
                Console.WriteLine("A stormtrooper has been recalled to the barracks and is placed in inactive mode");
                this.deployedStormtroopers--;
                this.inactiveStormtroopers++;
            }
            else if (deployedStormtroopers == 0)
            {
                Console.WriteLine("You currently have 0 deployed stormtroopers to recall.");
            }
        }
    }

}
