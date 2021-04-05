using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceProject
{
    class wolf : animal
    {
        public wolf()
        {
            SpeciesName = "Canis Lupus";
            Domestication = false;
        }
        public override void Sound()
        {
            base.Sound();
            Console.WriteLine("Awwwoooooo!");
        }
    }
}
