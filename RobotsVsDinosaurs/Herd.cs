using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Herd
    {
        public List<Dinosaur> herd;
        public Dinosaur dinosaur;

          public  Herd()
        {
            herd = new List<Dinosaur>();
            dinosaur = new Dinosaur("T-Rex", 100, 100, 20);
            herd.Add(dinosaur);
            dinosaur = new Dinosaur("Stegosaurus", 100, 100, 10);
            herd.Add(dinosaur);
            dinosaur = new Dinosaur("Pterodactyl", 100, 100, 5);
            herd.Add(dinosaur);
        }

        public Dinosaur CreateDinosaur(string type, int health, int energy, int attackPower)
        {
            return dinosaur = new Dinosaur(type, health, energy, attackPower);
        }

        public Dinosaur ElementAt(int i)
        {
            return herd.ElementAt(i);
        }

        public void AddDinosaurToHerd(Dinosaur dinosaur)
        {
            herd.Add(dinosaur);
        }
    }
}
