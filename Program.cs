
namespace ConsoleBattle
{
    public class Program
    {
        public static void Main(string[] args)
        {
            GameBoard playerA = new GameBoard();
            GameBoard playerB = new GameBoard();
            GameBoard playerAGuesses = new GameBoard();
            GameBoard playerBGuesses = new GameBoard();
            bool finished = false;
            string message;

            Welcome();
            Console.WriteLine("X: 0 - 9");
            Console.WriteLine("Y: 0 - 9");
            Console.WriteLine("Enter your guess: X, Y");

            while (!finished)
            {
                playerA.AddShip();
                //playerB.AddShip();
                //AddShip(playerA);
                //playerA.AssignShip()
                string guess = Console.ReadLine();
                try
                {
                    int xPos = Convert.ToInt32(guess.Split(',')[0]) - 1;
                    int yPos = Convert.ToInt32(guess.Split(',')[1]) - 1;

                    if (xPos > 9 || yPos > 9)
                    {
                       Console.WriteLine(message = "You are off the board, try again!");
                    }
                 
                   playerA.CheckGuess(xPos,yPos);
                   //playerB.CheckGuess(xPos,yPos);
                }
                catch
                {
                    Console.WriteLine(message = "Unable to process coordinates");
                }
                Console.ReadLine();
                //finished = true;
                Console.WriteLine(playerAGuesses);
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

        //static void Bomb()
        //{
        //
        //}

    }
}


