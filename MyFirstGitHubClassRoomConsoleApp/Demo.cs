using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstGitHubClassRoomConsoleApp
{
    class Demo
    {
        public string _commander { get; set; }
        public int _numberOfTroops { get; set; }
        public string _warCry { get; set; }

        public Demo(string commander, int numberOfTroops, string warCry)
        {
            _commander = commander;
            _numberOfTroops = numberOfTroops;
            _warCry = warCry;
        }

        public string ArmyPresent()
        {
            string presentArmy = $"Commander {_commander} presents an army of {_numberOfTroops}. {_warCry}";
            return presentArmy;

        }
    }
}
