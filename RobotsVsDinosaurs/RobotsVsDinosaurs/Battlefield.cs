using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Battlefield
    {
        //member variables //fleet vs herd
        public Fleet fleet;
        public Herd herd;
        
        //constructor
        public Battlefield()
        {
            fleet = new Fleet();
            herd = new Herd();
        }

        //member methods
        public void Attack(List<Robot> fleetOfBots) //remove "x" when powerlevel = 0
        {
            foreach(Robot robot in fleetOfBots)
            {
                if (List[0] <= 0)
                {
                    fleetOfBots.Remove(robot);
                }
            }
            //if ()
            //{

            //}
            //return attack;
        }
        //public void CompareAttacks(int fleetScore, int herdScore)   //fix this. original plan to calculate sum individual robots/dinos hp and calculate to get fleetHP/DinoHP
        //{
        //    if(fleetScore > herdScore)
        //    {
        //        fleetScore++;
        //        Console.WriteLine("Robots win this round");
        //    }
        //    else if(fleetScore < herdScore)
        //    {
        //        herdScore++;
        //        Console.WriteLine("Dinosaurs win this round");
        //    }
        //}
        public void ShowGameWinner()    //make list
        {
            if (Fleet <= 0)
            {
                Console.WriteLine("Dinosaurs win the game!");
            }
            else if (Herd <= 0)
            {
                Console.WriteLine("Robots win the game!");
            }
        }
        public void StartGame()
        {
            while((List<Robot>) > 0 && (List<Herd>) > 0)    //make list
            {
                int fleet = Attack();   //working on this
                int herd = Attack();    //working on this
            }
            
            //CompareAttacks(fleetScore, herdScore);
            ShowGameWinner();
        }
    }
}
