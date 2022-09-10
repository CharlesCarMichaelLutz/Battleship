
namespace Battleship
{
    internal class Program
    {
        private static int row = 10;
        private static int column = 10;

        private static int[,] gameBoard = new int[row, column];
        private static string message = "";
        private static bool gameOver = false;
        static void Main(string[] args)
        {
            PopulateMap();
            //user greeting
            GreetUser();

            while (!gameOver)
            {
                DrawMap();

                Console.WriteLine($"X: 1 - {row}");
                Console.WriteLine($"Y: 1 - {column}\n");
                Console.WriteLine("Enter guess (X,Y): ");
                string guess = Console.ReadLine();

                try
                {
                    int xPos = Convert.ToInt32(guess.Split(',')[0]) - 1;
                    int yPos = Convert.ToInt32(guess.Split(',')[1]) - 1;

                    if (xPos > row - 1 || yPos > column - 1)
                    {
                        message = "You are off the board, try again!";
                    }
                    CheckGuess(xPos, yPos);
                }
                catch
                {
                    message = "Unable to process coordinates";
                }
            }
        }
        private static void GreetUser()
        {
            Console.WriteLine("Welcome to Battle! press Enter ");
            Console.ReadLine();

            Console.WriteLine("Enter username: ");
            string username = Console.ReadLine();
            Console.WriteLine($"\nLet's begin {username}!");
        }
        private static void CheckGuess(int x, int y)
        {
            if (gameBoard[y, x] == 3)
            {
                gameBoard[y, x] = 1;

                if (CheckWin())
                {
                    message = "You Won!!!";
                    DrawMap();

                    Console.Write("Do you want to play again? (y/n): ");
                    string answer = Console.ReadLine();
                    if (answer.ToLower() == "y")
                    {
                        PopulateMap();
                        message = "";
                        return;
                    }
                    else
                    {
                        gameOver = true;
                        return;
                    }
                }
                message = "It's a Hit!";
            }
            else
            {
                message = "You Missed";
                gameBoard[y, x] = 2;
            }
        }

        private static bool CheckWin()
        {
            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (gameBoard[i, j] == 3)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        private static void PopulateMap()
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    gameBoard[i, j] = 0;
                }
            }
            AddShip();
        }
        private static void AddShip()
        {
            Random random = new Random();
            string direction;

            int x = random.Next(0,row -1);
            int y = random.Next(0, column -1);

            if (x < 5)
            {
                direction = "right";
            }
            else if (x > 5)
            {
                direction = "left";
            }
            else
            {
                direction = "left,right";
            }

            if (y < 5)
            {
                direction += "down";
            }
            else if (y > 5)
            {
                direction += "up";
            }
            else
            {
                direction += "up,down";
            }

            direction = direction.Split(',')[random.Next(0, direction.Split(',').Length)];

            if (direction == "up")
            {
                for (int i = y; i < y - 5; i--)
                {
                    gameBoard[i, x] = 3;
                }
            }
            else if (direction == "down")
            {
                for (int i = y; i < y + 5; i++)
                {
                    gameBoard[i, x] = 3;
                }
            }
            else if (direction == "left")
            {
                for (int i = x; i < x - 5; i--)
                {
                    gameBoard[y, i] = 3;
                }
            }
            else
            {
                for (int i = x; i < x + 5; i++)
                {
                    gameBoard[y, i] = 3;
                }
            }
        }
        private static void DrawMap()
        {
            Console.Clear();
            DrawLogo();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("+");
            for (int j = 0; j < row; j++)
            {
                Console.Write("-");
            }
            Console.Write("+\n");
            for (int i = 0; i < column; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("|");
                for (int j = 0; j < row; j++)
                {
                    switch (gameBoard[i, j])
                    {
                        case 0:
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("▒");
                            break;
                        case 1:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("X");
                            break;
                        case 2:
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("0");
                            break;
                        case 3:
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("▒");
                            break;
                    }
                }
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("|\n");
            }
            Console.Write("+");
            for (int j = 0; j < row; j++)
            {
                Console.Write("-");
            }
            Console.Write("+\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(message);
        }
        private static void DrawLogo()
        {
            Console.Write("\n");
            Console.WriteLine(" ██████╗  █████╗ ████████╗████████╗██╗     ███████╗███████╗██╗  ██╗██╗██████╗ ");
            Console.WriteLine(" ██╔══██╗██╔══██╗╚══██╔══╝╚══██╔══╝██║     ██╔════╝██╔════╝██║  ██║██║██╔══██╗");
            Console.WriteLine(" ██████╔╝███████║   ██║      ██║   ██║     █████╗  ███████╗███████║██║██████╔╝");
            Console.WriteLine(" ██╔══██╗██╔══██║   ██║      ██║   ██║     ██╔══╝  ╚════██║██╔══██║██║██╔═══╝ ");
            Console.WriteLine(" ██████╔╝██║  ██║   ██║      ██║   ███████╗███████╗███████║██║  ██║██║██║     ");
            Console.WriteLine(" ╚═════╝ ╚═╝  ╚═╝   ╚═╝      ╚═╝   ╚══════╝╚══════╝╚══════╝╚═╝  ╚═╝╚═╝╚═╝     ");
            Console.Write("\n");
        }
    }
}



