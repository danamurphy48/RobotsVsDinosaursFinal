using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Fleet
    {
        //member variables
        //public Robot robot;
        //public Robot robot1;
        //public Robot robot2;
        public List<Robot> fleetOfBots;

        //constructor
        public Fleet()
        {
            //robot = new Robot("Nevin");
            //robot1 = new Robot("Charles");
            //robot2 = new Robot("Mike T");

            fleetOfBots = new List<Robot>();
            Robot nevin = new Robot("Nevin");
            fleetOfBots.Add(nevin);
            Robot charles = new Robot("Charles");
            //fleetOfBots.Add(new Robot("Charles")); does'nt make a variable
            fleetOfBots.Add(new Robot("Mike T"));
        }

        //member methods

    }
}
