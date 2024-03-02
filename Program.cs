using System.Drawing;

namespace ConsoleBattle
{
    public class Program
    {
        public static readonly int numberOfGuesses = 15;

        private static int hitsToWin = 0;       

        public static void Main(string[] args)
        {
            while (true)
            {
                GameBoard player = new();

                Welcome();

                Random rand = new();
                Point loc = new(rand.Next(0, 10), rand.Next(0, 10));
                Orientation orient = Enum.GetValues(typeof(Orientation))
                                    .OfType<Orientation>()
                                    .ElementAt(rand.Next(0, 2));

                Ship shipToAdd = new Carrier();   
                player.PlaceShip(shipToAdd, loc, orient);
                
                hitsToWin = shipToAdd.Length;

                while (!player.GameIsOver(hitsToWin))
                {
                    Point guess = GetGuess();
                    player.CheckGuess(guess);
                    player.DisplayBoard();
                }

                Console.WriteLine("\nWant to play again? [Y or N]");
                string answer = Console.ReadLine().ToUpper();
                if (answer == "Y")
                {
                    player.ClearBoard();
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
            string username = "";
            while (username == "")
            {
                Console.WriteLine("\nEnter username: ");
                username = Console.ReadLine();
            }
            Console.WriteLine($"\nLet's begin {username} press Enter!");
            Console.ReadLine();
            Console.WriteLine("X: 0 - 9");
            Console.WriteLine("Y: 0 - 9");
        }

        private static Point GetGuess()
        {
            bool isValidInput = false;
            int xPos = 0;
            int yPos = 0;

            while (!isValidInput)
            {
                Console.WriteLine("\nEnter your guess: X, Y");
                string guess = Console.ReadLine();
                xPos = Convert.ToInt32(guess.Split(',')[0]);
                yPos = Convert.ToInt32(guess.Split(',')[1]);

                if (xPos > 9 || yPos > 9 || xPos < 0 || yPos < 0)
                {
                    Console.WriteLine("\nYou are off the board, try again!");
                }
                else
                {
                    isValidInput = true;
                }
            }
            return new Point(xPos, yPos);
        }
    }

    public enum Orientation
    {
        Vertical,
        Horizontal
    }

    public abstract class Ship
    {
        public abstract string Name { get; }
        public abstract int Length { get; }
    }

    public class Carrier : Ship
    {
        public override string Name { get => "Carrier"; }
        public override int Length { get => 5; }
    }
}
