using System;
using System.Threading;

namespace TicTacToe_2player
{
    public class Game
    {

        public static int HasWinner()

        {

            if (Board.board[1] == Board.board[2] && Board.board[2] == Board.board[3])

            {

                return 1;

            }

            else if (Board.board[4] == Board.board[5] && Board.board[5] == Board.board[6])

            {

                return 1;

            }

            else if (Board.board[6] == Board.board[7] && Board.board[7] == Board.board[8])

            {

                return 1;

            }
 

            else if (Board.board[1] == Board.board[4] && Board.board[4] == Board.board[7])

            {

                return 1;

            }

            else if (Board.board[2] == Board.board[5] && Board.board[5] == Board.board[8])

            {

                return 1;

            }

            else if (Board.board[3] == Board.board[6] && Board.board[6] == Board.board[9])

            {

                return 1;

            }

            else if (Board.board[1] == Board.board[5] && Board.board[5] == Board.board[9])

            {

                return 1;

            }

            else if (Board.board[3] == Board.board[5] && Board.board[5] == Board.board[7])

            {

                return 1;

            }

            else if (Board.board[1] != '1' && Board.board[2] != '2' && Board.board[3] != '3' && Board.board[4] != '4'
                && Board.board[5] != '5' && Board.board[6] != '6' && Board.board[7] != '7' && Board.board[8] != '8' && Board.board[9] != '9')

            {

                return -1;

            }

            else

            {

                return 0;

            }

        }
    }
}
