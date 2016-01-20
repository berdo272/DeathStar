using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSecretPlans
{
    public class Armory
    {
        int numberOfWeapons;
        int numberOfWeaponsOut;
        bool weaponAvailable;

        public Armory(int numberOfWeapons)
        {
            this.numberOfWeapons = numberOfWeapons;    
        }
        public void TakeWeapon()
        {
            this.numberOfWeapons--;
            this.numberOfWeaponsOut++;
        }
        public void resturnWeapon()
        {
            this.numberOfWeaponsOut--;
            this.numberOfWeapons++;
        }

    }
}
