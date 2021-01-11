using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Battlefield
    {
        Herd herd = new Herd();
        Fleet fleet = new Fleet();

        Robot robot1 = new Robot("Glide", 100, 100, "Sword");
        Robot robot2 = new Robot("Grind", 100, 100, "Sword");
        Robot robot3 = new Robot("Delete", 100, 100, "Gun");

        Dinosaur dinosaur1 = new Dinosaur("T-Rex", 100, 100, 20);
        Dinosaur dinosaur2 = new Dinosaur("Stegosaurus", 100, 100, 10);
        Dinosaur dinosaur3 = new Dinosaur("Pterodactyl", 100, 100, 5);

    }
}
