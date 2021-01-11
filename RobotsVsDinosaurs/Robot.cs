using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Robot
    {
        string name;
        int health;
        int powerLevel;
        Weapon weapon;

        public Robot(string name, int health, int powerLevel, string weaponChoice)
        {
            this.name = name;
            this.health = health;
            this.powerLevel = powerLevel;

            if (weaponChoice == "Gun")
            {
                weapon = new Weapon("Gun");
            }

            if (weaponChoice == "Sword")
            {
                weapon = new Weapon("Sword");
            }
        }
    }
}
