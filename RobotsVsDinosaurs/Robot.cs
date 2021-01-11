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

        public Robot(string name, int health, int powerLevel) 
            //string weaponChoice)
        {
            this.name = name;
            this.health = health;
            this.powerLevel = powerLevel;

            //if (weaponChoice == "Gun")
            //{
            //    weapon = new Weapon("Gun");
            //}

            //if (weaponChoice == "Sword")
            //{
            //    weapon = new Weapon("Sword");
            //}
        }

        public void CreateWeapon(string type, int attackPower)
        {
            weapon = new Weapon(type, attackPower);
        }

        public void AttackDinosaur(Dinosaur dinosaur)
        {
                dinosaur.health -= this.weapon.attackPower;
                this.powerLevel -= 10;
        }
    }
}
