using System.Drawing;
namespace ConsoleBattle
{
    public class Program
    {

        public static void Main(string[] args)
        {
            GameBoard playerA = new GameBoard();
            GameBoard playerAGuesses = new GameBoard();
            bool sunk = false;
            string message;

            Welcome();
            Console.WriteLine("X: 0 - 9");
            Console.WriteLine("Y: 0 - 9");

            while (true)
            {
                playerA.PlaceShip(new Submarine(), new Point(9, 10), Orientation.Right);

                while (!sunk)
                {

                try
                {
                    Console.WriteLine("Enter your guess: X, Y");
                    string guess = Console.ReadLine();
                    int xPos = Convert.ToInt32(guess.Split(',')[0]) - 1;
                    int yPos = Convert.ToInt32(guess.Split(',')[1]) - 1;

                    if (xPos > 9 || yPos > 9)
                    {
                        Console.WriteLine(message = "You are off the board, try again!");
                    }
                    playerA.CheckGuess(xPos, yPos);                   
                }
                catch
                {
                    Console.WriteLine(message = "Unable to process coordinates");
                }
                Console.ReadLine();
                //finished = true;
                }

                Console.WriteLine(message = "You sunk the ship!");
                Console.WriteLine("Play Again? [Y or N]");
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
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
    }
}


