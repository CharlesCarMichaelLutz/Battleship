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

        //Random rand = new Random();

        //Point pop = new Point(rand.Next(0, 10), rand.Next(0, 10));

        //Orientation orient = Enum.GetValues(typeof(Orientation))
        //                    .OfType<Orientation>()
        //                    .ElementAt(rand.Next(0, ));
        public Ship PlaceShip(Ship ship, Point loc, Orientation wayUp)
        {
            Console.WriteLine(ship.Name);
            //loop over the ship.Length to
            //populate the gameboard with Ship Enum
            
            Console.WriteLine(wayUp);
            //foreach (int point in loc)
            //{
            //    TheBoard[i, ship[i]] = Square.Ship;

            //}
            Console.WriteLine(loc);

            return ship;
        }

        //public Square[,] AddShip()
        //{
        //    Random random = new();

        //    string direction;

        //    int x = random.Next(0, 9);
        //    int y = random.Next(0, 9);

        //    if (x < 4)
        //    {
        //        direction = "right";
        //    }
        //    else if (x > 4)
        //    {
        //        direction = "left";
        //    }
        //    else
        //    {
        //        direction = "left,right";
        //    }

        //    if (y < 4)
        //    {
        //        direction += "down";
        //    }
        //    else if (y > 4)
        //    {
        //        direction += "up";
        //    }
        //    else
        //    {
        //        direction += "up,down";
        //    }

        //    direction = direction.Split(',')[random.Next(0, direction.Split(',').Length)];

        //    if (direction == "up")
        //    {
        //        for (int i = y; i < y - 4; i--)
        //        {
        //            TheBoard[i, y] = Square.Ship;
        //        }
        //    }
        //    else if (direction == "down")
        //    {
        //        for (int i = y; i < y + 4; i++)
        //        {
        //            TheBoard[i, y] = Square.Ship;
        //        }
        //    }
        //    else if (direction == "left")
        //    {
        //        for (int i = x; i < x - 4; i--)
        //        {
        //            TheBoard[x, i] = Square.Ship;
        //        }
        //    }
        //    else
        //    {
        //        for (int i = x; i < x + 4; i++)
        //        {
        //            TheBoard[x, i] = Square.Ship;
        //        }
        //    }
        //    return TheBoard;
        //}     
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