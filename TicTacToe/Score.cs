using System;
using System.IO;

namespace TicTacToe_2player
{
    public class Score
    {
        

        public void saveScore()
        {
            File.WriteAllText(@"/Users/moshak/Projects/Final/Final/Save:Load:Text/saveScore.txt", string.Empty);
            StreamWriter sw = new StreamWriter(@"/Users/moshak/Projects/Final/Final/Save:Load:Text/saveScore.txt");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    sw.WriteLine(Board.board[i]);
                }

            }
            sw.Close();

        }

        public void loadScore()
        {
            //File.WriteAllText(@"/Users/moshak/Desktop/Text.txt", string.Empty);
            StreamReader sr = new StreamReader(@"/Users/moshak/Desktop/Text.txt");
            string loadFile = sr.ReadToEnd();
            string[] myArray = loadFile.Split('\n');
            char[,] board = new char[3, 3];

            int row = 0;
            foreach (string sign in myArray)
            {
                int column = 0;
                foreach (char character in sign)
                {
                    board[row, column] = character;
                }
                row++;
            }

            sr.Close();

        }

    }
}
