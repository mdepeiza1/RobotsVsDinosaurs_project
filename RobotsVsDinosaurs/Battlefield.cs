using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Battlefield
    {
        // member variables
        // access modifiers
        public Fleet fleet = new Fleet();
        public Herd herd = new Herd(); // use the constructor to instantiate
        // constructor
        public Battlefield()
        {

            fleet.AddRobotToFleet(fleet.CreateRobot("Glide", 100, 100));
            fleet.ElementAt(0).ChooseWeapon(0);

            fleet.AddRobotToFleet(fleet.CreateRobot("Grind", 100, 100));
            fleet.ElementAt(1).ChooseWeapon(0);

            fleet.AddRobotToFleet(fleet.CreateRobot("Delete", 100, 100));
            fleet.ElementAt(2).ChooseWeapon(1);

            herd.AddDinosaurToHerd(herd.CreateDinosaur("T-Rex", 100, 100, 20));
            herd.AddDinosaurToHerd(herd.CreateDinosaur("Stegosaurus", 100, 100, 10));
            herd.AddDinosaurToHerd(herd.CreateDinosaur("Pterodactyl", 100, 100, 5));

            //Weapon weapon1 = new Weapon("Gun", 30); // which class handles this?
            //Weapon weapon2 = new Weapon();

            //Robot robot1 = new Robot("Glide", 100, 100, weapon2); // which class handles this?
            //Robot robot2 = new Robot("Grind", 100, 100, weapon2);
            //Robot robot3 = new Robot("Delete", 100, 100, weapon1);

            //Dinosaur dinosaur1 = new Dinosaur("T-Rex", 100, 100, 20); // etc
            //Dinosaur dinosaur2 = new Dinosaur("Stegosaurus", 100, 100, 10);
            //Dinosaur dinosaur3 = new Dinosaur("Pterodactyl", 100, 100, 5);

            //fleet.AddRobotToFleet(robot1);
            //fleet.AddRobotToFleet(robot2);
            //fleet.AddRobotToFleet(robot3);

            //herd.AddDinosaurToHerd(dinosaur1);
            //herd.AddDinosaurToHerd(dinosaur2);
            //herd.AddDinosaurToHerd(dinosaur3);

            RunGame();
           
        }
        // methods
        // runGame
        // display results
        public void RunGame()
        {
            while ((fleet.ElementAt(0).health > 0 || fleet.ElementAt(1).health > 0
                || fleet.ElementAt(2).health > 0) 
                && (herd.ElementAt(0).health > 0 || herd.ElementAt(1).health > 0
                || herd.ElementAt(2).health > 0))
            {
                herd.ElementAt(0).AttackRobot(fleet.ElementAt(0));
                fleet.ElementAt(0).AttackDinosaur(herd.ElementAt(0));

                herd.ElementAt(1).AttackRobot(fleet.ElementAt(1));
                fleet.ElementAt(1).AttackDinosaur(herd.ElementAt(1));

                herd.ElementAt(2).AttackRobot(fleet.ElementAt(2));
                fleet.ElementAt(2).AttackDinosaur(herd.ElementAt(2));

            }
            DisplayResults();
        }

        public void DisplayResults()
        {
            if (fleet.ElementAt(0).health <= 0 && fleet.ElementAt(1).health <= 0 
                && fleet.ElementAt(2).health <= 0)
            {
                Console.WriteLine("The dinosaurs have won!");
                Console.ReadLine();
            }

            if (herd.ElementAt(0).health <= 0 && herd.ElementAt(1).health <= 0 
                && herd.ElementAt(2).health <= 0)
            {
                Console.WriteLine("The robots have won!");
                Console.ReadLine();
            }
        }
    }
}
