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
        //member variables //fleet vs herd... don't currently have herd set as a list
        public Fleet fleet;
        public Herd herd;
        
        //constructor
        public Battlefield()
        {
            fleet = new Fleet();
            herd = new Herd();
        }

        //member methods
        //Have Attack method target a single fighter, do damage to them, and display results in console
        //Then think about using a loop to make it happen multiple times
        public void Attack() //remove "x" when powerlevel = 0 idk use a bool somewhere?
        {
            foreach(Robot robot in fleet.fleetOfBots)
            {
                //if (List<Robot>.this.fleet[0] <= 0)
                //{
                //    fleetOfBots.RemoveAt(0);
                //}
                robot.Attack(herd.herdOfDinos[0]);
            }
            //if ()
            //{

            //}
            //return attack;
        }
        public void RemoveAt(List<Dinosaur> herdOfDinos, List<Robot> fleetOfRobots)//trying to remove the defeated players
        {
            
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
        public void ShowGameWinner()    //make list or use a bool?
        {
            if (fleet.fleetOfBots.Count <= 0)
            {
                Console.WriteLine("Dinosaurs win the game!");
            }
            else if (herd.herdOfDinos.Count <= 0)
            {
                Console.WriteLine("Robots win the game!");
            }
        }
        public void StartGame()
        {
            while(fleet.fleetOfBots.Count > 0 && herd.herdOfDinos.Count > 0)    //make list....... use a bool?
            {
                fleet.fleetOfBots.Count = Attack();   //working on this
                herd.herdOfDinos.Count = Attack();    //working on this
            }
            
            //CompareAttacks(fleetScore, herdScore);
            ShowGameWinner();
        }
    }
}
