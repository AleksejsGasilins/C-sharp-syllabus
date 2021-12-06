using System;

namespace TicTacToe
{
    class Program
    {
        private static char[,] board = new char[3, 3];

        private static void Main(string[] args)
        {
            InitBoard();
            DisplayBoard();
        }

        private static char InitBoard()
        {
            for (int i = 0; i <= 9; i++)
            {
                var userR = Console.ReadLine();
                var userC = Console.ReadLine();

                string userRToInt = userR;
                string userCToInt = userC;

                int X = Convert.ToInt32(userRToInt);
                int Y = Convert.ToInt32(userCToInt);
                return board[X, Y] = '0';

                Console.WriteLine("  0  " + board[0, 0] + "|" + board[0, 1] + "|" + board[0, 2]);
                Console.WriteLine("    --+-+--");
                Console.WriteLine("  1  " + board[1, 0] + "|" + board[1, 1] + "|" + board[1, 2]);
                Console.WriteLine("    --+-+--");
                Console.WriteLine("  2  " + board[2, 0] + "|" + board[2, 1] + "|" + board[2, 2]);
                Console.WriteLine("    --+-+--");
                Console.ReadKey();
            }
            // fills up the board with blanks
            //for (var r = 0; r < 3; r++)
            //{
            //    for (var c = 0; c < 3; c++)
            //        board[r, c] = ' ';
            //}

        }

        private static void DisplayBoard()
        {
            Console.WriteLine("  0  " + board[0, 0] + "|" + board[0, 1] + "|" + board[0, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  1  " + board[1, 0] + "|" + board[1, 1] + "|" + board[1, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  2  " + board[2, 0] + "|" + board[2, 1] + "|" + board[2, 2]);
            Console.WriteLine("    --+-+--");
            Console.ReadKey();
        }

        private static int Userdats(ConsoleKeyInfo UserInput)
        {
            int Bowl;

            if (char.IsDigit(UserInput.KeyChar))
            {
                Bowl = int.Parse(UserInput.KeyChar.ToString()); // use Parse if it's a Digit
            }
            else
            {
                Bowl = -1;  // Else we assign a default value
            }
        }
    }
}
