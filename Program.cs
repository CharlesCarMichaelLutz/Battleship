
namespace ConsoleBattle
{ 
    public class Program
    {
        public enum Square
        {
            Water,
            Miss,
            Ship,
            Hit,
        }

        private static bool finished = false;
        private static string message;
        public static void Main(string[] args)
        {
            Square[,] TheBoard = new Square[10, 10];

            Console.WriteLine(TheBoard[4, 6]);
            while (!finished)
            {
                Welcome();

                Console.WriteLine("X: 0 - 9");
                Console.WriteLine("Y: 0 - 9");
                Console.WriteLine("Enter your guess: X, Y");
                string guess = Console.ReadLine();

                try
                {
                    int xPos = Convert.ToInt32(guess.Split(',')[0]) - 1;
                    int yPos = Convert.ToInt32(guess.Split(',')[1]) - 1;

                    if (xPos > 9 || yPos > 9)
                    {
                        message = "You are off the board, try again!";
                    }
                    CheckGuess(xPos, yPos);
                }
                catch
                {
                    message = "Unable to process coordinates";
                }
             
                finished = true;
            }
        }
        private static void Welcome()
        {
            Console.WriteLine("Welcome to Console Battle!");
            //Console.ReadLine();
            Console.WriteLine("Enter username: ");
            string username = Console.ReadLine();
            Console.WriteLine($"\nLet's begin {username} press Enter!");
            Console.ReadLine(); 
        }
        public static void CheckGuess(int x, int y)
        {
            if (TheBoard[x, y] == Square.Ship)
            {
                TheBoard[x, y] = Square.Hit;
            }
            else if (TheBoard[x, y] == Square.Water)
            {
                TheBoard[x, y] = Square.Miss;
            }
            else if (TheBoard[x, y] == Square.Miss)
            {
                message = "you already missed here";
            }
            else
            {
                message = "this spot was hit already";
            }
        }
    }
}





