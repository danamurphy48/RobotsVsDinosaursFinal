using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Robot
    {
        //member variables
        public string nameRobot;
        public int healthPoints;
        public int powerLevel;
        public Weapon weapon;

        //constructor
        public Robot()
        {
            weapon = new Weapon();

        }
        //member methods
        public void SelectRobot()
        {
            Console.WriteLine();
        }
    }
}
