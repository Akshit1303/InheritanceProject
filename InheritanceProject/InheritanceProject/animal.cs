using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceProject
{
    class animal
    {
       
        public string SpeciesName { get; set; }
        public bool Domestication { get; set; }

        public virtual void Sound()
        {
            Console.WriteLine("");
        }
       
    }
    
}
