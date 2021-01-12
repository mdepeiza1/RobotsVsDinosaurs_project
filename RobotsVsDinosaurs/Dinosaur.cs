using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Dinosaur
    {
        public string type;
        public int health;
        public int energy;
        public int attackPower;
        public int attackType;
        public AttackTypeArray attackTypeArray;

        public Dinosaur(string type, int health, int energy, int attackPower)
        {
            this.type = type;
            this.health = health;
            this.energy = energy;
            this.attackPower = attackPower;
            this.attackTypeArray = new AttackTypeArray();
        }

        public void AttackRobot(Robot robot)
        {
            Console.WriteLine("Please choose attack type for the " + this.type + ". Choose by using a number. " +
                "1 is bite. 2 is tail strike. 3 is headbutt.");
            attackType = Int32.Parse(Console.ReadLine());
            attackPower = attackTypeArray.GetValue(attackType-1);
            robot.health -= this.attackPower;
            this.energy -= 10;
        }
    }
}
