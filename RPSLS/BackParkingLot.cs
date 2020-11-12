﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class BackParkingLot
    {
        //Member Variables
        public int bestOfNumber;
        public bool noWinner;
        public string winnerOfThisGame;
        public List<Victim> victims;



        //Constructor
        public BackParkingLot()
        {
            bestOfNumber = 2;
            noWinner = true;
            winnerOfThisGame = "";
            victims = new List<Victim>();
        }



        //Member Methods
        //Checking number of players in game.
        public void SetNumberOfPlayers()
        {
            Console.WriteLine("One player or two?");
            string responcePlayer = Console.ReadLine();

            do
            {
                if (responcePlayer == "1")
                {
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

            if (responcePlayer == "1")
            {
                CreateVictim("person");
                CreateVictim("computer");
            }
            else if (responcePlayer == "2")
            {
                CreateVictim("person");
                CreateVictim("person");
            }
        }

        //Creating Vicims based on passed string. set up to allow more posssible child classes of victim
        public void CreateVictim(string victimType)
        {
            switch (victimType)
            {
                case "person":
                    Console.WriteLine("Player's name?");
                    string inputName = Console.ReadLine();
                    Person player = new Person(inputName);
                    victims.Add(player);
                    break;

                case "computer":
                    Computer robot = new Computer();
                    victims.Add(robot);
                    break;
            }
        }

        //Checking the number of rounds to play. 
        public void SetNumberOfRounds()
        {
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

        //Set up the game play situation and peramiters: # of players and rounds
        public void StartUp()
        {
            Graphics("start");
            Graphics("rules");
            
            SetNumberOfPlayers();

            Console.WriteLine("________________________");
            SetNumberOfRounds();
        }

        //Holds and displays art/comments
        //will add more fun stuff and cheeky comment later
        public void Graphics(string display)
        {
            switch (display)
            {
                case "rules":
                    //Display the rules of the game
                    Console.WriteLine("________________________");
                    break;
                case "newRound":
                    Console.WriteLine("Next Round! Are you ready?");
                    break;
                case "start":
                    //add cool graphis for the game
                    Console.WriteLine("Start of Game\n");
                    break;
                case "winner":
                    Console.WriteLine($"{winnerOfThisGame} won this round!");
                    break;
                case "score":
                    Console.WriteLine("____________________________________________");
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.WriteLine($"                                    {victims[0].playerName}: {victims[0].score}");
                    Console.WriteLine($"                                    {victims[1].playerName}: {victims[1].score}");
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
                case "gameWinner":
                    Console.WriteLine($"{winnerOfThisGame} is the Winner");
                    break;

            }

        }

        public string CompareGestures(Gesture gestureOne, Gesture gestureTwo)
        {


            return victims[0].playerName;
        }

        //
        public void RoundOfGame()
        {
            Graphics("score");
            Graphics("choices");

            victims[0].score++;
            winnerOfThisGame = CompareGestures(victims[0].SelectingGesture(), victims[1].SelectingGesture());
            Graphics("winner");
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
                
                if (victims[0].score == bestOfNumber)
                {
                    noWinner = false;
                    winnerOfThisGame = victims[0].playerName;
                    Graphics("gameWinner");
                }
                else if (victims[1].score == bestOfNumber)
                {
                    noWinner = false;
                    winnerOfThisGame = victims[1].playerName;
                    Graphics("gameWinner");
                }
            }

            Console.ReadLine(); 
        }

    }
}
