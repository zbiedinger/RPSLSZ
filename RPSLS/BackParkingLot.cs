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
            bestOfNumber = 2;
            playerOneScore = 0;
            playerTwoScore = 0;
            noWinner = true;
        }



        //Member Methods
        //Set up the game play situation and peramiters: # of players and rounds
        public void StartUp()
        {
            //Checking the number of players.
            Graphics("start");
            Console.WriteLine("________________________");
            Console.WriteLine("One player or two?");

            string responcePlayer = Console.ReadLine();

            do
            {
                if (responcePlayer == "1")
                {
                    twoPlayers = false;
                    Console.WriteLine("You chose one player.");

                }
                else if (responcePlayer == "2")
                {
                    Console.WriteLine("You chose two players.");
                }
                else
                {
                    Console.WriteLine("Lets try that again.\n1 or 2 players?");
                    responcePlayer = Console.ReadLine();
                }
            } while (responcePlayer != "1" && responcePlayer != "2");

            //Getting player info
            if (responcePlayer == "1")
            {
                Console.WriteLine("Whats your name?");
                string inputName = Console.ReadLine();

                Person playerOne = new Person(inputName);
                Computer playerTwo = new Computer();
            }
            else if (responcePlayer == "2")
            {
                Console.WriteLine("Player one's name?");
                string inputName = Console.ReadLine();
                Person playerOne = new Person(inputName);

                Console.WriteLine("\nPlayer two's name?");
                inputName = Console.ReadLine();
                Person playerTwo = new Person(inputName);
            }


            //Checking the number of rounds to play. 
            Console.WriteLine("________________________");
            Console.WriteLine("Best out of 3, 5, 9?");

            string responceRound = Console.ReadLine();

            do
            {
                if (responceRound == "3")
                {
                    Console.WriteLine("Lets play best of 3");
                }
                else if (responceRound == "5")
                {
                    bestOfNumber = 3;
                    Console.WriteLine("Lets play best of 5");
                }
                else if (responceRound == "9")
                {
                    bestOfNumber = 5;
                    Console.WriteLine("Lets play best of 9");
                }
                else
                {
                    Console.WriteLine("Lets try that again.\nHow many rounds to get a winner? 3, 5, or 9");
                    responceRound = Console.ReadLine();
                }
            } while (responceRound != "3" && responceRound != "5" && responceRound != "9");
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
                    Console.WriteLine("Player 1 wins this round!");
                    break;
                case "twoWins":
                    Console.WriteLine("Player 2 wins this round!");
                    break;
                case "youWin":
                    Console.WriteLine("You win this round!");
                    break;
                case "computerWin":
                    Console.WriteLine("Computer wins this round!");
                    break;
                case "score":
                    Console.WriteLine("____________________________________________");
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.WriteLine($"                                playerOne: {playerOneScore}");
                    Console.WriteLine($"                                playerTwo: {playerTwoScore}");
                    break;
                case "slander":
                    //tongue and cheek comments to make things more fun
                    //maybe add comments of encuragement if a player is losing?
                    //if statment to see if player is losing or winner.
                    //add random number generator and pit a different comment each time
                    break;
                case "choices":
                    Console.WriteLine("Pick you gesture:");
                    Console.WriteLine("1.Rock, 2.Paper, 3.Scissor, 4.Lizard, 5.Spock\n");
                    break;

            }

        }

        public void RoundOfGame()
        {
            Graphics("score");
            Graphics("choices");

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
            
            //display winner


            Console.ReadLine(); 
        }

    }
}
