using System;

// Group 2-1: Dalyn Baldin, Spencer Cable, Holly Lambert, Koleton Murray, Doug Regehr

namespace Mission3
{
    class Driver
    {
        // Do stuff
        static void Main(string[] args)
        {
            // Initialize game board
            string[] Board = Start();

            // Play the game
            Play(Board);
        }
        static string[] Start()
        {
            // Create game board
            string[] GameBoard = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };

            Console.WriteLine("Welcome to the game!");

            return GameBoard;
        }
        static void Play(string[] Board)
        {
            int Player = 1;
            int Round = 0;
            int ActivePlayer;
            string Winner = "false";

            // New supporting instance
            Supporting supporting = new Supporting();

            while (Round < 9)
            {
                // Loop until there is a winner
                while (Winner == "false")
                {
                    // Alternate players
                    if (Player % 2 == 0)
                    {
                        ActivePlayer = 2;
                    }
                    else
                    {
                        ActivePlayer = 1;
                    }

                    // Print the board
                    supporting.printBoard(Board);

                    // Player makes a guess
                    string[] Guesses = MakeMove(Board, ActivePlayer);

                    // Updated board
                    Board = Guesses;

                    // Check for a winner
                    Winner = supporting.Winner(Board)[0];

                    if (Round == 8 && Winner == "false")
                    {
                        Winner = "draw";
                    }

                    Round += 1;
                    Player += 1;
                }

                if (Winner == "draw")
                {
                    Console.WriteLine("Are you both equally good, or both equally bad? The game was a draw.");
                    Round += 1;
                }
                else
                {
                    // Congratulate winner
                    Console.WriteLine($"\nCongratuations, {supporting.Winner(Board)[1]}");
                    Round = 9;
                }
            }
        }
        static string[] MakeMove(string[] GameBoard, int Player)
        {
            string[] Guesses = GameBoard;
            string Letter;
            int Guess;
            bool GoodInput;
            bool GoodNumber;

            // Assign letter to a player
            if (Player == 1)
            {
                Letter = "X";
            }
            else
            {
                Letter = "O";
            }

            // Get a guess
            Console.Write($"Where do you want to place your {Letter}? ");

            // Set Input validation
            GoodInput = false;
            GoodNumber = false;

            // Perform input validation
            while (!GoodInput)
            {
                try
                {
                    while (!GoodNumber)
                    {
                        Guess = Convert.ToInt32(Console.ReadLine());
                        if (Guess > 0 || Guess < 10)
                        {
                            if (Guesses[Guess - 1] == "X" || Guesses[Guess -1 ] == "O")
                            {
                                Console.Write($"Spot taken by {Guesses[Guess - 1]}. Try another: ");
                            }
                            else
                            {
                                Guesses[Guess - 1] = Letter;
                                GoodInput = true;
                                GoodNumber = true;
                            }
                        }
                        else
                        {
                            Console.Write($"{Letter}, please put a number from 1-9: ");
                        }
                    }
                }
                catch
                {
                    Console.Write($"{Letter}, please put a number from 1-9: ");
                }
            }


            return Guesses;
        }
    }
}
