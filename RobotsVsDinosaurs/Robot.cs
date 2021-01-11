using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Robot
    {
        public string name;
        public int health;
        public int powerLevel;
        public Weapon weapon;

        public Robot(string name, int health, int powerLevel, Weapon weapon) 
            //string weaponChoice)
        {
            this.name = name;
            this.health = health;
            this.powerLevel = powerLevel;
            this.weapon = weapon;

            //if (weaponChoice == "Gun")
            //{
            //    weapon = new Weapon("Gun");
            //}

            //if (weaponChoice == "Sword")
            //{
            //    weapon = new Weapon("Sword");
            //}
        }

        public void attackDinosaur(Dinosaur dinosaur)
        {
                dinosaur.health -= this.weapon.attackPower;
        }
    }
}
