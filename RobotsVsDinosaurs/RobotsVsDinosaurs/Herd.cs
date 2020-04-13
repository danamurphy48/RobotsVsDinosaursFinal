using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Herd
    {
        //member variables
        public Dinosaur dinosaur;
        public List<Dinosaur> herdOfDinos;
        //constructor
        public Herd()
        {
            dinosaur = new Dinosaur();
            herdOfDinos = new List<Dinosaur>();
            herdOfDinos.Add(new Dinosaur());
            herdOfDinos.Add(new Dinosaur());
            herdOfDinos.Add(new Dinosaur());
        }
         
        //member methods
        
    }
}
