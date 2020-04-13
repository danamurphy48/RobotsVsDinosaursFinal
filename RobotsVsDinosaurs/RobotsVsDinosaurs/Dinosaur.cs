using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Dinosaur
    {
        //member variables
        public string typeDinosaur;
        public int health;
        public int energy;
        public int attackPower;

        //constructor
        public Dinosaur()
        {
            typeDinosaur = PickADinosaur();
            health = 100;
            energy = 100;
            attackPower = 100;
        }
        //member methods
        public string PickADinosaur()
        {
            Console.WriteLine("Please select a dinosaur: Stegosaurus, Microraptor, or Triceratops.");
            string userInput = Console.ReadLine();

            if (userInput == "Stegosaurus")
            {
                Console.WriteLine("You have selected Stegosaurus");
            }
            else if (userInput == "Microraptor")
            {
                Console.WriteLine("You have selected Microraptor");
            }
            else if (userInput == "Triceratops")
            {
                Console.WriteLine("You have selected Triceratops");
            }
            return userInput;
        }
        public void Attack(Robot robot, Dinosaur dinosaur)
        {
            robot.healthPoints -= 20;
            dinosaur.energy -= 5;
        }
    }
}
