using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Fleet
    {
        List<Robot> fleet;

        public Fleet()
        {
            fleet = new List<Robot>();
        }

        public void addRobotToFleet(Robot robot)
        {
            fleet.Add(robot);
        }
    }
}
