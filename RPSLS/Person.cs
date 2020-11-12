using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Person : Victim
    {
        //Member Variables


        //Constructor
        public Person(string playerName)
        {
            this.playerName = playerName;
           
            Rock rock = new Rock();
            Paper paper = new Paper();
            Scissors scissors = new Scissors();
            Lizard lizard = new Lizard();
            Spock spock = new Spock();

            gestureChoices = new List<Gesture>() { rock, paper, scissors, lizard, spock };
        }


        //Member Methods
        public string SelectingGesture()
        {
            currentGesture = "";

            return currentGesture;
        }

    }
}
