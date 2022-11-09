using System.Drawing;
namespace ConsoleBattle
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Random rand = new Random();

            Point loc = new Point(rand.Next(0,10), rand.Next(0,10));

            Orientation orient = Enum.GetValues(typeof(Orientation))
                                .OfType<Orientation>()
                                .ElementAt(rand.Next(0, 4));

            GameBoard playerA = new GameBoard();
            GameBoard playerAGuesses = new GameBoard();
            bool sunk = false;
            string message;

            playerA.PlaceShip(new Submarine(), loc, orient);

            Welcome();
            Console.WriteLine("X: 0 - 9");
            Console.WriteLine("Y: 0 - 9");

            while (true)
            {

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
    public class GameBoard
    {
        public enum Square
        {
            Water,
            Miss,
            Ship,
            Hit,
        }
        private Square[,] TheBoard = new Square[10, 10];
        public Square[,] CheckGuess(int x, int y)
        {

            if (TheBoard[x, y] == Square.Ship)
            {
                Console.WriteLine(TheBoard[x, y] = Square.Hit);
            }
            else if (TheBoard[x, y] == Square.Water)
            {
                Console.WriteLine(TheBoard[x, y] = Square.Miss);
            }
            else if (TheBoard[x, y] == Square.Miss)
            {
                string message1 = "you already missed here";
                Console.WriteLine(message1);
                //TheBoard[x, y] = Square.Miss;
            }
            else
            {
                string message2 = "this spot was hit already";
                Console.WriteLine(message2);
                //TheBoard[x, y] = Square.Hit;
            }
            return TheBoard;
        }

        public Ship PlaceShip(Ship ship, Point loc, Orientation direction)
        {
            loc = new Point(loc.X, loc.Y);
            Console.WriteLine(loc);

            if (direction == Orientation.Up)
            {
                for (int i = loc.Y; i < ship.Length + 3 ; i--)
                {
                    TheBoard[loc.X, i] = Square.Ship;
                }
            }
            else if (direction == Orientation.Down)
            {
                for (int i = loc.Y; i < ship.Length + 3; i++)
                {
                    TheBoard[loc.X, i] = Square.Ship;
                
                }
            }
            else if (direction == Orientation.Left)
            {
                for (int i = loc.X; i < ship.Length + 3; i--)
                {
                    TheBoard[i,loc.Y] = Square.Ship;
                }
            }
            else
            {
                for (int i = loc.X; i < ship.Length + 3; i++)
                {
                    TheBoard[i,loc.Y] = Square.Ship;
                }
            }
            Console.WriteLine(ship.Name);       
            Console.WriteLine(direction);
            return ship;
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


