using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class BackParkingLot
    {
        //Member Variables
        public bool twoPlayers;
        public int bestOfNumber;
        public int playerOneScore;
        public int playerTwoScore;






        //Constructor
        public BackParkingLot()
        {
            twoPlayers = true;
            bestOfNumber = 3;
            playerOneScore = 0;
            playerTwoScore = 0;
        }



        //Member Methods
        public void StartUp()
        {
            Graphics("start");
            Console.WriteLine("________________________");
            Console.WriteLine("One player or two?");

            string responcePlayer = Console.ReadLine();
            //while (responcePlayer != "1" || responcePlayer != "2")
            //{
            //    Console.WriteLine("Lets try that again.\n1 or 2 players?");
            //    responcePlayer = Console.ReadLine();
            //}

            if (responcePlayer == "1")
            {
                twoPlayers = false;
                Console.WriteLine("you choise one player.");

            }
            else
            {
                Console.WriteLine("you choise two players.");
            }

            Console.WriteLine("________________________");
            Console.WriteLine("Best out of 3, 5, 9?");

            string responceRound = Console.ReadLine();
            //while (responceRound != "3" || responceRound != "5" || responceRound != "9")
            //{
            //    Console.WriteLine("Lets try that again.\n How many rounds to get a winner? 3, 5, or 9");
            //    responceRound = Console.ReadLine();
            //}

            if (responceRound == "5")
            {
                bestOfNumber = 5;
                Console.WriteLine("Lets play best of 5");
            }
            else if (responceRound == "9")
            {
                bestOfNumber = 9;
                Console.WriteLine( "Lets play best of 9");
            }
            else
            {
                Console.WriteLine("Lets play best of 3");
            }

        }

        //Holds and displays all the bulky displays
        public void Graphics(string display)
        {
            switch (display)
            {
                case "rules":

                    break;
                case "newRound":
                    Console.WriteLine("Next Round! Are you ready?");
                    break;
                case "start":
                    Console.WriteLine("Start of Game\n");
                    break;
                case "oneWins":
                    Console.WriteLine("Player 1 wins!");
                    break;
                case "twoWins":
                    Console.WriteLine("Player 2 wins!");
                    break;
                case "youWin":
                    Console.WriteLine("You win!");
                    break;
                case "computerWin":
                    Console.WriteLine("Computer wins!");
                    break;
                case "score":
                    Console.WriteLine($"                            Player 1: {playerOneScore}");
                    Console.WriteLine($"                            Player 2: {playerTwoScore}");
                    break;

            }

        }


        //Gameplay and starta of a round
        public void NewRound()
        {
            StartUp();
            Graphics("rules");

            Console.ReadLine(); 
        }

    }
}
