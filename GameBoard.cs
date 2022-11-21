using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

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
        public int hitCounter = 0;
        public int guessCount = 0;

        public Square[,] TheBoard = new Square[10, 10];
        public Square[,] CheckGuess(int x, int y)
        {

            if (TheBoard[x, y] == Square.Ship)
            {
                Console.WriteLine(TheBoard[x, y] = Square.Hit);
                hitCounter++;
            }
            else if (TheBoard[x, y] == Square.Water)
            {
                Console.WriteLine(TheBoard[x, y] = Square.Miss);
            }
            else if (TheBoard[x, y] == Square.Miss)
            {
                string message1 = "you already missed here";
                Console.WriteLine(message1);
            }
            else
            {
                string message2 = "this spot was hit already";
                Console.WriteLine(message2);
            }
            guessCount++;
            return TheBoard;
        }
        public static Square[,] ClearBoard(Square[,] TheBoard)
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
            loc = new Point(loc.X, loc.Y);
            Console.WriteLine(loc);

            if (direction == Orientation.Up)
            {
                if(loc.Y <= 6)
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
            else if (direction == Orientation.Down)
            {
                if(loc.Y <= 6)
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
            else if (direction == Orientation.Left)
            {
                if(loc.X <= 6)
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
            else
            {
                if(loc.X <= 6)
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
            Console.WriteLine(ship.Name);
            Console.WriteLine(direction);
            return ship;
        }
    }
}