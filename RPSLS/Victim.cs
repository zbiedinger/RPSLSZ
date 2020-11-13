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

        //Constructor
        public Victim()
        {
            score = 0;
            currentGesture = "";
        }

        //Member Methods
        //asks user to pick a gesture and returns the gesture chosen
        public virtual Gesture SelectingGesture()
        {
            Console.WriteLine($"\n{playerName}'s gesture of choice?");
            string responcePlayer = Console.ReadLine();

            while (responcePlayer != "1" && responcePlayer != "2" && responcePlayer != "3" && responcePlayer != "4" && responcePlayer != "5")
            {
                Console.WriteLine($"\n{playerName}'s try again?");
                responcePlayer = Console.ReadLine();
            }

            Gesture currentGesture = gestureChoices[int.Parse(responcePlayer) - 1];

            //Console.Clear();
            return currentGesture;
        }
    }
}
