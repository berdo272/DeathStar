using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeathStar;

namespace TopSecretPlans
{
    public class ExteriorQuadaniumsteelouterhull : Iactivate
    {
        private int Hardness;
        private int Health = 100;
        private int repairDroids;

        public ExteriorQuadaniumsteelouterhull(int Hardness,int Health,int repairDroids)
        {
            this.Hardness = Hardness;
            this.Health = Health;
            this.repairDroids = repairDroids;
        }
        private void TakeDamage()
        {
            switch (Hardness)
            {
                case 1:
                    Health -= 20;
                    break;
                case 2:
                    Health -= 15;
                    break;
                case 3:
                    Health -= 10;
                    break;
                case 4:
                    Health -= 5;
                    break;
                case 5:
                    Health -= 1;
                    break;
            }     
        }
        private void droidRepairCrew()
        {
            if (Health == 100)
            {
                Console.WriteLine("Hull is at maximum health and does not need repairs.");
            }
            else if (Health >= 95)
            {
                repairDroids--;
                Health = 100;
            }
            else if (Health > 0)
            {
                repairDroids--;
                Health += 5;
            }
            else
            {
                Console.WriteLine("Hull breach is too critical. Droid repair is no longer possible");
            }
        }
        private void replenishDroids()
        {
            repairDroids = 20;
        }

        public void activate()
        {
            Console.WriteLine("Hull integrity is at " + Health + "Percent");
            Console.WriteLine("There are currently " + repairDroids + " repair droids available for emergency repairs.");
            Console.WriteLine("Attemping to repair hull");
            droidRepairCrew();
        }

        public void refresh()
        {
            Console.WriteLine("Replenishing supply of repair droids");
            replenishDroids();
        }
    }
}
