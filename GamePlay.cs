using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                TheBoard[x, y] = Square.Miss;
            }
            else
            {
                string message2 = "this spot was hit already";
                Console.WriteLine(message2);
                TheBoard[x, y] = Square.Hit;
            }
            return TheBoard;
        }

        /*
         4 squares were populated as Hit on last run through
         Figure out how game is going to end?
         If Hit = 4......end the game
         */
        public Square[,] AddShip()
        {
            Random random = new();

            string direction;

            int x = random.Next(0, 9);
            int y = random.Next(0, 9);

            if (x < 4)
            {
                direction = "right";
            }
            else if (x > 4)
            {
                direction = "left";
            }
            else
            {
                direction = "left,right";
            }

            if (y < 4)
            {
                direction += "down";
            }
            else if (y > 4)
            {
                direction += "up";
            }
            else
            {
                direction += "up,down";
            }

            direction = direction.Split(',')[random.Next(0, direction.Split(',').Length)];

            if (direction == "up")
            {
                for (int i = y; i < y - 4; i--)
                {
                    TheBoard[i, y] = Square.Ship;
                }
            }
            else if (direction == "down")
            {
                for (int i = y; i < y + 4; i++)
                {
                    TheBoard[i, y] = Square.Ship;
                }
            }
            else if (direction == "left")
            {
                for (int i = x; i < x - 4; i--)
                {
                    TheBoard[x, i] = Square.Ship;
                }
            }
            else
            {
                for (int i = x; i < x + 4; i++)
                {
                    TheBoard[x, i] = Square.Ship;
                }
            }
            return TheBoard;
        }   
    }
}

/*
 
Carrier: 5
Battleship: 4
Cruiser: 3
Submarine: 3
Destroyer: 2

 */ 