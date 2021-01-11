using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Herd
    {
        List<Dinosaur> herd;

          public  Herd()
        {
            herd = new List<Dinosaur>();
        }

        public void addDinosaurToHerd(Dinosaur dinosaur)
        {
            herd.Add(dinosaur);
        }
    }
}
