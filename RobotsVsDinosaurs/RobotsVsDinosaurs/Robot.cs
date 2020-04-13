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
        public Weapon weapon;   //could make a list and pick from list ... eventually

        //constructor
        public Robot(string name)
        {
            weapon = new Weapon();
            this.nameRobot = name;
            healthPoints = 100;
            powerLevel = 100;
        }
        //member methods
        public void Attack(Dinosaur dinosaur)
        {
            dinosaur.energy -= 10;
            powerLevel -= 10;
        }
    }
}
