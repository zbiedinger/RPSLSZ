using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Lizard : Gesture
    {
        //Member Variables

        //Constructor
        public Lizard()
        {
            name = "lizard";
            stringWeakness = new List<string>() { "rock", "scissors" };

            //Rock rock = new Rock();
            //Scissors scissors = new Scissors();

            //weeknesses = new List<Gesture>() { rock, scissors };
        }

        //Member Methods
    }
}
