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
            //robot = new Robot("Dana");
            //robot1 = new Robot("Charles");
            //robot2 = new Robot("Mike T");

            fleetOfBots = new List<Robot>();
            fleetOfBots.Add("Nevin");
            fleetOfBots.Add("Charles");
            fleetOfBots.Add("Mike T");
        }

        //member methods

    }
}
