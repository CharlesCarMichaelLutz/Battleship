
namespace Battleship
{
    class Program
    {
        static void Main(string[] args)
        {
            
            GamePlay ship = new GamePlay("ten", "USS Bergtree", 350);
            Console.WriteLine(ship.name);
            Console.ReadLine();
            //Console.WriteLine($"The {ship.name} is colored {ship.color}, and has {ship.health} power");

            GreetUser();

            //generate grid

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
            for(int i = 0; i < newShip; i++)
            {
                Console.Write(newShip);
            }
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


