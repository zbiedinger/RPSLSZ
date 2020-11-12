using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Gesture
    {
        //Member Variables
        public string name;
        //public Gesture[] weaknesses;
        //public List<Gesture> weeknesses;
        //public list<string> weaknesses;



        //Constructor
        public Gesture()
        {

        }


        //Member Methods
        public bool checkWeaknesses(Gesture gestureAttack, Gesture gestureOne, Gesture gestureTwo)
        {

            if (gestureAttack == gestureOne || gestureAttack == gestureTwo)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
