using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSecretPlans
{
    public class CentralComputerCore
    {
        string command;
        int computerPower;
        int coreHealth = 100;
        bool shieldStatus;

        public CentralComputerCore(string Command, int ComputerPower)
        {
            command = Command;
            computerPower = ComputerPower;
        }

        public string IssueCommands(string newCommand)
        {
            return newCommand;
        }
        public void UseComputer()
        {
            computerPower--;
        }
        public void TakeCoreDamage()
        {
            coreHealth--;
        }
        public bool TurnShieldOnOrOff(bool shieldStatus)
        {
            this.shieldStatus = shieldStatus;
            return this.shieldStatus;
        }
        }
    }
}
