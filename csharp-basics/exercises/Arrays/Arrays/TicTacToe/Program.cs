using System;
using System.Threading;

namespace TicTacToe
{
    class Program
    {
        static char[,] Board =
        {
            {'1', '2', '3'},
            {'4', '5', '6'},
            {'7', '8', '9'},
        };
        static int player = 1;
        static int choiceR;
        static int choiceC;

        static int flag = 0;

        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("\nPlayer1:X and Player2:O");

                if (player % 2 == 0)
                {
                    Console.WriteLine("Player 2 Chance");
                }
                else
                {
                    Console.WriteLine("Player 1 Chance");
                }

                Console.WriteLine("\n");
                DisplayBoard();
                Console.WriteLine("Enter Row number: ");
                choiceR = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Column number: ");
                choiceC = int.Parse(Console.ReadLine());

                if (Board[choiceR, choiceC] != 'X' && Board[choiceR, choiceC] != 'O')
                {
                    if (player % 2 == 0)
                    {
                        Board[choiceR, choiceC] = 'O';
                        player++;
                    }
                    else
                    {
                        Board[choiceR, choiceC] = 'X';
                        player++;
                    }
                }
                else
                {
                    Console.WriteLine("Sorry the row { 0} is already marked with { 1 }", choiceR, choiceC,
                        Board[choiceR, choiceC]);
                    Console.WriteLine("\n");
                    Console.WriteLine("Please wait 2 second board is loading again.....");
                    Thread.Sleep(2000);
                } 
                flag = CheckWin();
            } while (flag != 1 && flag != -1);

            if (flag == 1)
            {
                Console.WriteLine("Player {0} has won", (player % 2) + 1);
            }
            else
            {
                Console.WriteLine("Draw");
            }

            Console.ReadLine();
        }

        private static void DisplayBoard()
        {
            Console.Clear();
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", Board[0, 0], Board[0, 1], Board[0, 2]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", Board[1, 0], Board[1, 1], Board[1, 2]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", Board[2, 0], Board[2, 1], Board[2, 2]);
            Console.WriteLine("     |     |      ");
        }

        private static int CheckWin()
        {
            if (Board[0, 0] == Board[0, 1] && Board[0, 1] == Board[0,2])
            {
                return 1;
            }
            else if (Board[1, 0] == Board[1, 1] && Board[1, 1] == Board[1, 2])
            {
                return 1;
            }
            else if (Board[2, 0] == Board[2, 1] && Board[2, 1] == Board[2, 2])
            {
                return 1;
            }
            else if (Board[0, 0] == Board[1, 0] && Board[1, 0] == Board[2, 0])

            {
                return 1;
            }
            else if (Board[0, 1] == Board[1, 1] && Board[1, 1] == Board[2, 1])
            {
                return 1;
            }
            else if (Board[0, 2] == Board[1, 2] && Board[1, 2] == Board[2, 2])
            {
                return 1;
            }
            else if (Board[0, 0] == Board[1, 1] && Board[1, 1] == Board[2, 2])
            {
                return 1;
            }
            else if (Board[0, 2] == Board[1, 1] && Board[1, 0] == Board[2, 0])
            {
                return 1;
            }
            else if (Board[0, 0] != '1' && Board[0, 1] != '2' && Board[0, 2] != '3' && 
                     Board[1, 0] != '4' && Board[1, 1] != '5' && Board[1, 2] != '6' && 
                     Board[2, 0] != '7' && Board[2, 1] != '8' && Board[2, 2] != '9')
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