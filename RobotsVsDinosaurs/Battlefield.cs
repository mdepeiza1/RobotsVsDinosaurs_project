using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Battlefield
    {
        public Battlefield()
        {
            Fleet fleet = new Fleet();
            Herd herd = new Herd();

            Weapon weapon1 = new Weapon("Gun", 30);
            Weapon weapon2 = new Weapon("Sword", 15);

            Robot robot1 = new Robot("Glide", 100, 100, weapon2);
            Robot robot2 = new Robot("Grind", 100, 100, weapon2);
            Robot robot3 = new Robot("Delete", 100, 100, weapon1);

            Dinosaur dinosaur1 = new Dinosaur("T-Rex", 100, 100, 20);
            Dinosaur dinosaur2 = new Dinosaur("Stegosaurus", 100, 100, 10);
            Dinosaur dinosaur3 = new Dinosaur("Pterodactyl", 100, 100, 5);

            fleet.addRobotToFleet(robot1);
            fleet.addRobotToFleet(robot2);
            fleet.addRobotToFleet(robot3);

            herd.addDinosaurToHerd(dinosaur1);
            herd.addDinosaurToHerd(dinosaur2);
            herd.addDinosaurToHerd(dinosaur3);

        }
    }
}
