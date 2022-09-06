using System.Data;


namespace Battleship
{
    class Program
    {
        static void Main(string[] args)
        {
            
            GamePlay ship = new GamePlay("ten", "fast ship", 350);
            Console.ReadLine();

            GreetUser();

            //generate grid

            DataTable gameBoard  = new DataTable("Battleship");
                DataColumn columnA = new DataColumn("A");
                DataColumn columnB = new DataColumn("B");
                DataColumn columnC = new DataColumn("C");
                DataColumn columnD = new DataColumn("D");
                DataColumn columnE = new DataColumn("E");
                DataColumn columnF = new DataColumn("F");
                DataColumn columnG = new DataColumn("G");
                DataColumn columnH = new DataColumn("H");
                DataColumn columnI = new DataColumn("I");
                DataColumn columnJ = new DataColumn("J");
                    gameBoard.Columns.Add(columnA);
                    gameBoard.Columns.Add(columnB); 
                    gameBoard.Columns.Add(columnC);
                    gameBoard.Columns.Add(columnD);
                    gameBoard.Columns.Add(columnE);
                    gameBoard.Columns.Add(columnF);
                    gameBoard.Columns.Add(columnG);
                    gameBoard.Columns.Add(columnH);
                    gameBoard.Columns.Add(columnI);
                    gameBoard.Columns.Add(columnJ);

                DataRow row1 = gameBoard.NewRow();
                DataRow row2 = gameBoard.NewRow();
                DataRow row3 = gameBoard.NewRow();
                DataRow row4 = gameBoard.NewRow();
                DataRow row5 = gameBoard.NewRow();
                DataRow row6 = gameBoard.NewRow();
                DataRow row7 = gameBoard.NewRow();
                DataRow row8 = gameBoard.NewRow();
                DataRow row9 = gameBoard.NewRow();
                DataRow row10 = gameBoard.NewRow();
            row1["A"] = 0;  
            row1["B"] = 0;
            row1["C"] = 0;
            row1["D"] = 0;
            row1["E"] = 0;
            row1["F"] = 0;
            row1["G"] = 0;
            row1["H"] = 0;
            row1["I"] = 0;
            row1["J"] = 0;

            gameBoard.Rows.Add(row1);
                    gameBoard.Rows.Add(row2);
                    gameBoard.Rows.Add(row3);
                    gameBoard.Rows.Add(row4);
                    gameBoard.Rows.Add(row5);
                    gameBoard.Rows.Add(row6);
                    gameBoard.Rows.Add(row7);
                    gameBoard.Rows.Add(row8);
                    gameBoard.Rows.Add(row9);
                    gameBoard.Rows.Add(row10);

           for(int j = 0; j < gameBoard.Rows.Count; j++)
            {
                for (int i = 0; i < gameBoard.Columns.Count; i++)
                {
                    Console.WriteLine(gameBoard.Columns[i].ColumnName + " ");
                    Console.WriteLine(gameBoard.Rows[j].ItemArray[i]);
                }
            }

            Console.ReadLine();

            string coords;

            int[,] numberGrid =
               {
                { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 },
                { 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 },
                { 31, 32, 33, 34, 35, 36, 37, 38, 39, 40 },
                { 41, 42, 43, 44, 45, 46, 47, 48, 49, 50 },
                { 51, 52, 53, 54, 55, 56, 57, 58, 59, 60 },
                { 61, 62, 63, 64, 65, 66, 67, 68, 69, 70 },
                { 71, 72, 73, 74, 75, 76, 77, 78, 79, 80 },
                { 81, 82, 83, 84, 85, 86, 87, 88, 89, 90 },
                { 91, 92, 93, 94, 95, 96, 97, 98, 99, 100 }
            };

            int[,] freshGrid = new int[10, 10];
            for(int j = 0; j < freshGrid.Length; j++)
            {    
                coords = Convert.ToString(j);
                Console.Write(coords);

            }
            Console.ReadLine();

            Console.WriteLine(freshGrid[3,4]);
            Console.ReadLine();

            //generate ship
            Random random = new Random();
            int newShip = random.Next();
            
            Console.ReadLine();

            //place ship on grid


            //User input and gameplay logic
            Console.WriteLine("\nEnter guess: ");
            int guess = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nYou guessed: {guess}");
            //Console.WriteLine(isHit.HitOrMiss());
            Console.ReadLine();        
        }

        static void GreetUser()
        {
            Console.WriteLine("Welcome to Battle! press Enter ");
            Console.ReadLine();

            Console.WriteLine("Enter username: ");
            string username = Console.ReadLine();
            Console.WriteLine($"\nLet's begin {username}!");
        }

        //bool isHit = false;
        //public static string HitOrMiss()
        //{
        //    if (isHit)
        //    {
        //        Console.WriteLine("That's a hit!");
        //    }
        //    else
        //    {
        //        Console.WriteLine("You missed");
        //    }
        //}
    }
}


