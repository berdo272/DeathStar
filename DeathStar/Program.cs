using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopSecretPlans;

namespace DeathStar
{
    public class Program
    {
        

        static void Main(string[] args)
        {
            ExteriorQuadaniumsteelouterhull Hull = new ExteriorQuadaniumsteelouterhull( 5, 80, 20);

            Hull.activate();

            Hull.activate();
        }
    }
}
