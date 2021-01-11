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
