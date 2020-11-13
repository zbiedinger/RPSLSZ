using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Scissors : Gesture
    {
        //Member Variables

        //Constructor
        public Scissors()
        {
            name = "scissors";
            stringWeakness = new List<string>() { "rock", "spock" };

            //Rock rock = new Rock();
            //Spock spock = new Spock();

            //weeknesses = new List<Gesture>() { rock, spock };
        }

        //Member Methods
    }
}
