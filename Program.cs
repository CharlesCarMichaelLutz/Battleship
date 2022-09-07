
namespace Battleship
{
    class Program
    {
        enum Square
        {
            Water,
            Ship,
            Hit,
            Miss,
        }
        static void Main(string[] args)
            {

            //create game board
          Square[,] gameBoard = new Square[10, 10];

                    if(gameBoard[3,4] == Square.Ship)
                        {
                            gameBoard[3, 4] = Square.Hit;
                        }
                    else if(gameBoard[5, 1] != Square.Ship)
                        {
                            gameBoard[5, 1] = Square.Miss;
                                }
                    else
                    {
                        gameBoard[5, 1] = Square.Water;
                    }

                    Console.WriteLine(gameBoard);
                    Console.ReadLine();

                    //clear the game board
                    static Square[,] Clear(Square[,] board)
                {
                    for (int x = 0; x < board.GetLength(0); x++)
                    {
                        for (int y = 0; y < board.GetLength(1); y++)
                        {
                            board[x, y] = Square.Water;
                        }
                    }
                    return board;
                }

                //user greeting
                GreetUser();

           
            //generate ship
            Random random = new Random();
            int newShip = random.Next();
            Console.ReadLine();

            GamePlay ship = new GamePlay("ten", "fast ship", 350);
            Console.ReadLine();

            //place ship on grid

            //User input and gameplay logic
            Console.WriteLine("\nEnter guess: ");
            int guess = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nYou guessed: {guess}");
            //Console.WriteLine(isHit.HitOrMiss());
            Console.ReadLine();

            //Square[,] gameBoard = new Square[10, 10];
            //Clear(gameBoard);

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


