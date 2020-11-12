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
        public bool noWinner;


        //Constructor
        public BackParkingLot()
        {
            twoPlayers = true;
            bestOfNumber = 3;
            playerOneScore = 0;
            playerTwoScore = 0;
            noWinner = true;
        }



        //Member Methods
        //Set up the game play situation and peramiters: # of players and rounds
        public void StartUp()
        {
            Graphics("start");
            Console.WriteLine("________________________");
            Console.WriteLine("One player or two?");

            string responcePlayer = Console.ReadLine();
            bool wrong = true;

            while (wrong)
            {
                if (responcePlayer == "1")
                {
                    twoPlayers = false;
                    Console.WriteLine("You chose one player.");
                    wrong = false;

                }
                else if (responcePlayer == "2")
                {
                    Console.WriteLine("You chose two players.");
                    wrong = false;
                }
                else
                {
                    Console.WriteLine("Lets try that again.\n1 or 2 players?");
                    responcePlayer = Console.ReadLine();
                }
            }

            Console.WriteLine("________________________");
            Console.WriteLine("Best out of 3, 5, 9?");

            string responceRound = Console.ReadLine();
            wrong = true;
            
            while (wrong)
            {
                if (responceRound == "3")
                {
                    Console.WriteLine("Lets play best of 3");
                    wrong = false;
                }
                else if (responceRound == "5")
                {
                    bestOfNumber = 5;
                    Console.WriteLine("Lets play best of 5");
                    wrong = false;
                }
                else if (responceRound == "9")
                {
                    bestOfNumber = 9;
                    Console.WriteLine("Lets play best of 9");
                    wrong = false;
                }
                else
                {
                    Console.WriteLine("Lets try that again.\nHow many rounds to get a winner? 3, 5, or 9");
                    responceRound = Console.ReadLine();
                }
            }
        }

        //Holds and displays art/comments
        //will add more fun stuff and cheeky comment later
        public void Graphics(string display)
        {
            switch (display)
            {
                case "rules":
                    //Display the rules of the game
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
                    Console.WriteLine("____________________________________________");
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.WriteLine($"                            Player 1: {playerOneScore}");
                    Console.WriteLine($"                            Player 2: {playerTwoScore}");
                    break;
                case "slander":
                    //tongue and cheek comments to make things more fun
                    //maybe add comments of encuragement if a player is losing?
                    //if statment to see if player is losing or winner.
                    //add random number generator and pit a different comment each time
                    break;

            }

        }

        public void RoundOfGame()
        {
            playerOneScore++;
        }


        //Gameplay and starta of a round
        public void Gameplay()
        {
            StartUp();
            Graphics("rules");
            Graphics("start");

            while (noWinner)
            {
                RoundOfGame();
                
                if (playerOneScore == bestOfNumber)
                {
                    noWinner = false;
                    Graphics("oneWins");
                }
                else if (playerTwoScore == bestOfNumber)
                {
                    noWinner = false;
                    Graphics("twoWins");
                }
            }
            


            Console.ReadLine(); 
        }

    }
}
