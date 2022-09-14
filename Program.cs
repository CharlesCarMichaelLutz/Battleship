
namespace ConsoleBattle
{
    internal class Program
    {
        private static bool finished = false;
        string message;
        public enum Square
        {
            Water,
            Miss,
            Ship,
            Hit,
        }
        public static void Main(string[] args)
        {            
            Square[,] TheBoard = new Square[10, 10];

            while (!finished)
            {
                Welcome();
                UserInput();
                //CheckGuess();

                finished = true;
            }
        }
        private static void Welcome()
        {
            Console.WriteLine("Welcome to Console Battle!");
            //Console.ReadLine();
            Console.WriteLine("Enter username: ");
            string username = Console.ReadLine();
            Console.WriteLine($"\nLet's begin {username}!");
        }
        private static void UserInput()
        {
            Console.WriteLine("X: 0 - 9");
            Console.WriteLine("Y: 0 - 9");
            Console.WriteLine("Enter your guess: X, Y");
            string guess = Console.ReadLine();
            Console.WriteLine($"You guessed: {guess}");
            Console.ReadLine();
        }
    }
}

//private static void CheckGuess()
//{
//    if (TheBoard[x, y] == Square.Ship)
//    {
//        TheBoard[x, y] = Square.Hit;
//    }
//    else if (TheBoard[x, y] == Square.Water)
//    {
//        TheBoard[x, y] = Square.Miss;
//    }
//    else if (TheBoard[x, y] == Square.Miss)
//    {
//        message = "You already missed here";
//    }
//    else
//    {
//        message = "This spot was hit already";
//    }
//}

//    }
//}


