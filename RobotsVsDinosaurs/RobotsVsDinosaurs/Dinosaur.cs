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
        public int attackPower; //shoud this be a string?

        //constructor
        public Dinosaur()
        {
            typeDinosaur = "Stegosaurus";   //does this need to be typeDinosaur?
            health = 100;
            energy = 100;
            attackPower = 100;
        }

        //member methods

        public void PickADinoSaur() //do I string each dino's name?
        {
            Console.WriteLine("Please select a dinosaur: Stegosaurus, Microraptor, or Triceratops.");
            string userInput = Console.ReadLine();  //do I need to use a for loop or a do while to make sure user picks one of the dinos on the list?

            if (userInput == "Stegosaurus")
            {
                Console.WriteLine("You have selected Stegosaurus");
                //need attack information
                //need to be called to herd
                //do I have all of the dinosaurs listed in herd?
            }
            else if (userInput == "Microraptor")
            {
                Console.WriteLine("You have selected Microraptor");
                //needs attack info
                //needs to be called to herd
            }
            else if (userInput == "Triceratops")
            {
                Console.WriteLine("You have selected Triceratops");
            }
        }
    }
}
