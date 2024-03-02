using System.Drawing;

using static ConsoleBattle.Program;

namespace ConsoleBattle
{
    public class GameBoard
    {
        public enum Square
        {
            Water,
            Miss,
            Ship,
            Hit,
        }

        private static readonly Dictionary<Square, string> mapSymbols = new()
        {
            { Square.Water, "~" },
            { Square.Miss, "O" },
            { Square.Ship, "~" },
            { Square.Hit, "$" }
        };

        public int hitCounter = 0;

        public int guessCount = 0;

        public Square[,] TheBoard = new Square[10, 10];
        public Square[,] CheckGuess(Point point)
        {
            string message = "";
            switch(TheBoard[point.Y, point.X])
            {
                case Square.Ship:
                    TheBoard[point.Y, point.X] = Square.Hit;
                    hitCounter++;
                    message = "HIT!!!";
                    break;
                case Square.Water:
                    TheBoard[point.Y, point.X] = Square.Miss;
                    message = "MISS!!!";
                    break;
                case Square.Miss:
                    message = "You already missed here";
                    break;
                case Square.Hit:
                    message = "This spot was hit already";
                    break;
            }
            guessCount++;
            Console.WriteLine($"\n{message}\n");
            return TheBoard;
        }

        public Square[,] DisplayBoard()
        {
            for (int x = 0; x < TheBoard.GetLength(0); x++)
            {
                for (int y = 0; y < TheBoard.GetLength(1); y++)
                {
                    Console.Write(mapSymbols[TheBoard[x, y]] + " ");
                }
                Console.WriteLine();
            }
            return TheBoard;
        }

        public Square[,] ClearBoard()
        {
            for (int x = 0; x < TheBoard.GetLength(0); x++)
            {
                for (int y = 0; y < TheBoard.GetLength(1); y++)
                {
                    TheBoard[x, y] = Square.Water;
                }
            }
            return TheBoard;
        }

        public Ship PlaceShip(Ship ship, Point loc, Orientation direction)
        {
            if (direction == Orientation.Vertical)
            {
                if(loc.Y <= 4)
                {
                    for (int i = loc.Y; i < loc.Y + 5; i++)
                    {
                        TheBoard[loc.X, i] = Square.Ship;
                    }
                }
                else
                {
                    for (int i = loc.Y; i > loc.Y - 5; i--)
                    {
                        TheBoard[loc.X, i] = Square.Ship;
                    }
                }               
            }
            else
            {
                if(loc.X <= 4)
                {
                    for (int i = loc.X; i < loc.X + 5; i++)
                    {
                        TheBoard[i, loc.Y] = Square.Ship;
                    }
                }
                else 
                {
                    for (int i = loc.X; i > loc.X - 5; i--)
                    {
                        TheBoard[i, loc.Y] = Square.Ship;
                    }
                }                
            }
            return ship;
        }

        public bool GameIsOver(int hitsToWin)
        {
            if (guessCount >= numberOfGuesses && hitCounter < hitsToWin)
            {
                Console.WriteLine("\nYou ran out of guesses!");
                return true;
            }
            else if (hitCounter >= hitsToWin)
            {
                Console.WriteLine("\nYou sunk the ship!");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

