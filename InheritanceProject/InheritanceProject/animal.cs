using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceProject
{
    public class animal
    {
       
        public string SpeciesName { get; set; }
        public bool Domestication { get; set; }

        public  void Sound()
        {
            Console.WriteLine("Listen to the sounds of different dog breeds.");
        }
       public void Pet ()
        {
            Console.WriteLine("Everyone likes to pet a cute dog.");
        }
        public string Play()
        {
            return "Playing with dogs is great fun";
        }
    }
    
}
