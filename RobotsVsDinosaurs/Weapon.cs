using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Weapon
    {
        public string type;
        public int attackPower;

        public Weapon(string type, int attackPower)
        {
            this.type = type;
            this.attackPower = attackPower;

            //if(type == "Gun")
            //{
            //    attackPower = 30;
            //}
            //if(type == "Sword")
            //{
            //    attackPower = 15;
            //}
        }
    }
}
