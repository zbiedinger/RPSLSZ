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
        

    }
}
