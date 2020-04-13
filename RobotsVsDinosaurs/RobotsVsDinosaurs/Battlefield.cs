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
        public int fleetScore;
        public int herdScore;
        public int fleetHealthPoints;
        public int herdHealthPoints;
        //constructor
        public Battlefield()
        {
            fleetScore = 0;
            herdScore = 0;
            
        }

        //member methods
        //public string Attack() //need to factor attack power vs hp and multiple rounds of games
        //{
        //    if (robotAttackPower > dinosaurAttackPower)
        //    {

        //    }
        //    return attack;
        //}
        //public void CompareAttacks(int fleetScore, int herdScore)   //fix this
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
        public void ShowGameWinner()
        {
            if (fleetHealthPoints == 0)
            {
                Console.WriteLine("Dinosaurs win the game!");
            }
            else if (herdHealthPoints == 0)
            {
                Console.WriteLine("Robots win the game!");
            }
        }
        public void StartGame()
        {
            while(fleetHealthPoints > 0 && herdHealthPoints > 0)
            {
                int Fleet = Attack();   //working on this
                int Herd = Attack();    //working on this
            }
            
            //CompareAttacks(fleetScore, herdScore);
            ShowGameWinner();
        }
    }
}
