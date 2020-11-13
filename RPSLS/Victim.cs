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
        //public Gesture SelectingGesture()
        //{
        //    Console.WriteLine("\nWhats your gesture of choice?");

        //    Gesture currentGesture = gestureChoices[int.Parse(Console.ReadLine())];
        //    return currentGesture;
        //}

        public Gesture SelectingGesture()
        {
            Console.WriteLine($"{playerName}'s gesture of choice?");

            Gesture currentGesture = gestureChoices[int.Parse(Console.ReadLine())-1];
            return currentGesture;
        }


        //can I do this by referincing the current gesture instead of passing both in?

        //public bool Is1AWeaknessOf2(Gesture gestureOne, Gesture gestureTwo)
        //{
        //    if (gestureOne.name == gestureTwo.stringWeakness[0] || gestureOne.name == gestureTwo.stringWeakness[1])
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

    }
}
