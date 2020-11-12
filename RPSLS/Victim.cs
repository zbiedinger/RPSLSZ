using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Victim
    {
        //Member Variables
        public string playerName;
        public List<Gesture> gestureChoices;
        public int score;
        public string currentGesture;
        Random rand;



        //Constructor
        public Victim(string playerName)
        {
            this.playerName = playerName;
            score = 0;
            currentGesture = "";
            rand = new Random();

            Rock rock = new Rock();
            Paper paper = new Paper();
            Scissors scissors = new Scissors();
            Lizard lizard = new Lizard();
            Spock spock = new Spock();

            gestureChoices = new List<Gesture>() { rock, paper, scissors, lizard, spock };
        }


        //Member Methods
        public string selectingGesture(bool isPerson)
        {
            string newPick = "";



            return newPick;
        }

    }
}
