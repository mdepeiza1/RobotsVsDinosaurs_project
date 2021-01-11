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

            while(true)
            {
                dinosaur1.attackRobot(robot1);
                robot1.attackDinosaur(dinosaur1);
                dinosaur2.attackRobot(robot2);
                robot2.attackDinosaur(dinosaur2);
                dinosaur3.attackRobot(robot3);
                robot3.attackDinosaur(dinosaur3);


                if (robot1.health <= 0 && robot2.health <= 0 && robot3.health <= 0)
                {
                    Console.WriteLine("The dinosaurs have won!");
                    Console.ReadLine();
                    break;
                }

                if (dinosaur1.health <= 0 && dinosaur2.health <= 0 && dinosaur3.health <= 0)
                {
                    Console.WriteLine("The robots have won!");
                    Console.ReadLine();
                    break;
                }
            }
        }
    }
}
