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
        public Square[,] CheckGuess(int x,int y)
        {
            if (TheBoard[x,y] == Square.Ship)
            {
                //Console.WriteLine([x, y] = Square.Hit);
               TheBoard[x, y] = Square.Hit;               
            }
            else if (TheBoard[x,y] == Square.Water)
            {
                //Console.WriteLine([x, y] = Square.Miss);
                TheBoard[x,y] = Square.Miss;                
            }
            else if (TheBoard[x, y] == Square.Miss)
            {
                //Console.WriteLine(message = "you already missed here");
                string message1 = "you already missed here";
                Console.WriteLine(message1);
                 TheBoard[x,y] = Square.Miss;
            }
            else
            {
                //Console.WriteLine(message = "this spot was hit already");
                string message2 = "this spot was hit already";
                Console.WriteLine(message2);
                TheBoard[x,y] = Square.Hit;
            }
            return TheBoard;
        }
    }  
}
