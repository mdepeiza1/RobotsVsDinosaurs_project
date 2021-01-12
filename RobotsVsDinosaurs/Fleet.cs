using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Fleet
    {
        public List<Robot> fleet;
        public Robot robot;

        public Fleet()
        {
            fleet = new List<Robot>();
            robot = new Robot("Glide", 100, 100);
            robot.ChooseWeapon();
            fleet.Add(robot);

            robot = new Robot("Grind", 100, 100);
            robot.ChooseWeapon();
            fleet.Add(robot);

            robot = new Robot("Delete", 100, 100);
            robot.ChooseWeapon();
            fleet.Add(robot);
        }

        public Robot CreateRobot(string name, int health, int powerLevel)
        {
            return robot = new Robot(name, health, powerLevel);
        }

        public Robot ElementAt(int i)
        {
            return fleet.ElementAt(i);
        }

        public void AddRobotToFleet(Robot robot)
        {
            fleet.Add(robot);
        }
    }
}
