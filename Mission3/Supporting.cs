using System;
using System.Collections.Generic;
using System.Text;

namespace Mission3
{
    public class Supporting
    {
        public void printBoard (string[] Board) //Method that is called in main program to print the board
        {
            string bars = " | ";
            string lineBar = "---------"; //Create the board
            string output = Board[0] + bars + Board[1] + bars + Board[2] + "\n" + lineBar + "\n" + Board[3] + bars + Board[4] + bars + Board[5] + "\n" + lineBar + "\n" + Board[6] + bars + Board[7] + bars + Board[8];

            Console.WriteLine(output); //output board
        }

        public string[] Winner(string[] Board) //Determining if there is a winner.
        {
            string didWin = "false"; //Default that there isn't a winner
            string whoWon = ""; //No one's a winner yet

            if (Board[0] == Board[1] && Board[1] == Board[2]) //Each of these are different ways the user can win.
            {
                didWin = "true"; //In each, we set the didWin variable to True
                whoWon = Board[0]; //and set the whoWon variable equal to the value on the board.

            }
            else if (Board[3] == Board[4] && Board[4] == Board[5])
            {
                didWin = "true";
                whoWon = Board[3];
            }
            else if (Board[6] == Board[7] && Board[7] == Board[8])
            {
                didWin = "true"; didWin = "true";
                whoWon = Board[6];

            }
            else if (Board[0] == Board[3] && Board[3] == Board[6])
            {
                didWin = "true";
                whoWon = Board[0];
            }
            else if (Board[1] == Board[4] && Board[4] == Board[7])
            {
                didWin = "true";
                whoWon = Board[1];
            }
            else if (Board[2] == Board[5] && Board[5] == Board[8])
            {
                didWin = "true";
                whoWon = Board[2];
            }
            else if (Board[0] == Board[4] && Board[4] == Board[8])
            {
                didWin = "true";
                whoWon = Board[0];
            }
            else if (Board[2] == Board[4] && Board[4] == Board[6])
            {
                didWin = "true";
                whoWon = Board[2];
            }
            string[] gameSummary = { didWin, whoWon }; //Initiate the array we return back to main program that has didWin and whoWon.

            return (gameSummary); //return array
        }
    }
}
