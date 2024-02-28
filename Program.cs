using System.Drawing;
namespace ConsoleBattle
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                GameBoard player = new();
                bool sunk = false;
                string message;

                Welcome();
                Console.WriteLine("X: 0 - 9");
                Console.WriteLine("Y: 0 - 9");

                Random rand = new();
                Point loc = new(rand.Next(0, 10), rand.Next(0, 10));

                Orientation orient = Enum.GetValues(typeof(Orientation))
                                    .OfType<Orientation>()
                                    .ElementAt(rand.Next(0, 4));
               
                player.PlaceShip(new Carrier(), loc, orient);

            while (!sunk)
            {
                    try
                    {
                        Console.WriteLine("\nEnter your guess: X, Y");
                        string guess = Console.ReadLine();
                        int xPos = Convert.ToInt32(guess.Split(',')[0]);
                        int yPos = Convert.ToInt32(guess.Split(',')[1]);

                        if (xPos > 9 || yPos > 9)
                        {
                            Console.WriteLine(message = "\nYou are off the board, try again!");
                        }

                        player.CheckGuess(xPos, yPos);

                        if (player.hitCounter < 5 && player.guessCount <= 14)
                        {
                            continue;
                        }
                        else if (player.guessCount > 14 && player.hitCounter < 5)
                        {
                            Console.WriteLine(message = "\nYou ran out of guesses!");
                            sunk = true;
                        }
                        else
                        {
                            Console.WriteLine(message = "\nYou sunk the ship!");
                            sunk = true;
                        }
                    }
                    catch
                    {
                        Console.WriteLine(message = "\nUnable to process coordinates");
                    }
            }

                Console.WriteLine("\nWant to play again? [Y or N]");
                string answer = Console.ReadLine().ToUpper();
                GameBoard.ClearBoard(player.TheBoard);
                
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
            Console.WriteLine("\nEnter username: ");
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
    public class Carrier : Ship
    {
        public override string Name { get => "Carrier"; }
        public override int Length { get => 5; }
    }
}
