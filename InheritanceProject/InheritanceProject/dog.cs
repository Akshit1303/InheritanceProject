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
        public override void Sound()
        {
            base.Sound();
            Console.WriteLine("Woof! Woof!");

        }
         
    }
}
