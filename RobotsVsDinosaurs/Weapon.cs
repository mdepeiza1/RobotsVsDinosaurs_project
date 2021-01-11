using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Weapon
    {
        string type;
        int attackPower;

        public Weapon(string type)
        {
            this.type = type;

            if(type == "Gun")
            {
                attackPower = 30;
            }
            if(type == "Sword")
            {
                attackPower = 15;
            }
        }
    }
}
