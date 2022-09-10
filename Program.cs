
namespace Battleship
{
    class Program
    {      
        private static int row = 10;
        private static int column = 10;

        private static int[,] gameBoard = new int[row, column];
        private static string message = "";
        private static bool gameOver = false;
        static void Main(string[] args)
        {
            //AddShip();
            while (!gameOver)
            {
                DrawMap();
                Console.ReadLine();

            }                      
                    //hardcoded the ship location 
                    gameBoard[0,5] = 0;
                    gameBoard[0,6] = 0;
                    gameBoard[0,7] = 0;
                    gameBoard[0,8] = 0;
                    gameBoard[0,9] = 0;
                    Console.ReadLine();

            //generate ship and place on board
            Console.ReadLine();

            //user greeting
            GreetUser();
           
            //User input and gameplay logic
            Console.WriteLine("\nEnter guess: ");
            int guess = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("coolness");
            Console.ReadLine();
        }

        private static void GreetUser()
        {
            Console.WriteLine("Welcome to Battle! press Enter ");
            Console.ReadLine();

            Console.WriteLine("Enter username: ");
            string username = Console.ReadLine();
            Console.WriteLine($"\nLet's begin {username}!");
        }
        //private static void checkHit(int x, int y)
        //{
        //    if (gameBoard[x,y] == Square.Ship)
        //    {
        //        gameBoard[x,y] = Square.Hit;
        //        Console.WriteLine("It's a hit!!!");
        //    }
        //    else if (gameBoard[x,y] == Square.Miss)
        //    {
        //        Console.WriteLine("you guessed this before");
        //    }
        //    else if(gameBoard[x,y] == Square.Water)
        //    {
        //        gameBoard[x,y] = Square.Miss;
        //    }
        //    return gameBoard[x,y];
        //}

        //clear the game board
            //Console.Clear();

        //private static void AddShip()
        //{
        //    Random random = new Random();
        //    string direction;

        //    int x = random.Next();
        //    int y = random.Next();

        //    if (x < 5)
        //    {
        //        direction = "right";
        //    }
        //    else if (x > 5)
        //    {
        //        direction = "left";
        //    }
        //    else
        //    {
        //        direction = "left,right";
        //    }

        //    if (y < 5)
        //    {
        //        direction = "down";
        //    }
        //    else if (y > 5)
        //    {
        //        direction = "up";
        //    }
        //    else
        //    {
        //        direction = "up,down";
        //    }

        //    direction = direction.Split(',')[random.Next(0, direction.Split(',').Length];

        //    if (direction == "up")
        //    {
        //        for(int i = y; i < y - 5; i--)
        //        {
        //            map[i, x] = 3;
        //        }
        //    }else if (direction == "down")
        //    {
        //        for(int i = y; i < y + 5; i++)
        //        {
        //            map[i, x] = 3;
        //        }                   
        //    }else if (direction == "left")
        //    {
        //        for (int i = x; i < x - 5; i--)
        //        {
        //            map[y, i] = 3;
        //        }
        //    }else
        //    {
        //        for (int i = x; i < x + 5; i++)
        //        {
        //            map[y, i] = 3;
        //        }
        //    }

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



