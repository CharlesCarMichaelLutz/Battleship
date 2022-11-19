using System.Drawing;
namespace ConsoleBattle
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int counter = 0;
            Random rand = new Random();

            Point loc = new Point(rand.Next(0,10), rand.Next(0,10));

            Orientation orient = Enum.GetValues(typeof(Orientation))
                                .OfType<Orientation>()
                                .ElementAt(rand.Next(0, 4));

            GameBoard playerA = new GameBoard();
            GameBoard playerAGuesses = new GameBoard();
            bool sunk = false;
            string message;

            Welcome();
            Console.WriteLine("X: 0 - 9");
            Console.WriteLine("Y: 0 - 9");

            playerA.PlaceShip(new Submarine(), loc, orient);

            while (true)
            {

                while (!sunk)
                {

                try
                {
                Console.WriteLine("Enter your guess: X, Y");
                string guess = Console.ReadLine();
                int xPos = Convert.ToInt32(guess.Split(',')[0]);
                int yPos = Convert.ToInt32(guess.Split(',')[1]);
                
                playerA.CheckGuess(xPos, yPos);

                if (counter <= 4)
                {
                     continue;
                }
                else
                {
                Console.WriteLine(message = "You sunk the ship!");
                sunk = true;
                }

                if (xPos > 9 || yPos > 9)
                {
                Console.WriteLine(message = "You are off the board, try again!");
                }

                }
                catch
                {
                    Console.WriteLine(message = "Unable to process coordinates");
                }
                   
                      
                }

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
    public enum Orientation
    {
        Up = 1,
        Down = 2,
        Left = 4,
        Right = 8,
    }
    public abstract class Ship
    {
        public abstract string Name { get; }
        public abstract int Length { get; }
    }
    public class Destroyer : Ship
    {
        public override string Name { get => "Destroyer"; }
        public override int Length { get => 2; }
    }
    public class Submarine : Ship
    {
        public override string Name { get => "Submarine"; }
        public override int Length { get => 3; }
    }
    public class Cruiser : Ship
    {
        public override string Name { get => "Cruiser"; }
        public override int Length { get => 3; }
    }
    public class Battleship : Ship
    {
        public override string Name { get => "Battleship"; }
        public override int Length { get => 4; }
    }
    public class Carrier : Ship
    {
        public override string Name { get => "Carrier"; }
        public override int Length { get => 5; }
    }
}


