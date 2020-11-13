using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Spock : Gesture
    {
        //Member Variables

        //Constructor
        public Spock()
        {
            name = "spock";
            stringWeakness = new List<string>() { "paper", "lizard" };

            //Paper paper = new Paper();
            //Lizard lizard = new Lizard();

            //weeknesses = new List<Gesture>() { paper, lizard };
        }

        //Member Methods
    }
}
