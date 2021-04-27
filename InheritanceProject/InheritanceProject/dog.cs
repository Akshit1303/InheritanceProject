using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceProject
{
    class dog : animal
    {
        public string breedName { get; set; }


        public dog (string Breed_Name)
        {
            SpeciesName = "Canis lupus familiaris";
            Domestication = true;
            breedName = Breed_Name;
        }
        public  void DogSound()
        {
            base.Sound();
            Console.WriteLine("Woof! Woof!");

        }
         public void doActivity()
        {
            base.Play();
            Console.WriteLine("Dogs are great pets!");
        }
    }
}
