using System;
using System.Threading;

namespace TicTacToe_2player
{
    public class Move
    {

        int playerCounter = 1;
        int winCondition = 0;
        int move;
        public void HumanVsHuman()
        {

            do

            {
                Console.Clear();
                Console.WriteLine("Player1: gets X and Player2: gets O");
                Console.WriteLine("\n");
                if (playerCounter % 2 == 0)
                {
                    Console.WriteLine("Player 2 Turn");

                }

                else

                {
                    Console.WriteLine("Player 1 Turn");
                }
                Board.TicTacToe();
                Console.WriteLine("Please enter a number between 1-9 to make a move on the board");
                Console.WriteLine("\n");
                move = int.Parse(Console.ReadLine());

                if (Board.board[move] != 'X' && Board.board[move] != 'O')

                {

                    if (playerCounter % 2 == 0)
                    {

                        Board.board[move] = 'O';
                        playerCounter++;

                    }
                    else
                    {

                        Board.board[move] = 'X';
                        playerCounter++;

                    }

                }

                else
                {
                    Console.WriteLine("Sorry the row {0} is already marked with {1}", move, Board.board[move]);

                    Console.WriteLine("\n");
                    Thread.Sleep(2000);
                }

                winCondition = Game.HasWinner();

            } while (winCondition != 1 && winCondition != -1);

            Console.Clear();
            Board.TicTacToe();

            if (winCondition == 1)

            {
                Console.WriteLine("Player {0} has won", (playerCounter % 2) + 1);
            }

            else
            {
                Console.WriteLine("Its a Draw");
            }

            Console.ReadLine();


        }

    
        
    }
    
}