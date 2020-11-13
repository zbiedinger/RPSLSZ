using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Computer : Victim
    {
        //Member Variables
        Random rand;

        //Constructor
        public Computer()
        {
            playerName = "Computer";
            rand = new Random();

            Rock rock = new Rock();
            Paper paper = new Paper();
            Scissors scissors = new Scissors();
            Lizard lizard = new Lizard();
            Spock spock = new Spock();

            gestureChoices = new List<Gesture>() { rock, paper, scissors, lizard, spock };
        }


        //Member Methods
        public override Gesture SelectingGesture()
        {
            Gesture currentGesture = gestureChoices[rand.Next(5)];
            Console.WriteLine($"\n{playerName} chose {currentGesture.name}");

            return currentGesture;
            //Console.Clear();
        }
    }
}
