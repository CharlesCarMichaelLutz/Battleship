using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

//namespace ConsoleBattle
//{
//    public Square[,] AddShip()
//    {
//        Random random = new();

//        string direction;

//        int x = random.Next(0, 9);
//        int y = random.Next(0, 9);

//        if (x < 4)
//        {
//            direction = "right";
//        }
//        else if (x > 4)
//        {
//            direction = "left";
//        }
//        else
//        {
//            direction = "left,right";
//        }

//        if (y < 4)
//        {
//            direction += "down";
//        }
//        else if (y > 4)
//        {
//            direction += "up";
//        }
//        else
//        {
//            direction += "up,down";
//        }

//        direction = direction.Split(',')[random.Next(0, direction.Split(',').Length)];

//        if (direction == "up")
//        {
//            for (int i = y; i < y - 4; i--)
//            {
//                TheBoard[i, y] = Square.Ship;
//            }
//        }
//        else if (direction == "down")
//        {
//            for (int i = y; i < y + 4; i++)
//            {
//                TheBoard[i, y] = Square.Ship;
//            }
//        }
//        else if (direction == "left")
//        {
//            for (int i = x; i < x - 4; i--)
//            {
//                TheBoard[x, i] = Square.Ship;
//            }
//        }
//        else
//        {
//            for (int i = x; i < x + 4; i++)
//            {
//                TheBoard[x, i] = Square.Ship;
//            }
//        }
//        return TheBoard;
//    }

//}