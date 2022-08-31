
namespace Battleship
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool isHit = false;

            Console.WriteLine("Welcome to Battle! press Enter ");
            Console.ReadLine();

            Console.WriteLine("Enter username: ");
            string username = Console.ReadLine();
            Console.WriteLine($"\nLet's begin {username}!");

            Console.WriteLine("\nEnter guess: ");
            int guess = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nYou guessed: {guess}");
            //Console.WriteLine(isHit.HitOrMiss());
            Console.ReadLine();
        }

        //public static string HitOrMiss()
        //{
        //    if (Program.isHit)
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


