using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Rock : Gesture
    {
        //Member Variables


        //Constructor
        public Rock()
        {
            name = "rock";

            stringWeakness = new List<string>() { "paper", "spock" };

            //Paper paper = new Paper();
            //Spock spock = new Spock();

            //weeknesses = new List<Gesture> { paper, spock };
        }



        //Member Methods
    }
}
