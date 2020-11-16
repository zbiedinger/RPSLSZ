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
            Console.WriteLine("\n+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+");
            Console.WriteLine("                  Game setup");
            Console.WriteLine("+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+\n");
            Console.WriteLine("One player or two?");
            string responcePlayer = Console.ReadLine();

            while (responcePlayer != "1" && responcePlayer != "2")
            {
                Console.WriteLine("Lets try that again.\n1 or 2 players?");
                responcePlayer = Console.ReadLine();
            }

            if (responcePlayer == "1")
            {
                Console.WriteLine("You chose one player.");

                CreateVictim("person");
                CreateVictim("computer");
            }
            else if (responcePlayer == "2")
            {

                Console.WriteLine("You chose two players.");

                CreateVictim("person");
                CreateVictim("person");
            }
        }

        //Creating Vicims based on passed in string.
        //Set up as a switch to allow more posssible child classes of victim i.e. "kid", "old person", "cheater"
        public void CreateVictim(string victimType)
        {
            switch (victimType)
            {
                case "person":
                    Console.WriteLine("\nPlayer's name?");
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

            while (responceRound != "3" && responceRound != "5" && responceRound != "9")
            {

                Console.WriteLine("\nLets try that again.\n3, 5, or 9");
                responceRound = Console.ReadLine();
            }

            if (responceRound == "3")
            {
                Console.WriteLine("                   Best of 3");
                Console.WriteLine("              Press ENTER to begin");
            }
            else if (responceRound == "5")
            {
                bestOfNumber = 3;
                Console.WriteLine("                   Best of 5");
                Console.WriteLine("              Press ENTER to begin");
            }
            else if (responceRound == "9")
            {
                bestOfNumber = 5;
                Console.WriteLine("                   Best of 9");
                Console.WriteLine("              Press ENTER to begin");
            }

            Console.ReadLine();
        }

        //Set up the game play situation and peramiters: # of players and rounds
        public void StartUp()
        {            
            SetNumberOfPlayers();
            Console.WriteLine("\n+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+\n");
            SetNumberOfRounds();
        }

        //Holds and displays art/comments
        //will add more fun stuff and cheeky comment later
        public void Graphics(string display)
        {
            switch (display)
            {
                case "start":
                    //add cool graphis for the game
                    Console.WriteLine("        _____ _______       _____ _______ \n" +
                        "       / ____|__   __|/\\   |  __ \\__   __|\n" +
                        "      | (___    | |  /  \\  | |__) | | |\n" +
                        "       \\___ \\   | | / /\\ \\ |  _  /  | |\n" +
                        "       ____) |  | |/ ____ \\| | \\ \\  | |\n" +
                        "      |_____/   |_/_/    \\_\\_|  \\_\\ |_| ");
                    break;
                case "rules":
                    //Display the rules of the game
                    Console.WriteLine("                _____  _____   _____ _       _____ \n" +
                        "               |  __ \\|  __ \\ / ____| |     / ____|\n" +
                        "               | |__) | |__) | (___ | |    | (___\n" +
                        "               |  _ / | ___ / \\___ \\| |     \\___ \\ \n" +
                        "               | | \\ \\| |     ____) | |____ ____) |\n" +
                        "               |_|  \\_\\_|    |_____/|______|_____/ \n\n");
                    Console.WriteLine("      .-.------------------------------------------------.-.\n" +
                        "     ((o))                                                  )\n" +
                        "      \\U/  _______              _________            ____  /\n" +
                        "        |                                                 |\n" +
                        "        |                       RULES                     |\n" +
                        "        |                       -----                     |\n" +
                        "        |                                                 |\n" +
                        "        |  1. ROCK crushes SCISSORS and LIZARD.           |\n" +
                        "        |  2. PAPER covers ROCK and disproves SPOCK       |\n" +
                        "        |  3. SCISSORS cuts PAPER and decapitates LIZARD  |\n" +
                        "        |  4. LIZARD poisons SPOCK and eats PAPER         |\n" +
                        "        |  5. SPOCK smashes SCISSORS and vaporizes ROCK   |\n" +
                        "        |                                                 |\n" +
                        "        | ____       _______     __    ____      ___      |\n" +
                        "       /A\\                                                \\\n" +
                        "      ((o))                                                )\n" +
                        "       '-'------------------------------------------------'\n");
                    Console.WriteLine("                        Press ENTER to play");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case "newRound":
                    Console.WriteLine("Next Round! Are you ready?");
                    break;
                case "score":
                    Console.WriteLine("______________________________________________");
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.WriteLine($"                                     {victims[0].playerName}: {victims[0].score}");
                    Console.WriteLine($"                                     {victims[1].playerName}: {victims[1].score}");
                    break;
                case "rock":
                    Console.WriteLine("  _____            _    \n" +
                        " |  __ \\          | |\n" +
                        " | |__) |___   ___| | __\n" +
                        " |  _  // _ \\ / __| |/ /\n" +
                        " | | \\ \\ (_) | (__|   <\n" +
                        " |_|  \\_\\___/ \\___|_|\\_\\\n");
                    break;
                case "paper":
                    Console.WriteLine("  _____                      \n" +
                        " |  __ \\                     \n" +
                        " | |__) |_ _ _ __   ___ _ __\n" +
                        " |  ___/ _` | '_ \\ / _ \\ '__|\n" +
                        " | |  | (_| | |_) |  __/ |\n" +
                        " |_|   \\__,_| .__/ \\___|_|\n" +
                        "            | |\n" +
                        "            |_| \n");
                    break;
                case "scissors":
                    Console.WriteLine("   _____      _                        \n" +
                        "  / ____|    (_)\n" +
                        " | (___   ___ _ ___ ___  ___  _ __ ___ \n" +
                        "  \\___ \\ / __| / __/ __|/ _ \\| '__/ __|\n" +
                        "  ____) | (__| \\__ \\__ \\ (_) | |  \\__ \\\n" +
                        " |_____/ \\___|_|___/___/\\___/|_|  |___/ \n");
                    break;
                case "lizard":
                    Console.WriteLine("  _      _                  _ \n" +
                        " | |    (_)                | |\n" +
                        " | |     _ ______ _ _ __ __| |\n" +
                        " | |    | |_  / _` | '__/ _` |\n" +
                        " | |____| |/ / (_| | | | (_| |\n" +
                        " |______|_/___\\__,_|_|  \\__,_| \n");
                    break;
                case "spock":
      Console.WriteLine("   _____                  _    \n" +
                        "  / ____|                | |\n" +
                        " | (___  _ __   ___   ___| | __\n" +
                        "  \\___ \\| '_ \\ / _ \\ / __| |/ /\n" +
                        "  ____) | |_) | (_) | (__|   <\n" +
                        " |_____/| .__/ \\___/ \\___|_|\\_\\\n" +
                        "        | |\n" +
                        "        |_| \n");
                    break;
                case "vs":
                    Console.WriteLine("            _  _ ___  \n" +
                        "           ( \\/ / __) \n" +
                        "            \\  /\\__ \\ \n" +
                        "             \\/ (___()\n");
                    break;
                case "choices":
                    Console.WriteLine("Gestures:");
                    Console.WriteLine("1.Rock, 2.Paper, 3.Scissor, 4.Lizard, 5.Spock\n");
                    break;
                case "tie":
                    Console.WriteLine("You tied!");
                    break;
                case "winner":
                    Console.WriteLine($"{winnerOfThisGame} won this round!");
                    break;
                case "gameWinner":
                    Console.WriteLine($"\n{winnerOfThisGame} is the Winner\n");
                    break;

            }

        }

        //Display the two gestures going hesd to head
        public void DisplayGestures(Gesture gestureOne, Gesture gestureTwo)
        {
            Console.WriteLine("..............................................");
            Graphics(gestureOne.name);
            Graphics("vs");
            Graphics(gestureTwo.name);
            Console.WriteLine("..............................................");
        }

        //check which gesture beats another
        public bool CompareGestures(Gesture gestureOne, Gesture gestureTwo)
        {

            bool winner = !gestureOne.stringWeakness.Contains(gestureTwo.name);
            if (gestureOne.name == gestureTwo.stringWeakness[0] || gestureOne.name == gestureTwo.stringWeakness[1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //logic of a single round.
        public void RoundOfGame()
        {
            Graphics("score");
            Graphics("choices");

            Gesture gestureOfROund1 = victims[0].SelectingGesture();
            Gesture gestureOfROund2 = victims[1].SelectingGesture();

            DisplayGestures(gestureOfROund1, gestureOfROund2);

            if (gestureOfROund1.name == gestureOfROund2.name)
            {
                Graphics("tie");
            }
            else
            {
                bool playerOneWins = CompareGestures(gestureOfROund1, gestureOfROund2);
                if(playerOneWins)
                {
                    victims[0].score++;
                    winnerOfThisGame = victims[0].playerName;
                }
                else
                {
                    victims[1].score++;
                    winnerOfThisGame = victims[1].playerName;
                }
                Graphics("winner");
            }
        } 

        //ask to play another game and set variable accourdingly
        public void PlayAnotherGame()
        {
            Console.WriteLine("Play another game?\n1.Yes    2.No");
            string responceGame = Console.ReadLine();

            while (responceGame != "1" && responceGame != "2")
            { 
                Console.WriteLine("Try that again");
                    responceGame = Console.ReadLine();
                
            }

            if (responceGame == "1")
            {
                foreach (Victim victim in victims)
                {
                    victim.score = 0;
                }
                noWinner = true;
                Console.Clear();
            }
            else if (responceGame == "2")
            {
                Console.Clear();
                Console.WriteLine("\n\nThanks for joining us in the back parking lot\n" +
                    "to play RPSLS. We will be here all week.");
                noWinner = false;
            }
        }

        //Gameplay and starta of a round
        public void Gameplay()
        {
            Graphics("rules");
            StartUp();
            Console.Clear();
            Graphics("start");


            while (noWinner)
            {
                RoundOfGame();

                if (victims[0].score == bestOfNumber)
                {
                    winnerOfThisGame = victims[0].playerName;
                    Graphics("gameWinner");
                     PlayAnotherGame();
                }
                else if (victims[1].score == bestOfNumber)
                {
                    winnerOfThisGame = victims[1].playerName;
                    Graphics("gameWinner");
                    PlayAnotherGame();
                }
            }
     
            Console.ReadLine();
        }

    }
}
