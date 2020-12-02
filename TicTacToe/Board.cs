using System;
namespace TicTacToe_2player
{
    public class Board
    {
        public static char[] board = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        public static void TicTacToe()

        {
           

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", board[1], board[2], board[3]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", board[4], board[5], board[6]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", board[7], board[8], board[9]);

            Console.WriteLine("     |     |      ");

        }
    }
}
