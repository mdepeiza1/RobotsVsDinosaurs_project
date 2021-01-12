using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class AttackTypeArray
    {
        //member variables
        public int[] attackTypeArray;

        //constructor
        public AttackTypeArray()
        {
            attackTypeArray = new int[3];
            attackTypeArray[0] = 10;
            attackTypeArray[1] = 15;
            attackTypeArray[2] = 20;
        }

        //member methods
        public int GetValue(int i)
        {
            return attackTypeArray[i];
        }
    }
}
