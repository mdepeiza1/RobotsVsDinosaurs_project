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

        public Dinosaur(string type, int health, int energy, int attackPower)
        {
            this.type = type;
            this.health = health;
            this.energy = energy;
            this.attackPower = attackPower;
        }

        public void AttackRobot(Robot robot)
        {
            robot.health -= this.attackPower;
            this.energy -= 10;
        }
    }
}
