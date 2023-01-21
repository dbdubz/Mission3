using System;

namespace Mission3
{
    class Driver
    {
        static void Main(string[] args)
        {
            string Winner = "false";
            string[] Board = Start();

            while (Winner == "false")
            {
                Play(Board);
                Winner = Supporting.Winner()[0];
            }

            Console.WriteLine($"Congratuations, {Supporting.Winner()[1]}");
        }

        static string[] Start()
        {
            string[] GameBoard = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };

            Console.WriteLine("Welcome to the game!");

            return GameBoard;
        }
        static void Play(string[] Board)
        {
            int Player = 1;
            int ActivePlayer;

            Supporting.PrintBoard(Board);

            while (Player < 10)
            {
                if (Player % 2 == 0)
                {
                    ActivePlayer = 2;
                }
                else
                {
                    ActivePlayer = 1;
                }
                string[] Guesses = MakeMove(Board, ActivePlayer);
                Board = Guesses;
                Player += 1;
            }
        }
        static string[] MakeMove(string[] GameBoard, int Player)
        {
            string[] Guesses = GameBoard;
            string Letter;

            if (Player == 1)
            {
                Letter = "X";
            }
            else
            {
                Letter = "O";
            }

            Console.Write($"Where do you want to place your {Letter}? ");
            int Guess = Convert.ToInt32(Console.ReadLine());

            Guesses[Guess - 1] = Letter;

            return Guesses;
        }
    }
}
