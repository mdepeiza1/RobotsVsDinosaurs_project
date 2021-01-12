using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class WeaponList
    {
        //member variables
        List<Weapon> weaponList = new List<Weapon>();

        //constructor
        public WeaponList()
        {
            Weapon gun = new Weapon("Gun", 30);
            Weapon sword = new Weapon("Sword", 15);
            weaponList.Add(gun);
            weaponList.Add(sword);
        }

        //member methods

        public Weapon ElementAt(int i)
        {
            return weaponList.ElementAt(i);
        }
    }
}
