using System.Data;


namespace Battleship
{
    class Program
    {
            static void Main(string[] args)
            {

                public enum Square
            {
                Water,
                Ship,
                Hit,
                Miss,
            }

            Square[,] gameBoard = new Square[10, 10];

                    if(gameBoard[x, y] == Square.Ship)
                        {
                            gameBoard[x, y] = Square.Hit;
                        }
                    else if(gameBoard[x,y] != Square.Ship)
                        {
                            gameBoard[[x, y] = Square.Miss;
                        }

            public static Square[,] Clear(Square[,] board)
            {
                for (int x = 0; x < board.GetLength(0); x++)
                {
                    for (int y = 0; y < board.GetLength(1); y++)
                    {
                        board[x, y] = Square.Empty;
                    }
                }
                return board;
            }


GamePlay ship = new GamePlay("ten", "fast ship", 350);
            Console.ReadLine();

            GreetUser();

            //generate grid

            Console.ReadLine();

            int[,] numberGrid =
               {
                { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 },
                { 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 },
                { 31, 32, 33, 34, 35, 36, 37, 38, 39, 40 },
                { 41, 42, 43, 44, 45, 46, 47, 48, 49, 50 },
                { 51, 52, 53, 54, 55, 56, 57, 58, 59, 60 },
                { 61, 62, 63, 64, 65, 66, 67, 68, 69, 70 },
                { 71, 72, 73, 74, 75, 76, 77, 78, 79, 80 },
                { 81, 82, 83, 84, 85, 86, 87, 88, 89, 90 },
                { 91, 92, 93, 94, 95, 96, 97, 98, 99, 100 }
            };

            //int[,] freshGrid = new int[10, 10];
            //for(int j = 0; j < freshGrid.Length; j++)
            //{    
            //    coords = Convert.ToString(j);
            //    Console.Write(coords);

            //}
            //Console.ReadLine();

            //Console.WriteLine(freshGrid[3,4]);
            Console.ReadLine();

            //generate ship
            Random random = new Random();
            int newShip = random.Next();
            
            Console.ReadLine();

            //place ship on grid


            //User input and gameplay logic
            Console.WriteLine("\nEnter guess: ");
            int guess = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nYou guessed: {guess}");
            //Console.WriteLine(isHit.HitOrMiss());
            Console.ReadLine();

            Square[,] gameBoard = new Square[10, 10];
            Clear(gameBoard);

        }

        static void GreetUser()
        {
            Console.WriteLine("Welcome to Battle! press Enter ");
            Console.ReadLine();

            Console.WriteLine("Enter username: ");
            string username = Console.ReadLine();
            Console.WriteLine($"\nLet's begin {username}!");
        }

        
            //bool isHit = false;
            //public static string HitOrMiss()
            //{
            //    if (isHit)
            //    {
            //        Console.WriteLine("That's a hit!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("You missed");
            //    }
            //}


    }
}


