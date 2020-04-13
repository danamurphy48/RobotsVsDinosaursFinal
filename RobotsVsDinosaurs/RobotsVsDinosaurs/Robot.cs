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
            nameRobot = "Charles";
            healthPoints = 100;
            powerLevel = 100;

        }
        //member methods
        public void Attack(Robot robot, Dinosaur dinosaur)
        {
            dinosaur.energy -= 10;
            robot.powerLevel -= 10;
        }
    }
}
