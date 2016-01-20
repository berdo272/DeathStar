using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSecretPlans
{
    public class Exhaust
    {
        public int Diameter;
        public int Length;
        public int numberOfFans;
        
        public Exhaust(int diameter, int length, int numberOfFans)
        {
            this.Diameter = diameter;
            this.Length = length;
            this.numberOfFans = numberOfFans;
        }
        public bool isOpen;

        public virtual Radiation ExpendExhaust()
        {
            return null;
        }
    }
}
