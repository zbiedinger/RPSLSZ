using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Paper : Gesture
    {
        //Member Variables
        
        


        //Constructor
        public Paper()
        {
            name = "paper";

            stringWeakness = new List<string>() { "scissors", "lizard" };

            //Scissors scissors = new Scissors();
            //Lizard lizard = new Lizard();

            //weeknesses = new List<Gesture>() { scissors, lizard };
        }



        //Member Methods
    }
}
