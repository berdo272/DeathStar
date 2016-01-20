using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopSecretPlans;

namespace DeathStar
{
    public class DeathStar
    {
        Exhaust exhaust;
        TractorBeam tractorBeam;
        MainPowerGenerator mainPowerGenerator;
        HyperMatterReactor hyperMatterReactor;
        IonDriveReactor ionDriveReactor;
        OverBridge overBridge;
        SuperLaser superLaser;
        MagneticShielding magneticShielding;
        HyperDrive hyperDrive;
        PowerCell powerCell;
        CentralComputerCore centralComputerCore;
        HeatExchanger heatExchanger;
        CoolingSystem coolingSystem;
        Refinery refinery;
        FuelCollector fuelCollector;
        ExteriorQuadaniumsteelouterhull exteriorQuadaniumSteelOuterHull;
        Barracks barracks;
        Armory armory;
        
        public void emergencyHullRepair()
        {
            exteriorQuadaniumSteelOuterHull.NaniteRepair();
        }
        public void calltoArms()
        {
            barracks.activateStormtrooper();
            barracks.deployToArmory();
            armory.TakeWeapon();
        }
        public void disarmForce()
        {
            armory.resturnWeapon();
            barracks.recallToBarracks();
        }
    }
}
